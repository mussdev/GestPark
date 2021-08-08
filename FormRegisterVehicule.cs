using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GestPark
{
    public partial class FormRegisterVehicule : Form
    {
        private SqlCommand SqlCmd;
        private string IdFour,IdMarq,IdTypeConso,IdPark;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        //private string ImgLocation = null;
        private DataSet Ds;

        public FormRegisterVehicule()
        {
            InitializeComponent();
        }

        private void iconBtnCloseFormRegistVehi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMarqVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_MARQ FROM MARQUE WHERE DESCRIPTION_MARQ = '" + comboBoxMarqVehi.SelectedItem + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdMarq = MyReader[0].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnSeachFourn_Click(object sender, EventArgs e)
        {
            Form FormCreateProvider = new FormCreateFourn();
            FormCreateProvider.ShowDialog();
        }

        private void FormRegisterVehicule_Load(object sender, EventArgs e)
        {
            fillComboboxProvider();
            fillComboboxParking();
            fillComboboxMarque();
            fillComboboxTypConso();
        }

        private void iconBtnProprSearch_Click(object sender, EventArgs e)
        {
            Form FormCreatePers = new FormCreatePersonne();
            FormCreatePers.ShowDialog();
        }

        // Method to fill the combobox provider
        private void fillComboboxProvider()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT*FROM FOURNISSEUR", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        comboBoxFourn.Items.Add(MyReader["DESCRIPTION_FOUR"].ToString());
                        comboBoxFourn.DisplayMember = (MyReader["DESCRIPTION_FOUR"].ToString());
                        comboBoxFourn.ValueMember = (MyReader["ID_FOUR"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to fill the combobox parking
        private void fillComboboxParking()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT*FROM PARKING", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        comboBoxEmplVehi.Items.Add(MyReader["DESCRIPTION_PARK"].ToString());
                        comboBoxEmplVehi.DisplayMember = (MyReader["DESCRIPTION_PARK"].ToString());
                        comboBoxEmplVehi.ValueMember = (MyReader["ID_PARK"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTypConsoVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_TYPCONSO FROM TYPECONSOMMATION WHERE DESCRIPTION_TYPCONSO = '" + comboBoxTypConsoVehi.SelectedItem + "' ", Conn.cn);
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

        private void comboBoxFourn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {

                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_FOUR FROM FOURNISSEUR WHERE DESCRIPTION_FOUR = '" + comboBoxFourn.SelectedItem + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdFour = MyReader[0].ToString();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEmplVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_PARK FROM PARKING WHERE DESCRIPTION_PARK = '" + comboBoxEmplVehi.SelectedItem + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdPark = MyReader[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to fill the combobox marque
        private void fillComboboxMarque()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT*FROM MARQUE", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        comboBoxMarqVehi.Items.Add(MyReader["DESCRIPTION_MARQ"].ToString());
                        comboBoxMarqVehi.DisplayMember = (MyReader["DESCRIPTION_MARQ"].ToString());
                        comboBoxMarqVehi.ValueMember = (MyReader["ID_MARQ"].ToString());
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to fill the combobox type of consommation
        private void fillComboboxTypConso()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT*FROM TYPECONSOMMATION", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        comboBoxTypConsoVehi.Items.Add(MyReader["DESCRIPTION_TYPCONSO"].ToString());
                        comboBoxTypConsoVehi.DisplayMember = (MyReader["DESCRIPTION_TYPCONSO"].ToString());
                        comboBoxTypConsoVehi.ValueMember = (MyReader["ID_TYPCONSO"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       /* private void iconBtnUploadImgVehi_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| All Files(*.*)|*.*";

                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImgLocation = Dialog.FileName.ToString();
                    iconPictureBoxVehi.ImageLocation = ImgLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       */
        private void iconBtnSavedVehi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(textBoxImmatVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le champ immatriculation du vehicule !");
                }
                else if (string.IsNullOrEmpty(textBoxCartGriVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le champ carte grise !");
                }
                else if (string.IsNullOrEmpty(textBoxPrixVentVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le prix du vehicule !");
                }
                else if (string.IsNullOrEmpty(comboBoxFourn.Text))
                {
                    MessageBox.Show("Veillez saisir le fournisseur du vehicule !");
                }
                else if (string.IsNullOrEmpty(textBoxPrixVentVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le prix du vehicule !");
                }
                else if (comboBoxEtatVehi.Text != "Parking")
                {
                    MessageBox.Show("Veillez saisir le champ Position !");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Code car
                        string CodCar = generateCodeCar();
                        if (Conn.IsConnection)
                        {
                            SqlCmd = new SqlCommand("INSERT INTO VEHICULE (ID_PARK,ID_TYPCONSO,ID_FOUR,ID_MARQ,CODE_VEHICULE,DATE_ACHA_VEHICULE,DATE_VISITE_VEHICULE,IMMATRICULATION_VEHICULE,MODELE_VEHICULE,CARTE_GRISE_VEHICULE,PRIX_VEHICULE,TYPEVITESSE_VEHICULE,TYPE_VEHICULE,ETAT_VEHICULE,CORDGPS_VEHICULE,DATECREATE_VEHICULE,ASSURANCE_VEHICULE,STATUT_VEHICULE,NOTE_VEHICULE,SANTE_VEHICULE) VALUES (@ID_PARK,@ID_TYPCONSO,@ID_FOUR,@ID_MARQ,@CODE_VEHICULE,@DATE_ACHA_VEHICULE,@DATE_VISITE_VEHICULE,@IMMATRICULATION_VEHICULE,@MODELE_VEHICULE,@CARTE_GRISE_VEHICULE,@PRIX_VEHICULE,@TYPEVITESSE_VEHICULE,@TYPE_VEHICULE,@ETAT_VEHICULE,@CORDGPS_VEHICULE,GETDATE(),@ASSURANCE_VEHICULE,@NOTE_VEHICULE,@STATUT_VEHICULE,@SANTE_VEHICULE)", Conn.cn);
                            SqlCmd.Parameters.AddWithValue("@ID_PARK", IdPark);
                            SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", IdTypeConso);
                            SqlCmd.Parameters.AddWithValue("@ID_FOUR", IdFour);
                            SqlCmd.Parameters.AddWithValue("@ID_MARQ", IdMarq);
                            SqlCmd.Parameters.AddWithValue("@CODE_VEHICULE", CodCar);
                            SqlCmd.Parameters.AddWithValue("@DATE_ACHA_VEHICULE", dateTimePickDatAchaVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATE_VISITE_VEHICULE", dateTimePickDatVisitVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBoxImmatVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@MODELE_VEHICULE", textBoxModelVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBoxCartGriVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@PRIX_VEHICULE", decimal.Parse(textBoxPrixVentVehi.Text));
                            SqlCmd.Parameters.AddWithValue("@TYPEVITESSE_VEHICULE", comboBoxTypVitessVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", comboBoxTypVeh.Text);
                            SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxEtatVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@CORDGPS_VEHICULE", textBoxCordGPSVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", DateTimePickerAssurance.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@NOTE_VEHICULE", richTextBoxNoteVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@STATUT_VEHICULE", CbxStatut_vehi.Text);
                            SqlCmd.Parameters.AddWithValue("@SANTE_VEHICULE", CbxSanteCar.Text);
                            SqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Enregistré avec succès");
                            textBoxCodVehi.Clear(); textBoxImmatVehi.Clear(); textBoxCartGriVehi.Clear(); textBoxModelVehi.Clear(); textBoxPrixVentVehi.Clear(); richTextBoxNoteVehi.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode te generate code
        private string generateCodeCar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_VEHICULE FROM VEHICULE WHERE ID_VEHICULE=(SELECT MAX(ID_VEHICULE) FROM VEHICULE)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    textBoxCodVehi.Text = Ds.Tables[0].Rows[0]["CODE_VEHICULE"].ToString();
                }
                else
                {
                    textBoxCodVehi.Text = "VEHI0000";
                }
                if (!string.IsNullOrEmpty(textBoxCodVehi.Text))
                {
                    textBoxCodVehi.SelectionStart = 4;
                    textBoxCodVehi.SelectionLength = 4;
                    textBoxCodVehi.Text = textBoxCodVehi.SelectedText;
                }
                if (!string.IsNullOrEmpty(textBoxCodVehi.Text))
                {
                    int CodeFour = int.Parse(textBoxCodVehi.Text.ToString()) + 1;
                    textBoxCodVehi.Text = CodeFour.ToString("VEHI0000");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return textBoxCodVehi.Text;
        }
    }
}
