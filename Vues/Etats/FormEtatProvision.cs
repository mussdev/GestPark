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
    public partial class FormEtatProvision : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        public FormEtatProvision()
        {
            InitializeComponent();
            ListeVehicule();
        }

        private void btnCloseEtatProvision_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEtatProvision_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestParkDataSetProvCarb.View_Provision'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.view_ProvisionTableAdapter.Fill(this.gestParkDataSetProvCarb.View_Provision);
            //this.reportViewer1.RefreshReport();
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
                            cbxVehiProv.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxVehiProv.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxVehiProv.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ListCarProvOfOneCar()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Provision where IMMATRICULATION_VEHICULE ='" + cbxVehiProv.SelectedItem + "'", Conn.cn);
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

        private DataTable ListAllCarProv()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Provision", Conn.cn);
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

        private DataTable ListCarProvPerPeriod()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Provision where DATE_PROV between '"+dateProvFrom.Value.ToString("dd/MM/yyyy")+"' and '"+ dateProvTo.Value.ToString("dd/MM/yyyy") + "'", Conn.cn);
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

        private DataTable ListCarProvPerMonthly()
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
                    SqlCmd = new SqlCommand("SELECT * FROM View_Provision WHERE DATE_PROV BETWEEN '" + startOfMonth.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ORDER BY DATE_PROV ASC ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private DataTable ListCarProvPerMonthlyPrevious()
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
                    SqlCmd = new SqlCommand("SELECT * FROM View_Provision WHERE DATE_PROV BETWEEN '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' AND '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' ORDER BY DATE_PROV ASC ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private DataTable ListCarProvToday()
        {
            DataTable dt = new DataTable();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("select*from View_Provision where DATE_PROV='"+ DateTime.Now.ToString("dd/MM/yyyy") + "'", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private DataTable ListCarProvToYear()
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
                    SqlCmd = new SqlCommand("select*from View_Provision where DATE_PROV between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATE_PROV asc ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    dt.Load(MyReader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        private DataTable ListCarProvToYearPrevious()
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
                    SqlCmd = new SqlCommand("select*from View_Provision where DATE_PROV between '" + firstDay.ToString("dd/MM/yyyy") + "' and '" + lastDay.ToString("dd/MM/yyyy") + "' order by DATE_PROV asc ", Conn.cn);
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


        private void btnSearchProvCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled==false && dateProvTo.Enabled==false && string.IsNullOrEmpty(cbxPeriodeProvCar.Text) && !string.IsNullOrEmpty(cbxVehiProv.Text))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListCarProvOfOneCar());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
            else if(string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled == false && dateProvTo.Enabled == false && string.IsNullOrEmpty(cbxVehiProv.Text) && string.IsNullOrEmpty(cbxPeriodeProvCar.Text))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListAllCarProv());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
            else if (string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled == true && dateProvTo.Enabled == true && string.IsNullOrEmpty(cbxVehiProv.Text) && !string.IsNullOrEmpty(cbxPeriodeProvCar.Text) && cbxPeriodeProvCar.Text.Equals("Personnalisé"))
            {
                //this.reportViewerRepaiCar.Reset();
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListCarProvPerPeriod());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
            else if (string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled == false && dateProvTo.Enabled == false && string.IsNullOrEmpty(cbxVehiProv.Text) && !string.IsNullOrEmpty(cbxPeriodeProvCar.Text) && cbxPeriodeProvCar.Text.Equals("Aujourd'hui"))
            {
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListCarProvToday());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
            else if (string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled == false && dateProvTo.Enabled == false && string.IsNullOrEmpty(cbxVehiProv.Text) && !string.IsNullOrEmpty(cbxPeriodeProvCar.Text) && cbxPeriodeProvCar.Text.Equals("Mois en cours"))
            {
                //MessageBox.Show("Nombre de jour pour un mois " + DaysInMonth);
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListCarProvPerMonthly());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
            else if (string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled == false && dateProvTo.Enabled == false && string.IsNullOrEmpty(cbxVehiProv.Text) && !string.IsNullOrEmpty(cbxPeriodeProvCar.Text) && cbxPeriodeProvCar.Text.Equals("Mois précedent"))
            {
                //MessageBox.Show("Nombre de jour pour un mois " + DaysInMonth);
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListCarProvPerMonthlyPrevious());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
            else if (string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled == false && dateProvTo.Enabled == false && string.IsNullOrEmpty(cbxVehiProv.Text) && !string.IsNullOrEmpty(cbxPeriodeProvCar.Text) && cbxPeriodeProvCar.Text.Equals("Année en cours"))
            {
                //MessageBox.Show("Années : " + year + "First day :" + firstDay + " Last day : " + lastDay);
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListCarProvToYear());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
            else if (string.IsNullOrEmpty(txtMultiCritereProvCar.Text) && dateProvFrom.Enabled == false && dateProvTo.Enabled == false && string.IsNullOrEmpty(cbxVehiProv.Text) && !string.IsNullOrEmpty(cbxPeriodeProvCar.Text) && cbxPeriodeProvCar.Text.Equals("Année précédente"))
            {
                ReportDataSource rdsRepairCar = new ReportDataSource("DataSetProvisionCarb", ListCarProvToYearPrevious());
                reportViewerProvision.LocalReport.DataSources.Clear();
                reportViewerProvision.Name = "ReportProvisionCarb.rdlc";
                reportViewerProvision.LocalReport.Refresh();
                reportViewerProvision.LocalReport.DataSources.Add(rdsRepairCar);
                reportViewerProvision.RefreshReport();
            }
        }

        private void btnResetProvCar_Click(object sender, EventArgs e)
        {
            reportViewerProvision.Refresh();
            reportViewerProvision.Clear();
            cbxVehiProv.Text = null;
            dateProvFrom.Text = DateTime.Now.ToShortDateString();
            dateProvTo.Text = DateTime.Now.ToShortDateString();
        }

        private void cbxPeriodeProvCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)cbxPeriodeProvCar.SelectedItem == "Personnalisé")
            {
                dateProvFrom.Enabled = true;
                dateProvTo.Enabled = true;
            }
            else
            {
                dateProvFrom.Enabled = false;
                dateProvTo.Enabled = false;
            }
        }
    }
}
