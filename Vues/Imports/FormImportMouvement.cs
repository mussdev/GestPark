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
    public partial class FormImportMouvement : Form
    {
        private Guid IdVehiMvtImp, IdConduc,IdStatutMvt,IdPersMvt;
        private SqlDataReader MyReader;
        public FormImportMouvement()
        {
            InitializeComponent();
        }

        private void btnExpImpMvt_Click(object sender, EventArgs e)
        {
            ExporterMvtCar();
        }

        private void ExporterMvtCar()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "mouvement";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvImpMvt.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvImpMvt.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvImpMvt.Rows.Count; i++)
            {
                for (int j = 0; j < dgvImpMvt.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvImpMvt.Rows[i].Cells[j].Value?.ToString();
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

        private void btnLoadImpMvt_Click(object sender, EventArgs e)
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
                        dgvImpMvt.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text);
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

        private void btnValImpMvt_Click(object sender, EventArgs e)
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
                            for (int i = 0; i < dgvImpMvt.Rows.Count; i++)
                            {
                                /* Recuperer l'id véhicule */
                                Cmd.CommandText = "SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE=@IMMATRICULATION_VEHICULE";
                                Cmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", dgvImpMvt.Rows[i].Cells["IMMATRICULATION_VEHICULE"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdVehiMvtImp = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();

                                /* Recuperer l'id conducteur */
                                Cmd.CommandText = "SELECT ID_COND FROM CONDUCTEUR WHERE DESCRIPTION_COND=@DESCRIPTION_COND";
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_COND", dgvImpMvt.Rows[i].Cells["DESCRIPTION_COND"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdConduc = Guid.Parse(MyReader["ID_COND"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();

                                /* Recuperer l'id du demandeur de véhicule */
                                Cmd.CommandText = "SELECT ID_PERS FROM PERSONNELS WHERE DESCRIPTION_PERS=@DESCRIPTION_PERS";
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_PERS", dgvImpMvt.Rows[i].Cells["DESCRIPTION_PERS"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdPersMvt = Guid.Parse(MyReader["ID_PERS"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();

                                //MessageBox.Show("Description directeur: " + dgvImportServ.Rows[i].Cells["DESCRIPTION_DIR"].Value.ToString().Trim() + " Id direction = " + IdDir);
                                /*.........Requête pour importer les données..........*/
                                Cmd.CommandText = "INSERT INTO MOUVEMENTS (ID_VEHICULE,ID_COND,ID_VALMVT,ID_PERS,DATE_PROV,LITRE_PROV,PRIX_LITRE_PROV) VALUES (@ID_VEHICULE,@CODE_PROV,@KILO_AVANT_VIDENGE,@MONTANT_PROV,@DATE_PROV,@LITRE_PROV,@PRIX_LITRE_PROV)";
                                Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiMvtImp);
                                Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdConduc);
                                Cmd.Parameters.AddWithValue("@ID_VALMVT", IdStatutMvt);
                                Cmd.Parameters.AddWithValue("@ID_PERS", IdPersMvt);
                                Cmd.Parameters.AddWithValue("@CODE_MVTS", dgvImpMvt.Rows[i].Cells["CODE_MVTS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@LIEU_MVTS", dgvImpMvt.Rows[i].Cells["LIEU_MVTS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DATEDEPARTSOUHAITE_MVTS", dgvImpMvt.Rows[i].Cells["DATEDEPARTSOUHAITE_MVTS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DATEEXECUTION", dgvImpMvt.Rows[i].Cells["DATEEXECUTION"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DATERETOURPROBABLE", dgvImpMvt.Rows[i].Cells["DATERETOURPROBABLE"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DATERETOURREEL", dgvImpMvt.Rows[i].Cells["DATERETOURREEL"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@TIMESTART_MVTS", dgvImpMvt.Rows[i].Cells["TIMESTART_MVTS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@TIMEEND_MVTS", dgvImpMvt.Rows[i].Cells["TIMEEND_MVTS"].Value.ToString());
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
