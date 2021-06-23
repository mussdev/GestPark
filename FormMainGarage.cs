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
    public partial class FormMainGarage : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
        private DataSet ds;
        public FormMainGarage()
        {
            InitializeComponent();
            DisplayGarage();
        }

        private void IcBtnCloseFormGarage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnRegisterGarage_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(TbxDescriptionGar.Text))
                {
                    MessageBox.Show("Veiller saisir le garage !");
                }
                else if (string.IsNullOrEmpty(TbxProprioGar.Text))
                {
                    MessageBox.Show("Veiller saisir le champ propriétaire !");
                }
                else if (string.IsNullOrEmpty(TbxTelGar.Text))
                {
                    MessageBox.Show("Veiller saisir le contact !");
                }
                else
                {
                    // Generate code to person
                    string codeGarage = generateCodeGarage();
                 
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                sqlCmd = new SqlCommand("INSERT INTO GARAGE (CODE_GARAGE,DESCRIPTION_GARAGE,PROPRIETAIRE_GARAGE,TEL_GARAGE,OBSERVATIONS_GARAGE,DATECREATE_GARAGE) VALUES (@CODE_GARAGE,@DESCRIPTION_GARAGE,@PROPRIETAIRE_GARAGE,@TEL_GARAGE,@OBSERVATIONS_GARAGE, GETDATE()); ", Conn.cn);
                                sqlCmd.Parameters.AddWithValue("@CODE_GARAGE", codeGarage);
                                sqlCmd.Parameters.AddWithValue("@DESCRIPTION_GARAGE", TbxDescriptionGar.Text);
                                sqlCmd.Parameters.AddWithValue("@PROPRIETAIRE_GARAGE", TbxProprioGar.Text);
                                sqlCmd.Parameters.AddWithValue("@TEL_GARAGE", TbxTelGar.Text);
                                sqlCmd.Parameters.AddWithValue("@OBSERVATIONS_GARAGE", RichTextBoxNoteGar.Text);
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès");

                                // Display data in datagridview
                                sqlAda = new SqlDataAdapter("select*from garage", Conn.cn);
                                DataTable dt = new DataTable();
                                sqlAda.Fill(dt);
                                dataGridViewGarage.AutoGenerateColumns = false;
                                dataGridViewGarage.DataSource = dt;
                                // Clear the fields provider of car
                                TbxGarCode.Clear(); TbxDescriptionGar.Clear(); TbxProprioGar.Clear(); TbxTelGar.Clear(); RichTextBoxNoteGar.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Generate code of personne
        private string generateCodeGarage()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code garage
                        sqlCmd = new SqlCommand("SELECT CODE_GARAGE FROM GARAGE WHERE CODE_GARAGE=(SELECT MAX(CODE_GARAGE) FROM GARAGE)", Conn.cn);
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        ds = new DataSet();
                        sqlAda.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            TbxGarCode.Text = ds.Tables[0].Rows[0]["CODE_GARAGE"].ToString();
                        }
                        else
                        {
                            TbxGarCode.Text = "GAR0000";
                        }
                        if (!string.IsNullOrEmpty(TbxGarCode.Text))
                        {
                            TbxGarCode.SelectionStart = 3;
                            TbxGarCode.SelectionLength = 4;
                            TbxGarCode.Text = TbxGarCode.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TbxGarCode.Text))
                        {
                            int codePers = int.Parse(TbxGarCode.Text.ToString()) + 1;
                            TbxGarCode.Text = codePers.ToString("GAR0000");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TbxGarCode.Text;
        }

        // Display garage
        private void DisplayGarage()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        sqlAda = new SqlDataAdapter("select*from garage", Conn.cn);
                        DataTable dt = new DataTable();
                        sqlAda.Fill(dt);
                        dataGridViewGarage.AutoGenerateColumns = false;
                        dataGridViewGarage.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
