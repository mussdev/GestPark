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
    public partial class FormMainFournisseur : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        public FormMainFournisseur()
        {
            InitializeComponent();
        }


        private void iconBtnCloseFormMainFour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateFourn_Click(object sender, EventArgs e)
        {
            Form FormCreateFourn = new FormCreateFourn();
            FormCreateFourn.ShowDialog();
        }

        private void iconBtnSearchFourn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using(Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM FOURNISSEUR WHERE DESCRIPTION_FOUR LIKE @DESCRIPTION_FOUR", Conn.cn);
                        SqlCmd.Parameters.Add("@DESCRIPTION_FOUR", string.Format("%{0}%", textBoxRecheFour.Text));
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill DataGridView
                        dgvProvider.AutoGenerateColumns = false;
                        dgvProvider.DataSource = dtbl;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
