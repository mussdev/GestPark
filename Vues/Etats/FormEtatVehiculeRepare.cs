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
using Microsoft.Reporting.WinForms;

namespace GestPark
{
    public partial class FormEtatVehiculeRepare : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdVehiculeRepaiEtat;
        public FormEtatVehiculeRepare()
        {
            InitializeComponent();
            ListeVehicule();
        }

        private void btnCloseEtatReapir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEtatVehiculeRepare_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestParkDataSet.ViewReparation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.viewReparationTableAdapter.Fill(this.gestParkDataSet.ViewReparation);
        }

        private void btnSearchReapir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled==false && dateRepairTo.Enabled==false)
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListCarRepairOfOneCar());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled == false && dateRepairTo.Enabled == false)
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListAllCarRepair());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled == false && dateRepairTo.Enabled == false && cbxPeriodeRepair.Text.Equals("Aujourd'hui"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListCarRepairToDay());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled == false && dateRepairTo.Enabled == false && cbxPeriodeRepair.Text.Equals("Mois en cours"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListCarRepairToMonthly());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled == false && dateRepairTo.Enabled == false && cbxPeriodeRepair.Text.Equals("Mois précedent"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListCarRepairPreviousMonthly());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled == false && dateRepairTo.Enabled == false && cbxPeriodeRepair.Text.Equals("Année en cours"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListCarRepairToYear());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled == false && dateRepairTo.Enabled == false && cbxPeriodeRepair.Text.Equals("Année précédente"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListCarRepairPreviousYear());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
            else if (string.IsNullOrEmpty(cbxVehiRepair.Text) && string.IsNullOrEmpty(txtMultiCritereRepair.Text) && string.IsNullOrEmpty(cbxPeriodeRepair.Text) && dateRepaiFrom.Enabled == false && dateRepairTo.Enabled == false && cbxPeriodeRepair.Text.Equals("Personnalisé"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetRepairCar", ListCarRepairPeriod());
                reportViewerRepaiCar.LocalReport.DataSources.Clear();
                reportViewerRepaiCar.Name = "ReportRepairCar.rdlc";
                reportViewerRepaiCar.LocalReport.Refresh();
                reportViewerRepaiCar.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerRepaiCar.RefreshReport();

            }
        }

        private void cbxVehiRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxVehiRepair.SelectedItem + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculeRepaiEtat = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            cbxVehiRepair.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxVehiRepair.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxVehiRepair.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ListCarRepairOfOneCar()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from ViewReparation where IMMATRICULATION_VEHICULE ='" + cbxVehiRepair.SelectedItem + "'", Conn.cn);
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

        private DataTable ListAllCarRepair()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from ViewReparation", Conn.cn);
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

        private DataTable ListCarRepairToDay()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from ViewReparation where DATE_REPAR = '"+DateTime.Now.ToString("dd/MM/yyyy")+"'", Conn.cn);
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

        private DataTable ListCarRepairToMonthly()
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
                    SqlCmd = new SqlCommand("select*from ViewReparation where DATE_REPAR between '" + startOfMonth.ToString("dd/MM/yyyy") + "' and '"+ lastDay.ToString("dd/MM/yyyy") + "' order by DATE_REPAR asc ", Conn.cn);
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

        private DataTable ListCarRepairPreviousMonthly()
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
                    SqlCmd = new SqlCommand("select*from ViewReparation where DATE_REPAR between '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' and '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' order by DATE_REPAR asc ", Conn.cn);
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

        private DataTable ListCarRepairToYear()
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
                    SqlCmd = new SqlCommand("select*from ViewReparation where DATE_REPAR between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATE_REPAR asc ", Conn.cn);
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
        private DataTable ListCarRepairPreviousYear()
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
                    SqlCmd = new SqlCommand("select*from ViewReparation where DATE_REPAR between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATE_REPAR asc ", Conn.cn);
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

        private DataTable ListCarRepairPeriod()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from ViewReparation where DATE_REPAR between '" + dateRepaiFrom.Value.ToString("dd/MM/yyyy") + "' and '" + dateRepairTo.Value.ToString("dd/MM/yyyy") + "' order by DATE_REPAR asc ", Conn.cn);
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

        private void btnResetRepairCar_Click(object sender, EventArgs e)
        {
            reportViewerRepaiCar.Refresh();
            txtMultiCritereRepair.Clear();
            cbxVehiRepair.Text = null;
            dateRepaiFrom.Text = DateTime.Now.ToShortDateString();
            dateRepairTo.Text = DateTime.Now.ToShortDateString();
        }

        private void cbxPeriodeRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)cbxPeriodeRepair.Text== "Personnalisé")
            {
                dateRepaiFrom.Enabled = true;
                dateRepairTo.Enabled = true;
            }
            else
            {
                dateRepaiFrom.Enabled = false;
                dateRepairTo.Enabled = false;
            }
        }
    }
}
