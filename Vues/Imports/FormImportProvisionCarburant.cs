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
    public partial class FormImportProvisionCarburant : Form
    {
        private SqlDataReader MyReader;
        private Guid IdVehiProv;
        public FormImportProvisionCarburant()
        {
            InitializeComponent();
        }

        private void btnLoadImpProv_Click(object sender, EventArgs e)
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

                int i = 1;

                for (xlRow = 2; xlRow < xlRange.Rows.Count; xlRow++)
                {
                    //if (xlRange.Cells[xlRow, 1].Text != "")
                    //{
                       
                        dgvImpProv.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text);
                        i++;
                    //}
                }
                xlWorkBook.Close();
                xlApplication.Quit();
            }
            else
            {
                MessageBox.Show("Aucun fichier n'a été importé !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValImpProv_Click(object sender, EventArgs e)
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
                            for (int i = 0; i < dgvImpProv.Rows.Count; i++)
                            {
                                /* Recuperer l'id directeur */
                                Cmd.CommandText = "SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE=@IMMATRICULATION_VEHICULE";
                                Cmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", dgvImpProv.Rows[i].Cells["IMMATRICULATION_VEHICULE"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdVehiProv = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                                    MessageBox.Show("Matricule véhicule : " + dgvImpProv.Rows[i].Cells["IMMATRICULATION_VEHICULE"].Value.ToString() + " Id véhicule : " + IdVehiProv);
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();
                                
                                /*.........Requête pour importer les données..........*/
                                Cmd.CommandText = "INSERT INTO PROVISION (ID_VEHICULE,CODE_PROV,KILO_AVANT_VIDENGE,MONTANT_PROV,DATE_PROV,LITRE_PROV,PRIX_LITRE_PROV) VALUES (@ID_VEHICULE,@CODE_PROV,@KILO_AVANT_VIDENGE,@MONTANT_PROV,@DATE_PROV,@LITRE_PROV,@PRIX_LITRE_PROV)";
                                Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiProv);
                                Cmd.Parameters.AddWithValue("@CODE_PROV", dgvImpProv.Rows[i].Cells["CODE_PROV"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@KILO_AVANT_VIDENGE", dgvImpProv.Rows[i].Cells["KILO_AVANT_VIDENGE"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@MONTANT_PROV", dgvImpProv.Rows[i].Cells["MONTANT_PROV"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DATE_PROV", dgvImpProv.Rows[i].Cells["DATE_PROV"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@LITRE_PROV", dgvImpProv.Rows[i].Cells["LITRE_PROV"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@PRIX_LITRE_PROV", dgvImpProv.Rows[i].Cells["PRIX_LITRE_PROV"].Value.ToString());
                                //Cmd.ExecuteNonQuery();

                                // Réinitialiser le datagridview
                                dgvImpProv.DataSource = null;
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

        private void btnExpImpProv_Click(object sender, EventArgs e)
        {
            ExporterProvCar();
        }

        private void ExporterProvCar()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "provision";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvImpProv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvImpProv.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvImpProv.Rows.Count; i++)
            {
                for (int j = 0; j < dgvImpProv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvImpProv.Rows[i].Cells[j].Value?.ToString();
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
