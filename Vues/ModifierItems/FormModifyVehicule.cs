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
using LiveCharts;
using System.Configuration;
using System.Text.RegularExpressions;

namespace GestPark
{
    public partial class FormModifyVehicule : Form
    {
        private SqlCommand SqlCmd;
        private Guid? IdFour, IdMarq=null, IdPark = null, IdPers=null, IdVehicule=null, IdTypeConso = null, IdCar;
        private SqlDataReader MyReader;
        private List<double> DatConso = new List<double>();
        public static string codeCar, idCarMod;
        public SeriesCollection SeriesCollection { get; set; }
        //private DataSet ds;
        public FormModifyVehicule()
        {
            InitializeComponent();
            FillComboboxProvider();
            FillComboboxTypConsoVehi();
            FillComboMarqVehicule();
            FillComboboxProprietor();
            // textBoxModifyCarPrixVentVehi.Text = $"{decimal.Parse(textBoxModifyCarPrixVentVehi.Text).ToString("### ### ### ###")} ";
        }

        
        private void iconBtnReportCar_Click(object sender, EventArgs e)
        {
            codeCar = textBoxModifyCarCodVehi.Text;
            idCarMod = textBoxModifyCarImmatVehi.Text;
            FormReportCar reportCar = new FormReportCar();
            reportCar.ShowDialog();
            //reportCar.displayDataCar();
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
                            IdPers = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IconBtnSavedModifica_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "ParcAuto: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert table car
                                SqlCmd = new SqlCommand("UPDATE VEHICULE SET ID_TYPCONSO=@ID_TYPCONSO,ID_FOUR=@ID_FOUR,ID_MARQ=@ID_MARQ,DATE_ACHA_VEHICULE=@DATE_ACHA_VEHICULE,DATE_VISITE_VEHICULE=@DATE_VISITE_VEHICULE,IMMATRICULATION_VEHICULE=@IMMATRICULATION_VEHICULE,CARTE_GRISE_VEHICULE=@CARTE_GRISE_VEHICULE,PRIX_VEHICULE=@PRIX_VEHICULE,TYPEVITESSE_VEHICULE=@TYPEVITESSE_VEHICULE,TYPE_VEHICULE=@TYPE_VEHICULE,ETAT_VEHICULE=@ETAT_VEHICULE,CORDGPS_VEHICULE=@CORDGPS_VEHICULE,ASSURANCE_VEHICULE=@ASSURANCE_VEHICULE,DATEMISEENSERVICE=@DATEMISEENSERVICE,NOTE_VEHICULE=@NOTE_VEHICULE,STATUT_VEHICULE=@STATUT_VEHICULE,TOTALKILOMETRAGE_VEHICULE=@TOTALKILOMETRAGE_VEHICULE,SANTE_VEHICULE=@SANTE_VEHICULE,DATEPROCHAINEVISITETECH=@DATEPROCHAINEVISITETECH,DATEALERTEVISITETECH=@DATEALERTEVISITETECH,DATEPROCHAINEASSURANCE=@DATEPROCHAINEASSURANCE,DATEALERTEASSURANCE=@DATEALERTEASSURANCE WHERE CODE_VEHICULE='" + textBoxModifyCarCodVehi.Text + "' ", Conn.cn);
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
                            //MessageBox.Show("Prix du véhicule : ", Regex.Replace(textBoxModifyCarPrixVentVehi.Text, @"\s", ""));
                            SqlCmd.Parameters.AddWithValue("@ID_FOUR", IdFour);
                            SqlCmd.Parameters.AddWithValue("@DATE_ACHA_VEHICULE", dateTimePickModifyCarDatAchaVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATE_VISITE_VEHICULE", dateTimeModifyCarPickDatVisitVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATEPROCHAINEVISITETECH", dateTimeModifyCarPickDatVisitVehi.Value.AddYears(1).ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATEALERTEVISITETECH", dateTimeModifyCarPickDatVisitVehi.Value.AddMonths(-1).ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBoxModifyCarImmatVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBoxModifyCarCartGriVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@PRIX_VEHICULE", decimal.Parse(Regex.Replace(textBoxModifyCarPrixVentVehi.Text,@"\s","")));
                            SqlCmd.Parameters.AddWithValue("@TYPEVITESSE_VEHICULE", comboBoxModifyCarTypVitessVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", comboBoxModifyCarTypVeh.Text);
                            SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxModifyCarEtatVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@CORDGPS_VEHICULE", textBoxModifyCarCordGPSVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", DateTimePickerModifyCarAssurance.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATEPROCHAINEASSURANCE", DateTimePickerModifyCarAssurance.Value.AddYears(1).ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATEALERTEASSURANCE", DateTimePickerModifyCarAssurance.Value.AddMonths(-1).ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATEMISEENSERVICE", dateMiseEnServMod.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@NOTE_VEHICULE", richTextBoxModifyCarNoteVehi.Text);
                            SqlCmd.Parameters.AddWithValue("@STATUT_VEHICULE", CbxStatutModifyCar.Text);

                            if(string.IsNullOrEmpty(Regex.Replace(TxtKolimetrageCar.Text,@"\s","")))
                            {
                                SqlCmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", 0);
                                //MessageBox.Show("Kilo : " + TxtKolimetrageCar.Text);
                            }
                            else
                                SqlCmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", decimal.Parse(Regex.Replace(TxtKolimetrageCar.Text,@"\s","")));
                            
                            SqlCmd.Parameters.AddWithValue("@SANTE_VEHICULE", CbxSanteCar.SelectedItem);
                            SqlCmd.ExecuteNonQuery();
                            
                            MessageBox.Show("Vos modifications ont été enregistrées avec succès !", "Fleet : Informations", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Close();
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            IdTypeConso = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        SqlCmd = new SqlCommand("SELECT * FROM FOURNISSEUR", Conn.cn);
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
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVidengeCar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                FormCreateEntretien CreateEntretien = new FormCreateEntretien();
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE FROM VEHICULE WHERE CODE_VEHICULE='" + textBoxModifyCarCodVehi.Text + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CreateEntretien.txtCarVdge.Text = MyReader["IMMATRICULATION_VEHICULE"].ToString();
                        }
                    }
                    
