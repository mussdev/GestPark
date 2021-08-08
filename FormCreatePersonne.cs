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
    public partial class FormCreatePersonne : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;

        public FormCreatePersonne()
        {
            InitializeComponent();
        }

        private void iconBtnSavedPerson_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(textBxNomPers.Text))
                {
                    MessageBox.Show("Veiller saisir le nom !");
                }
                else if (string.IsNullOrEmpty(textBxPrenPers.Text))
                {
                    MessageBox.Show("Veiller saisir le champ prénom !");
                }
                else if (string.IsNullOrEmpty(comboBoxTypPiecPers.SelectedItem.ToString()))
                {
                    MessageBox.Show("Veiller sélectionner la pièce !");
                }
                else if (string.IsNullOrEmpty(textBoxNumPieceIdentPers.Text))
                {
                    MessageBox.Show("Veiller saisir le champ n° pièce !");
                }
                else if (string.IsNullOrEmpty(textBoxNumPermisPers.Text))
                {
                    MessageBox.Show("Veiller saisir le champ n° permis !");
                }
                else
                {
                    // Generate code to person
                    string codePerson = generateCodePersonel();
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // INSERT PROVIDER IN DATABASE
                                string DescPerson = textBxNomPers.Text + " " + textBxPrenPers.Text;
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("INSERT INTO PERSONNELS (CODE_PERS,NOM_PERS,PRENOM_PERS,DESCRIPTION_PERS,TEL_PERS,DATENAISS_PERS,LIEUNAISS_PERS,NUMPERMIS_PERS,TYPEPIECE_PERS,NUMPIECEIDENT_PERS,TYPE_PERS,NOTE_PERS,PAYS_PERS,ADRESSE_PERS,VILLE_PERS,CODEPOSTAL_PERS,DATE_PERS,DATECREATE_PERS) VALUES (@CODE_PERS, @NOM_PERS, @PRENOM_PERS,@DESCRIPTION_PERS, @TEL_PERS, @DATENAISS_PERS, @LIEUNAISS_PERS, @NUMPERMIS_PERS, @TYPEPIECE_PERS, @NUMPIECEIDENT_PERS, @TYPE_PERS, @NOTE_PERS, @PAYS_PERS, @ADRESSE_PERS, @VILLE_PERS, @CODEPOSTAL_PERS, @DATE_PERS, GETDATE()); ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@CODE_PERS", codePerson);
                                SqlCmd.Parameters.AddWithValue("@NOM_PERS", textBxNomPers.Text);
                                SqlCmd.Parameters.AddWithValue("@PRENOM_PERS", textBxPrenPers.Text);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PERS", DescPerson);
                                SqlCmd.Parameters.AddWithValue("@TEL_PERS", textBxTelPers.Text);
                                SqlCmd.Parameters.AddWithValue("@DATENAISS_PERS", dateTimePickerDateNaissPers.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@LIEUNAISS_PERS", comboBoxTownPers.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPERMIS_PERS", textBoxNumPermisPers.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPEPIECE_PERS", comboBoxTypPiecPers.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPIECEIDENT_PERS", textBoxNumPieceIdentPers.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPE_PERS", comboBoxTypPers.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_PERS", richTextBoxNotePers.Text);
                                SqlCmd.Parameters.AddWithValue("@PAYS_PERS", comboBoxCountryPers.Text);
                                SqlCmd.Parameters.AddWithValue("@ADRESSE_PERS", textBoxAdressPers.Text);
                                SqlCmd.Parameters.AddWithValue("@VILLE_PERS", comboBoxTownPers.Text);
                                SqlCmd.Parameters.AddWithValue("@CODEPOSTAL_PERS", textBoxCodePostalPers.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_PERS", dateTimePickerDateCreate.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès");
                                // Clear the fields provider of car
                                textBxCodePers.Clear(); textBxNomPers.Clear(); textBxPrenPers.Clear(); textBoxAdressPers.Clear(); textBoxCodePostalPers.Clear(); textBoxNumPermisPers.Clear(); textBoxNumPieceIdentPers.Clear();
                                textBxTelPers.Clear(); richTextBoxNotePers.Clear();
                            }
                        }
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Generate code of personne
        private string generateCodePersonel()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code person
                        SqlCmd = new SqlCommand("SELECT CODE_PERS FROM PERSONNELS WHERE CODE_PERS=(SELECT MAX(CODE_PERS) FROM PERSONNELS)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            textBxCodePers.Text = Ds.Tables[0].Rows[0]["CODE_PERS"].ToString();
                        }
                        else
                        {
                            textBxCodePers.Text = "PERS0000";
                        }
                        if (!string.IsNullOrEmpty(textBxCodePers.Text))
                        {
                            textBxCodePers.SelectionStart = 4;
                            textBxCodePers.SelectionLength = 4;
                            textBxCodePers.Text = textBxCodePers.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(textBxCodePers.Text))
                        {
                            int codePers = int.Parse(textBxCodePers.Text.ToString()) + 1;
                            textBxCodePers.Text = codePers.ToString("PERS0000");
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return textBxCodePers.Text;
        }
    }
}
