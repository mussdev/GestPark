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
    public partial class FormMainPrepareVisit : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormMainPrepareVisit()
        {
            InitializeComponent();
        }

        private void IbtnCreateVisitPrepa_Click(object sender, EventArgs e)
        {
            FormCreatePreparVisit CreatePrepaVisit = new FormCreatePreparVisit();
            CreatePrepaVisit.ShowDialog();
        }

        private void DataGridViewPrepaVisit_DoubleClick(object sender, EventArgs e)
        {
            FormModifierPreparVisit ModifPrepaVisit = new FormModifierPreparVisit();
            ModifPrepaVisit.TxtCodePrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[0].Value?.ToString();
           // ModifPrepaVisit.CbxStatutPrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[1].Value?.ToString();
            ModifPrepaVisit.TxtMontantPrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[2].Value?.ToString();
            if(this.DataGridViewPrepaVisit.CurrentRow.Cells[3].Value?.ToString() == "True")
            {
                ModifPrepaVisit.CheckParallelismePrepaVisitMod.Checked = true ;
            }else
                ModifPrepaVisit.CheckParallelismePrepaVisitMod.Checked = false;

            if (this.DataGridViewPrepaVisit.CurrentRow.Cells[4].Value?.ToString() == "True")
            {
                ModifPrepaVisit.CheckReglagePharePrepaVisitMod.Checked = true;
            }
            else
                ModifPrepaVisit.CheckReglagePharePrepaVisitMod.Checked = false;

            if (this.DataGridViewPrepaVisit.CurrentRow.Cells[5].Value?.ToString() == "True")
            {
                ModifPrepaVisit.CheckFreinagePrepaVisitMod.Checked = true;
            }
            else
                ModifPrepaVisit.CheckFreinagePrepaVisitMod.Checked = false;

            if (this.DataGridViewPrepaVisit.CurrentRow.Cells[6].Value?.ToString() == "True")
            {
                ModifPrepaVisit.CheckGazEchappPrepaVisitMod.Checked = true;
            }
            else
                ModifPrepaVisit.CheckGazEchappPrepaVisitMod.Checked = false;

            if (this.DataGridViewPrepaVisit.CurrentRow.Cells[7].Value?.ToString() == "True")
            {
                ModifPrepaVisit.ChekPneusPrepaVisitMod.Checked = true;
            }
            else
                ModifPrepaVisit.ChekPneusPrepaVisitMod.Checked = false;
            //MessageBox.Show("Valeur vérification pneu : " + this.DataGridViewPrepaVisit.CurrentRow.Cells[7].Value?.ToString());
            ModifPrepaVisit.CbxCarPrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[8].Value?.ToString();
            ModifPrepaVisit.CbxGaragePrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[10].Value?.ToString();
            ModifPrepaVisit.TxtMecanicienPrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[11].Value?.ToString();
            ModifPrepaVisit.RTxtNotePrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[12].Value?.ToString();
            ModifPrepaVisit.DatePikerRegisterPrepaVisitMod.Text = this.DataGridViewPrepaVisit.CurrentRow.Cells[13].Value?.ToString();
            ModifPrepaVisit.ShowDialog();
        }

        private void IbtnSearchVisitPrepa_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM ViewPrepareVisiteTechnique", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        DataGridViewPrepaVisit.AutoGenerateColumns = false;
                        DataGridViewPrepaVisit.DataSource = Ds.Tables[0];

                        // Calculer le nombre total de véhicule
                        LblTotalPrepaVisit.Text = $"Total = {DataGridViewPrepaVisit.RowCount - 1 }";
                        SumMontantPrepaVisit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumMontantPrepaVisit()
        {
            int Mont = 0;
            for(int i= 0; i < DataGridViewPrepaVisit.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(DataGridViewPrepaVisit.Rows[i].Cells[2].Value);
            }

            LblTotalMontant.Text = $"Total montant = {Mont.ToString("### ### ### ###")} ";
        }

        private void IbtnCloseFormPrepaVisit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImportPrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImportPrepaVisit = new ToolTip();
            ToolTipBtnImportPrepaVisit.AutoPopDelay = 5000;
            ToolTipBtnImportPrepaVisit.InitialDelay = 1000;
            ToolTipBtnImportPrepaVisit.ReshowDelay = 500;
            ToolTipBtnImportPrepaVisit.ShowAlways = true;
            ToolTipBtnImportPrepaVisit.SetToolTip(this.BtnImportPrepaVisit, "Importer");
        }

        private void IcBtnExportVisitPrepa_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExpPrepaVisit = new ToolTip();
            ToolTipBtnExpPrepaVisit.AutoPopDelay = 5000;
            ToolTipBtnExpPrepaVisit.InitialDelay = 1000;
            ToolTipBtnExpPrepaVisit.ReshowDelay = 500;
            ToolTipBtnExpPrepaVisit.ShowAlways = true;
            ToolTipBtnExpPrepaVisit.SetToolTip(this.IcBtnExportVisitPrepa, "Exporter");
        }

        private void IbtnCreateVisitPrepa_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateVisitPrepa = new ToolTip();
            ToolTipBtnCreateVisitPrepa.AutoPopDelay = 5000;
            ToolTipBtnCreateVisitPrepa.InitialDelay = 1000;
            ToolTipBtnCreateVisitPrepa.ReshowDelay = 500;
            ToolTipBtnCreateVisitPrepa.ShowAlways = true;
            ToolTipBtnCreateVisitPrepa.SetToolTip(this.IbtnCreateVisitPrepa, "Ajouter une préparation de visite");
        }

        private void IcBtnExportVisitPrepa_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DataGridViewPrepaVisit.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridViewPrepaVisit.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DataGridViewPrepaVisit.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewPrepaVisit.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridViewPrepaVisit.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeVehicule";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
