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
    public partial class FormImportService : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdDir;
        public FormImportService()
        {
            InitializeComponent();
        }

        // Methode pour importer les files
        private void btnValidImportServ_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using(var Cmd = Conn.cn.CreateCommand())
                        {
                            for (int i = 0; i < dgvImportServ.Rows.Count; i++)
                            {
                                /* Recuperer l'id directeur */
                                Cmd.CommandText = "SELECT ID_DIR FROM DIRECTION WHERE DESCRIPTION_DIR=@DESCRIPTION_DIR";
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_DIR", dgvImportServ.Rows[i].Cells["DESCRIPTION_DIR"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdDir = Guid.Parse(MyReader["ID_DIR"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();
                                //MessageBox.Show("Description directeur: " + dgvImportServ.Rows[i].Cells["DESCRIPTION_DIR"].Value.ToString().Trim() + " Id direction = " + IdDir);
                                /*.........Requête pour importer les données..........*/
                                Cmd.CommandText = "INSERT INTO SERVICESENT (ID_DIR,CODE_SERV,DESCRIPTION_SERV) VALUES (@ID_DIR,@CODE_SERV,@DESCRIPTION_SERV)";
                                Cmd.Parameters.AddWithValue("@ID_DIR", IdDir);
                                Cmd.Parameters.AddWithValue("@CODE_SERV", dgvImportServ.Rows[i].Cells["CODE_SERV"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_SERV", dgvImportServ.Rows[i].Cells["DESCRIPTION_SERV"].Value.ToString());
                                Cmd.ExecuteNonQuery();
                            }
                        }
                        Conn.cn.Close();
                        MessageBox.Show("Importation effectée avec succès !!!", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadFileExcelServ_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApplication;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            /* ... Récuperer le fichier Excel ... */
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Excel Office |*.xls; *xlsx";
            openFD.ShowDialog();
            strFileName = openFD.FileName;

            if (!string.IsNullOrEmpty(strFileName))
            {
                xlApplication = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApplication.Workbooks.Open(strFileName);
                xlWorkSheet = xlWorkBook.Worksheets["DATA"];
                xlRange = xlWorkSheet.UsedRange;

                int i = 0;

                for (xlRow = 2; xlRow < xlRange.Rows.Count; xlRow++)
                {
                    if (xlRange.Cells[xlRow, 1].Text != "")
                    {
                        i++;
                        dgvImportServ.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text);
                    }
                }
                xlWorkBook.Close();
                xlApplication.Quit();
            }
            else
            {
                MessageBox.Show("Aucun fichier n'a été importé !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportFileServ_Click(object sender, EventArgs e)
        {
            ExporterServ();
        }

        private void ExporterServ()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvImportServ.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvImportServ.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvImportServ.Rows.Count; i++)
            {
                for (int j = 0; j < dgvImportServ.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvImportServ.Rows[i].Cells[j].Value?.ToString();
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
    }
}