                    CreateEntretien.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_PERS FROM PERSONNELS", Conn.cn);
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
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnVidengeCar_Click_1(object sender, EventArgs e)
        {
            FormCreateEntretien CreateEntretien = new FormCreateEntretien();
            CreateEntretien.txtCarVdge.Text = textBoxModifyCarImmatVehi.Text;
            //CreateEntretien.TxtKiloVidenge.Text = TxtKilometrageParCar.Text;
            CreateEntretien.ShowDialog();
        }

        private void comboBoxModifyCarTypConsoVehi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_TYPCONSO FROM TYPECONSOMMATION WHERE DESCRIPTION_TYPCONSO = '" + comboBoxModifyCarTypConsoVehi.SelectedItem + "' ", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxModifyCarFourn_SelectedIndexChanged_1(object sender, EventArgs e)
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
                            IdFour = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IconBtnSavedModifica_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnRegistCarMod = new ToolTip();
            ToolTipBtnRegistCarMod.AutoPopDelay = 5000;
            ToolTipBtnRegistCarMod.InitialDelay = 1000;
            ToolTipBtnRegistCarMod.ReshowDelay = 500;
            ToolTipBtnRegistCarMod.ShowAlways = true;
            ToolTipBtnRegistCarMod.SetToolTip(this.IconBtnSavedModifica, "Enregistrer");
        }

        private void iconBtnReportCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImportCarMod = new ToolTip();
            ToolTipBtnImportCarMod.AutoPopDelay = 5000;
            ToolTipBtnImportCarMod.InitialDelay = 1000;
            ToolTipBtnImportCarMod.ReshowDelay = 500;
            ToolTipBtnImportCarMod.ShowAlways = true;
            ToolTipBtnImportCarMod.SetToolTip(this.iconBtnReportCar, "Imprimer");
        }

        private void TxtKolimetrageCar_TextChanged(object sender, EventArgs e)
        {
            //if (TxtKolimetrageCar.Text == "" || TxtKolimetrageCar.Text == "0") return;
            //decimal price;
            //price = decimal.Parse(TxtKolimetrageCar.Text, System.Globalization.NumberStyles.Currency);
            //TxtKolimetrageCar.Text = price.ToString("#,#");
            //TxtKolimetrageCar.SelectionStart = TxtKolimetrageCar.Text.Length;
        }

        private void iconBtnSeachFourn_Click(object sender, EventArgs e)
        {
            Form formForm = new FormCreateFourn();
            formForm.ShowDialog();
        }

        private void iconBtnProprSearch_Click(object sender, EventArgs e)
        {
            Form formPers = new FormCreatePersonne();
            formPers.ShowDialog();
        }

        private void comboBoxModifyCarModelVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_MARQ,DESCRIPTION_MARQ FROM MARQUE WHERE MODELE_MARQ = '" + comboBoxModifyCarModelVehi.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdMarq = Guid.Parse(MyReader[0].ToString());
                            textBoxModifyCarMarkVehi.Text = MyReader[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcbtnJointFileCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExportCarMod = new ToolTip();
            ToolTipBtnExportCarMod.AutoPopDelay = 5000;
            ToolTipBtnExportCarMod.InitialDelay = 1000;
            ToolTipBtnExportCarMod.ReshowDelay = 500;
            ToolTipBtnExportCarMod.ShowAlways = true;
            ToolTipBtnExportCarMod.SetToolTip(this.IcbtnJointFileCar, "Joindre un fichier");
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
                        SqlCmd = new SqlCommand("SELECT * FROM TYPECONSOMMATION", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        SqlCmd = new SqlCommand("SELECT * FROM MARQUE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            comboBoxModifyCarModelVehi.Items.Add(MyReader["MODELE_MARQ"].ToString());
                            comboBoxModifyCarModelVehi.DisplayMember = (MyReader["MODELE_MARQ"].ToString());
                            comboBoxModifyCarModelVehi.ValueMember = (MyReader["ID_MARQ"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Guid IdCarExport() {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + textBoxModifyCarImmatVehi.Text  + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCar = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (Guid)IdCar;
        }

    }
}
