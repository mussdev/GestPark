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
    public partial class FormCreatePlaceParcking : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        public FormCreatePlaceParcking()
        {
            InitializeComponent();
            DisplayParking();
        }

        private void IconBtnEnregistreParc_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(TextBoxCodeParc.Text))
                {
                    MessageBox.Show("Veiller saisir un code dans le champ code !");
                }
                else if (string.IsNullOrEmpty(TextBoxDescriptionParc.Text))
                {
                    MessageBox.Show("Veiller saisir le champ description !");
                }
                else if (string.IsNullOrEmpty(CboBoxTypeParc.Text))
                {
                    MessageBox.Show("Veiller Définir le type de parking !");
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            SqlCmd = new SqlCommand("INSERT INTO PARKING (CODE_PARK,DESCRIPTION_PARK,OBSERVATION_PARK,TYPE_PARK,DATECREATE_PARK) " +
                                "VALUES ('" + TextBoxCodeParc.Text + "','" + TextBoxDescriptionParc.Text + "','" + RichTextBoxNoteParc.Text + "', '" + CboBoxTypeParc.Text + "',GETDATE())", Conn.cn);
                            SqlCmd.ExecuteNonQuery();
                            // Display in datagridview
                            SqlAda = new SqlDataAdapter("select*from Parking", Conn.cn);
                            DataTable dt = new DataTable();
                            SqlAda.Fill(dt);
                            DataGridViewParking.AutoGenerateColumns = false;
                            DataGridViewParking.DataSource = dt;
                            MessageBox.Show("Enregistré avec succès !");
                            // Clear the fields
                            TextBoxCodeParc.Clear(); TextBoxDescriptionParc.Clear(); RichTextBoxNoteParc.Clear();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display parking
        private void DisplayParking()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlAda = new SqlDataAdapter("select*from parking", Conn.cn);
                        DataTable dt = new DataTable();
                        SqlAda.Fill(dt);
                        DataGridViewParking.AutoGenerateColumns = false;
                        DataGridViewParking.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
