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
    public partial class FormConsommationCarburant : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private Guid? GuidProv=null;
        FormModifyConsoCarburant consoCarburant = new FormModifyConsoCarburant();
        FormImportProvisionCarburant impProvCarb = new FormImportProvisionCarburant();
        private String DatePaieProv;
        public FormConsommationCarburant()
        {
            InitializeComponent();
            fillComboboxEnegry();
        }

        private void IbtnCloseFormConsoCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnCreateConsoCar_Click(object sender, EventArgs e)
        {
            FormCreateConsoCarburant CreatConsoCarb = new FormCreateConsoCarburant();
            CreatConsoCarb.ShowDialog();
        }

        private void IbtnSearchConsoCarbu_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if(string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled==false && dateApprovForm.Enabled==false && string.IsNullOrEmpty(cbxPeriodeProv.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM PROVISION", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = Ds.Tables[0];

                            // dgvConsoCar.Columns["PRIX_LITRE_PROV"].DefaultCellStyle.Format = "#,0.###";
                            //ToString("### ### ### ###")

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                        else if (!string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled == false && dateApprovForm.Enabled == false && string.IsNullOrEmpty(cbxPeriodeProv.Text))
                        {
                            string reqCar = "SELECT * FROM PROVISION";
                            //reqCar += " where VEHICULE.IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                            reqCar += " WHERE PROVISION.CODE_PROV LIKE '%' +@param1+ '%' ";

                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", TbxSearchConsoCarApprov.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = tb.Tables[0];

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                        else if (string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled == false && dateApprovForm.Enabled == false && cbxPeriodeProv.Text.Equals("Aujourd'hui"))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM PROVISION WHERE DATE_PROV = '" + DateTime.Now.ToString("dd/MM/yyyy")+"'", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);
                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = tb.Tables[0];

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                        else if (string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled == false && dateApprovForm.Enabled == false && cbxPeriodeProv.Text.Equals("Mois en cours"))
                        {
                            var now = DateTime.Now;
                            var startOfMonth = new DateTime(now.Year, now.Month, 1);
                            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
                            SqlCmd = new SqlCommand("SELECT * FROM PROVISION WHERE DATE_PROV BETWEEN '" + startOfMonth.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ORDER BY DATE_PROV ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);
                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = tb.Tables[0];

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                        else if (string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled == false && dateApprovForm.Enabled == false && cbxPeriodeProv.Text.Equals("Mois Précédent"))
                        {
                            var now = DateTime.Now;
                            var startOfMonth = new DateTime(now.Year, now.Month, 1);
                            var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                            var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
                            var startOfMonthPrevious = startOfMonth.AddMonths(-1);
                            var DaysInMonthPrevious = DateTime.DaysInMonth(now.Year, startOfMonthPrevious.Month);
                            var lastOfMonthPrevious = new DateTime(now.Year, startOfMonthPrevious.Month, DaysInMonthPrevious);
                            SqlCmd = new SqlCommand("SELECT * FROM PROVISION WHERE DATE_PROV BETWEEN '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' AND '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' ORDER BY DATE_PROV ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);
                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = tb.Tables[0];

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                        else if (string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled == false && dateApprovForm.Enabled == false && cbxPeriodeProv.Text.Equals("Année en cours"))
                        {
                            int year = DateTime.Now.Year;
                            DateTime firstDay = new DateTime(year, 1, 1);
                            DateTime lastDay = new DateTime(year, 12, 31);
                            SqlCmd = new SqlCommand("SELECT * FROM PROVISION WHERE DATE_PROV BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ORDER BY DATE_PROV ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);
                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = tb.Tables[0];

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                        else if (string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled == false && dateApprovForm.Enabled == false && cbxPeriodeProv.Text.Equals("Année Précédente"))
                        {
                            DateTime lastYearToDate = DateTime.Now.AddYears(-1);
                            int year = lastYearToDate.Year;
                            DateTime firstDay = new DateTime(year, 1, 1);
                            DateTime lastDay = new DateTime(year, 12, 31);

                            SqlCmd = new SqlCommand("SELECT * FROM PROVISION WHERE DATE_PROV BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ORDER BY DATE_PROV ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);
                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = tb.Tables[0];

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                        else if (string.IsNullOrEmpty(TbxSearchConsoCarApprov.Text) && dateApprovTo.Enabled == true && dateApprovForm.Enabled == true && cbxPeriodeProv.Text.Equals("Personnalisée"))
                        {
                            int year = DateTime.Now.Year;
                            DateTime firstDay = new DateTime(year, 1, 1);
                            DateTime lastDay = new DateTime(year, 12, 31);
                            SqlCmd = new SqlCommand("SELECT * FROM PROVISION WHERE DATE_PROV BETWEEN '" + dateApprovTo.Value.ToString("dd/MM/yyyy") + "' AND '" + dateApprovForm.Value.ToString("dd/MM/yyyy") + "' ORDER BY DATE_PROV ", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);
                            // Fill DataGridView
                            dgvConsoCar.AutoGenerateColumns = false;
                            dgvConsoCar.DataSource = tb.Tables[0];

                            lblTotalConso.Text = $"Nbr. Véhi. Appro. = {dgvConsoCar.RowCount - 1}";
                            SumPriceCar();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnCreateConsoCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IbtnCreateConsoCar, "Saisir un ravitaillement");
        }

        private void IcBtnExportConsoCarb_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IcBtnExportConsoCarb, "Exporter");
        }

        private void BtnImportRavi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnImportRavi, "Importer");
        }

        private void DataGridViewConsoCar_DoubleClick(object sender, EventArgs e)
        {
            consoCarburant.TxtCodeConsoCarbMod.Text = this.dgvConsoCar.CurrentRow.Cells["CODE_PROV"].Value?.ToString();
            consoCarburant.DateRegisterConsoCarbMod.Text = this.dgvConsoCar.CurrentRow.Cells["DATE_PROV"].Value?.ToString();
            GuidProv = Guid.Parse(this.dgvConsoCar.CurrentRow.Cells["ID_PROV"].Value?.ToString());
      
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT PROVISIONLINE.ID_VEHICULE AS IdCarRavi, VEHICULE.IMMATRICULATION_VEHICULE AS ImmatCarMod, PROVISIONLINE.KILO_TOTAL_OLD_PROV AS kilometrageTotalCar, PROVISIONLINE.KILO_AVANT_VIDENGE AS KilometrageVidangeAva, PROVISIONLINE.MONTANT_PROV AS AmountCarb, PROVISIONLINE.ANCIEN_COUNT_VIDANGE_PROV AS AncienCompteurVidange, TYPCONSO.PRIXLITRE_TYPCONSO AS PrixLitreCarb FROM PROVISIONLINE INNER JOIN  VEHICULE ON PROVISIONLINE.ID_VEHICULE=VEHICULE.ID_VEHICULE INNER JOIN TYPECONSOMMATION AS TYPCONSO ON VEHICULE.ID_TYPCONSO=TYPCONSO.ID_TYPCONSO INNER JOIN PROVISION ON PROVISION.ID_PROV=PROVISIONLINE.ID_PROV WHERE PROVISION.CODE_PROV='" + consoCarburant.TxtCodeConsoCarbMod.Text + "'", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet Tb = new DataSet();
                        SqlAda.Fill(Tb);
                        // Fill DataGridView
                        consoCarburant.DvgCarApproMod.AutoGenerateColumns = false;
                        consoCarburant.DvgCarApproMod.DataSource = Tb.Tables[0];
                        
                        // Affiche les paiements
                        SqlCmd = new SqlCommand("SELECT CARDPAIEMENT.ID_CARD AS IdCard, CARDPAIEMENT.NUM_CARD AS CardNum,CARDPAIEMENT.SOLDE_CARD As SoldeReel, PAIEMENT.TOTALPRIX_PAIE AS AmountCard,ANCIEN_SOLDE_CARTE_PAIE AS holdAmountCard, PAIEMENT.ID_PAIE AS IdPaie FROM PAIEMENT  INNER JOIN CARDPAIEMENT ON PAIEMENT.ID_CARD=CARDPAIEMENT.ID_CARD INNER JOIN PROVISION ON PAIEMENT.ID_PROV=PROVISION.ID_PROV WHERE PROVISION.CODE_PROV ='" + consoCarburant.TxtCodeConsoCarbMod.Text + "'", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet Tab = new DataSet();
                        SqlAda.Fill(Tab);
                        // Fill DataGridView
                        consoCarburant.DgvPaieMod.AutoGenerateColumns = false;
                        consoCarburant.DgvPaieMod.DataSource = Tab.Tables[0];

                        using(var Cmd = Conn.cn.CreateCommand())
                        {
                            Cmd.CommandText = "SELECT DATE_PAIE FROM PAIEMENT AS PAIE INNER JOIN PROVISION AS PROV ON PAIE.ID_PROV=PROV.ID_PROV WHERE PROV.ID_PROV='" + GuidProv + "'";
                            MyReader = Cmd.ExecuteReader();

                            while (MyReader.Read())
                            {
                                DatePaieProv = MyReader["DATE_PAIE"].ToString();
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            consoCarburant.datePaieMod.Text = DatePaieProv;
            consoCarburant.TotalAmountConsoCarbu();
            consoCarburant.TotalAmountPaieCard();
            consoCarburant.ShowDialog();
        }

        // Method to fill the combobox type of consommation
        private void fillComboboxEnegry()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM TYPECONSOMMATION", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        CbxEnergyApprov.Items.Add(MyReader["DESCRIPTION_TYPCONSO"].ToString());
                        CbxEnergyApprov.DisplayMember = (MyReader["DESCRIPTION_TYPCONSO"].ToString());
                        CbxEnergyApprov.ValueMember = (MyReader["ID_TYPCONSO"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxPeriodeProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)cbxPeriodeProv.Text== "Personnalisée")
            {
                dateApprovForm.Enabled = true;
                dateApprovTo.Enabled = true;
            }
            else
            {
                dateApprovForm.Enabled = false;
                dateApprovTo.Enabled = false;
            }
        }

        // Calculer le coût total d'approvisionnement
        private void SumPriceCar()
        {
            decimal Mont = 0;
            for (int i = 0; i < dgvConsoCar.Rows.Count; ++i)
            {
                Mont += Convert.ToDecimal(dgvConsoCar.Rows[i].Cells["MONTANT_PROV"].Value);
            }

            lblTotalApprov.Text = $"Coût Total = {Mont.ToString("### ### ### ###")} ";
        }
       
        private void BtnImportRavi_Click(object sender, EventArgs e)
        {
            impProvCarb.ShowDialog();
        }

        private void IcBtnExportConsoCarb_Click(object sender, EventArgs e)
        {
            ExportProv();
        }

        private void ExportProv()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "provisionCarburant";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvConsoCar.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvConsoCar.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvConsoCar.Rows.Count; i++)
            {
                for (int j = 0; j < dgvConsoCar.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvConsoCar.Rows[i].Cells[j].Value?.ToString();
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
    }
}
