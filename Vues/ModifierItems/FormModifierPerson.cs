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
    public partial class FormModifierPerson : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdServMod;
        public FormModifierPerson()
        {
            InitializeComponent();
            FillCbxService();
        }

        private void BtnPrintDocPers_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSavedPersonMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtNomPersMod.Text) && !string.IsNullOrEmpty(TxtPrenPersMod.Text) && !string.IsNullOrEmpty(TxtTelPersMod.Text) && !string.IsNullOrEmpty(CbxTypPiecPersMod.Text) && !string.IsNullOrEmpty(TxtNumPieceIdentPersMod.Text) && !string.IsNullOrEmpty(TxtNumPermisPersMod.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert table car
                                SqlCmd = new SqlCommand("UPDATE PERSONNELS SET ID_SERV=@ID_SERV, NOM_PERS=@NOM_PERS,PRENOM_PERS=@PRENOM_PERS,TEL_PERS=@TEL_PERS,DATENAISS_PERS=@DATENAISS_PERS,LIEUNAISS_PERS=@LIEUNAISS_PERS,NUMPERMIS_PERS=@NUMPERMIS_PERS,TYPEPIECE_PERS=@TYPEPIECE_PERS,NUMPIECEIDENT_PERS=@NUMPIECEIDENT_PERS,FONCTION_PERS=@FONCTION_PERS,NOTE_PERS=@NOTE_PERS,PAYS_PERS=@PAYS_PERS,ADRESSE_PERS=@ADRESSE_PERS,VILLE_PERS=@VILLE_PERS,CODEPOSTAL_PERS=@CODEPOSTAL_PERS,DATE_PERS=@DATE_PERS,DATEMODIFIER_PERS=GETDATE() WHERE CODE_PERS='" + TxtCodePersMod.Text + "' ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_SERV", IdServMod);
                                SqlCmd.Parameters.AddWithValue("@NOM_PERS", TxtNomPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@PRENOM_PERS", TxtPrenPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@TEL_PERS", TxtTelPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@DATENAISS_PERS", DpDateNaissPersMod.Value.ToString());
                                SqlCmd.Parameters.AddWithValue("@LIEUNAISS_PERS", CbxLieuNaissPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPERMIS_PERS", TxtNumPermisPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPEPIECE_PERS", CbxTypPiecPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPIECEIDENT_PERS", TxtNumPieceIdentPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@FONCTION_PERS", txtFonctionPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_PERS", RtxtNotePersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@PAYS_PERS", CbxCountryPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@ADRESSE_PERS", TxtAdressPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@VILLE_PERS", CbxTownPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@CODEPOSTAL_PERS", TxtCodePostalPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_PERS", DtKDateCreateMod.Value.ToString());
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès", "GestPark", MessageBoxButtons.OK);
                                this.Close();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Veillez saisir les informations obligatoires !", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void BtnSavedPersonMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnSavedPersonMod, "Enregistrer");
        }

        private void BtnImportDocMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnImportDocMod, "Importer");
        }

        private void BtnPrintDocPers_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnPrintDocPers, "Imprimer");
        }

        private void FillCbxService()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_SERV, DESCRIPTION_SERV FROM SERVICESENT", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxSerPersMod.Items.Add(MyReader["DESCRIPTION_SERV"].ToString());
                            CbxSerPersMod.DisplayMember = (MyReader["DESCRIPTION_SERV"].ToString());
                            CbxSerPersMod.ValueMember = (MyReader["ID_SERV"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: Gestion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxSerPersMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(CbxSerPersMod.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_SERV,DESCRIPTION_DIR FROM SERVICESENT INNER JOIN DIRECTION ON SERVICESENT.ID_DIR=DIRECTION.ID_DIR WHERE DESCRIPTION_SERV = '" + CbxSerPersMod.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdServMod = Guid.Parse(MyReader[0].ToString());
                                TxtDirPersMod.Text = MyReader[1].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
