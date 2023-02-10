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
    public partial class FormEtatLavageVehicule : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        public FormEtatLavageVehicule()
        {
            InitializeComponent();
            ListeVehicule();
        }

        private void FormEtatLavageVehicule_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestParkDataSetLavage.View_Lavage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.view_LavageTableAdapter.Fill(this.gestParkDataSetLavage.View_Lavage);
            // TODO: cette ligne de code charge les données dans la table 'gestParkDataSetLavage.View_Lavage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.view_LavageTableAdapter.Fill(this.gestParkDataSetLavage.View_Lavage);
            // this.reportViewerLavageCar.RefreshReport();
        }

        private void btnResetLavageCar_Click(object sender, EventArgs e)
        {
            reportViewerLavageCar.Refresh();
            txtMultiCritereLavagCar.Clear();
            cbxVehiLavag.Text = null;
            dateLavagFrom.Text = DateTime.Now.ToShortDateString();
            dateLavagTo.Text = DateTime.Now.ToShortDateString();
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
                            cbxVehiLavag.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxVehiLavag.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxVehiLavag.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ListAllCarCleaning()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Lavage", Conn.cn);
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

        private DataTable ListCleaningOfOneCar()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Lavage where IMMATRICULATION_VEHICULE ='" + cbxVehiLavag.SelectedItem + "'", Conn.cn);
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
        private DataTable ListCleaningPeriod()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Lavage where DATEREGISTER between '"+dateLavagFrom.Value.ToString("dd/MM/yyyy")+"' and '"+dateLavagTo.Value.ToString("dd/MM/yyyy")+"' order by DATEREGISTER asc", Conn.cn);
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

        private DataTable ListCleaningToDay()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Lavage where DATEREGISTER = '"+DateTime.Now.ToString("dd/MM/yyyy")+"' order by DATEREGISTER asc", Conn.cn);
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

        private DataTable ListCleaningMonthly()
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
                    SqlCmd = new SqlCommand("select*from View_Lavage where DATEREGISTER between '" + startOfMonth.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATEREGISTER asc", Conn.cn);
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

        private DataTable ListCleaningPreviousMonthly()
        {
            DataTable dt = new DataTable();
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
            var startOfMonthPrevious = startOfMonth.AddMonths(-1);
            var DaysInMonthPrevious = DateTime.DaysInMonth(now.Year, startOfMonthPrevious.Month);
            var lastOfMonthPrevious = new DateTime(now.Year, startOfMonthPrevious.Month, DaysInMonthPrevious);
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Lavage where DATEREGISTER between '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' and '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' order by DATEREGISTER asc", Conn.cn);
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

        private DataTable ListCleaningYear()
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
                    SqlCmd = new SqlCommand("select*from View_Lavage where DATEREGISTER between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATEREGISTER asc", Conn.cn);
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

        private DataTable ListCleaningPreviousYear()
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
                    SqlCmd = new SqlCommand("select*from View_Lavage where DATEREGISTER between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATEREGISTER asc", Conn.cn);
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

        private void btnSearchLavageCar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled==false && dateLavagFrom.Enabled==false && string.IsNullOrEmpty(cbxPeriodeLavagCar.Text))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListCleaningOfOneCar());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled == false && dateLavagFrom.Enabled == false && string.IsNullOrEmpty(cbxPeriodeLavagCar.Text))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListAllCarCleaning());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled == true && dateLavagFrom.Enabled == true && !string.IsNullOrEmpty(cbxPeriodeLavagCar.Text) && cbxPeriodeLavagCar.Text.Equals("Personnalisé"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListCleaningPeriod());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled == true && dateLavagFrom.Enabled == true && !string.IsNullOrEmpty(cbxPeriodeLavagCar.Text) && cbxPeriodeLavagCar.Text.Equals("Aujourd'hui"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListCleaningToDay());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled == true && dateLavagFrom.Enabled == true && !string.IsNullOrEmpty(cbxPeriodeLavagCar.Text) && cbxPeriodeLavagCar.Text.Equals("Mois en cours"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListCleaningMonthly());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled == true && dateLavagFrom.Enabled == true && !string.IsNullOrEmpty(cbxPeriodeLavagCar.Text) && cbxPeriodeLavagCar.Text.Equals("Mois précedent"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListCleaningPreviousMonthly());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled == true && dateLavagFrom.Enabled == true && !string.IsNullOrEmpty(cbxPeriodeLavagCar.Text) && cbxPeriodeLavagCar.Text.Equals("Année en cours"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListCleaningYear());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiLavag.Text) && string.IsNullOrEmpty(txtMultiCritereLavagCar.Text) && dateLavagTo.Enabled == true && dateLavagFrom.Enabled == true && !string.IsNullOrEmpty(cbxPeriodeLavagCar.Text) && cbxPeriodeLavagCar.Text.Equals("Année précédente"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetLavageCar", ListCleaningPreviousYear());
                reportViewerLavageCar.LocalReport.DataSources.Clear();
                reportViewerLavageCar.Name = "ReportRepairCar.rdlc";
                reportViewerLavageCar.LocalReport.Refresh();
                reportViewerLavageCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerLavageCar.RefreshReport();

            }
        }

        private void btnCloseEtatLavage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPeriodeLavagCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbxPeriodeLavagCar.Text=="Personnalisé")
            {
                dateLavagFrom.Enabled=true;
                dateLavagTo.Enabled = true;
            }
            else
            {
                dateLavagFrom.Enabled=false;
                dateLavagTo.Enabled=false;
            }
        }
    }
}
