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
    public partial class FormCreateFourn : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormCreateFourn()
        {
            InitializeComponent();
        }

        private void iconBtnSavedFourn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(textBxDescripFourn.Text))
                {
                    MessageBox.Show("Veiller saisir un code dans le champ description !");
                }
                else if (string.IsNullOrEmpty(textBxTelFourn.Text))
                {
                    MessageBox.Show("Veiller saisir le champ tel !");
                }
                else if (string.IsNullOrEmpty(textBxMailFourn.Text))
                {
                    MessageBox.Show("Veiller saisir le champ mail !");
                }
                else
                {
                    // code of provider 
                    string CodProvider = generateCodeProvider();
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // INSERT PROVIDER IN DATABASE
                                SqlCmd = new SqlCommand("INSERT INTO FOURNISSEUR (CODE_FOUR,DESCRIPTION_FOUR,TEL_FOUR,MAIL_FOUR,NOTE_FOUR,REGICOM_FOUR,PAYS_FOUR,VILLE_FOUR,ADRESSE_FOUR,CODEPOSTA_FOUR,CPTCONTRIB_FOUR,AUTREINFO_FOUR,DATE_FOUR,DATECREATION_FOUR) " +
                                    "VALUES ('" + CodProvider + "','" + textBxDescripFourn.Text + "','" + textBxTelFourn.Text + "','" + textBxMailFourn.Text + "','" + richTextBoxNoteFourn.Text + "','" + textBoxRCFourn.Text + "','" + comboBoxCountry.SelectedItem + "'," +
                                    "'" + comboBoxTown.Text + "','" + textBxRueFourn.Text + "','" + textBxCodPostalFourn.Text + "','" + textBxCCFourn.Text + "','" + textBoxOtherFieldFourn.Text + "','" + dateTimePickerFourn.Value.ToString("dd/MM/yyyy") + "', GETDATE() )", Conn.cn);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès");
                                // Clear the fields provider of car
                                textBxCodFourn.Clear(); textBxDescripFourn.Clear(); textBxTelFourn.Clear(); textBxMailFourn.Clear();
                                richTextBoxNoteFourn.Clear(); textBoxRCFourn.Clear(); textBxCCFourn.Clear(); textBoxOtherFieldFourn.Clear(); textBxCodPostalFourn.Clear();
                                textBxCodPostalFourn.Clear(); textBxRueFourn.Clear();
                            }
                        }
                    }
                             
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Generate code of provider
        private string generateCodeProvider()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                // Generate code fournisseur
                SqlCmd = new SqlCommand("SELECT CODE_FOUR FROM FOURNISSEUR WHERE CODE_FOUR=(SELECT MAX(CODE_FOUR) FROM FOURNISSEUR)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    textBxCodFourn.Text = Ds.Tables[0].Rows[0]["CODE_FOUR"].ToString();
                }
                else
                {
                    textBxCodFourn.Text = "FOUR0000";
                }
                if (!string.IsNullOrEmpty(textBxCodFourn.Text))
                {
                    textBxCodFourn.SelectionStart = 4;
                    textBxCodFourn.SelectionLength = 4;
                    textBxCodFourn.Text = textBxCodFourn.SelectedText;
                }
                if (!string.IsNullOrEmpty(textBxCodFourn.Text))
                {
                    int codeFour = int.Parse(textBxCodFourn.Text.ToString()) + 1;
                    textBxCodFourn.Text = codeFour.ToString("FOUR0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return textBxCodFourn.Text;
        }
    }
}
