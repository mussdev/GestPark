using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace GestPark
{
    public partial class FormViewVehicule : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
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
                    if (!string.IsNullOrEmpty(checkedListBoxTypVehi.ToString()) && !string.IsNullOrEmpty(textBxSearchVehi.Text))
                    {
                        sqlCmd = new SqlCommand("select * from VEHICULE " +
                            " left outer join PARKING on PARKING.ID_PARK = VEHICULE.ID_PARK" +
                            " left outer join TYPECONSOMMATION on TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO" +
                            " left outer join FOURNISSEUR on FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR" +
                            " left outer join MARQUE on MARQUE.ID_MARQ = VEHICULE.ID_MARQ" +
                            " left outer join APPARTENIR on APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE" +
                            " left outer join PERSONNELS on PERSONNELS.ID_PERS = APPARTENIR.ID_PERS" +
                            " where VEHICULE.TYPE_VEHICULE = @TYPE_VEHICULE AND VEHICULE.IMMATRICULATION_VEHICULE LIKE @IMMATRICULATION_VEHICULE OR VEHICULE.CARTE_GRISE_VEHICULE LIKE @CARTE_GRISE_VEHICULE ", conn.cn);
                        sqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", checkedListBoxTypVehi.ToString());
                        sqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", string.Format("%{0}%", textBxSearchVehi.Text));
                        sqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", string.Format("%{0}%", textBxSearchVehi.Text));
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        DataSet tb = new DataSet();
                        sqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];

                    }
                    else if (!string.IsNullOrEmpty(comboBoxEtatVehi.Text) && !string.IsNullOrEmpty(textBxSearchVehi.Text))
                    {
                        sqlCmd = new SqlCommand("select * from VEHICULE " +
                            " left outer join PARKING on PARKING.ID_PARK = VEHICULE.ID_PARK" +
                            " left outer join TYPECONSOMMATION on TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO" +
                            " left outer join FOURNISSEUR on FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR" +
                            " left outer join MARQUE on MARQUE.ID_MARQ = VEHICULE.ID_MARQ" +
                            " left outer join APPARTENIR on APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE" +
                            " left outer join PERSONNELS on PERSONNELS.ID_PERS = APPARTENIR.ID_PERS" +
                            " where VEHICULE.ETAT_VEHICULE = @ETAT_VEHICULE AND VEHICULE.IMMATRICULATION_VEHICULE = @IMMATRICULATION_VEHICULE OR VEHICULE.CARTE_GRISE_VEHICULE = @CARTE_GRISE_VEHICULE OR VEHICULE.CODE_VEHICULE = @CODE_VEHICULE ", conn.cn);
                        sqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxEtatVehi.Text);
                        sqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBxSearchVehi.Text);
                        sqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        sqlCmd.Parameters.AddWithValue("@CODE_VEHICULE", textBxSearchVehi.Text);
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        DataSet tb = new DataSet();
                        sqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                    }
                    else if (!string.IsNullOrEmpty(comboBoxEtatVehi.Text) || !string.IsNullOrEmpty(checkedListBoxTypVehi.ToString()))
                    {
                        sqlCmd = new SqlCommand("select * from VEHICULE " +
                            " left outer join PARKING on PARKING.ID_PARK = VEHICULE.ID_PARK" +
                            " left outer join TYPECONSOMMATION on TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO" +
                            " left outer join FOURNISSEUR on FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR" +
                            " left outer join MARQUE on MARQUE.ID_MARQ = VEHICULE.ID_MARQ" +
                            " left outer join APPARTENIR on APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE" +
                            " left outer join PERSONNELS on PERSONNELS.ID_PERS = APPARTENIR.ID_PERS" +
                            " where VEHICULE.ETAT_VEHICULE = @ETAT_VEHICULE OR VEHICULE.TYPE_VEHICULE = @TYPE_VEHICULE ", conn.cn);
                        sqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxEtatVehi.Text);
                        sqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", checkedListBoxTypVehi.ToString());
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        DataSet tb = new DataSet();
                        sqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];

                    }
                    else if (!string.IsNullOrEmpty(textBxSearchVehi.Text))
                    {
                        sqlCmd = new SqlCommand("select * from VEHICULE " +
                            " left outer join PARKING on PARKING.ID_PARK = VEHICULE.ID_PARK" +
                            " left outer join TYPECONSOMMATION on TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO" +
                            " left outer join FOURNISSEUR on FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR" +
                            " left outer join MARQUE on MARQUE.ID_MARQ = VEHICULE.ID_MARQ" +
                            " left outer join APPARTENIR on APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE" +
                            " left outer join PERSONNELS on PERSONNELS.ID_PERS = APPARTENIR.ID_PERS" +
                            " where VEHICULE.IMMATRICULATION_VEHICULE LIKE @IMMATRICULATION_VEHICULE OR VEHICULE.CARTE_GRISE_VEHICULE LIKE @CARTE_GRISE_VEHICULE OR VEHICULE.CODE_VEHICULE LIKE @CODE_VEHICULE ", conn.cn);
                        sqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", string.Format("%{0}%", textBxSearchVehi.Text));
                        sqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", string.Format("%{0}%", textBxSearchVehi.Text));
                        sqlCmd.Parameters.AddWithValue("@CODE_VEHICULE", string.Format("%{0}%", textBxSearchVehi.Text));
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        DataSet tb = new DataSet();
                        sqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                    }
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
            FormDisplayAndModifyCar.dateTimePickModifyCarDatAchaVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[14].Value?.ToString();
            FormDisplayAndModifyCar.dateTimeModifyCarPickDatVisitVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[15].Value?.ToString();
            FormDisplayAndModifyCar.DateTimePickerModifyCarAssurance.Text = this.DataGridViewVehi.CurrentRow.Cells[16].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarTypVitessVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[17].Value?.ToString();
            FormDisplayAndModifyCar.ShowDialog();
        }
    }
}
