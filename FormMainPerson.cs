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
    public partial class FormMainPerson : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
        public FormMainPerson()
        {
            InitializeComponent();
        }

        private void iconBtnCreatePers_Click(object sender, EventArgs e)
        {
            Form FormCreatePers = new FormCreatePersonne();
            FormCreatePers.ShowDialog();
        }

        private void iconBtnCloseFormPers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnSearchPers_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        sqlCmd = new SqlCommand("SELECT*FROM PERSONNELS WHERE NOM_PERS=@NOM_PERS OR NOM_PERS LIKE @NOM_PERS OR PRENOM_PERS LIKE @PRENOM_PERS ", Conn.cn);
                        sqlCmd.Parameters.Add("@NOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        sqlCmd.Parameters.Add("@PRENOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        DataTable dtbl = new DataTable();
                        sqlAda.Fill(dtbl);

                        // Fill DataGridView
                        dgvPerson.AutoGenerateColumns = false;
                        dgvPerson.DataSource = dtbl;

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
