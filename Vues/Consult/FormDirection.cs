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
    public partial class FormDirection : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormDirection()
        {
            InitializeComponent();
            displayDirection();
            TotalDir.Text = $"Total direction = {dgvDir.RowCount - 1 }";
        }

        private void btnValiderMarq_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                
                if (string.IsNullOrEmpty(DescriptionDir.Text))
                {
                    MessageBox.Show("Veiller saisir le champ description !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string CodeDirection = generateCodDir();
                            if (string.IsNullOrEmpty(txtIdDir.Text))
                            {
                                SqlCmd = new SqlCommand("INSERT INTO DIRECTION (CODE_DIR,DESCRIPTION_DIR,NOTE_DIR,DATE_DIR) VALUES (@CODE_DIR,@DESCRIPTION_DIR,@NOTE_DIR,GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@CODE_DIR", CodeDirection);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_DIR", DescriptionDir.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_DIR", RTxtNoteDir.Text);
                                SqlCmd.ExecuteNonQuery();

                                // Clean the fields
                                TxtCodDir.Clear(); DescriptionDir.Clear(); RTxtNoteDir.Clear();

                                // Display data in datagridview
                                SqlAda = new SqlDataAdapter("select * from DIRECTION order by DATE_DIR desc", Conn.cn);
                                DataTable dt = new DataTable();
                                SqlAda.Fill(dt);

                                // Fill DataGridView
                                dgvDir.AutoGenerateColumns = false;
                                dgvDir.DataSource = dt;
                                MessageBox.Show("Cette direction a été créee avec succcès !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Cette direction existe déjà !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display all service car
        private void displayDirection()
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
                        SqlAda = new SqlDataAdapter("SELECT * FROM DIRECTION", Conn.cn);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill DataGridView dgvMarq
                        dgvDir.AutoGenerateColumns = false;
                        dgvDir.DataSource = dtbl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCloseFormDir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnnulerDir_Click(object sender, EventArgs e)
        {
            TxtCodDir.Clear();RTxtNoteDir.Clear();DescriptionDir.Clear();
        }

        private void btnEditDir_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtCodDir.Text) && !string.IsNullOrEmpty(DescriptionDir.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("UPDATE DIRECTION SET DESCRIPTION_DIR=@DESCRIPTION_DIR,NOTE_DIR=@NOTE_DIR WHERE CODE_DIR='" + TxtCodDir.Text + "'; ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_DIR", DescriptionDir.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_DIR", RTxtNoteDir.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Modification prise compte !", "Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                SqlAda = new SqlDataAdapter("select*from direction order by DATE_DIR desc", Conn.cn);
                                DataTable dt = new DataTable();
                                SqlAda.Fill(dt);
                                dgvDir.AutoGenerateColumns = false;
                                dgvDir.DataSource = dt;
                                // Clear the fields provider of car
                                TxtCodDir.Clear(); DescriptionDir.Clear(); RTxtNoteDir.Clear();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Veillez sélectionner une direction dans la table !", "Fleet: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvDirection = dgvDir.Rows[e.RowIndex];
                txtIdDir.Text = dgvDirection.Cells[0].Value.ToString();
                TxtCodDir.Text = dgvDirection.Cells[1].Value.ToString();
                DescriptionDir.Text = dgvDirection.Cells[2].Value.ToString();
                RTxtNoteDir.Text = dgvDirection.Cells[3].Value.ToString();
            }
        }

        // Methode to generate code for watching
        private string generateCodDir()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_DIR FROM DIRECTION WHERE CODE_DIR=(SELECT MAX(CODE_DIR) FROM DIRECTION)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodDir.Text = Ds.Tables[0].Rows[0]["CODE_DIR"].ToString();
                }
                else
                {
                    TxtCodDir.Text = "DIR0000";
                }
                if (!string.IsNullOrEmpty(TxtCodDir.Text))
                {
                    TxtCodDir.SelectionStart = 3;
                    TxtCodDir.SelectionLength = 4;
                    TxtCodDir.Text = TxtCodDir.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodDir.Text))
                {
                    int CodeWatch = int.Parse(TxtCodDir.Text.ToString()) + 1;
                    TxtCodDir.Text = CodeWatch.ToString("DIR0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodDir.Text;
        }

        private void BtnImportDirec_Click(object sender, EventArgs e)
        {
            Form ImportDirec = new FormImportDirection();
            ImportDirec.ShowDialog();
        }

        private void BtnExportDirection_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DATA";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvDir.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvDir.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvDir.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDir.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvDir.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Nom du fichier";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void btnRafraichirDir_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            // Display data in datagridview
                            SqlAda = new SqlDataAdapter("select * from DIRECTION order by DATE_DIR desc", Conn.cn);
                            DataTable dt = new DataTable();
                            SqlAda.Fill(dt);

                            // Fill DataGridView
                            dgvDir.AutoGenerateColumns = false;
                            dgvDir.DataSource = dt;

                            // Nombre de service 
                            TotalDir.Text = $"Total direction = {dgvDir.RowCount - 1}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemMenuDeleteDir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer cette direction ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyGarageDelete = dgvDir.SelectedRows[0].Cells[0].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "delete from direction where code_dir = '" + KeyGarageDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("La direction a été supprimée avec succès !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int rowIndex = 0;
        private void dataGridViewDir_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvDir.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvDir.CurrentCell = this.dgvDir.Rows[e.RowIndex].Cells[1];
                this.menuDeleteDir.Show(this.dgvDir, e.Location);
                menuDeleteDir.Show(Cursor.Position);
            }
        }

        private void txtFilterDir_TextChanged(object sender, EventArgs e)
        {
            (dgvDir.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_DIR LIKE '%" + txtFilterDir.Text + "%' ";
        }
    }
}
