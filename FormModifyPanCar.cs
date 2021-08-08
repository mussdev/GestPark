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
    public partial class FormModifyPanCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private string CodCarPan;
        private int IdCarPanMod, IdGaragePan;
        private SqlDataReader MyReader;
        public FormModifyPanCar()
        {
            InitializeComponent();
            FillComboboxGarage();
            FillCar();
            IbtnRepaiCarPan.Visible = false;
            TxtMecanicien.Visible = false;
            CbxGarage.Visible = false;
            LbGarage.Visible = false;
            LbMeacn.Visible = false;
        }

        private void IbtnRepaiCarPan_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtDescriptionModifyPanCar.Text) && !string.IsNullOrEmpty(TxtMecanicien.Text) && !string.IsNullOrEmpty(CbxGarage.Text) && !string.IsNullOrEmpty(CbxVehiModifyPanCar.Text) )
            {
                if(CbxEtatModifyPanCar.Text == "Bon")
                {
                    FormCreateRepairCar RepairCar = new FormCreateRepairCar();
                    RepairCar.TxtMecanicienRepairCar.Text = TxtMecanicien.Text;
                    RepairCar.CbxGarageRepairCar.Text = CbxGarage.Text;
                    RepairCar.CbxRepaiCar.Text = CbxVehiModifyPanCar.Text;
                    RepairCar.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Iddentifiez le garage ou le nom du mécanicien");
            }
            
        }

        private void FormModifyPanCar_Load(object sender, EventArgs e)
        {
            IbtnRepaiCarPan.Hide();
        }

        private void CbxEtatModifyPanCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyStateCar();
        }

        private void VerifyStateCar()
        {
            if (CbxEtatModifyPanCar.Text == "Bon")
            {
                IbtnRepaiCarPan.Visible = true;
            }
            else if (CbxEtatModifyPanCar.Text == "Panne")
            {
                IbtnRepaiCarPan.Visible = false;
                TxtMecanicien.Visible = false;
                CbxGarage.Visible = false;
                LbGarage.Visible = false;
                LbMeacn.Visible = false;
            }
            else if (CbxEtatModifyPanCar.Text == "En cours de reparation")
            {
                TxtMecanicien.Visible = true;
                CbxGarage.Visible = true;
                LbGarage.Visible = true;
                LbMeacn.Visible = true;
            }
            
        }

        private void IcBtnSavedModifyPanCar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);

            try {
                string ImmatCarPan = CbxEtatModifyPanCar.Text;
                if(CbxEtatModifyPanCar.Text == "Panne")
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modificattions ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                if(ImmatCarPan == CbxEtatModifyPanCar.Text)
                                {
                                    SqlCmd = new SqlCommand("UPDATE PANNE SET DESCRIPTION_PAN=@DESCRIPTION_PAN,NOTE_PAN=@NOTE_PAN,INFOS_PAN=@INFOS_PAN,DATE_PAN=@DATE_PAN,DATEMODIFIER_PAN=GETDATE() WHERE CODE_PAN = '" + TxtCodeModifyPanCar.Text + "' ", Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PAN", TxtDescriptionModifyPanCar.Text);
                                    SqlCmd.Parameters.AddWithValue("@NOTE_PAN", RtxtNoteModifyPanCar.Text);
                                    SqlCmd.Parameters.AddWithValue("@INFOS_PAN", RichTxtoutheInfosModifyPanCar.Text);
                                    SqlCmd.Parameters.AddWithValue("@DATE_PAN", DateRegisterModifyPanCar.Value.ToString("dd/MM/yyyy"));
                                    SqlCmd.ExecuteNonQuery();
                                    MessageBox.Show("Enregistré avec suucès");
                                    this.Close();
                                }
                                else
                                {
                                    SqlCmd = new SqlCommand("UPDATE PANNE SET ID_VEHICULE=@ID_VEHICULE,DESCRIPTION_PAN=@DESCRIPTION_PAN,NOTE_PAN=@NOTE_PAN,INFOS_PAN=@INFOS_PAN,DATE_PAN=@DATE_PAN,DATEMODIFIER_PAN=GETDATE() WHERE CODE_PAN = '" + TxtCodeModifyPanCar.Text + "' ", Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarPanMod);
                                    SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PAN", TxtDescriptionModifyPanCar.Text);
                                    SqlCmd.Parameters.AddWithValue("@NOTE_PAN", RtxtNoteModifyPanCar.Text);
                                    SqlCmd.Parameters.AddWithValue("@INFOS_PAN", RichTxtoutheInfosModifyPanCar.Text);
                                    SqlCmd.Parameters.AddWithValue("@DATE_PAN", DateRegisterModifyPanCar.Value.ToString("dd/MM/yyyy"));
                                    SqlCmd.ExecuteNonQuery();
                                    MessageBox.Show("Enregistré avec suucès");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                else if(CbxEtatModifyPanCar.Text == "En cours de reparation")
                {
                    if (!string.IsNullOrEmpty(TxtMecanicien.Text))
                    {
                        if (!string.IsNullOrEmpty(CbxGarage.Text))
                        {
                            DialogResult result = MessageBox.Show("Voulez vous enregister les modificattions ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                               // Console.WriteLine("Id véhicule = " + IdCarPanMod);
                                using (Conn.cn)
                                {
                                    if (Conn.IsConnection)
                                    {
                                        if(ImmatCarPan == CbxEtatModifyPanCar.Text)
                                        {
                                            SqlCmd = new SqlCommand("UPDATE PANNE SET ID_GARAGE=@ID_GARAGE,ETAT_PAN=@ETAT_PAN,DESCRIPTION_PAN=@DESCRIPTION_PAN,NOTE_PAN=@NOTE_PAN,INFOS_PAN=@INFOS_PAN,DATE_PAN=@DATE_PAN,MECANICIEN=@MECANICIEN,DATEMODIFIER_PAN=GETDATE() WHERE CODE_PAN = '" + TxtCodeModifyPanCar.Text + "' ", Conn.cn);
                                            SqlCmd.Parameters.AddWithValue("@ID_GARAGE", IdGaragePan);
                                            SqlCmd.Parameters.AddWithValue("@ETAT_PAN", CbxEtatModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PAN", TxtDescriptionModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@NOTE_PAN", RtxtNoteModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@INFOS_PAN", RichTxtoutheInfosModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@DATE_PAN", DateRegisterModifyPanCar.Value.ToString("dd/MM/yyyy"));
                                            SqlCmd.Parameters.AddWithValue("@MECANICIEN", TxtMecanicien.Text);
                                            SqlCmd.ExecuteNonQuery();
                                            MessageBox.Show("Les modifications ont bien été enregistrées !");
                                            // Request to change the state of car
                                            SqlCmd = new SqlCommand("UPDATE VEHICULE SET SANTE_VEHICULE=@SANTE_VEHICULE WHERE ID_VEHICULE = '" + IdCarPanMod + "' ", Conn.cn);
                                            SqlCmd.Parameters.AddWithValue("@SANTE_VEHICULE", CbxEtatModifyPanCar.Text);
                                            SqlCmd.ExecuteNonQuery();
                                            MessageBox.Show("Enregistré avec suucès");
                                            this.Close();
                                        }
                                        else
                                        {
                                            SqlCmd = new SqlCommand("UPDATE PANNE SET ID_VEHICULE=@ID_VEHICULE,ID_GARAGE=@ID_GARAGE,ETAT_PAN=@ETAT_PAN,DESCRIPTION_PAN=@DESCRIPTION_PAN,NOTE_PAN=@NOTE_PAN,INFOS_PAN=@INFOS_PAN,DATE_PAN=@DATE_PAN,MECANICIEN=@MECANICIEN,DATEMODIFIER_PAN=GETDATE() WHERE CODE_PAN = '" + TxtCodeModifyPanCar.Text + "' ", Conn.cn);
                                            SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarPanMod);
                                            SqlCmd.Parameters.AddWithValue("@ID_GARAGE", IdGaragePan);
                                            SqlCmd.Parameters.AddWithValue("@ETAT_PAN", CbxEtatModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PAN", TxtDescriptionModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@NOTE_PAN", RtxtNoteModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@INFOS_PAN", RichTxtoutheInfosModifyPanCar.Text);
                                            SqlCmd.Parameters.AddWithValue("@DATE_PAN", DateRegisterModifyPanCar.Value.ToString("dd/MM/yyyy"));
                                            SqlCmd.Parameters.AddWithValue("@MECANICIEN", TxtMecanicien.Text);
                                            SqlCmd.ExecuteNonQuery();
                                            MessageBox.Show("Les modifications ont bien été enregistrées !");
                                            // Request to change the state of car
                                            SqlCmd = new SqlCommand("UPDATE VEHICULE SET SANTE_VEHICULE=@SANTE_VEHICULE WHERE ID_VEHICULE = '" + IdCarPanMod + "' ", Conn.cn);
                                            SqlCmd.Parameters.AddWithValue("@SANTE_VEHICULE", CbxEtatModifyPanCar.Text);
                                            SqlCmd.ExecuteNonQuery();
                                            MessageBox.Show("Enregistré avec suucès");
                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Identifiez le garage svp !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veillez saisir le nom du mécanicien");
                    }
                  //  Console.WriteLine("Id véhicule" + IdCarPanMod);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill car in the combobox

        private void FillCar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE SANTE_VEHICULE='Bon' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiModifyPanCar.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiModifyPanCar.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiModifyPanCar.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            CbxGarage.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarage.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarage.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiModifyPanCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiModifyPanCar.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCarPanMod = int.Parse(MyReader[0].ToString());
                        }
                     //   Console.WriteLine("Id véhicule selected : " + IdCarPanMod + " Immat véhicule selected : " + CbxVehiModifyPanCar.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGarage.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdGaragePan = int.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
       
}

