using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Data.SqlClient;

namespace GestPark
{
    public partial class FormImportPerson : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdServ;
        public FormImportPerson()
        {
            InitializeComponent();
            //loadListPerson();
        }

        private void btnLoadFileExcelPers_Click(object sender, EventArgs e)
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

            if(strFileName != " ")
            {
                xlApplication = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApplication.Workbooks.Open(strFileName);
                xlWorkSheet = xlWorkBook.Worksheets["DATA"];
                xlRange = xlWorkSheet.UsedRange;

                int i = 0;

                for(xlRow = 2; xlRow < xlRange.Rows.Count; xlRow++)
                {
                    if(xlRange.Cells[xlRow,1].Text != "")
                    {
                        i++;
                        dgvImportPerson.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text);
                    }
                }
                xlWorkBook.Close();
                xlApplication.Quit();

            }
         
        }

        private void btnImportFilePers_Click(object sender, EventArgs e)
        {
            dgvImportPerson.Rows.Clear();
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DATA";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvImportPerson.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvImportPerson.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvImportPerson.Rows.Count; i++)
            {
                for (int j = 0; j < dgvImportPerson.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvImportPerson.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListPersonnel";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        // Charger les données du personnel déjà saisies dans la base
        private void loadListPerson()
        {
            dgvImportPerson.Rows.Clear();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                // Request
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlAda = new SqlDataAdapter("SELECT * FROM PERSONNELS", Conn.cn);
                        System.Data.DataTable Dtbl = new System.Data.DataTable();
                        SqlAda.Fill(Dtbl);

                        // Fill DataGridView dgvMarq
                        dgvImportPerson.AutoGenerateColumns = false;
                        dgvImportPerson.DataSource = Dtbl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnValidImportPers_Click(object sender, EventArgs e)
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
                            for (int i = 0; i < dgvImportPerson.Rows.Count; i++)
                            {
                                //MessageBox.Show("Service: " + dgvImportPerson.Rows[i].Cells["DESCRIPTION_SERV"].Value.ToString());
                                /* Recuperer id des Services rattachés */
                                Cmd.CommandText = "SELECT ID_SERV FROM SERVICESENT WHERE DESCRIPTION_SERV=@paramServ";
                                Cmd.Parameters.AddWithValue("@paramServ", dgvImportPerson.Rows[i].Cells["DESCRIPTION_SERV"].Value.ToString());
                                MyReader = Cmd.ExecuteReader();

                                while (MyReader.Read())
                                {
                                    IdServ = Guid.Parse(MyReader["ID_SERV"].ToString());
                                }
                                MyReader.Close();
                                Cmd.Parameters.Clear();
                                //MessageBox.Show("Id Service: " + IdServ);
                                /*......... Inser les données dans le système ................*/
                                Cmd.CommandText = "INSERT INTO PERSONNELS (ID_SERV,CODE_PERS,NOM_PERS,PRENOM_PERS,DESCRIPTION_PERS,TEL_PERS,NUMPERMIS_PERS,TYPEPIECE_PERS,NUMPIECEIDENT_PERS,FONCTION_PERS) VALUES (@ID_SERV,@CODE_PERS,@NOM_PERS,@PRENOM_PERS,@DESCRIPTION_PERS,@TEL_PERS,@NUMPERMIS_PERS,@TYPEPIECE_PERS,@NUMPIECEIDENT_PERS,@FONCTION_PERS)";
                                Cmd.Parameters.AddWithValue("@ID_SERV", IdServ);
                                Cmd.Parameters.AddWithValue("@CODE_PERS", dgvImportPerson.Rows[i].Cells["CODE_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@NOM_PERS", dgvImportPerson.Rows[i].Cells["NOM_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@PRENOM_PERS", dgvImportPerson.Rows[i].Cells["PRENOM_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_PERS", dgvImportPerson.Rows[i].Cells["DESCRIPTION_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@TEL_PERS", dgvImportPerson.Rows[i].Cells["TEL_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@NUMPERMIS_PERS", dgvImportPerson.Rows[i].Cells["NUMPERMIS_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@TYPEPIECE_PERS", dgvImportPerson.Rows[i].Cells["TYPEPIECE_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@NUMPIECEIDENT_PERS", dgvImportPerson.Rows[i].Cells["NUMPIECEIDENT_PERS"].Value.ToString());
                                Cmd.Parameters.AddWithValue("@FONCTION_PERS", dgvImportPerson.Rows[i].Cells["FONCTION_PERS"].Value.ToString());
                                Cmd.ExecuteNonQuery();
                                //Conn.cn.Close();
                            }

                            Conn.cn.Close();
                            MessageBox.Show("Importation effectée avec succès !!!", "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"ParcAuto: Gestion des erreurs",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }
    }
}
