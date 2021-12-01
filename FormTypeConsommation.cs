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
    public partial class FormTypeConsommation : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        public FormTypeConsommation()
        {
            InitializeComponent();
            displayListTypConsommation();
        }

        private void iconBtnCloseFormTypConso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnValiderTypConso_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(textBoxCodTypConso.Text))
                {
                    MessageBox.Show("Veiller saisir un code dans le champ code !");
                }
                else if (string.IsNullOrEmpty(textBoxDescripTypConso.Text))
                {
                    MessageBox.Show("Veiller saisir le champ description !");
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            SqlCmd = new SqlCommand("INSERT INTO TYPECONSOMMATION (CODE_TYPCONSO,DESCRIPTION_TYPCONSO,OBSERVATION_TYPCONSO,DATECREATE_TYPCONSO) " +
                            "VALUES ('" + textBoxCodTypConso.Text + "','" + textBoxDescripTypConso.Text + "','" + richTextBoxNoteTypConso.Text + "',GETDATE())", Conn.cn);
                            SqlCmd.ExecuteNonQuery();
                            // Clear the fields
                            textBoxCodTypConso.Clear(); textBoxDescripTypConso.Clear(); richTextBoxNoteTypConso.Clear();

                            // Request
                            SqlAda = new SqlDataAdapter("SELECT*FROM TYPECONSOMMATION WHERE ID_TYPCONSO = (SELECT MAX(ID_TYPCONSO) FROM TYPECONSOMMATION)", Conn.cn);
                            DataTable dtbl = new DataTable();
                            SqlAda.Fill(dtbl);

                            // Fill DataGridView
                            dataGridViewTypConso.AutoGenerateColumns = false;
                            dataGridViewTypConso.DataSource = dtbl;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to display all type of car consommation
        private void displayListTypConsommation()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Request
                        SqlAda = new SqlDataAdapter("SELECT*FROM TYPECONSOMMATION", Conn.cn);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill dataGridView to display the list of parking
                        dataGridViewTypConso.AutoGenerateColumns = false;
                        dataGridViewTypConso.DataSource = dtbl;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
