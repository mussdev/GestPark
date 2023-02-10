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

namespace GestPark.Vues.Imports
{
    public partial class FormImportRepairCar : Form
    {
        private SqlDataReader MyReader;
        private Guid guidRepairCar, guidGarage;
        public FormImportRepairCar()
        {
            InitializeComponent();
        }

        private void btnExpImpRepaiCar_Click(object sender, EventArgs e)
        {
            ExporterRepairCar();
        }

        private void ExporterRepairCar()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "reparation";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvImpCleanCar.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvImpCleanCar.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvImpCleanCar.Rows.Count; i++)
            {
                for (int j = 0; j < dgvImpCleanCar.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvImpCleanCar.Rows[i].Cells[j].Value?.ToString();
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

        private void btnLoadRepaiCar_Click(object sender, EventArgs e)
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
                        dgvImpCleanCar.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvImpCleanCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnValImpRepaiCar_Click(object sender, EventArgs e)
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
                            for (int i = 0; i < dgvImpCleanCar.Rows.Count; i++)
                            {
                                /* Recuperer l'id du véhicule réparé */
                                Cmd.CommandText = "SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE=@IMMATRICULATION_VEHICULE";
                                Cmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", dgvImpCleanCar.Rows[i].Cells["IMMATRICULATION_VEHICULE"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    guidRepairCar = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();

                                /* Recuperer l'id du garage où le véhicule a subi une réparation ! */
                                Cmd.CommandText = "SELECT ID_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE=@DESCRIPTION_GARAGE";
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_GARAGE", dgvImpCleanCar.Rows[i].Cells["DESCRIPTION_GARAGE"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    guidGarage = Guid.Parse(MyReader["ID_GARAGE"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();

                                /*.........Requête pour importer les données..........*/
                                Cmd.CommandText = "INSERT INTO LAVAGE (ID_VEHICULE,ID_GARAGE,CODE_REPAR,PRIX_REPAR,DATE_REPAR,CAUSE_REPAR) VALUES (@ID_VEHICULE,@ID_GARAGE,@CODE_REPAR,@PRIX_REPAR,@DATE_REPAR,@CAUSE_REPAR)";
                                Cmd.Parameters.AddWithValue("@ID_VEHICULE", guidRepairCar);
                                Cmd.Parameters.AddWithValue("@ID_GARAGE", guidGarage);
                                Cmd.Parameters.AddWithValue("@CODE_REPAR", dgvImpCleanCar.Rows[i].Cells["CODE_REPAR"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@PRIX_REPAR", dgvImpCleanCar.Rows[i].Cells["PRIX_REPAR"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DATE_REPAR", dgvImpCleanCar.Rows[i].Cells["DATE_REPAR"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@CAUSE_REPAR", dgvImpCleanCar.Rows[i].Cells["CAUSE_REPAR"].Value.ToString());
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
