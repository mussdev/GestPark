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
    public partial class FormMainPerson : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
        public FormMainPerson()
        {
            InitializeComponent();
        }

        private void iconBtnCreatePers_Click(object sender, EventArgs e)
        {
            Form FormCreatePers = new FormCreatePersonne();
            FormCreatePers.ShowDialog();
        }

        private void iconBtnCloseFormPers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnSearchPers_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        sqlCmd = new SqlCommand("SELECT * FROM PERSONNELS AS PERS INNER JOIN SERVICESENT AS SERV ON PERS.ID_SERV=SERV.ID_SERV INNER JOIN DIRECTION AS DIREC ON SERV.ID_DIR=DIREC.ID_DIR", Conn.cn);
                        //sqlCmd.Parameters.Add("@NOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        //sqlCmd.Parameters.Add("@PRENOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        DataTable dtbl = new DataTable();
                        sqlAda.Fill(dtbl);

                        // Fill DataGridView
                        DgvPerson.AutoGenerateColumns = false;
                        DgvPerson.DataSource = dtbl;

                    }
                }
                TxtTotalPers.Text = $"Total = {DgvPerson.RowCount - 1 }";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayPers()
        {
            FormModifierPerson ModifierPers = new FormModifierPerson();
            ModifierPers.TxtCodePersMod.Text = this.DgvPerson.CurrentRow.Cells[0].Value?.ToString();
            ModifierPers.TxtNomPersMod.Text = this.DgvPerson.CurrentRow.Cells[1].Value?.ToString();
            ModifierPers.TxtPrenPersMod.Text = this.DgvPerson.CurrentRow.Cells[2].Value?.ToString();
            ModifierPers.DpDateNaissPersMod.Text = this.DgvPerson.CurrentRow.Cells[3].Value?.ToString();
            ModifierPers.CbxLieuNaissPersMod.Text = this.DgvPerson.CurrentRow.Cells[4].Value?.ToString();
            ModifierPers.TxtTelPersMod.Text = this.DgvPerson.CurrentRow.Cells[5].Value?.ToString();
            ModifierPers.TxtNumPermisPersMod.Text = this.DgvPerson.CurrentRow.Cells[6].Value?.ToString();
            ModifierPers.CbxTypPiecPersMod.Text = this.DgvPerson.CurrentRow.Cells[7].Value?.ToString();
            ModifierPers.TxtNumPieceIdentPersMod.Text = this.DgvPerson.CurrentRow.Cells[8].Value?.ToString();
            ModifierPers.txtFonctionPersMod.Text = this.DgvPerson.CurrentRow.Cells[9].Value?.ToString();
            ModifierPers.CbxCountryPersMod.Text = this.DgvPerson.CurrentRow.Cells[10].Value?.ToString();
            ModifierPers.CbxTownPersMod.Text = this.DgvPerson.CurrentRow.Cells[11].Value?.ToString();
            ModifierPers.TxtAdressPersMod.Text = this.DgvPerson.CurrentRow.Cells[12].Value?.ToString();
            ModifierPers.TxtCodePostalPersMod.Text = this.DgvPerson.CurrentRow.Cells[13].Value?.ToString();
            ModifierPers.CbxSerPersMod.Text = this.DgvPerson.CurrentRow.Cells[14].Value?.ToString();
            ModifierPers.TxtDirPersMod.Text = this.DgvPerson.CurrentRow.Cells[15].Value?.ToString();
            ModifierPers.DtKDateCreateMod.Text = this.DgvPerson.CurrentRow.Cells[16].Value?.ToString();
            ModifierPers.RtxtNotePersMod.Text = this.DgvPerson.CurrentRow.Cells[17].Value?.ToString();
            ModifierPers.TxtCategPersMod.Text = this.DgvPerson.CurrentRow.Cells[18].Value?.ToString();

            ModifierPers.ShowDialog();
        }

        private void iconBtnCreatePers_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.iconBtnCreatePers, "Ajouter");
        }

        private void BtnExportPerson_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnExportPerson, "Exporter");
        }

        private void DgvPerson_DoubleClick(object sender, EventArgs e)
        {
            DisplayPers();
        }

        private void MenuContextOpenPers_Click(object sender, EventArgs e)
        {
            DisplayPers();
        }

        private void MenuContextEditerPers_Click(object sender, EventArgs e)
        {
            DisplayPers();
        }

        private int rowIndex = 0;
        private void DgvPerson_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DgvPerson.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DgvPerson.CurrentCell = this.DgvPerson.Rows[e.RowIndex].Cells[1];
                this.CntxtMenuPerson.Show(this.DgvPerson, e.Location);
                CntxtMenuPerson.Show(Cursor.Position);
            }
        }

        private void MenuContextCreatePers_Click(object sender, EventArgs e)
        {
            Form CreatePers = new FormCreatePersonne();
            CreatePers.ShowDialog();
        }

        private void BtnExportPerson_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DgvPerson.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvPerson.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DgvPerson.Rows.Count; i++)
            {
                for (int j = 0; j < DgvPerson.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvPerson.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListePersonnel";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void btnImportPerson_Click(object sender, EventArgs e)
        {
            Form ImportPers = new FormImportPerson();
            ImportPers.ShowDialog();
        }

        private void txtFilterPers_TextChanged(object sender, EventArgs e)
        {
            (DgvPerson.DataSource as DataTable).DefaultView.RowFilter = "PRENOM_PERS LIKE '%" + txtFilterPers.Text + "%' ";
        }
    }
}
