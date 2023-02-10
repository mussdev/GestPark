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
using System.Globalization;

namespace GestPark
{
    public partial class FormMainCleanCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        FormImportCleanCar imptCleanCar = new FormImportCleanCar();
        private String DatePaieCarWatch;
        private Guid GuidWatchCar;
        public FormMainCleanCar()
        {
            InitializeComponent();
            ListeVehicule();
        }

        private void IbtnCloseFormCleanCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnCreateCleanCar_Click(object sender, EventArgs e)
        {
            FormCreateWatchCar FanWatch = new FormCreateWatchCar();
            FanWatch.ShowDialog();
        }

        private void IbtnSearchWatchCar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && string.IsNullOrEmpty(cbxLavagPeriod.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false)
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (!string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && string.IsNullOrEmpty(cbxLavagPeriod.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false)
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE LEFT OUTER JOIN LAVAGELINE ON LAVAGE.ID_WATCH=LAVAGELINE.ID_WATCH LEFT OUTER JOIN VEHICULE ON LAVAGELINE.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE VEHICULE.IMMATRICULATION_VEHICULE = '" + cbxCarLava.Text+ "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(cbxCarLava.Text) && !string.IsNullOrEmpty(TbxSearchCleanCar.Text) && string.IsNullOrEmpty(cbxLavagPeriod.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false)
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE LEFT OUTER JOIN LAVAGELINE ON LAVAGE.ID_WATCH=LAVAGELINE.ID_WATCH LEFT OUTER JOIN VEHICULE ON LAVAGELINE.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE VEHICULE.IMMATRICULATION_VEHICULE = '" + TbxSearchCleanCar.Text + "' OR CODE_WTCH = '"+ TbxSearchCleanCar.Text+ "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false && cbxLavagPeriod.Text.Equals("Aujourd'hui"))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE WHERE DATE_WATCH = '" + DateTime.Now.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false && cbxLavagPeriod.Text.Equals("Mois en cours"))
                        {
                            var now = DateTime.Now;
                            var startOfMonth = new DateTime(now.Year, now.Month, 1);
                            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);

                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE WHERE DATE_WATCH BETWEEN '" + startOfMonth.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false && cbxLavagPeriod.Text.Equals("Mois précédent"))
                        {
                            var now = DateTime.Now;
                            var startOfMonth = new DateTime(now.Year, now.Month, 1);
                            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
                            var startOfMonthPrevious = startOfMonth.AddMonths(-1);
                            var DaysInMonthPrevious = DateTime.DaysInMonth(now.Year, startOfMonthPrevious.Month);
                            var lastOfMonthPrevious = new DateTime(now.Year, startOfMonthPrevious.Month, DaysInMonthPrevious);

                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE WHERE DATE_WATCH BETWEEN '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' AND '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false && cbxLavagPeriod.Text.Equals("Année en cours"))
                        {
                            int year = DateTime.Now.Year;
                            DateTime firstDay = new DateTime(year, 1, 1);
                            DateTime lastDay = new DateTime(year, 12, 31);

                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE LEFT JOIN VEHICULE ON LAVAGE.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE DATEREGISTER BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && dateLavagFrom.Enabled == false && dateLavagTo.Enabled == false && cbxLavagPeriod.Text.Equals("Année précédente"))
                        {
                            DateTime lastYearToDate = DateTime.Now.AddYears(-1);
                            int year = lastYearToDate.Year;
                            DateTime firstDay = new DateTime(year, 1, 1);
                            DateTime lastDay = new DateTime(year, 12, 31);

                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE LEFT JOIN VEHICULE ON LAVAGE.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE DATEREGISTER BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else if (string.IsNullOrEmpty(cbxCarLava.Text) && string.IsNullOrEmpty(TbxSearchCleanCar.Text) && dateLavagFrom.Enabled == true && dateLavagTo.Enabled == true && cbxLavagPeriod.Text.Equals("Personnalisée"))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM LAVAGE LEFT JOIN VEHICULE ON LAVAGE.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE DATEREGISTER BETWEEN '" + dateLavagFrom.Value.ToString("dd/MM/yyyy") + "' AND '" + dateLavagTo.Value.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            SumAndNbrCleanCar();

                            // Fill DataGridView
                            Dgv_WatchCar.AutoGenerateColumns = false;
                            Dgv_WatchCar.DataSource = Tb.Tables[0];
                        }
                        else
                        {
                            Dgv_WatchCar.DataSource = null;
                            SumAndNbrCleanCar();
                        }
                            

                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnCreateCleanCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateLavg = new ToolTip();
            ToolTipBtnCreateLavg.AutoPopDelay = 5000;
            ToolTipBtnCreateLavg.InitialDelay = 1000;
            ToolTipBtnCreateLavg.ReshowDelay = 500;
            ToolTipBtnCreateLavg.ShowAlways = true;
            ToolTipBtnCreateLavg.SetToolTip(this.IbtnCreateCleanCar, "Ajouter");
        }

