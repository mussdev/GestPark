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
    public partial class FormModifyVehicule : Form
    {
        private SqlCommand SqlCmd;
        private string IdFour, IdMarq, IdTypeConso, IdPark, IdPers, IdVehicule;
        private SqlDataReader MyReader, MyReaderApp;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormModifyVehicule()
        {
            InitializeComponent();
            FillComboboxProvider();
            FillComboboxTypConsoVehi();
            FillComboMarqVehicule();
            FillComboboxParking();
            FillComboboxProprietor();
        }

        private void iconBtCloseFanModify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void iconBtnReportCar_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxModifyCarProprio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE DESCRIPTION_PERS = '" + comboBoxModifyCarProprio.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdPers = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxModifyCarFourn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_FOUR FROM FOURNISSEUR WHERE DESCRIPTION_FOUR = '" + comboBoxModifyCarFourn.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdFour = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxModifyCarEmplVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PARK FROM PARKING WHERE DESCRIPTION_PARK = '" + comboBoxModifyCarEmplVehi.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdPark = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxModifyCarMarqVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_MARQ FROM MARQUE WHERE DESCRIPTION_MARQ = '" + comboBoxModifyCarMarqVehi.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdMarq = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IconBtnSavedModifica_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(comboBoxModifyCarProprio.Text) && comboBoxModifyCarTypVeh.Text == "Pool")
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert table car
                                SqlCmd = new SqlCommand("UPDATE VEHICULE SET ID_PARK=@ID_PARK,ID_TYPCONSO=@ID_TYPCONSO,ID_FOUR=@ID_FOUR,ID_MARQ=@ID_MARQ,DATE_ACHA_VEHICULE=@DATE_ACHA_VEHICULE,DATE_VISITE_VEHICULE=@DATE_VISITE_VEHICULE,IMMATRICULATION_VEHICULE=@IMMATRICULATION_VEHICULE,MODELE_VEHICULE=@MODELE_VEHICULE,CARTE_GRISE_VEHICULE=@CARTE_GRISE_VEHICULE,PRIX_VEHICULE=@PRIX_VEHICULE,TYPEVITESSE_VEHICULE=@TYPEVITESSE_VEHICULE,TYPE_VEHICULE=@TYPE_VEHICULE,ETAT_VEHICULE=@ETAT_VEHICULE,CORDGPS_VEHICULE=@CORDGPS_VEHICULE,ASSURANCE_VEHICULE=@ASSURANCE_VEHICULE,NOTE_VEHICULE=@NOTE_VEHICULE WHERE CODE_VEHICULE='" + textBoxModifyCarCodVehi.Text + "' ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_PARK", IdPark);
                                SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", IdTypeConso);
                                SqlCmd.Parameters.AddWithValue("@ID_FOUR", IdFour);
                                SqlCmd.Parameters.AddWithValue("@ID_MARQ", IdMarq);
                                SqlCmd.Parameters.AddWithValue("@DATE_ACHA_VEHICULE", dateTimePickModifyCarDatAchaVehi.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATE_VISITE_VEHICULE", dateTimeModifyCarPickDatVisitVehi.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBoxModifyCarImmatVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@MODELE_VEHICULE", textBoxModifyCarModelVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBoxModifyCarCartGriVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@PRIX_VEHICULE", float.Parse(textBoxModifyCarPrixVentVehi.Text));
                                SqlCmd.Parameters.AddWithValue("@TYPEVITESSE_VEHICULE", comboBoxModifyCarTypVitessVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", comboBoxModifyCarTypVeh.Text);
                                SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxModifyCarEtatVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@CORDGPS_VEHICULE", textBoxModifyCarCordGPSVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", DateTimePickerModifyCarAssurance.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@NOTE_VEHICULE", richTextBoxModifyCarNoteVehi.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès");
                            }
                        }
                    }
                }
                else if (!string.IsNullOrEmpty(comboBoxModifyCarProprio.Text) && comboBoxModifyCarTypVeh.Text == "Privé")
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert table car
                                SqlCmd = new SqlCommand("UPDATE VEHICULE SET ID_PARK=@ID_PARK,ID_TYPCONSO=@ID_TYPCONSO,ID_FOUR=@ID_FOUR,ID_MARQ=@ID_MARQ,DATE_ACHA_VEHICULE=@DATE_ACHA_VEHICULE,DATE_VISITE_VEHICULE=@DATE_VISITE_VEHICULE,IMMATRICULATION_VEHICULE=@IMMATRICULATION_VEHICULE,MODELE_VEHICULE=@MODELE_VEHICULE,CARTE_GRISE_VEHICULE=@CARTE_GRISE_VEHICULE,PRIX_VEHICULE=@PRIX_VEHICULE,TYPEVITESSE_VEHICULE=@TYPEVITESSE_VEHICULE,TYPE_VEHICULE=@TYPE_VEHICULE,ETAT_VEHICULE=@ETAT_VEHICULE,CORDGPS_VEHICULE=@CORDGPS_VEHICULE,ASSURANCE_VEHICULE=@ASSURANCE_VEHICULE,NOTE_VEHICULE=@NOTE_VEHICULE WHERE CODE_VEHICULE='" + textBoxModifyCarCodVehi.Text + "' ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_PARK", IdPark);
                                SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", IdTypeConso);
                                SqlCmd.Parameters.AddWithValue("@ID_FOUR", IdFour);
                                SqlCmd.Parameters.AddWithValue("@ID_MARQ", IdMarq);
                                SqlCmd.Parameters.AddWithValue("@DATE_ACHA_VEHICULE", dateTimePickModifyCarDatAchaVehi.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATE_VISITE_VEHICULE", dateTimeModifyCarPickDatVisitVehi.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBoxModifyCarImmatVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@MODELE_VEHICULE", textBoxModifyCarModelVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBoxModifyCarCartGriVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@PRIX_VEHICULE", float.Parse(textBoxModifyCarPrixVentVehi.Text));
                                SqlCmd.Parameters.AddWithValue("@TYPEVITESSE_VEHICULE", comboBoxModifyCarTypVitessVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", comboBoxModifyCarTypVeh.Text);
                                SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxModifyCarEtatVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@CORDGPS_VEHICULE", textBoxModifyCarCordGPSVehi.Text);
                                SqlCmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", DateTimePickerModifyCarAssurance.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@NOTE_VEHICULE", richTextBoxModifyCarNoteVehi.Text);
                                SqlCmd.ExecuteNonQuery();
                            }
                        }
                        // Request to send the last id vehicule
                        using (Conn.cn)
                            {
                                if (Conn.IsConnection)
                                {
                                    SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE CODE_VEHICULE='" + textBoxModifyCarCodVehi.Text + "')", Conn.cn);
                                    MyReader = SqlCmd.ExecuteReader();

                                    while (MyReader.Read())
                                    {
                                        IdVehicule = MyReader[0].ToString();
                                    }
                                }
                            }

                            // Fill table Appartenir, association between personnels and vehicule
                            using (Conn.cn)
                            {
                                if (Conn.IsConnection)
                                {
                                    SqlCmd = new SqlCommand("UPDATE APPARTENIR SET ID_PERS=@ID_PERS,ID_VEHICULE=@ID_VEHICULE,DATE_DEBUT_PERS=@DATE_DEBUT_PERS WHERE ID_VEHICULE = '" + IdVehicule + "' ", Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPers);
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehicule);
                                    SqlCmd.ExecuteNonQuery();
                                }
                            }

                        MessageBox.Show("Enregistré avec succès");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Veiller saisir correctement les champs ou vérifier le type de vehicule");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxModifyCarTypConsoVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_TYPCONSO FROM TYPECONSOMMATION WHERE DESCRIPTION_TYPCONSO = '" + comboBoxModifyCarTypConsoVehi.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdTypeConso = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to fill the combobox provider
        private void FillComboboxProvider()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM FOURNISSEUR", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            comboBoxModifyCarFourn.Items.Add(MyReader["DESCRIPTION_FOUR"].ToString());
                            comboBoxModifyCarFourn.DisplayMember = (MyReader["DESCRIPTION_FOUR"].ToString());
                            comboBoxModifyCarFourn.ValueMember = (MyReader["ID_FOUR"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to fill the combobox proprietor
        private void FillComboboxProprietor()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        string TypePerson = "Propriétaire";
                        SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_PERS FROM PERSONNELS WHERE TYPE_PERS='" + TypePerson + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            comboBoxModifyCarProprio.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            comboBoxModifyCarProprio.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            comboBoxModifyCarProprio.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillComboboxParking()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM PARKING", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            comboBoxModifyCarEmplVehi.Items.Add(MyReader["DESCRIPTION_PARK"].ToString());
                            comboBoxModifyCarEmplVehi.DisplayMember = (MyReader["DESCRIPTION_PARK"].ToString());
                            comboBoxModifyCarEmplVehi.ValueMember = (MyReader["ID_PARK"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillComboboxTypConsoVehi()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM TYPECONSOMMATION", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            comboBoxModifyCarTypConsoVehi.Items.Add(MyReader["DESCRIPTION_TYPCONSO"].ToString());
                            comboBoxModifyCarTypConsoVehi.DisplayMember = (MyReader["DESCRIPTION_TYPCONSO"].ToString());
                            comboBoxModifyCarTypConsoVehi.ValueMember = (MyReader["ID_TYPCONSO"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillComboMarqVehicule()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM MARQUE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            comboBoxModifyCarMarqVehi.Items.Add(MyReader["DESCRIPTION_MARQ"].ToString());
                            comboBoxModifyCarMarqVehi.DisplayMember = (MyReader["DESCRIPTION_MARQ"].ToString());
                            comboBoxModifyCarMarqVehi.ValueMember = (MyReader["ID_MARQ"].ToString());
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
