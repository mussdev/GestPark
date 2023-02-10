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
    public partial class FormMainRevision : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormMainRevision()
        {
            InitializeComponent();
            listVehicule();
            listGarage();
        }

        private void IbtnSearchVdge_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if( string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && string.IsNullOrEmpty(cbxPeriodeRevision.Text) && dateRevisionForm.Enabled==false && dateRevisionTo.Enabled==false)
                        {
                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE ORDER BY CODE_MAINT DESC", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && !string.IsNullOrEmpty(cbxCarRevision.Text) && string.IsNullOrEmpty(cbxPeriodeRevision.Text) && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false)
                        {
                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE IMMATRICULATION_VEHICULE = '"+cbxCarRevision.Text+"' ORDER BY CODE_MAINT DESC", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && !string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && string.IsNullOrEmpty(cbxPeriodeRevision.Text) && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false)
                        {
                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE DESCRIPTION_GARAGE = '" + cbxGarageRevision.Text + "' ORDER BY CODE_MAINT DESC", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (!string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && string.IsNullOrEmpty(cbxPeriodeRevision.Text) && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false)
                        {
                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE IMMATRICULATION_VEHICULE LIKE '" + TbxSearchRevision.Text + "' OR CARTE_GRISE_VEHICULE LIKE '" + TbxSearchRevision.Text+ "'  ORDER BY CODE_MAINT DESC", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text)  && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false && cbxPeriodeRevision.Text.Equals("Aujourd'hui") )
                        {
                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE DATE_MAINT = '"+DateTime.Now.ToString("dd/MM/yyyy")+"' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false && cbxPeriodeRevision.Text.Equals("Mois en cours"))
                        {
                            var now = DateTime.Now;
                            var startOfMonth = new DateTime(now.Year, now.Month, 1);
                            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);

                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE DATE_MAINT BETWEEN '" + startOfMonth.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false && cbxPeriodeRevision.Text.Equals("Mois precedent"))
                        {
                            var now = DateTime.Now;
                            var startOfMonth = new DateTime(now.Year, now.Month, 1);
                            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
                            var startOfMonthPrevious = startOfMonth.AddMonths(-1);
                            var DaysInMonthPrevious = DateTime.DaysInMonth(now.Year, startOfMonthPrevious.Month);
                            var lastOfMonthPrevious = new DateTime(now.Year, startOfMonthPrevious.Month, DaysInMonthPrevious);

                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE DATE_MAINT BETWEEN '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' AND '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false && cbxPeriodeRevision.Text.Equals("Année en cours"))
                        {
                            var now = DateTime.Now;
                            int year = DateTime.Now.Year;
                            DateTime firstDay = new DateTime(year, 1, 1);
                            DateTime lastDay = new DateTime(year, 12, 31);

                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE DATE_MAINT BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && dateRevisionForm.Enabled == false && dateRevisionTo.Enabled == false && cbxPeriodeRevision.Text.Equals("Année precedente"))
                        {
                            DateTime lastYearToDate = DateTime.Now.AddYears(-1);
                            int year = lastYearToDate.Year;
                            DateTime firstDay = new DateTime(year, 1, 1);
                            DateTime lastDay = new DateTime(year, 12, 31);

                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE DATE_MAINT BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(TbxSearchRevision.Text) && string.IsNullOrEmpty(cbxGarageRevision.Text) && string.IsNullOrEmpty(cbxCarRevision.Text) && dateRevisionForm.Enabled == true && dateRevisionTo.Enabled == true && cbxPeriodeRevision.Text.Equals("Personnalisée"))
                        {
                            SqlCmd = new SqlCommand("SELECT*FROM VIDANGE LEFT OUTER JOIN VEHICULE ON VIDANGE.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON VIDANGE.ID_GARAGE=GARAGE.ID_GARAGE WHERE DATE_MAINT BETWEEN '" + dateRevisionForm.Value.ToString("dd/MM/yyyy") + "' AND '" + dateRevisionTo.Value.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvVidange.AutoGenerateColumns = false;
                            DgvVidange.DataSource = Ds.Tables[0];
                        }
                        else
                            DgvVidange.DataSource= null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnCloseFormVdge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvVdge_DoubleClick(object sender, EventArgs e)
        {
            displayVidange();
        }

        // Afficher une prise de vidange
        public void displayVidange()
        {
            FormModifierEntretien modifierEntretien = new FormModifierEntretien();
            modifierEntretien.TxtCodeVdgeModi.Text = DgvVidange.CurrentRow.Cells[0].Value.ToString();
            modifierEntretien.txtVehiculeVdge.Text = DgvVidange.CurrentRow.Cells[1].Value.ToString();
            modifierEntretien.TxtMontantVdgeMod.Text = DgvVidange.CurrentRow.Cells[2].Value.ToString();
            modifierEntretien.CbxGarageVdgeModi.Text = DgvVidange.CurrentRow.Cells[3].Value.ToString();
            modifierEntretien.TxtStationVdgeMod.Text = DgvVidange.CurrentRow.Cells[4].Value.ToString();
            modifierEntretien.RtxtNotesVdgeModi.Text = DgvVidange.CurrentRow.Cells[5].Value.ToString();
            modifierEntretien.DatePickerCreateVdgeMod.Text = DgvVidange.CurrentRow.Cells[6].Value.ToString();
            modifierEntretien.ShowDialog();
        }

        private void btnAddVidange_Click(object sender, EventArgs e)
        {
            FormCreateEntretien revisionVidange = new FormCreateEntretien();
            revisionVidange.ShowDialog();
        }

        // Fill combobox vehicule
        private void listVehicule()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE WHERE TYPE_VEHICULE = 'Pool' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarRevision.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarRevision.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarRevision.ValueMember = (MyReader["ID_VEHICULE"].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion de erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // List garage 
        private void listGarage()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM GARAGE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarRevision.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            cbxCarRevision.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            cbxCarRevision.ValueMember = (MyReader["ID_GARAGE"].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion de erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnExportVdge_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DgvVidange.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvVidange.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DgvVidange.Rows.Count; i++)
            {
                for (int j = 0; j < DgvVidange.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvVidange.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListVidange";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void cbxPeriodeRevision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodeRevision.Text.Equals("Personnalisée"))
            {
                dateRevisionForm.Enabled = true;
                dateRevisionTo.Enabled = true;
            }
            else
            {
                dateRevisionForm.Enabled = false;
                dateRevisionTo.Enabled = false;
            }
        }
    }
}