        private void BtnImportLavg_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImportLavg = new ToolTip();
            ToolTipBtnImportLavg.AutoPopDelay = 5000;
            ToolTipBtnImportLavg.InitialDelay = 1000;
            ToolTipBtnImportLavg.ReshowDelay = 500;
            ToolTipBtnImportLavg.ShowAlways = true;
            ToolTipBtnImportLavg.SetToolTip(this.BtnImportLavg, "Importer");
        }

        private void IcBtnExportCleanCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExpLavg = new ToolTip();
            ToolTipBtnExpLavg.AutoPopDelay = 5000;
            ToolTipBtnExpLavg.InitialDelay = 1000;
            ToolTipBtnExpLavg.ReshowDelay = 500;
            ToolTipBtnExpLavg.ShowAlways = true;
            ToolTipBtnExpLavg.SetToolTip(this.IcBtnExportCleanCar, "Exporter");
        }

        private void DisplayCarClean()
        {
            FormModifyWatchCar ModiWatchCar = new FormModifyWatchCar();

            ModiWatchCar.TbxCodeWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells["CODE_WATCH"].Value?.ToString();
            ModiWatchCar.TxtBLieuWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells["LIEU_WATCH"].Value?.ToString();
            ModiWatchCar.DatePikerWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells["DATE_WATCH"].Value?.ToString();
            ModiWatchCar.txtNetAPayerCarWatchMod.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", this.Dgv_WatchCar.CurrentRow.Cells["MONTANT_WATCH"].Value);
            GuidWatchCar = Guid.Parse(this.Dgv_WatchCar.CurrentRow.Cells["ID_WATCH"].Value?.ToString());

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM LAVAGELINE INNER JOIN LAVAGE ON LAVAGELINE.ID_WATCH=LAVAGE.ID_WATCH INNER JOIN VEHICULE AS V ON V.ID_VEHICULE=LAVAGELINE.ID_VEHICULE INNER JOIN MARQUE AS M ON M.ID_MARQ=V.ID_MARQ WHERE CODE_WATCH = '" + ModiWatchCar.TbxCodeWatchCarModi.Text + "'", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet Tb = new DataSet();
                        SqlAda.Fill(Tb);
                        // Fill DataGridView
                        ModiWatchCar.dgvCarLineWatchMod.AutoGenerateColumns = false;
                        ModiWatchCar.dgvCarLineWatchMod.DataSource = Tb.Tables[0];

                        // Affiche les paiements
                        SqlCmd = new SqlCommand("SELECT * FROM LAVAGE AS L INNER JOIN PAIEMENT AS P ON L.ID_WATCH=P.ID_WATCH INNER JOIN CARDPAIEMENT AS CARDP ON CARDP.ID_CARD=P.ID_CARD WHERE L.CODE_WATCH='" + ModiWatchCar.TbxCodeWatchCarModi.Text + "'", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet Tab = new DataSet();
                        SqlAda.Fill(Tab);
                        // Fill DataGridView
                        ModiWatchCar.dgvPaieWatchCarMod.AutoGenerateColumns = false;
                        ModiWatchCar.dgvPaieWatchCarMod.DataSource = Tab.Tables[0];

                        // Récuperer la date de paiement
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            Cmd.CommandText = "SELECT DATE_PAIE FROM PAIEMENT AS PAIE INNER JOIN LAVAGE AS LAV ON PAIE.ID_WATCH=LAV.ID_WATCH WHERE LAV.ID_WATCH='" + GuidWatchCar + "'";
                            MyReader = Cmd.ExecuteReader();

                            while (MyReader.Read())
                            {
                                DatePaieCarWatch = MyReader["DATE_PAIE"].ToString();
                            }
                        }

                        ModiWatchCar.datePaieWatchMod.Text = DatePaieCarWatch;


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ModiWatchCar.totalAmountCleanCar();
            ModiWatchCar.Show();

        }

        private void SumAndNbrCleanCar()
        {
            int Mont = 0;
            for (int i = 0; i < Dgv_WatchCar.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(Dgv_WatchCar.Rows[i].Cells["MONTANT_WATCH"].Value);
            }

            TotalAmountCleanCar.Text = $"Coût total = {Mont.ToString("### ### ### ###")} ";
            NbrCleaning.Text = $"Nbr de véhicule lavé = {Dgv_WatchCar.RowCount - 1 }";
        }

        private void IcBtnExportCleanCar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < Dgv_WatchCar.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Dgv_WatchCar.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < Dgv_WatchCar.Rows.Count; i++)
            {
                for (int j = 0; j < Dgv_WatchCar.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Dgv_WatchCar.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeLavage";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        // List vehicule
        private void ListeVehicule()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarLava.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarLava.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarLava.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxLavagPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLavagPeriod.Text.Equals("Personnalisée"))
            {
                dateLavagFrom.Enabled = true;
                dateLavagTo.Enabled = true;
            }
            else
            {
                dateLavagFrom.Enabled=false;
                dateLavagTo.Enabled=false;
            }
        }

        private void BtnImportLavg_Click(object sender, EventArgs e)
        {
            imptCleanCar.ShowDialog();
        }

        private void txtFilterCleanAuto_TextChanged(object sender, EventArgs e)
        {
            (Dgv_WatchCar.DataSource as DataTable).DefaultView.RowFilter = "IMMATRICULATION_VEHICULE LIKE '%" + txtFilterCleanAuto.Text + "%' ";
        }

        private void Dgv_WatchCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayCarClean();
        }
    }
}
