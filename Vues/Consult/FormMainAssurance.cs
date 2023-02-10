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

namespace GestPark
{
    public partial class FormMainAssurance : Form
    {
        private SqlCommand SqlCmd;
        private DataSet Ds;
        private SqlDataAdapter SqlAda;
        public FormMainAssurance()
        {
            InitializeComponent();
        }

        private void iconBtnCloseFormAssur_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateAssur_Click(object sender, EventArgs e)
        {
            Form CreateAssurance = new FormCreateAssurance();
            CreateAssurance.ShowDialog();
        }

        private void iconBtnCreateAssur_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.iconBtnCreateAssur, "Ajouter une assurance");
        }

        private void iconBtnExportReportCarAss_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExportCar = new ToolTip();
            ToolTipBtnExportCar.AutoPopDelay = 5000;
            ToolTipBtnExportCar.InitialDelay = 1000;
            ToolTipBtnExportCar.ReshowDelay = 500;
            ToolTipBtnExportCar.ShowAlways = true;
            ToolTipBtnExportCar.SetToolTip(this.iconBtnExportReportCarAss, "Exporter");
        }

        private void iconBtnSearchFormAssur_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM ASSURANCE LEFT OUTER JOIN VEHICULE ON VEHICULE.ID_VEHICULE=ASSURANCE.ID_VEHICULE", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        DgvAssur.AutoGenerateColumns = false;
                        DgvAssur.DataSource = Ds.Tables[0];

                        // Calculer la somme de prise d'assurance
                        SumPriceAssurCar();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculer la somme des assurances prises par les véhicules
        private void SumPriceAssurCar()
        {
            int Mont = 0;
            for (int i = 0; i < DgvAssur.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(DgvAssur.Rows[i].Cells[2].Value);
            }

            lbltotalAmoutAssur.Text = $"Total montant = {Mont.ToString("### ### ### ###")} ";
            // Calculer le nombre total de véhicule
            lblNbrAssur.Text = $"Nbr. Assurance = {DgvAssur.RowCount - 1}";
        }

        private void DgvAssur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyAssurance modifyAssurance = new FormModifyAssurance();
            modifyAssurance.txtCodeAssurMod.Text = DgvAssur.CurrentRow.Cells[0].Value.ToString();
            modifyAssurance.cbxCarAssurMod.Text = DgvAssur.CurrentRow.Cells[1].Value.ToString();
            modifyAssurance.txtAmountAssurMod.Text = DgvAssur.CurrentRow.Cells[2].Value.ToString();
            modifyAssurance.txtAssureurMod.Text = DgvAssur.CurrentRow.Cells[3].Value.ToString();
            modifyAssurance.cbxTypeAssurMod.Text = DgvAssur.CurrentRow.Cells[4].Value.ToString();
            modifyAssurance.cbxStatutAssurMod.Text = DgvAssur.CurrentRow.Cells[5].Value.ToString();
            modifyAssurance.txtNoteAssurMod.Text = DgvAssur.CurrentRow.Cells[6].Value.ToString();
            modifyAssurance.dateRegisterAssurMod.Text = DgvAssur.CurrentRow.Cells[7].Value.ToString();
            modifyAssurance.ShowDialog();
        }

        private void iconBtnExportReportCarAss_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DgvAssur.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvAssur.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DgvAssur.Rows.Count; i++)
            {
                for (int j = 0; j < DgvAssur.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvAssur.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeAssuranceVehicule";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
