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

namespace GestPark
{
    public partial class FormRepairCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private Guid IdCarRepai, idGarageRepaiCar;
        FormImportRepairCar importRepairCar = new FormImportRepairCar();
        public FormRepairCar()
        {
            InitializeComponent();
            fillCbxRepairCar();
            listGarageSearch();

        }

        private void IbtnCloseFanRepairCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnSearchRepairCar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (string.IsNullOrEmpty(TxtSeachRepairCar.Text) && string.IsNullOrEmpty(cbxCarRepairSearch.Text) && string.IsNullOrEmpty(cbxGarageSearch.Text) && dateDebutRepairCar.Enabled==false && dateFinRepairCar.Enabled==false && string.IsNullOrEmpty(cbxPeriodeRepar.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM REPARATION LEFT OUTER JOIN GARAGE ON REPARATION.ID_GARAGE=GARAGE.ID_GARAGE LEFT OUTER JOIN VEHICULE ON REPARATION.ID_VEHICULE=VEHICULE.ID_VEHICULE", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            DgvCarRepair.AutoGenerateColumns = false;
                            DgvCarRepair.DataSource = Ds.Tables[0];
                            SumPriceRepairCar();
                        }
                        else if (!string.IsNullOrEmpty(TxtSeachRepairCar.Text) && string.IsNullOrEmpty(cbxCarRepairSearch.Text) && string.IsNullOrEmpty(cbxGarageSearch.Text) && dateDebutRepairCar.Enabled == false && dateFinRepairCar.Enabled == false && string.IsNullOrEmpty(cbxPeriodeRepar.Text))
                        {
                            string reqCar = "SELECT * FROM REPARATION LEFT OUTER JOIN GARAGE ON REPARATION.ID_GARAGE=GARAGE.ID_GARAGE LEFT OUTER JOIN VEHICULE ON REPARATION.ID_VEHICULE=VEHICULE.ID_VEHICULE";
                            reqCar += " WHERE VEHICULE.IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                            reqCar += " OR GARAGE.DESCRIPTION_GARAGE LIKE '%' +@param1+ '%' ";

                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", TxtSeachRepairCar.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarRepair.AutoGenerateColumns = false;
                            DgvCarRepair.DataSource = tb.Tables[0];
                            SumPriceRepairCar();
                        }
                        else if (string.IsNullOrEmpty(TxtSeachRepairCar.Text) && !string.IsNullOrEmpty(cbxCarRepairSearch.Text) && string.IsNullOrEmpty(cbxGarageSearch.Text) && dateDebutRepairCar.Enabled == false && dateFinRepairCar.Enabled == false && string.IsNullOrEmpty(cbxPeriodeRepar.Text))
                        {
                            string reqCar = "SELECT * FROM REPARATION LEFT OUTER JOIN GARAGE ON REPARATION.ID_GARAGE=GARAGE.ID_GARAGE LEFT OUTER JOIN VEHICULE ON REPARATION.ID_VEHICULE=VEHICULE.ID_VEHICULE";
                            reqCar += " WHERE VEHICULE.IMMATRICULATION_VEHICULE =@param1 ";

                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", cbxCarRepairSearch.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarRepair.AutoGenerateColumns = false;
                            DgvCarRepair.DataSource = tb.Tables[0];
                            SumPriceRepairCar();
                        }
                        else if (string.IsNullOrEmpty(TxtSeachRepairCar.Text) && string.IsNullOrEmpty(cbxCarRepairSearch.Text) && !string.IsNullOrEmpty(cbxGarageSearch.Text) && dateDebutRepairCar.Enabled == false && dateFinRepairCar.Enabled == false && string.IsNullOrEmpty(cbxPeriodeRepar.Text))
                        {
                            string reqCar = "SELECT * FROM REPARATION LEFT OUTER JOIN GARAGE ON REPARATION.ID_GARAGE=GARAGE.ID_GARAGE LEFT OUTER JOIN VEHICULE ON REPARATION.ID_VEHICULE=VEHICULE.ID_VEHICULE";
                            reqCar += " WHERE GARAGE.DESCRIPTION_GARAGE =@param1 ";

                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", cbxGarageSearch.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarRepair.AutoGenerateColumns = false;
                            DgvCarRepair.DataSource = tb.Tables[0];
                            SumPriceRepairCar();
                        }
                        else if (string.IsNullOrEmpty(TxtSeachRepairCar.Text) && !string.IsNullOrEmpty(cbxCarRepairSearch.Text) && !string.IsNullOrEmpty(cbxGarageSearch.Text) && dateDebutRepairCar.Enabled == false && dateFinRepairCar.Enabled == false && string.IsNullOrEmpty(cbxPeriodeRepar.Text))
                        {
                            string reqCar = "SELECT * FROM REPARATION LEFT OUTER JOIN GARAGE ON REPARATION.ID_GARAGE=GARAGE.ID_GARAGE LEFT OUTER JOIN VEHICULE ON REPARATION.ID_VEHICULE=VEHICULE.ID_VEHICULE";
                            reqCar += " WHERE VEHICULE.IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                            reqCar += " OR GARAGE.DESCRIPTION_GARAGE LIKE '%' +@param2+ '%' ";

                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", cbxCarRepairSearch.Text);
                            SqlCmd.Parameters.AddWithValue("param2", cbxGarageSearch.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarRepair.AutoGenerateColumns = false;
                            DgvCarRepair.DataSource = tb.Tables[0];
                            SumPriceRepairCar();
                        }
                        else if (!string.IsNullOrEmpty(TxtSeachRepairCar.Text) && !string.IsNullOrEmpty(cbxCarRepairSearch.Text) && !string.IsNullOrEmpty(cbxGarageSearch.Text) && dateDebutRepairCar.Enabled == false && dateFinRepairCar.Enabled == false && string.IsNullOrEmpty(cbxPeriodeRepar.Text))
                        {
                            string reqCar = "SELECT * FROM REPARATION LEFT OUTER JOIN GARAGE ON REPARATION.ID_GARAGE=GARAGE.ID_GARAGE LEFT OUTER JOIN VEHICULE ON REPARATION.ID_VEHICULE=VEHICULE.ID_VEHICULE";
                            reqCar += " WHERE VEHICULE.IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                            reqCar += " OR GARAGE.DESCRIPTION_GARAGE LIKE '%' +@param2+ '%' ";
                            reqCar += " WHERE VEHICULE.IMMATRICULATION_VEHICULE LIKE '%' +@param3+ '%' ";

                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", cbxCarRepairSearch.Text);
                            SqlCmd.Parameters.AddWithValue("param2", cbxGarageSearch.Text);
                            SqlCmd.Parameters.AddWithValue("param3", TxtSeachRepairCar.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarRepair.AutoGenerateColumns = false;
                            DgvCarRepair.DataSource = tb.Tables[0];
                            SumPriceRepairCar();
                        }
                        else
                        {
                            DgvCarRepair.DataSource = null;
                            SumPriceRepairCar();
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCreateRepaiCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnRepaiCar = new ToolTip();
            ToolTipBtnRepaiCar.AutoPopDelay = 5000;
            ToolTipBtnRepaiCar.InitialDelay = 1000;
            ToolTipBtnRepaiCar.ReshowDelay = 500;
            ToolTipBtnRepaiCar.ShowAlways = true;
            ToolTipBtnRepaiCar.SetToolTip(this.BtnCreateRepaiCar, "Enregistrer");
        }

        private void IbtnExportRepairCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExpRepaiCar = new ToolTip();
            ToolTipBtnExpRepaiCar.AutoPopDelay = 5000;
            ToolTipBtnExpRepaiCar.InitialDelay = 1000;
            ToolTipBtnExpRepaiCar.ReshowDelay = 500;
            ToolTipBtnExpRepaiCar.ShowAlways = true;
            ToolTipBtnExpRepaiCar.SetToolTip(this.IbtnExportRepairCar, "Exporter");
        }

        private void BtnImportRepaiCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImpRepaiCar = new ToolTip();
            ToolTipBtnImpRepaiCar.AutoPopDelay = 5000;
            ToolTipBtnImpRepaiCar.InitialDelay = 1000;
            ToolTipBtnImpRepaiCar.ReshowDelay = 500;
            ToolTipBtnImpRepaiCar.ShowAlways = true;
            ToolTipBtnImpRepaiCar.SetToolTip(this.BtnImportRepaiCar, "Importer");
        }

        private void BtnCreateRepaiCar_Click(object sender, EventArgs e)
        {
            Form createRepaiCar = new FormCreateRepairCar();
            createRepaiCar.ShowDialog();
        }

        // Fill combobox vehicule
        private void fillCbxRepairCar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE SANTE_VEHICULE = 'Bon'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarRepairSearch.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarRepairSearch.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarRepairSearch.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCarRepair_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyRepairCar modifyRepairCar = new FormModifyRepairCar();
            modifyRepairCar.TxtCodeRepaiCarMod.Text = DgvCarRepair.CurrentRow.Cells[0].Value.ToString();
            modifyRepairCar.CbxRepaiCarMod.Text = DgvCarRepair.CurrentRow.Cells[1].Value.ToString();
            modifyRepairCar.TxtAmountRepairMod.Text = DgvCarRepair.CurrentRow.Cells[2].Value.ToString();
            modifyRepairCar.CbxGarageRepairCarMod.Text = DgvCarRepair.CurrentRow.Cells[3].Value.ToString();
            modifyRepairCar.RtxtNoteRepairCarMod.Text = DgvCarRepair.CurrentRow.Cells[4].Value.ToString();
            modifyRepairCar.TxtMecanicienRepairCarMod.Text = DgvCarRepair.CurrentRow.Cells[5].Value.ToString();
            modifyRepairCar.cbxEtatCarRepairMod.Text = DgvCarRepair.CurrentRow.Cells[7].Value.ToString();
            modifyRepairCar.DateRegisterRepairCarMod.Text = DgvCarRepair.CurrentRow.Cells[8].Value.ToString();
            modifyRepairCar.ShowDialog();
        }

