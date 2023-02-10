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
using System.Globalization;

namespace GestPark
{
    public partial class FormRegisterVehicule : Form
    {
        private SqlCommand SqlCmd;
        private Guid? IdFour, IdMarq=null, IdTypeConso=null, IdPark=null;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        //private string ImgLocation = null;
        private DataSet Ds;

        public FormRegisterVehicule()
        {
            InitializeComponent();
        }

        private void iconBtnSeachFourn_Click(object sender, EventArgs e)
        {
            Form FormCreateProvider = new FormCreateFourn();
            FormCreateProvider.ShowDialog();
        }

        private void FormRegisterVehicule_Load(object sender, EventArgs e)
        {
            fillComboboxProvider();
            //fillComboboxParking();
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
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            IdTypeConso = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        IdFour = Guid.Parse(MyReader[0].ToString());
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        comboBoxMarqVehi.Items.Add(MyReader["MODELE_MARQ"].ToString());
                        comboBoxMarqVehi.DisplayMember = (MyReader["MODELE_MARQ"].ToString());
                        comboBoxMarqVehi.ValueMember = (MyReader["ID_MARQ"].ToString());
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnSavedVehi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.iconBtnSavedVehi, "Enregistrer");
        }

        private void BtnImportDoc_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnImportDoc, "Joindre doc.");
        }

        private void textBoxPrixVentVehi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrixVentVehi.Text == "" || textBoxPrixVentVehi.Text == "0") return;
            decimal price;
            price = decimal.Parse(textBoxPrixVentVehi.Text, System.Globalization.NumberStyles.Currency);
            textBoxPrixVentVehi.Text = price.ToString("#,#");
            textBoxPrixVentVehi.SelectionStart = textBoxPrixVentVehi.Text.Length;
        }

        private void TxtKilometrageCar_TextChanged(object sender, EventArgs e)
        {
            if (TxtKilometrageCar.Text == "" || TxtKilometrageCar.Text == "0") return;
            decimal price;
            price = decimal.Parse(TxtKilometrageCar.Text, System.Globalization.NumberStyles.Currency);
            TxtKilometrageCar.Text = price.ToString("#,#");
            TxtKilometrageCar.SelectionStart = TxtKilometrageCar.Text.Length;
        }

        private void comboBoxMarqVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_MARQ,DESCRIPTION_MARQ,MODELE_MARQ FROM MARQUE WHERE MODELE_MARQ = '" + comboBoxMarqVehi.SelectedItem + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdMarq = Guid.Parse(MyReader[0].ToString());
                        textBoxMarqVehi.Text = MyReader[1].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //private void iconBtnSavedVehi_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //        ConnectDB Conn = new ConnectDB(connectionString);
        //        if (string.IsNullOrEmpty(textBoxImmatVehi.Text))
        //        {
        //            MessageBox.Show("Veillez saisir le champ immatriculation du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //        }
        //        else if (string.IsNullOrEmpty(textBoxCartGriVehi.Text))
        //        {
        //            MessageBox.Show("Veillez saisir le champ carte grise !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else if (string.IsNullOrEmpty(textBoxPrixVentVehi.Text))
        //        {
        //            MessageBox.Show("Veillez saisir le prix du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else if (string.IsNullOrEmpty(comboBoxFourn.Text))
        //        {
        //            MessageBox.Show("Veillez saisir le fournisseur du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else if (string.IsNullOrEmpty(textBoxPrixVentVehi.Text))
        //        {
        //            MessageBox.Show("Veillez saisir le prix du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else if (comboBoxEtatVehi.Text != "Parking")
        //        {
        //            MessageBox.Show("Veillez saisir le champ Position !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            DialogResult result = MessageBox.Show("Voulez vous enregister ce véhicule ?", "Fleet: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //            if (result == DialogResult.Yes)
        //            {
        //                // Code car
        //                string CodCar = generateCodeCar();
        //                if (Conn.IsConnection)
        //                {
        //                    SqlCmd = new SqlCommand("INSERT INTO VEHICULE (ID_TYPCONSO,ID_FOUR,ID_MARQ,CODE_VEHICULE,DATE_ACHA_VEHICULE,DATE_VISITE_VEHICULE,IMMATRICULATION_VEHICULE,CARTE_GRISE_VEHICULE,PRIX_VEHICULE,TYPEVITESSE_VEHICULE,TYPE_VEHICULE,ETAT_VEHICULE,CORDGPS_VEHICULE,DATECREATE_VEHICULE,DATEMISEENSERVICE,ASSURANCE_VEHICULE,NOTE_VEHICULE,SANTE_VEHICULE,STATUT_VEHICULE,TOTALKILOMETRAGE_VEHICULE,KILOMETRAGE_VIDENGE_VEHICULE,DATEPROCHAINEVISITETECH,DATEALERTEVISITETECH,DATEPROCHAINEASSURANCE,DATEALERTEASSURANCE) VALUES (@ID_TYPCONSO,@ID_FOUR,@ID_MARQ,@CODE_VEHICULE,@DATE_ACHA_VEHICULE,@DATE_VISITE_VEHICULE,@IMMATRICULATION_VEHICULE,@CARTE_GRISE_VEHICULE,@PRIX_VEHICULE,@TYPEVITESSE_VEHICULE,@TYPE_VEHICULE,@ETAT_VEHICULE,@CORDGPS_VEHICULE,GETDATE(),@DATEMISEENSERVICE,@ASSURANCE_VEHICULE,@NOTE_VEHICULE,@SANTE_VEHICULE,@STATUT_VEHICULE,@TOTALKILOMETRAGE_VEHICULE,@DATEPROCHAINEVISITETECH,@DATEALERTEVISITETECH,@DATEPROCHAINEASSURANCE,@DATEALERTEASSURANCE'" + 0 +"')", Conn.cn);
        //                    //if (IdPark.HasValue)
        //                    //    SqlCmd.Parameters.AddWithValue("@ID_PARK", IdPark.Value);
        //                    //else
        //                    //    SqlCmd.Parameters.AddWithValue("@ID_PARK", DBNull.Value);
        //                    if (IdTypeConso.HasValue)
        //                        SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", IdTypeConso.Value);
        //                    else
        //                        SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", DBNull.Value);

        //                    if (IdMarq.HasValue)
        //                        SqlCmd.Parameters.AddWithValue("@ID_MARQ", IdMarq.Value);
        //                    else
        //                        SqlCmd.Parameters.AddWithValue("@ID_MARQ", DBNull.Value);

        //                    SqlCmd.Parameters.AddWithValue("@ID_FOUR", IdFour);
        //                    //SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", IdTypeConso);
        //                    //SqlCmd.Parameters.AddWithValue("@ID_MARQ", IdMarq);
        //                    MessageBox.Show("Kilometrage total véhicule : " + TxtKilometrageCar.Text);
        //                    SqlCmd.Parameters.AddWithValue("@CODE_VEHICULE", CodCar);
        //                    SqlCmd.Parameters.AddWithValue("@DATE_ACHA_VEHICULE", dateTimePickDatAchaVehi.Value.ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@DATEPROCHAINEVISITETECH", dateTimePickDatVisitVehi.Value.AddYears(1).ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@DATE_VISITE_VEHICULE", dateTimePickDatVisitVehi.Value.ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@DATEALERTEVISITETECH", dateTimePickDatVisitVehi.Value.AddMonths(-1).ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBoxImmatVehi.Text);
        //                    SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBoxCartGriVehi.Text);
        //                    SqlCmd.Parameters.AddWithValue("@PRIX_VEHICULE", decimal.Parse(textBoxPrixVentVehi.Text));
        //                    SqlCmd.Parameters.AddWithValue("@TYPEVITESSE_VEHICULE", comboBoxTypVitessVehi.Text);
        //                    SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", comboBoxTypVeh.Text);
        //                    SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxEtatVehi.Text);
        //                    SqlCmd.Parameters.AddWithValue("@CORDGPS_VEHICULE", textBoxCordGPSVehi.Text);
        //                    SqlCmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", DateTimePickerAssurance.Value.ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@DATEPROCHAINEASSURANCE", DateTimePickerAssurance.Value.AddYears(1).ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@DATEALERTEASSURANCE", DateTimePickerAssurance.Value.AddMonths(-1).ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@NOTE_VEHICULE", RTxtNoteCar.Text);
        //                    SqlCmd.Parameters.AddWithValue("@SANTE_VEHICULE", CbxSanteCar.Text);
        //                    SqlCmd.Parameters.AddWithValue("@DATEMISEENSERVICE", dateDeMiseEnService.Value.ToString("dd/MM/yyyy"));
        //                    SqlCmd.Parameters.AddWithValue("@STATUT_VEHICULE", "Non attribué");
        //                    SqlCmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", decimal.Parse(TxtKilometrageCar.Text));
        //                    SqlCmd.ExecuteNonQuery();

        //                    MessageBox.Show("Le véhicule a été enregistré avec succès !!!","Fleet: Informations",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //                    textBoxCodVehi.Clear(); textBoxImmatVehi.Clear(); textBoxCartGriVehi.Clear(); textBoxMarqVehi.Clear(); textBoxPrixVentVehi.Clear(); RTxtNoteCar.Clear(); TxtKilometrageCar.Clear(); comboBoxMarqVehi.Text = null;comboBoxTypConsoVehi.Text = null;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void iconBtnSavedVehi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(textBoxImmatVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le champ immatriculation du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(textBoxCartGriVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le champ carte grise !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(textBoxPrixVentVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le prix du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(comboBoxFourn.Text))
                {
                    MessageBox.Show("Veillez saisir le fournisseur du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(textBoxPrixVentVehi.Text))
                {
                    MessageBox.Show("Veillez saisir le prix du vehicule !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (comboBoxEtatVehi.Text != "Parking")
                {
                    MessageBox.Show("Veillez saisir le champ Position !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister ce véhicule ?", "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Code car
                        string CodCar = generateCodeCar();
                        if (Conn.IsConnection)
                        {
                            SqlCmd = new SqlCommand("INSERT INTO VEHICULE (ID_TYPCONSO,ID_FOUR,ID_MARQ,CODE_VEHICULE,DATE_ACHA_VEHICULE,DATE_VISITE_VEHICULE,IMMATRICULATION_VEHICULE,CARTE_GRISE_VEHICULE,PRIX_VEHICULE,TYPEVITESSE_VEHICULE,TYPE_VEHICULE,ETAT_VEHICULE,CORDGPS_VEHICULE,DATECREATE_VEHICULE,DATEMISEENSERVICE,ASSURANCE_VEHICULE,NOTE_VEHICULE,SANTE_VEHICULE,STATUT_VEHICULE,TOTALKILOMETRAGE_VEHICULE,KILOMETRAGE_VIDENGE_VEHICULE) VALUES (@ID_TYPCONSO,@ID_FOUR,@ID_MARQ,@CODE_VEHICULE,@DATE_ACHA_VEHICULE,@DATE_VISITE_VEHICULE,@IMMATRICULATION_VEHICULE,@CARTE_GRISE_VEHICULE,@PRIX_VEHICULE,@TYPEVITESSE_VEHICULE,@TYPE_VEHICULE,@ETAT_VEHICULE,@CORDGPS_VEHICULE,GETDATE(),@DATEMISEENSERVICE,@ASSURANCE_VEHICULE,@NOTE_VEHICULE,@SANTE_VEHICULE,@STATUT_VEHICULE,@TOTALKILOMETRAGE_VEHICULE,'" + 0 + "')", Conn.cn);
                            //if (IdPark.HasValue)
                            //    SqlCmd.Parameters.AddWithValue("@ID_PARK", IdPark.Value);
                            //else
                            //    SqlCmd.Parameters.AddWithValue("@ID_PARK", DBNull.Value);

                            if (IdTypeConso.HasValue)
                                SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", IdTypeConso.Value);
                            else
                                SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", DBNull.Value);

                            if (IdMarq.HasValue)
                                SqlCmd.Parameters.AddWithValue("@ID_MARQ", IdMarq.Value);
                            else
                                SqlCmd.Parameters.AddWithValue("@ID_MARQ", DBNull.Value);

                            SqlCmd.Parameters.AddWithValue("@ID_FOUR", IdFour);
                            //SqlCmd.Parameters.AddWithValue("@ID_TYPCONSO", IdTypeConso);
                            //SqlCmd.Parameters.AddWithValue("@ID_MARQ", IdMarq);
                            SqlCmd.Parameters.AddWithValue("@CODE_VEHICULE", CodCar);
                            SqlCmd.Parameters.AddWithValue("@DATE_ACHA_VEHICULE", dateTimePickDatAchaVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATE_VISITE_VEHICULE", dateTimePickDatVisitVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBoxImmatVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBoxCartGriVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@PRIX_VEHICULE", decimal.Parse(textBoxPrixVentVehi.Text));
                            SqlCmd.Parameters.AddWithValue("@TYPEVITESSE_VEHICULE", comboBoxTypVitessVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", comboBoxTypVeh.Text);
                            SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxEtatVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@CORDGPS_VEHICULE", textBoxCordGPSVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", DateTimePickerAssurance.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@NOTE_VEHICULE", RTxtNoteCar.Text);
                            SqlCmd.Parameters.AddWithValue("@SANTE_VEHICULE", CbxSanteCar.Text);
                            SqlCmd.Parameters.AddWithValue("@DATEMISEENSERVICE", dateDeMiseEnService.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@STATUT_VEHICULE", "Non attribué");
                            SqlCmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", decimal.Parse(TxtKilometrageCar.Text));
                            SqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Le véhicule a été enregistré avec succès !!!", "GestParc: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxCodVehi.Clear(); textBoxImmatVehi.Clear(); textBoxCartGriVehi.Clear(); textBoxMarqVehi.Clear(); textBoxPrixVentVehi.Clear(); RTxtNoteCar.Clear(); TxtKilometrageCar.Clear(); comboBoxMarqVehi.Text = null; comboBoxTypConsoVehi.Text = null;
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
                SqlCmd = new SqlCommand("SELECT CODE_VEHICULE FROM VEHICULE WHERE CODE_VEHICULE=(SELECT MAX(CODE_VEHICULE) FROM VEHICULE)", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return textBoxCodVehi.Text;
        }

        //private string MeleageCar()
        //{
        //    if (string.IsNullOrEmpty(TxtKilometrageCar.Text))
        //    {
        //        return TxtKilometrageCar.Text = "0";
        //    }
        //    else
        //    {
        //        return TxtKilometrageCar.Text;
        //    }
        //}
    }
}
