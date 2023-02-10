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
using GestPark.Vues.Imports;

namespace GestPark
{
    public partial class FormMainPaiement : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        private DataSet Ds;
        FormImportPaiement importPaie = new FormImportPaiement();
        public FormMainPaiement()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormPaie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnSearchPaie_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("select * from paiement inner join cardpaiement on cardpaiement.ID_CARD=paiement.ID_CARD inner join provision on provision.ID_PROV=paiement.ID_PROV inner join vehicule on vehicule.ID_VEHICULE=provision.ID_VEHICULE inner join typeconsommation on typeconsommation.ID_TYPCONSO=vehicule.ID_TYPCONSO", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        DataGridViewPaie.AutoGenerateColumns = false;
                        DataGridViewPaie.DataSource = Ds.Tables[0];
                    }
                    SumAndNbrPaieEnergy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnExportPaie_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExptCar = new ToolTip();
            ToolTipBtnExptCar.AutoPopDelay = 5000;
            ToolTipBtnExptCar.InitialDelay = 1000;
            ToolTipBtnExptCar.ReshowDelay = 500;
            ToolTipBtnExptCar.ShowAlways = true;
            ToolTipBtnExptCar.SetToolTip(this.IbtnExportPaie, "Exporter");
        }

        private void DisplayPaie()
        {
            FormModifierPaiement ModifierPaie = new FormModifierPaiement();
            ModifierPaie.TxtLitreCarbuMod.Text = this.DataGridViewPaie.CurrentRow.Cells[0].Value?.ToString();
            ModifierPaie.TxtPrixUnitaireCarbuMod.Text = this.DataGridViewPaie.CurrentRow.Cells[1].Value?.ToString();
            ModifierPaie.TxtPrixTotalCarbuMod.Text = this.DataGridViewPaie.CurrentRow.Cells[2].Value?.ToString();
            ModifierPaie.CbxTypCartPaieMod.Text = this.DataGridViewPaie.CurrentRow.Cells[3].Value?.ToString();
            ModifierPaie.TxtNumPaieMod.Text = this.DataGridViewPaie.CurrentRow.Cells[4].Value?.ToString();
            ModifierPaie.TxtCodeApproMod.Text = this.DataGridViewPaie.CurrentRow.Cells[5].Value?.ToString();
            ModifierPaie.DateRegisterPaieMod.Text = this.DataGridViewPaie.CurrentRow.Cells[7].Value?.ToString();

            ModifierPaie.ShowDialog();
        }

        private void SumAndNbrPaieEnergy()
        {
            int Mont = 0;
            for (int i = 0; i < DataGridViewPaie.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(DataGridViewPaie.Rows[i].Cells[2].Value);
            }

            TotalAmountPaie.Text = $"Total montant = {Mont.ToString("### ### ### ###")} ";
            LlbNbrPaie.Text = $"Nbr de paiement = {DataGridViewPaie.RowCount - 1 }";
        }

        private void IbtnExportPaie_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DataGridViewPaie.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridViewPaie.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DataGridViewPaie.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewPaie.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridViewPaie.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListePaiement";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void txtPaieProvFilter_TextChanged(object sender, EventArgs e)
        {
            (DataGridViewPaie.DataSource as DataTable).DefaultView.RowFilter = "NUM_CARD LIKE '%" + txtPaieProvFilter.Text + "%' ";
        }

        private void btnImpPaie_Click(object sender, EventArgs e)
        {
            
            importPaie.ShowDialog();
        }
    }
}
