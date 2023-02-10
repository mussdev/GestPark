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
    public partial class FormCreateAttributeCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private string IdVehicule, IdProprio;
        public FormCreateAttributeCar()
        {
            InitializeComponent();
            fillComboboxProprietor();
            FillComboboxVehicule();
        }


        // Generate code of personne
        private string generateCodeAttributionCar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code attribution car to person
                        SqlCmd = new SqlCommand("SELECT CODE_ATTRI FROM APPARTENIR WHERE CODE_ATTRI=(SELECT MAX(CODE_ATTRI) FROM APPARTENIR)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TbxCodeAttr.Text = Ds.Tables[0].Rows[0]["CODE_ATTRI"].ToString();
                        }
                        else
                        {
                            TbxCodeAttr.Text = "ATTR0000";
                        }
                        if (!string.IsNullOrEmpty(TbxCodeAttr.Text))
                        {
                            TbxCodeAttr.SelectionStart = 4;
                            TbxCodeAttr.SelectionLength = 4;
                            TbxCodeAttr.Text = TbxCodeAttr.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TbxCodeAttr.Text))
                        {
                            int codePers = int.Parse(TbxCodeAttr.Text.ToString()) + 1;
                            TbxCodeAttr.Text = codePers.ToString("ATTR0000");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TbxCodeAttr.Text;
        }

        private void CbxProprietAttr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE DESCRIPTION_PERS = '" + CbxProprietAttr.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdProprio = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiculeAttr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeAttr.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehicule = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void IbtnRegisterAttributeCarToPersonn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxVehiculeAttr.Text) || string.IsNullOrEmpty(CbxProprietAttr.Text))
            {
                MessageBox.Show("Veiller saisir le vehicule ou le propriétaire");
            }
            else
            {
                DialogResult result = MessageBox.Show("Voulez vous enregister cette attribution de véhicule ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                        ConnectDB Conn = new ConnectDB(connectionString);
                        string CodAttrCar=generateCodeAttributionCar();
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                using(var CmdAttri = Conn.cn.CreateCommand())
                                {
                                    CmdAttri.CommandText = "INSERT INTO APPARTENIR (ID_PERS,ID_VEHICULE,DATE_DEBUT_ATTRI,CODE_ATTRI,DATE_ATTRI,NOTE_ATTRI) VALUES (@ID_PERS,@ID_VEHICULE,@DATE_DEBUT_ATTRI,@CODE_ATTRI,@DATE_ATTRI,@NOTE_ATTRI)";
                                    // Request to insert data in table personnels
                                    CmdAttri.Parameters.AddWithValue("@ID_PERS", IdProprio);
                                    CmdAttri.Parameters.AddWithValue("@ID_VEHICULE", IdVehicule);
                                    CmdAttri.Parameters.AddWithValue("@DATE_DEBUT_ATTRI", DateAttrVehi.Value.ToString("dd/MM/yyyy"));
                                    CmdAttri.Parameters.AddWithValue("@CODE_ATTRI", CodAttrCar);
                                    CmdAttri.Parameters.AddWithValue("@DATE_ATTRI", DatePikerCreateAttr.Value.ToString("dd/MM/yyyy"));
                                    CmdAttri.Parameters.AddWithValue("@NOTE_ATTRI", RbtxNoteAttr.Text);
                                    CmdAttri.ExecuteNonQuery();
                                    MessageBox.Show("Enregistré avec succès !!!", "GestPark: Informations", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    this.Close();

                                    // Update Table carburant statut

                                    CmdAttri.CommandText = " UPDATE VEHICULE SET STATUT_VEHICULE=@STATUT_VEHICULE WHERE ID_VEHICULE='" + IdVehicule + "' ";
                                    CmdAttri.Parameters.AddWithValue("@STATUT_VEHICULE", "Attribué");
                                    CmdAttri.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fillComboboxProprietor()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_PERS FROM PERSONNELS ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxProprietAttr.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            CbxProprietAttr.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            CbxProprietAttr.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterAttributeCarToPersonn_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IbtnRegisterAttributeCarToPersonn, "Enregistrer");
        }

        private void IbtnJoindreDocAttr_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IbtnJoindreDocAttr, "Joindre doc.");
        }

        // Fill combobox vehicule
        private void FillComboboxVehicule()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE FROM VEHICULE WHERE STATUT_VEHICULE='Non attribué' AND TYPE_VEHICULE='Affecté' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeAttr.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeAttr.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeAttr.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
