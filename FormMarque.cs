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
    public partial class FormMarque : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
        public FormMarque()
        {
            InitializeComponent();
            displaybrandCar();
        }

        private void iconBtnCloseFormMarq_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderMarq_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(textBxCodeMarq.Text))
                {
                    MessageBox.Show("Veiller saisir un code dans le champ code !");
                }
                else if (string.IsNullOrEmpty(textBoxDescriptMarq.Text))
                {
                    MessageBox.Show("Veiller saisir le champ description !");
                }
                else
                {

                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            sqlCmd = new SqlCommand("INSERT INTO MARQUE (CODE_MARQ,DESCRIPTION_MARQ,OBSERVATIONS_MARQ,DATECREATE_MARQ) " +
                            "VALUES ('" + textBxCodeMarq.Text + "','" + textBoxDescriptMarq.Text + "','" + richTextBoxNoteMarq.Text + "', GETDATE()) ", Conn.cn);
                            sqlCmd.ExecuteNonQuery();

                            // Clean the fields
                            textBxCodeMarq.Clear(); textBoxDescriptMarq.Clear(); richTextBoxNoteMarq.Clear();

                            // Request
                            sqlAda = new SqlDataAdapter("SELECT*FROM MARQUE WHERE ID_MARQ = (SELECT MAX(ID_MARQ) FROM MARQUE)", Conn.cn);
                            DataTable dtbl = new DataTable();
                            sqlAda.Fill(dtbl);

                            // Fill DataGridView
                            dataGridViewMarq.AutoGenerateColumns = false;
                            dataGridViewMarq.DataSource = dtbl;
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display all brand car
        private void displaybrandCar()
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                // Request
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        sqlAda = new SqlDataAdapter("SELECT*FROM MARQUE", Conn.cn);
                        DataTable dtbl = new DataTable();
                        sqlAda.Fill(dtbl);

                        // Fill DataGridView dgvMarq
                        dataGridViewMarq.AutoGenerateColumns = false;
                        dataGridViewMarq.DataSource = dtbl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