        private void SumPriceRepairCar()
        {
            int Mont = 0;
            for (int i = 0; i < DgvCarRepair.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(DgvCarRepair.Rows[i].Cells[2].Value);
            }

            totalAmountReapir.Text = $"Montant net = {Mont.ToString("### ### ### ###")} ";
            TotalRepair.Text = $"Total véhicule = {DgvCarRepair.RowCount - 1}";
        }

        private void IbtnExportRepairCar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DgvCarRepair.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvCarRepair.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DgvCarRepair.Rows.Count; i++)
            {
                for (int j = 0; j < DgvCarRepair.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvCarRepair.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeVehiculeRepare";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        // Fill combobox garage for research
        private void listGarageSearch()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM GARAGE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxGarageSearch.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            cbxGarageSearch.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            cbxGarageSearch.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateDebutRepairCar_ValueChanged(object sender, EventArgs e)
        {
            dateDebutRepairCar.CustomFormat = "dd/MM/yyyy";
        }

        private void dateFinRepairCar_ValueChanged(object sender, EventArgs e)
        {
            dateFinRepairCar.CustomFormat = "dd/MM/yyyy";
        }

        private void dateDebutRepairCar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dateDebutRepairCar.CustomFormat = " ";
            }
        }

        private void dateFinRepairCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dateFinRepairCar.CustomFormat = " ";
            }
        }

        private void cbxCarRepairSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxCarRepairSearch.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCarRepai = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // List véhicule
        private void listCarRepai()
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
                            cbxCarRepairSearch.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarRepairSearch.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarRepairSearch.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImportRepaiCar_Click(object sender, EventArgs e)
        {
            importRepairCar.ShowDialog();
        }

        private void txtFilterRepairCar_TextChanged(object sender, EventArgs e)
        {
            (DgvCarRepair.DataSource as DataTable).DefaultView.RowFilter = "IMMATRICULATION_VEHICULE LIKE '%" + txtFilterRepairCar.Text + "%' ";
        }

        private void cbxPeriodeRepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodeRepar.Text.Equals("Personnalisée"))
            {
                dateDebutRepairCar.Enabled = true;
                dateFinRepairCar.Enabled = true;
            }
            else
            {
                dateDebutRepairCar.Enabled = false;
                dateFinRepairCar.Enabled = false;
            }
        }

    }
}
