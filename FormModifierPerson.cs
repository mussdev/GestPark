using Stimulsoft.Report;
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
        public FormModifierPerson()
        {
            InitializeComponent();
        }

        private void BtnPrintDocPers_Click(object sender, EventArgs e)
        {
            var reportPers = new StiReport();
            // Call report
            reportPers.Design();
        }

        private void BtnSavedPersonMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(CbxTypPersMod.Text) && !string.IsNullOrEmpty(TxtNomPersMod.Text) && !string.IsNullOrEmpty(TxtPrenPersMod.Text) && !string.IsNullOrEmpty(TxtTelPersMod.Text) && !string.IsNullOrEmpty(CbxTypPiecPersMod.Text) && !string.IsNullOrEmpty(TxtNumPieceIdentPersMod.Text) && !string.IsNullOrEmpty(TxtNumPermisPersMod.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert table car
                                SqlCmd = new SqlCommand("UPDATE PERSONNELS SET NOM_PERS=@NOM_PERS,PRENOM_PERS=@PRENOM_PERS,TEL_PERS=@TEL_PERS,DATENAISS_PERS=@DATENAISS_PERS,LIEUNAISS_PERS=@LIEUNAISS_PERS,NUMPERMIS_PERS=@NUMPERMIS_PERS,TYPEPIECE_PERS=@TYPEPIECE_PERS,NUMPIECEIDENT_PERS=@NUMPIECEIDENT_PERS,TYPE_PERS=@TYPE_PERS,NOTE_PERS=@NOTE_PERS,PAYS_PERS=@PAYS_PERS,ADRESSE_PERS=@ADRESSE_PERS,VILLE_PERS=@VILLE_PERS,CODEPOSTAL_PERS=@CODEPOSTAL_PERS,DATE_PERS=@DATE_PERS,DATEMODIFIER_PERS=GETDATE() WHERE CODE_PERS='" + TxtCodePersMod.Text + "' ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@NOM_PERS", TxtNomPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@PRENOM_PERS", TxtPrenPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@TEL_PERS", TxtTelPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@DATENAISS_PERS", DpDateNaissPersMod.Value.ToString());
                                SqlCmd.Parameters.AddWithValue("@LIEUNAISS_PERS", CbxLieuNaissPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPERMIS_PERS", TxtNumPermisPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPEPIECE_PERS", CbxTypPiecPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPIECEIDENT_PERS", TxtNumPieceIdentPersMod.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPE_PERS", CbxTypPersMod.Text);
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
                    MessageBox.Show("Veillez saisir les informations obligatoires !", "GestPark", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
