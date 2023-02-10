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
using Microsoft.Reporting.WinForms;

namespace GestPark
{
    public partial class FormEtatVehicule : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        public FormEtatVehicule()
        {
            InitializeComponent();
        }

        private void FormEtatVehicule_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestParkDataSetListCar.View_Vehicule'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.view_VehiculeTableAdapter.Fill(this.gestParkDataSetListCar.View_Vehicule);

            //this.reportViewerListCar.RefreshReport();
        }

        private void btnSearchListCar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbxEtatCar.Text)  && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled==false && dateListCarTo.Enabled==false && string.IsNullOrEmpty(cbxPeriodeListCar.Text))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListAllCar());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }
            else if (string.IsNullOrEmpty(cbxEtatCar.Text) && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled == false && dateListCarTo.Enabled == false && !string.IsNullOrEmpty(cbxPeriodeListCar.Text) && cbxPeriodeListCar.Text.Equals("Aujourd'hui"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListCarToday());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }
            else if (string.IsNullOrEmpty(cbxEtatCar.Text) && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled == false && dateListCarTo.Enabled == false && !string.IsNullOrEmpty(cbxPeriodeListCar.Text) && cbxPeriodeListCar.Text.Equals("Mois en cours"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListCarPerMonthly());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }
            else if (string.IsNullOrEmpty(cbxEtatCar.Text) && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled == false && dateListCarTo.Enabled == false && !string.IsNullOrEmpty(cbxPeriodeListCar.Text) && cbxPeriodeListCar.Text.Equals("Mois précedent"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListCarPerMonthlyPrevious());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }
            else if (string.IsNullOrEmpty(cbxEtatCar.Text) && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled == false && dateListCarTo.Enabled == false && !string.IsNullOrEmpty(cbxPeriodeListCar.Text) && cbxPeriodeListCar.Text.Equals("Année en cours"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListCarToday());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }
            else if (string.IsNullOrEmpty(cbxEtatCar.Text) && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled == false && dateListCarTo.Enabled == false && !string.IsNullOrEmpty(cbxPeriodeListCar.Text) && cbxPeriodeListCar.Text.Equals("Année en cours"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListCarToYear());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }
            else if (string.IsNullOrEmpty(cbxEtatCar.Text) && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled == false && dateListCarTo.Enabled == false && !string.IsNullOrEmpty(cbxPeriodeListCar.Text) && cbxPeriodeListCar.Text.Equals("Année précédente"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListCarToYearPrevious());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }
            else if (string.IsNullOrEmpty(cbxEtatCar.Text) && string.IsNullOrEmpty(txtMultiCritereListCar.Text) && dateListCarFrom.Enabled == true && dateListCarTo.Enabled == true && !string.IsNullOrEmpty(cbxPeriodeListCar.Text) && cbxPeriodeListCar.Text.Equals("Personnalisé"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetListCar", ListCarPerPeriod());
                reportViewerListCar.LocalReport.DataSources.Clear();
                reportViewerListCar.Name = "ReportListCar.rdlc";
                reportViewerListCar.LocalReport.Refresh();
                reportViewerListCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerListCar.RefreshReport();
            }


        }

        private DataTable ListAllCar()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Vehicule", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private void cbxPeriodeListCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)cbxPeriodeListCar.Text == "Personnalisé")
            {
                dateListCarFrom.Enabled = true;
                dateListCarTo.Enabled = true;
            }
            else
            {
                dateListCarFrom.Enabled = false;
                dateListCarTo.Enabled = false;
            }
        }

        private DataTable ListCarPerPeriod()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Vehicule where DATE_ACHA_VEHICULE between '" + dateListCarFrom.Value.ToString("dd/MM/yyyy") + "' and '" + dateListCarTo.Value.ToString("dd/MM/yyyy") + "' order by DATE_ACHA_VEHICULE asc", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private DataTable ListCarPerMonthly()
        {
            DataTable dt = new DataTable();
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Vehicule where DATE_ACHA_VEHICULE between '" + startOfMonth.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATE_ACHA_VEHICULE asc ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private DataTable ListCarPerMonthlyPrevious()
        {
            DataTable dt = new DataTable();
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
            var startOfMonthPrevious = startOfMonth.AddMonths(-1);
            var DaysInMonthPrevious = DateTime.DaysInMonth(now.Year, startOfMonthPrevious.Month);
            var lastOfMonthPrevious = new DateTime(now.Year, startOfMonthPrevious.Month, DaysInMonthPrevious);
            //MessageBox.Show("Premier jour du mois précédent : " + startOfMonthPrevious + " Dernier jour du mois précédent : " + lastOfMonthPrevious);
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Vehicule where DATE_ACHA_VEHICULE between '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' and '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' order by DATE_ACHA_VEHICULE asc ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private DataTable ListCarToday()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Vehicule where DATE_ACHA_VEHICULE='" + DateTime.Now.ToString("dd/MM/yyyy") + "'", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private DataTable ListCarToYear()
        {
            DataTable dt = new DataTable();
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Vehicule where DATE_ACHA_VEHICULE between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATE_ACHA_VEHICULE asc ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        private DataTable ListCarToYearPrevious()
        {
            DataTable dt = new DataTable();
            DateTime lastYearToDate = DateTime.Now.AddYears(-1);
            int year = lastYearToDate.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Vehicule where DATE_ACHA_VEHICULE between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATE_ACHA_VEHICULE asc ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
