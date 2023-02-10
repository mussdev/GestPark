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
    public partial class FormServices : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private Guid IdDir;
        private DataSet Ds;
        public FormServices()
        {
            InitializeComponent();
            FillCbxDir();
            displayService();
            TotalServ.Text = $"Total direction = {dataGridViewServ.RowCount - 1 }";
        }

        private void FillCbxDir()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_DIR, DESCRIPTION_DIR FROM DIRECTION", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxDir.Items.Add(MyReader["DESCRIPTION_DIR"].ToString());
                            CbxDir.DisplayMember = (MyReader["DESCRIPTION_DIR"].ToString());
                            CbxDir.ValueMember = (MyReader["ID_DIR"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display all service car
        private void displayService()
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
                        SqlAda = new SqlDataAdapter("SELECT*FROM SERVICESENT INNER JOIN DIRECTION ON DIRECTION.ID_DIR=SERVICESENT.ID_DIR", Conn.cn);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill DataGridView dgvMarq
                        dataGridViewServ.AutoGenerateColumns = false;
                        dataGridViewServ.DataSource = dtbl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CbxDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        
                        SqlCmd = new SqlCommand("SELECT ID_DIR FROM DIRECTION WHERE DESCRIPTION_DIR =@paramDir", Conn.cn);
                        SqlCmd.Parameters.AddWithValue("@paramDir", CbxDir.Text);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdDir = Guid.Parse(MyReader[0].ToString());
                        }
                       // MessageBox.Show("Direction : " + CbxDir.Text + " IDir : " + IdDir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValiderDir_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                string CodeService = generateCodServ();
                if (string.IsNullOrEmpty(TxtBoxDescriptServ.Text))
                {
                    MessageBox.Show("Veiller saisir un code dans le champ description !", "Fleet: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(CbxDir.Text))
                {
                    MessageBox.Show("Veiller choisir la direction à laquelle appartient le service !","Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if (string.IsNullOrEmpty(txtIdService.Text))
                            {
                                textBxCodeServ.Text = generateCodServ();
                                SqlCmd = new SqlCommand("INSERT INTO SERVICESENT (ID_DIR,CODE_SERV,DESCRIPTION_SERV,NOTE_SERV,DATE_SERV) VALUES (@ID_DIR,@CODE_SERV,@DESCRIPTION_SERV,@NOTE_SERV, GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_DIR", IdDir);
                                SqlCmd.Parameters.AddWithValue("@CODE_SERV", CodeService);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_SERV", TxtBoxDescriptServ.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_SERV", richTextBoxNoteServ.Text);
                                SqlCmd.ExecuteNonQuery();

                                // Clean the fields
                                TxtBoxDescriptServ.Clear(); textBxCodeServ.Clear(); richTextBoxNoteServ.Clear(); CbxDir.Text = null;

                                // Display data in datagridview
                                SqlAda = new SqlDataAdapter("SELECT*FROM SERVICESENT INNER JOIN DIRECTION ON DIRECTION.ID_DIR=SERVICESENT.ID_DIR ORDER BY DATE_SERV DESC", Conn.cn);
                                DataTable dt = new DataTable();
                                SqlAda.Fill(dt);

                                // Fill DataGridView
                                dataGridViewServ.AutoGenerateColumns = false;
                                dataGridViewServ.DataSource = dt;
                            }
                            else
                                MessageBox.Show("Ce service existe déja ! Veillez créer un nouveau service !","Fleet: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCloseFormServ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnAnnulerDir_Click(object sender, EventArgs e)
        {
            TxtBoxDescriptServ.Clear(); textBxCodeServ.Clear(); CbxDir.Text=null; richTextBoxNoteServ.Clear();
        }

        // Methode to generate code for service
        private string generateCodServ()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_SERV FROM SERVICESENT WHERE CODE_SERV=(SELECT MAX(CODE_SERV) FROM SERVICESENT)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    textBxCodeServ.Text = Ds.Tables[0].Rows[0]["CODE_SERV"].ToString();
                }
                else
                {
                    textBxCodeServ.Text = "SERV0000";
                }
                if (!string.IsNullOrEmpty(textBxCodeServ.Text))
                {
                    textBxCodeServ.SelectionStart = 4;
                    textBxCodeServ.SelectionLength = 4;
                    textBxCodeServ.Text = textBxCodeServ.SelectedText;
                }
                if (!string.IsNullOrEmpty(textBxCodeServ.Text))
                {
                    int CodeWatch = int.Parse(textBxCodeServ.Text.ToString()) + 1;
                    textBxCodeServ.Text = CodeWatch.ToString("SERV0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return textBxCodeServ.Text;
        }

        private void btnEditServ_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(textBxCodeServ.Text) && !string.IsNullOrEmpty(TxtBoxDescriptServ.Text) && !string.IsNullOrEmpty(CbxDir.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("UPDATE SERVICESENT SET DESCRIPTION_SERV=@DESCRIPTION_SERV,ID_DIR=@ID_DIR,NOTE_SERV=@NOTE_SERV WHERE CODE_SERV='" + textBxCodeServ.Text + "'; ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_SERV", TxtBoxDescriptServ.Text);
                                SqlCmd.Parameters.AddWithValue("@ID_DIR", IdDir);
                                SqlCmd.Parameters.AddWithValue("@NOTE_SERV", richTextBoxNoteServ.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Modification prise en compte !", "Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                SqlAda = new SqlDataAdapter("select * from SERVICESENT left outer join DIRECTION on DIRECTION.ID_DIR=SERVICESENT.ID_DIR order by CODE_SERV desc", Conn.cn);
                                DataTable dt = new DataTable();
                                SqlAda.Fill(dt);
                                dataGridViewServ.AutoGenerateColumns = false;
                                dataGridViewServ.DataSource = dt;
                                // Clear the fields provider of car
                                textBxCodeServ.Clear(); TxtBoxDescriptServ.Clear(); CbxDir.Text=null; richTextBoxNoteServ.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void dataGridViewServ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvServ = dataGridViewServ.Rows[e.RowIndex];
                txtIdService.Text = dgvServ.Cells[0].Value.ToString();
                textBxCodeServ.Text = dgvServ.Cells[1].Value.ToString();
                TxtBoxDescriptServ.Text = dgvServ.Cells[2].Value.ToString();
                CbxDir.Text = dgvServ.Cells[3].Value.ToString();
                richTextBoxNoteServ.Text = dgvServ.Cells[4].Value.ToString();
            }
        }

        private void BtnImportServ_Click(object sender, EventArgs e)
        {
            Form ImportServ = new FormImportService();
            ImportServ.ShowDialog();
        }

        private void btnRafraichirServ_Click(object sender, EventArgs e)
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
                            SqlAda = new SqlDataAdapter("SELECT*FROM SERVICESENT INNER JOIN DIRECTION ON DIRECTION.ID_DIR=SERVICESENT.ID_DIR", Conn.cn);
                            DataTable dt = new DataTable();
                            SqlAda.Fill(dt);

                            // Fill DataGridView
                            dataGridViewServ.AutoGenerateColumns = false;
                            dataGridViewServ.DataSource = dt;

                            // Calcule le nombre de service
                            TotalServ.Text = $"Total direction = {dataGridViewServ.RowCount - 1}";
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportServ_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DATA";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dataGridViewServ.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewServ.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dataGridViewServ.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewServ.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewServ.Rows[i].Cells[j].Value?.ToString();
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

        private void itemMenuDeleteServ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer ce garage ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyGarageDelete = dataGridViewServ.SelectedRows[0].Cells[0].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "DELETE FROM SERVICESENT WHERE CODE_SERV = '" + KeyGarageDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("Le Service a été supprimé avec succès !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void dataGridViewServ_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewServ.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridViewServ.CurrentCell = this.dataGridViewServ.Rows[e.RowIndex].Cells[1];
                this.menuDeleteService.Show(this.dataGridViewServ, e.Location);
                menuDeleteService.Show(Cursor.Position);
            }
        }

        private void txtFilterServ_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewServ.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_SERV LIKE '%" + txtFilterServ.Text + "%' ";
        }
    }
}
