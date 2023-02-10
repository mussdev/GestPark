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
        private DataSet Ds;
        public FormUtilisateur()
        {
            InitializeComponent();
            DgvUser.DefaultCellStyle.ForeColor = Color.Black;
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
                        SqlCmd = new SqlCommand("SELECT*FROM UTILISATEURS LEFT OUTER JOIN UTILISATEURROLE ON UTILISATEURROLE.ID_USER=UTILISATEURS.ID_USER LEFT OUTER JOIN ROLES ON UTILISATEURROLE.ID_ROLE=ROLES.ID_ROLE", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyUser ModifyUser = new FormModifyUser();
            ModifyUser.TxtCodeUserMod.Text = this.DgvUser.CurrentRow.Cells[0].Value?.ToString();
            ModifyUser.TxtUserNameEdit.Text = this.DgvUser.CurrentRow.Cells[1].Value?.ToString();
            ModifyUser.TxtDescriptionUserEdit.Text = this.DgvUser.CurrentRow.Cells[2].Value?.ToString();
            ModifyUser.TxtMailUserEdit.Text = this.DgvUser.CurrentRow.Cells[3].Value?.ToString();
            ModifyUser.TxtTelUserEdit.Text = this.DgvUser.CurrentRow.Cells[4].Value?.ToString();
            ModifyUser.cbxRolesUserMod.Text = this.DgvUser.CurrentRow.Cells[5].Value?.ToString();
            if (!string.IsNullOrEmpty(this.DgvUser.CurrentRow.Cells[6].Value?.ToString()) && this.DgvUser.CurrentRow.Cells[6].Value?.ToString()=="Actif")
            {
                ModifyUser.CbxActifUserEdit.Checked = true;
            }
            ModifyUser.ShowDialog();
        }

        private void IbtnExporterUser_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DgvUser.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvUser.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DgvUser.Rows.Count; i++)
            {
                for (int j = 0; j < DgvUser.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvUser.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListUser";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
