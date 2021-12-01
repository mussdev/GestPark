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
    public partial class FormModifierFourn : Form
    {
        private SqlCommand SqlCmd;
        public FormModifierFourn()
        {
            InitializeComponent();
        }

        private void BtnSavedFournMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtDescripFournMod.Text) && !string.IsNullOrEmpty(TxtTelFournMod.Text) && !string.IsNullOrEmpty(TxtMailFournMod.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert table car
                                SqlCmd = new SqlCommand("UPDATE FOURNISSEUR SET DESCRIPTION_FOUR=@DESCRIPTION_FOUR,TEL_FOUR=@TEL_FOUR,MAIL_FOUR=@MAIL_FOUR,NOTE_FOUR=@NOTE_FOUR,AUTREINFO_FOUR=@AUTREINFO_FOUR,PAYS_FOUR=@PAYS_FOUR,VILLE_FOUR=@VILLE_FOUR,ADRESSE_FOUR=@ADRESSE_FOUR,CODEPOSTA_FOUR=@CODEPOSTA_FOUR,REGICOM_FOUR=@REGICOM_FOUR,CPTCONTRIB_FOUR=@CPTCONTRIB_FOUR,DATE_FOUR=@DATE_FOUR,DATEEDIT_FOUR=GETDATE() WHERE CODE_FOUR='" + TxtCodFournMod.Text + "' ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_FOUR", TxtDescripFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@TEL_FOUR", TxtTelFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@MAIL_FOUR", TxtMailFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_FOUR", RtxtNoteFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@AUTREINFO_FOUR", TxtOtherFieldFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@PAYS_FOUR", CbxCountryMod.Text);
                                SqlCmd.Parameters.AddWithValue("@VILLE_FOUR", CbxTownMod.Text);
                                SqlCmd.Parameters.AddWithValue("@ADRESSE_FOUR", TxtAdressFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@CODEPOSTA_FOUR", TxtCodPostalFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@REGICOM_FOUR", TxtRCFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@CPTCONTRIB_FOUR", TxtCCFournMod.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_FOUR", DtpRegisterFournMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès", "GestPark", MessageBoxButtons.OK);
                                this.Close();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Veillez saisir les informations obligatoires !", "GestPark", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
