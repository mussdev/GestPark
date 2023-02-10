using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GestPark
{
    public partial class FormCreateRepairCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        Guid IdRepairCarPan, IdGarage, IdVehiRepair;
        public FormCreateRepairCar()
        {
            InitializeComponent();
            FillComboboxGarage();
            FillComboboxVehicule();
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
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE SANTE_VEHICULE = 'En panne'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxRepaiCar.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxRepaiCar.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxRepaiCar.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Fill combobox garage
        private void FillComboboxGarage()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM GARAGE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxGarageRepairCar.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageRepairCar.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageRepairCar.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string generateCodeRepairCar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_REPAR FROM REPARATION WHERE CODE_REPAR=(SELECT MAX(CODE_REPAR) FROM REPARATION)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodeRepaiCar.Text = Ds.Tables[0].Rows[0]["CODE_REPAR"].ToString();
                }
                else
                {
                    TxtCodeRepaiCar.Text = "REPAIR0000";
                }
                if (!string.IsNullOrEmpty(TxtCodeRepaiCar.Text))
                {
                    TxtCodeRepaiCar.SelectionStart = 6;
                    TxtCodeRepaiCar.SelectionLength = 4;
                    TxtCodeRepaiCar.Text = TxtCodeRepaiCar.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodeRepaiCar.Text))
                {
                    int CodeRepair = int.Parse(TxtCodeRepaiCar.Text.ToString()) + 1;
                    TxtCodeRepaiCar.Text = CodeRepair.ToString("REPAIR0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodeRepaiCar.Text;
        }

        private void CbxRepaiCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxRepaiCar.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiRepair = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcBtnSavedRepaiCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxRepaiCar.Text))
            {
                MessageBox.Show("Identifier le vehicule reparé !!!","GestParc: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }else if (string.IsNullOrEmpty(TxtAmountRepair.Text))
            {
                MessageBox.Show("Saisir le coût de reparation !!!","GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    if (Conn.IsConnection)
                    {
                        DialogResult result = MessageBox.Show("Voulez vous enregister les informations ?", "GESTPARC: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            using (Conn.cn)
                            {
                                using (var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "INSERT INTO REPARATION (ID_VEHICULE,ID_GARAGE,CODE_REPAR,PRIX_REPAR,CAUSE_REPAR,STATUT_REPAR,DATE_REPAR,DATECREATE_REPAR) VALUES (@ID_VEHICULE,@ID_GARAGE,@CODE_REPAR,@PRIX_REPAR,@CAUSE_REPAR,@STATUT_REPAR,@DATE_REPAR,GETDATE())";
                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiRepair);
                                    Cmd.Parameters.AddWithValue("@ID_GARAGE", IdGarage);
                                    Cmd.Parameters.AddWithValue("@CODE_REPAR", generateCodeRepairCar());
                                    Cmd.Parameters.AddWithValue("@PRIX_REPAR", decimal.Parse(TxtAmountRepair.Text));
                                    Cmd.Parameters.AddWithValue("@CAUSE_REPAR", RtxtNoteRepairCar.Text);
                                    Cmd.Parameters.AddWithValue("@STATUT_REPAR", cbxEtatCarRepair.Text);
                                    Cmd.Parameters.AddWithValue("@DATE_REPAR", DateRegisterRepairCar.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();

                                    // Update the date car of assurance
                                    Cmd.CommandText = "UPDATE VEHICULE SET SANTE_VEHICULE=@SANTE_VEHICULE WHERE ID_VEHICULE='" + IdVehiRepair + "'";
                                    Cmd.Parameters.AddWithValue("@SANTE_VEHICULE", cbxEtatCarRepair.Text);
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();
                                    MessageBox.Show("Votre véhicule est assuré bravo !", "GestParc : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    TxtCodeRepaiCar.Clear();CbxGarageRepairCar.Text = null;CbxRepaiCar.Text = null; RtxtNoteRepairCar.Clear();
                                    this.Close();
                                }
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

        private void JointDocModifyPanCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnJoindCar = new ToolTip();
            ToolTipBtnJoindCar.AutoPopDelay = 5000;
            ToolTipBtnJoindCar.InitialDelay = 1000;
            ToolTipBtnJoindCar.ReshowDelay = 500;
            ToolTipBtnJoindCar.ShowAlways = true;
            ToolTipBtnJoindCar.SetToolTip(this.JointDocModifyPanCar, "Joindre un document");
        }

        private void IcBtnSavedRepaiCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnSavedRepaiCar = new ToolTip();
            ToolTipBtnSavedRepaiCar.AutoPopDelay = 5000;
            ToolTipBtnSavedRepaiCar.InitialDelay = 1000;
            ToolTipBtnSavedRepaiCar.ReshowDelay = 500;
            ToolTipBtnSavedRepaiCar.ShowAlways = true;
            ToolTipBtnSavedRepaiCar.SetToolTip(this.IcBtnSavedRepaiCar, "Enregistrer");
        }

        private void CbxGarageRepairCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE,PROPRIETAIRE_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGarageRepairCar.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdGarage = Guid.Parse(MyReader[0].ToString());
                            TxtMecanicienRepairCar.Text = MyReader[1].ToString();
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
