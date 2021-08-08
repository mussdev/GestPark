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
    public partial class FormUtilisateur : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private DataSet Ds;
        public FormUtilisateur()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnAddUser_Click(object sender, EventArgs e)
        {
            FormCreateUser CreateUser = new FormCreateUser();
            CreateUser.ShowDialog();
        }

        private void IbtnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT PSEUDO_USERS,DESCRIPTION_USER,ACTIF,TEL_USERS,EMAIL_USERS,DESCRIPTION_ROLE,DATECREATE_USERS FROM UTILISATEURS LEFT OUTER JOIN	ROLES ON UTILISATEURS.ID_ROLE=ROLES.ID_ROLE", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        DgvUser.AutoGenerateColumns = false;
                        DgvUser.DataSource = Ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyUser ModifyUser = new FormModifyUser();
            ModifyUser.TxtUserNameEdit.Text = this.DgvUser.CurrentRow.Cells[0].Value?.ToString();
            ModifyUser.TxtDescriptionUserEdit.Text = this.DgvUser.CurrentRow.Cells[1].Value?.ToString();
            ModifyUser.TxtMailUserEdit.Text = this.DgvUser.CurrentRow.Cells[2].Value?.ToString();
            ModifyUser.TxtTelUserEdit.Text = this.DgvUser.CurrentRow.Cells[3].Value?.ToString();
           // ModifyUser.CbxActifUserEdit.Text = this.DgvUser.CurrentRow.Cells[4]?.ToString();
            ModifyUser.TxtTelUserEdit.Text = this.DgvUser.CurrentRow.Cells[5].Value?.ToString();
            ModifyUser.ShowDialog();
        }
    }
}
