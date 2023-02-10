using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using System.Drawing;


namespace GestPark
{
    public partial class FormViewVehicule : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;

        FormModifyVehicule FormDisplayAndModifyCar = new FormModifyVehicule();
        public FormViewVehicule()
        {
            InitializeComponent();
        }

        private void iconBtnCloseViewForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnSearchVehi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB conn = new ConnectDB(connectionString);
                if (conn.IsConnection)
                {
                    if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false)
                    {
                        //MessageBox.Show("Muss Tech");
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS ", conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];

                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1 }";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && !string.IsNullOrEmpty(checkedListEtatCar.Text) && string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false)
                    {
                        //MessageBox.Show("Valeur = " + checkedListEtatCar.Text);
                        string reqCar = "SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS";
                        //reqCar += " WHERE VEHICULE.TYPE_VEHICULE = @TYPE_VEHICULE  ";
                        reqCar += " WHERE VEHICULE.SANTE_VEHICULE = @SANTE_VEHICULE  ";
                        //reqCar += " AND VEHICULE.IMMATRICULATION_VEHICULE LIKE '%' +@param2+ '%'  ";

                        SqlCmd = new SqlCommand(reqCar, conn.cn);
                        //SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", checkedListBoxTypVehi.Text);
                        SqlCmd.Parameters.AddWithValue("@SANTE_VEHICULE", checkedListEtatCar.Text);
                        //SqlCmd.Parameters.AddWithValue("@param2", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && !string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false)
                    {
                        //MessageBox.Show("Valeu combo = " + comboBoxEtatVehi.Text);
                        string reqCar = "SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS";
                        reqCar += " WHERE VEHICULE.ETAT_VEHICULE = @ETAT_VEHICULE  ";

                        SqlCmd = new SqlCommand(reqCar, conn.cn);
                        SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", comboBoxPositionVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (!string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false)
                    {
                        //MessageBox.Show("Valeu combo = " + comboBoxEtatVehi.Text);
                        string reqCar = "SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS";
                        reqCar += " WHERE VEHICULE.TYPE_VEHICULE = @TYPE_VEHICULE  ";

                        SqlCmd = new SqlCommand(reqCar, conn.cn);
                        SqlCmd.Parameters.AddWithValue("@TYPE_VEHICULE", checkedListBoxTypVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && !string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false)
                    {
                        string reqCar = "SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS";
                        reqCar += " WHERE VEHICULE.CODE_VEHICULE =@CODE_VEHICULE";
                        reqCar += " OR VEHICULE.IMMATRICULATION_VEHICULE =@IMMATRICULATION_VEHICULE";
                        reqCar += " OR VEHICULE.CARTE_GRISE_VEHICULE =@CARTE_GRISE_VEHICULE";

                        SqlCmd = new SqlCommand(reqCar, conn.cn);
                        SqlCmd.Parameters.AddWithValue("@CODE_VEHICULE", textBxSearchVehi.Text);
                        SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBxSearchVehi.Text);
                        SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && !string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false && cbxPeriodCar.Text.Equals("Aujourd'hui"))
                    {
                        string reqCar = "SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS";
                        reqCar += " WHERE VEHICULE.DATE_ACHA_VEHICULE =@DATE_ACHA_VEHICULE";
                        //reqCar += " OR VEHICULE.IMMATRICULATION_VEHICULE =@IMMATRICULATION_VEHICULE";
                        //reqCar += " OR VEHICULE.CARTE_GRISE_VEHICULE =@CARTE_GRISE_VEHICULE";

                        SqlCmd = new SqlCommand(reqCar, conn.cn);
                        SqlCmd.Parameters.AddWithValue("@DATE_ACHA_VEHICULE", DateTime.Now.ToString("dd/MM/yyyy"));
                        //qlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", textBxSearchVehi.Text);
                        //SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && !string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false && cbxPeriodCar.Text.Equals("Mois en cours"))
                    {
                        var now = DateTime.Now;
                        var startOfMonth = new DateTime(now.Year, now.Month, 1);
                        var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                        var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);

                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS WHERE VEHICULE.DATE_ACHA_VEHICULE BETWEEN '"+ startOfMonth.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "'", conn.cn);
                        
                        //SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && !string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false && cbxPeriodCar.Text.Equals("Mois précédent"))
                    {
                        var now = DateTime.Now;
                        var startOfMonth = new DateTime(now.Year, now.Month, 1);
                        var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                        var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
                        var startOfMonthPrevious = startOfMonth.AddMonths(-1);
                        var DaysInMonthPrevious = DateTime.DaysInMonth(now.Year, startOfMonthPrevious.Month);
                        var lastOfMonthPrevious = new DateTime(now.Year, startOfMonthPrevious.Month, DaysInMonthPrevious);

                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS WHERE VEHICULE.DATE_ACHA_VEHICULE BETWEEN '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' AND '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "'", conn.cn);

                        //SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && !string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false && cbxPeriodCar.Text.Equals("Année en cours"))
                    {
                        var now = DateTime.Now;
                        int year = DateTime.Now.Year;
                        DateTime firstDay = new DateTime(year, 1, 1);
                        DateTime lastDay = new DateTime(year, 12, 31);

                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS WHERE VEHICULE.DATE_ACHA_VEHICULE BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "'", conn.cn);

                        //SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && !string.IsNullOrEmpty(cbxPeriodCar.Text) && dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false && cbxPeriodCar.Text.Equals("Année précédente"))
                    {
                        DateTime lastYearToDate = DateTime.Now.AddYears(-1);
                        int year = lastYearToDate.Year;
                        DateTime firstDay = new DateTime(year, 1, 1);
                        DateTime lastDay = new DateTime(year, 12, 31);

                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS WHERE VEHICULE.DATE_ACHA_VEHICULE BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "'", conn.cn);

                        //SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else if (string.IsNullOrEmpty(checkedListBoxTypVehi.Text) && string.IsNullOrEmpty(comboBoxPositionVehi.Text) && string.IsNullOrEmpty(textBxSearchVehi.Text) && string.IsNullOrEmpty(checkedListEtatCar.Text) && !string.IsNullOrEmpty(cbxPeriodCar.Text) /*&& dateVehiFrom.Enabled == false && dateVehiTo.Enabled == false*/ && cbxPeriodCar.Text.Equals("Personnalisée"))
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK = VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS WHERE VEHICULE.DATE_ACHA_VEHICULE BETWEEN '" + dateVehiFrom.Value.ToString("dd/MM/yyyy") + "' AND '" + dateVehiTo.Value.ToString("dd/MM/yyyy") + "' order by DATE_ACHA_VEHICULE asc", conn.cn);

                        //SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", textBxSearchVehi.Text);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet tb = new DataSet();
                        SqlAda.Fill(tb);

                        // Fill DataGridView
                        DataGridViewVehi.AutoGenerateColumns = false;
                        DataGridViewVehi.DataSource = tb.Tables[0];
                        // Calculer le nombre total de véhicule
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    else
                    {
                        DataGridViewVehi.DataSource = null;
                        LbTotalCar.Text = $"Total véhicule = {DataGridViewVehi.RowCount - 1}";
                        SumPriceCar();
                    }
                    //MessageBox.Show("C'est pas bon !!!!!!!!!!!!!!!!!!!!!!!" + checkedListEtatCar.Text);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconBtnExportVehi_Click(object sender, EventArgs e)
        {
            ExporterCar();
        }


        private void BtnCreateCar_Click(object sender, EventArgs e)
        {
            FormRegisterVehicule CreateCar = new FormRegisterVehicule();
            CreateCar.ShowDialog();
        }

        private void DataGridViewVehi_DoubleClick(object sender, EventArgs e)
        {
            DisplayFormCar();
        }


        private void SumPriceCar()
        {
            decimal Mont = 0;
            for (int i = 0; i < DataGridViewVehi.Rows.Count; ++i)
            {
                Mont += Convert.ToDecimal(DataGridViewVehi.Rows[i].Cells[5].Value);
            }

            TotalPriceCar.Text = $"Total montant = {Mont.ToString("### ### ### ###")} ";
        }

        private int rowIndex = 0;
        private void DataGridViewVehi_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DataGridViewVehi.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DataGridViewVehi.CurrentCell = this.DataGridViewVehi.Rows[e.RowIndex].Cells[1];
                this.MenuContextCar.Show(this.DataGridViewVehi, e.Location);
                MenuContextCar.Show(Cursor.Position);
            }
        }

        private void MenuContextOpenCar_Click(object sender, EventArgs e)
        {
            DisplayFormCar();
        }

        private void DisplayFormCar()
        {
            FormDisplayAndModifyCar.textBoxModifyCarCodVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[0].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarEtatVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[1].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarImmatVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[2].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarCartGriVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[3].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarModelVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[4].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarPrixVentVehi.Text = $"{decimal.Parse(this.DataGridViewVehi.CurrentRow.Cells[5].Value?.ToString()).ToString("### ### ### ###")} ";
            FormDisplayAndModifyCar.comboBoxModifyCarTypVeh.Text = this.DataGridViewVehi.CurrentRow.Cells[6].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarTypVitessVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[7].Value?.ToString();
            //FormDisplayAndModifyCar.comboBoxModifyCarEmplVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[8].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarTypConsoVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[9].Value?.ToString();
            FormDisplayAndModifyCar.textBoxModifyCarMarkVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[10].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarProprio.Text = this.DataGridViewVehi.CurrentRow.Cells[11].Value?.ToString();
            FormDisplayAndModifyCar.comboBoxModifyCarFourn.Text = this.DataGridViewVehi.CurrentRow.Cells[12].Value?.ToString();
            FormDisplayAndModifyCar.richTextBoxModifyCarNoteVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[13].Value?.ToString();
            FormDisplayAndModifyCar.CbxStatutModifyCar.Text = this.DataGridViewVehi.CurrentRow.Cells[14].Value?.ToString();
            FormDisplayAndModifyCar.CbxSanteCar.Text = this.DataGridViewVehi.CurrentRow.Cells[15].Value?.ToString();
            FormDisplayAndModifyCar.TxtKolimetrageCar.Text = $"{decimal.Parse(this.DataGridViewVehi.CurrentRow.Cells[16].Value?.ToString()).ToString("### ### ### ###")} ";
            FormDisplayAndModifyCar.TxtKilometrageParCar.Text = this.DataGridViewVehi.CurrentRow.Cells[17].Value?.ToString();
            FormDisplayAndModifyCar.dateTimePickModifyCarDatAchaVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[18].Value?.ToString();
            FormDisplayAndModifyCar.dateTimeModifyCarPickDatVisitVehi.Text = this.DataGridViewVehi.CurrentRow.Cells[19].Value?.ToString();
            FormDisplayAndModifyCar.DateTimePickerModifyCarAssurance.Text = this.DataGridViewVehi.CurrentRow.Cells[20].Value?.ToString();
            FormDisplayAndModifyCar.dateMiseEnServMod.Text = this.DataGridViewVehi.CurrentRow.Cells[21].Value?.ToString();
            FormDisplayAndModifyCar.ShowDialog();
        }

        private void MenuContextEditCar_Click(object sender, EventArgs e)
        {
            DisplayFormCar();
        }

        private void MenuContextExporterCar_Click(object sender, EventArgs e)
        {
            ExporterCar();
        }

        private void ExporterCar()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DataGridViewVehi.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridViewVehi.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DataGridViewVehi.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewVehi.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridViewVehi.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Nom du fichier";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void BtnCreateCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnCreateCar, "Enregistrer");

        }

        private void iconBtnExportVehi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExportCar = new ToolTip();
            ToolTipBtnExportCar.AutoPopDelay = 5000;
            ToolTipBtnExportCar.InitialDelay = 1000;
            ToolTipBtnExportCar.ReshowDelay = 500;
            ToolTipBtnExportCar.ShowAlways = true;
            ToolTipBtnExportCar.SetToolTip(this.iconBtnExportVehi, "Exporter");
        }

        private void BtnImportCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImportCar = new ToolTip();
            ToolTipBtnImportCar.AutoPopDelay = 5000;
            ToolTipBtnImportCar.InitialDelay = 1000;
            ToolTipBtnImportCar.ReshowDelay = 500;
            ToolTipBtnImportCar.ShowAlways = true;
            ToolTipBtnImportCar.SetToolTip(this.BtnImportCar, "Importer");
        }

        private void cbxPeriodCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)cbxPeriodCar.Text== "Personnalisée")
            {
                dateVehiFrom.Enabled=true;
                dateVehiTo.Enabled=true;
            }
            else
            {
                dateVehiFrom.Enabled=false;
                dateVehiTo.Enabled=false;
            }
        }

        private void txtFilterVehicule_TextChanged(object sender, EventArgs e)
        {
            (DataGridViewVehi.DataSource as DataTable).DefaultView.RowFilter = "IMMATRICULATION_VEHICULE LIKE '%" + txtFilterVehicule.Text + "%' ";
        }
    }
}
