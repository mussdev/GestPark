using GestPark.Vues.CreateItems;
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
    public partial class FormRoles : Form
    {
        private SqlDataAdapter SqlAda;
        public FormRoles()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormRole_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnAddRole_Click(object sender, EventArgs e)
        {
            Form CreateRole = new FormCreateRoles();
            CreateRole.ShowDialog();
        }

        private void IbtnSearchRole_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (Conn.IsConnection)
                {
                    using (var Cmd = Conn.cn.CreateCommand())
                    {
                        Cmd.CommandText = "select*from roles";
                        SqlAda = new SqlDataAdapter(Cmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        dgvRoles.AutoGenerateColumns = false;
                        dgvRoles.DataSource = tb.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRoles_DoubleClick(object sender, EventArgs e)
        {
            displayRolesToEdit();
        }

        private void displayRolesToEdit()
        {
            FormModifierRoles ModifierRoles = new FormModifierRoles();
            ModifierRoles.txtIdRoles.Text = dgvRoles.CurrentRow.Cells[0].Value?.ToString();
            ModifierRoles.txtCodeRoleMod.Text = dgvRoles.CurrentRow.Cells[1].Value?.ToString();
            ModifierRoles.txtDescriptionRoleMod.Text = dgvRoles.CurrentRow.Cells[2].Value?.ToString();
            ModifierRoles.RtxtNoteRoleMod.Text = dgvRoles.CurrentRow.Cells[3].Value?.ToString();
            ModifierRoles.chkAdminRoleMod.Checked = bool.Parse(dgvRoles.CurrentRow.Cells[4].Value?.ToString());
            ModifierRoles.chkParamRoleMod.Checked = bool.Parse(dgvRoles.CurrentRow.Cells[5].Value?.ToString());
            ModifierRoles.chkGestVehiPoolRoleMod.Checked = bool.Parse(dgvRoles.CurrentRow.Cells[6].Value?.ToString());
            ModifierRoles.chkSuiviVheiRoleMod.Checked = bool.Parse(dgvRoles.CurrentRow.Cells[7].Value?.ToString());
            ModifierRoles.chkTablBordRoleMod.Checked = bool.Parse(dgvRoles.CurrentRow.Cells[8].Value?.ToString());

            ModifierRoles.ShowDialog();
        }
    }
}
