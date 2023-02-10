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
    public partial class FormMainFournisseur : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        public FormMainFournisseur()
        {
            InitializeComponent();
        }


        private void iconBtnCloseFormMainFour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateFourn_Click(object sender, EventArgs e)
        {
            Form FormCreateFourn = new FormCreateFourn();
            FormCreateFourn.ShowDialog();
        }

        private void iconBtnSearchFourn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using(Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM FOURNISSEUR WHERE DESCRIPTION_FOUR LIKE @DESCRIPTION_FOUR", Conn.cn);
                        SqlCmd.Parameters.Add("@DESCRIPTION_FOUR", string.Format("%{0}%", textBoxRecheFour.Text));
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill DataGridView
                        DgvProvider.AutoGenerateColumns = false;
                        DgvProvider.DataSource = dtbl;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayListFour()
        {
            FormModifierFourn EditFourn = new FormModifierFourn();
            EditFourn.TxtCodFournMod.Text = this.DgvProvider.CurrentRow.Cells[0].Value?.ToString();
            EditFourn.TxtDescripFournMod.Text = this.DgvProvider.CurrentRow.Cells[1].Value?.ToString();
            EditFourn.TxtTelFournMod.Text = this.DgvProvider.CurrentRow.Cells[2].Value?.ToString();
            EditFourn.TxtMailFournMod.Text = this.DgvProvider.CurrentRow.Cells[3].Value?.ToString();
            EditFourn.RtxtNoteFournMod.Text = this.DgvProvider.CurrentRow.Cells[4].Value?.ToString();
            EditFourn.TxtRCFournMod.Text = this.DgvProvider.CurrentRow.Cells[5].Value?.ToString();
            EditFourn.TxtCCFournMod.Text = this.DgvProvider.CurrentRow.Cells[6].Value?.ToString();
            EditFourn.CbxCountryMod.Text = this.DgvProvider.CurrentRow.Cells[7].Value?.ToString();
            EditFourn.CbxTownMod.Text = this.DgvProvider.CurrentRow.Cells[8].Value?.ToString();
            EditFourn.TxtAdressFournMod.Text = this.DgvProvider.CurrentRow.Cells[9].Value?.ToString();
            EditFourn.TxtCodPostalFournMod.Text = this.DgvProvider.CurrentRow.Cells[10].Value?.ToString();
            EditFourn.DtpRegisterFournMod.Text = this.DgvProvider.CurrentRow.Cells[11].Value?.ToString();
            EditFourn.TxtOtherFieldFournMod.Text = this.DgvProvider.CurrentRow.Cells[12].Value?.ToString();
            EditFourn.ShowDialog();
        }

        private void iconBtnCreateFourn_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateFour = new ToolTip();
            ToolTipBtnCreateFour.AutoPopDelay = 5000;
            ToolTipBtnCreateFour.InitialDelay = 1000;
            ToolTipBtnCreateFour.ReshowDelay = 500;
            ToolTipBtnCreateFour.ShowAlways = true;
            ToolTipBtnCreateFour.SetToolTip(this.iconBtnCreateFourn, "Ajouter un fournisseur");
        }

        private void BtnExportFourn_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExpFour = new ToolTip();
            ToolTipBtnExpFour.AutoPopDelay = 5000;
            ToolTipBtnExpFour.InitialDelay = 1000;
            ToolTipBtnExpFour.ReshowDelay = 500;
            ToolTipBtnExpFour.ShowAlways = true;
            ToolTipBtnExpFour.SetToolTip(this.BtnExportFourn, "Exporter");
        }

        private void BtnImportFourn_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImpFour = new ToolTip();
            ToolTipBtnImpFour.AutoPopDelay = 5000;
            ToolTipBtnImpFour.InitialDelay = 1000;
            ToolTipBtnImpFour.ReshowDelay = 500;
            ToolTipBtnImpFour.ShowAlways = true;
            ToolTipBtnImpFour.SetToolTip(this.BtnImportFourn, "Importer");
        }

        private void DgvProvider_DoubleClick(object sender, EventArgs e)
        {
            DisplayListFour();
        }

        private void BtnExportFourn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DATA";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DgvProvider.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvProvider.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DgvProvider.Rows.Count; i++)
            {
                for (int j = 0; j < DgvProvider.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvProvider.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeFounisseurVehicule";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void BtnImportFourn_Click(object sender, EventArgs e)
        {
            Form ImportFour = new FormImportFournisseur();
            ImportFour.ShowDialog();
        }

        private int rowIndex = 0;
        private void DgvProvider_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DgvProvider.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DgvProvider.CurrentCell = this.DgvProvider.Rows[e.RowIndex].Cells[1];
                this.MenuDeleteFour.Show(this.DgvProvider, e.Location);
                MenuDeleteFour.Show(Cursor.Position);
            }
        }

        private void ItemMenuDeleteFour_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer ce fournisseur ?"), "ParcAuto: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyGarageDelete = DgvProvider.SelectedRows[0].Cells[0].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "delete from fournisseur where code_four = '" + KeyGarageDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("Le garage a été supprimé avec succès !", "ParcAuto: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
