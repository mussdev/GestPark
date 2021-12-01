using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

namespace GestPark
{
    public partial class FormViewVehicule : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        public FormViewVehicule()
        {
            InitializeComponent();
        }

        private void iconBtnCloseViewForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnSearchVehi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB conn = new ConnectDB(connectionString);
                if (conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS ", conn.cn);
                    SqlAda = new SqlDataAdapter(SqlCmd);
                    DataSet tb = new DataSet();
                    SqlAda.Fill(tb);

                    // Fill DataGridView
                    DataGridViewVehi.AutoGenerateColumns = false;
                    DataGridViewVehi.DataSource = tb.Tables[0];
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconBtnExportVehi_Click(object sender, EventArgs e)
        {
           
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for(int i = 1; i < DataGridViewVehi.Columns.Count+1; i++)
            {
                worksheet.Cells[1, i] = DataGridViewVehi.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for(int i = 0; i < DataGridViewVehi.Rows.Count; i++)
            {
                for(int j = 0; j < DataGridViewVehi.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridViewVehi.Rows[i].Cells[j].Value?.ToString();
                }
            }              
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Nom du fichier";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog()==DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void DataGridViewVehi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyVehicule FormDisplayAndModifyCar = new FormModifyVehicule();
            FormDisplayAndModifyCar.textBoxModifyCarCodVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[0].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarEtatVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[1].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarImmatVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[2].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarCartGriVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[3].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarModelVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[4].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarPrixVentVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[5].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarTypVeh.Text = this.DataGridViewVehi.CurrentRow.Cells[6].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarTypVitessVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[7].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarEmplVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[8].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarTypConsoVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[9].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarMarqVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[10].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarProprio.Text = this.DataGridViewVehi.CurrentRow.Cells[11].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarFourn.Text = this.DataGridViewVehi.CurrentRow.Cells[12].Value?.ToString();
            FormDisplayAndModifyCar.richTextBoxModifyCarNoteVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[13].Value?.ToString();
            FormDisplayAndModifyCar.CbxStatutModifyCar.Text = this.DataGridViewVehi.CurrentRow.Cells[14].Value?.ToString();
            FormDisplayAndModifyCar.CbxSanteCar.Text = this.DataGridViewVehi.CurrentRow.Cells[15].Value?.ToString();
            FormDisplayAndModifyCar.TxtKolimetrageCar.Text = this.DataGridViewVehi.CurrentRow.Cells[16].Value?.ToString();
            FormDisplayAndModifyCar.TxtKilometrageParCar.Text = this.DataGridViewVehi.CurrentRow.Cells[17].Value?.ToString();
            FormDisplayAndModifyCar.dateTimePickModifyCarDatAchaVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[18].Value?.ToString();
            FormDisplayAndModifyCar.dateTimeModifyCarPickDatVisitVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[19].Value?.ToString();
            FormDisplayAndModifyCar.DateTimePickerModifyCarAssurance.Text = this.DataGridViewVehi.CurrentRow.Cells[20].Value?.ToString();
            FormDisplayAndModifyCar.ShowDialog();

        }


        // Method to display the kilometer of car

        //private string ViewCarKilometer()
        //{
        //    string KiloCar = null;
        //    try
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //        ConnectDB Conn = new ConnectDB(connectionString);
        //        FormModifyVehicule FormDisplayAndModifyCar = new FormModifyVehicule();
        //        using (Conn.cn)
        //        {
        //            if (Conn.IsConnection)
        //            {
        //                // Calculate total kilometers of car
        //                SqlCmd = new SqlCommand("SELECT SUM((KILO_APRES_MVTS + KILOMETRE_AVA_MVTS)) AS KILOTOTAL FROM MOUVEMENTS LEFT OUTER JOIN VEHICULE ON MOUVEMENTS.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE VEHICULE.CODE_VEHICULE = '" + this.DataGridViewVehi.CurrentRow.Cells[0].Value?.ToString() + "'", Conn.cn);
        //                MyReader = SqlCmd.ExecuteReader();
        //                while (MyReader.Read())
        //                {
        //                    KiloCar = MyReader[0].ToString();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return KiloCar;
        //}

        private void BtnCreateCar_Click(object sender, EventArgs e)
        {
            FormRegisterVehicule CreateCar = new FormRegisterVehicule();
            CreateCar.ShowDialog();
        }
    }
}
