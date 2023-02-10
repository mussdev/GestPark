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

namespace GestPark.Vues.Imports
{
    public partial class FormImportPaiement : Form
    {
        private SqlDataReader MyReader;
        private Guid guidCardPaie, guidProv;
        public FormImportPaiement()
        {
            InitializeComponent();
        }

        private void btnExpImpPaieProv_Click(object sender, EventArgs e)
        {
            ExporterPaieProv();
        }

        private void ExporterPaieProv()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DATA";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvImpPaieProv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvImpPaieProv.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvImpPaieProv.Rows.Count; i++)
            {
                for (int j = 0; j < dgvImpPaieProv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvImpPaieProv.Rows[i].Cells[j].Value?.ToString();
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

        private void btnLoadImpPaieProv_Click(object sender, EventArgs e)
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
                        dgvImpPaieProv.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text);
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

        private void btnValImpPaieProv_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            for (int i = 0; i < dgvImpPaieProv.Rows.Count - 1; i++)
                            {
                                /* Recuperer l'id de l'approvisionnement ! */
                                Cmd.CommandText = "SELECT ID_PROV FROM PROVISION WHERE CODE_PROV=@CODE_PROV";
                                Cmd.Parameters.AddWithValue("@CODE_PROV", dgvImpPaieProv.Rows[i].Cells["CODE_PROV"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    guidProv = Guid.Parse(MyReader["ID_PROV"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();

                                /* Recuperer l'id de la carte de paiement de carburant ! */
                                Cmd.CommandText = "SELECT ID_CARD FROM CARDPAIEMENT WHERE NUM_CARD=@NUM_CARD";
                                Cmd.Parameters.AddWithValue("@NUM_CARD", dgvImpPaieProv.Rows[i].Cells["NUM_CARD"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    guidCardPaie = Guid.Parse(MyReader["ID_CARD"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();

                                /*.........Requête pour importer les données..........*/
                                Cmd.CommandText = "INSERT INTO PAIEMENT (ID_PROV,ID_CARD,TOTALPRIX_PAIE,DATE_PAIE) VALUES (@ID_PROV,@ID_CARD,@TOTALPRIX_PAIE,@DATE_PAIE)";
                                Cmd.Parameters.AddWithValue("@ID_PROV", guidProv);
                                Cmd.Parameters.AddWithValue("@ID_CARD", guidCardPaie);
                                Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", dgvImpPaieProv.Rows[i].Cells["TOTALPRIX_PAIE"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DATE_PAIE", dgvImpPaieProv.Rows[i].Cells["DATE_PAIE"].Value.ToString());
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
    }
}
