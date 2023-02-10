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
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace GestPark
{
    public partial class FormImportFournisseur : Form
    {
        private SqlCommand SqlCmd;
        public FormImportFournisseur()
        {
            InitializeComponent();
        }

        private void btnLoadFileExcelFour_Click(object sender, EventArgs e)
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
                        dgvImportFourn.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text);
                    }
                }
                xlWorkBook.Close();
                xlApplication.Quit();
            }
            else
            {
                MessageBox.Show("Aucun fichier n'a été importé !", "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValidImportFour_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        for (int i = 0; i < dgvImportFourn.Rows.Count; i++)
                        {
                            SqlCmd = new SqlCommand("INSERT INTO FOURNISSEUR (CODE_FOUR,DESCRIPTION_FOUR,TEL_FOUR) VALUES (@param1,@param2,@param3)", Conn.cn);
                            SqlCmd.Parameters.AddWithValue("@param1", dgvImportFourn.Rows[i].Cells["CODE_FOUR"].Value.ToString());
                            SqlCmd.Parameters.AddWithValue("@param2", dgvImportFourn.Rows[i].Cells["DESCRIPTION_FOUR"].Value.ToString());
                            SqlCmd.Parameters.AddWithValue("@param3", dgvImportFourn.Rows[i].Cells["TEL_FOUR"].Value.ToString());
                            SqlCmd.ExecuteNonQuery();
                        }
                        Conn.cn.Close();
                        MessageBox.Show("Importation effectée avec succès !!!", "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportFileFour_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DATA";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvImportFourn.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvImportFourn.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvImportFourn.Rows.Count; i++)
            {
                for (int j = 0; j < dgvImportFourn.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvImportFourn.Rows[i].Cells[j].Value?.ToString();
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
