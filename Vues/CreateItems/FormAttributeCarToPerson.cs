using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GestPark
{
    public partial class FormAttributeCarToPerson : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private Guid IdVehiAttri, idPersonAttri;
        public FormAttributeCarToPerson()
        {
            InitializeComponent();
            fillCbxCarAttri();
            listPersonAttri();
        }

        private void IbtnCloseFormMainAttribute_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnCreateAttribute_Click(object sender, EventArgs e)
        {
            FormCreateAttributeCar AttributeCar = new FormCreateAttributeCar();
            AttributeCar.ShowDialog();
        }

        private void IbtnSearchCarAttribute_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (string.IsNullOrEmpty(TbxSearchAttribute.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM APPARTENIR LEFT OUTER JOIN PERSONNELS ON APPARTENIR.ID_PERS = PERSONNELS.ID_PERS LEFT OUTER JOIN VEHICULE ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            // Fill DataGridView
                            dataGridViewAttributeCar.AutoGenerateColumns = false;
                            dataGridViewAttributeCar.DataSource = Tb.Tables[0];
                        }
                        else if (!string.IsNullOrEmpty(TbxSearchAttribute.Text))
                        {
                            string reqCar = "SELECT * FROM APPARTENIR LEFT OUTER JOIN PERSONNELS ON APPARTENIR.ID_PERS = PERSONNELS.ID_PERS LEFT OUTER JOIN VEHICULE ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE";
                            reqCar += " WHERE VEHICULE.IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                            reqCar += " OR PERSONNELS.DESCRIPTION_PERS LIKE '%' +@param2+ '%' ";


                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", TbxSearchAttribute.Text);
                            SqlCmd.Parameters.AddWithValue("param2", TbxSearchAttribute.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            dataGridViewAttributeCar.AutoGenerateColumns = false;
                            dataGridViewAttributeCar.DataSource = tb.Tables[0];
                        }else
                            dataGridViewAttributeCar.DataSource=null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // display list of attribution of car

        private void displayAttributionCar()
        {
            FormAttributeCarModify AttributeCarModify = new FormAttributeCarModify();
            AttributeCarModify.TbxCodeAttrMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[0].Value?.ToString();
            AttributeCarModify.CbxVehiculeAttrMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[1].Value?.ToString();
            AttributeCarModify.CbxProprietAttrMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[2].Value?.ToString();
            AttributeCarModify.DateAttrVehiMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[3].Value?.ToString();
            AttributeCarModify.DatePikerCreateAttrMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[4].Value?.ToString();
            AttributeCarModify.RbtxNoteAttrMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[6].Value?.ToString();
            AttributeCarModify.ShowDialog();
        }

        private void IbtnCreateAttribute_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateAttr = new ToolTip();
            ToolTipBtnCreateAttr.AutoPopDelay = 5000;
            ToolTipBtnCreateAttr.InitialDelay = 1000;
            ToolTipBtnCreateAttr.ReshowDelay = 500;
            ToolTipBtnCreateAttr.ShowAlways = true;
            ToolTipBtnCreateAttr.SetToolTip(this.IbtnCreateAttribute, "Enregistrer");
        }

        private void BtnExportAffect_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExpAttr = new ToolTip();
            ToolTipBtnExpAttr.AutoPopDelay = 5000;
            ToolTipBtnExpAttr.InitialDelay = 1000;
            ToolTipBtnExpAttr.ReshowDelay = 500;
            ToolTipBtnExpAttr.ShowAlways = true;
            ToolTipBtnExpAttr.SetToolTip(this.BtnExportAffect, "Exporter");
        }

        private void BtnImportAffect_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImpAttr = new ToolTip();
            ToolTipBtnImpAttr.AutoPopDelay = 5000;
            ToolTipBtnImpAttr.InitialDelay = 1000;
            ToolTipBtnImpAttr.ReshowDelay = 500;
            ToolTipBtnImpAttr.ShowAlways = true;
            ToolTipBtnImpAttr.SetToolTip(this.BtnExportAffect, "Importer");
        }

        private void dataGridViewAttributeCar_DoubleClick(object sender, EventArgs e)
        {
            displayAttributionCar();
        }

        private void cbxCarAttriSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, TOTALKILOMETRAGE_VEHICULE,KILOMETRAGE_VIDENGE_VEHICULE,CODE_VEHICULE,PRIXLITRE_TYPCONSO FROM VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON VEHICULE.ID_TYPCONSO=TYPECONSOMMATION.ID_TYPCONSO WHERE IMMATRICULATION_VEHICULE = '" + cbxCarAttriSearch.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiAttri = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox vehicule
        private void fillCbxCarAttri()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE WHERE TYPE_VEHICULE = 'Affecté'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarAttriSearch.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarAttriSearch.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarAttriSearch.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // List person
        private void listPersonAttri()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM PERSONNELS", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxPersonSearch.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            cbxPersonSearch.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            cbxPersonSearch.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportAffect_Click(object sender, EventArgs e)
        {

        }

        private void cbxPeriodAttri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodAttri.Text.Equals("Aujourd'hui"))
            {
                dateAttrFromiSearch.Enabled= true;
                dateAttriTo.Enabled= true;
            }
            else
            {
                dateAttrFromiSearch.Enabled = false;
                dateAttriTo.Enabled = false;
            }
        }

        private void cbxPersonSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS PERSONNELS WHERE DESCRIPTION_PERS = '" + cbxPersonSearch.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            idPersonAttri = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
