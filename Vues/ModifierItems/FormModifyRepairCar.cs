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
    public partial class FormModifyRepairCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid? IdVehiRepairMod=null, IdGarageMod;
        public FormModifyRepairCar()
        {
            InitializeComponent();
            fillCbxRepairCarMod();
            fillCbxGarageRepair();
        }

        // Fill combobox vehicule
        private void fillCbxRepairCarMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE WHERE SANTE_VEHICULE = 'En panne'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxRepaiCarMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxRepaiCarMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxRepaiCarMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxRepaiCarMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxRepaiCarMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiRepairMod = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                            MessageBox.Show("Id véhicule : " + IdVehiRepairMod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxGarageRepairCarMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE,PROPRIETAIRE_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGarageRepairCarMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdGarageMod = Guid.Parse(MyReader["ID_GARAGE"].ToString());
                            TxtMecanicienRepairCarMod.Text = MyReader["PROPRIETAIRE_GARAGE"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcBtnSavedRepaiCarMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxRepaiCarMod.Text))
            {
                MessageBox.Show("Identifier le vehicule reparé !!!", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(TxtAmountRepairMod.Text))
            {
                MessageBox.Show("Saisir le coût de reparation !!!", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                    Cmd.CommandText = "UPDATE REPARATION SET ID_VEHICULE=@ID_VEHICULE,ID_GARAGE=@ID_GARAGE,PRIX_REPAR=@PRIX_REPAR,CAUSE_REPAR=@CAUSE_REPAR,STATUT_REPAR=@STATUT_REPAR,DATE_REPAR=@DATE_REPAR,DATEMODIFIER_REPAR=GETDATE() WHERE CODE_REPAR='"+ TxtCodeRepaiCarMod.Text +"'";

                                    if(IdVehiRepairMod.HasValue)
                                        Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiRepairMod);
                                    else
                                        Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarRepair());

                                    Cmd.Parameters.AddWithValue("@ID_GARAGE", IdGarageMod);
                                    Cmd.Parameters.AddWithValue("@PRIX_REPAR", decimal.Parse(TxtAmountRepairMod.Text));
                                    Cmd.Parameters.AddWithValue("@CAUSE_REPAR", RtxtNoteRepairCarMod.Text);
                                    Cmd.Parameters.AddWithValue("@STATUT_REPAR", cbxEtatCarRepairMod.Text);
                                    Cmd.Parameters.AddWithValue("@DATE_REPAR", DateRegisterRepairCarMod.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();

                                    // Update the date car of assurance
                                    if(IdVehiRepairMod.HasValue)
                                        Cmd.CommandText = "UPDATE VEHICULE SET SANTE_VEHICULE=@SANTE_VEHICULE WHERE ID_VEHICULE='" + IdVehiRepairMod + "'";
                                    else
                                        Cmd.CommandText = "UPDATE VEHICULE SET SANTE_VEHICULE=@SANTE_VEHICULE WHERE ID_VEHICULE='" + IdCarRepair() + "'";

                                    Cmd.Parameters.AddWithValue("@SANTE_VEHICULE", cbxEtatCarRepairMod.Text);
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();
                                    MessageBox.Show("Vos modifications ont été prises en compte. Merci !", "GestParc : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    TxtCodeRepaiCarMod.Clear(); CbxGarageRepairCarMod.Text = null; CbxRepaiCarMod.Text = null; RtxtNoteRepairCarMod.Clear();
                                    this.Close();
                                }
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

        // Fill combobox garage
        private void fillCbxGarageRepair()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM GARAGE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxGarageRepairCarMod.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageRepairCarMod.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageRepairCarMod.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Guid IdCarRepair()
        {
            Guid IdCarRepairMod = Guid.Empty;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxRepaiCarMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCarRepairMod = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                           // MessageBox.Show("Id véhicule : " + IdCarRepairMod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IdCarRepairMod;
        }
    }
}
