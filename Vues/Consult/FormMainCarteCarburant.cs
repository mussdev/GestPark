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
    public partial class FormMainCarteCarburant : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormMainCarteCarburant()
        {
            InitializeComponent();
        }

        private void IbtnRegisterCarteCarb_Click(object sender, EventArgs e)
        {
            FormAddCarteCarburant AddCarteCarburant = new FormAddCarteCarburant();
            AddCarteCarburant.ShowDialog();
        }

        private void IbtnCloseFormMvt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void IbtnSearchCarteCarb_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if(string.IsNullOrEmpty(checkedListBoxCard.Text) && string.IsNullOrEmpty(TbxSearchCarteCarb.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM CARDPAIEMENT", Conn.cn);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvCarteCarb.AutoGenerateColumns = false;
                            DgvCarteCarb.DataSource = Ds.Tables[0];
                        }else if(string.IsNullOrEmpty(checkedListBoxCard.Text) && !string.IsNullOrEmpty(TbxSearchCarteCarb.Text))
                        {
                            string reqCar = "select * from CARDPAIEMENT";
                            reqCar += " where NUM_CARD like '%' +@param1+ '%' ";
                            reqCar += " or STATION_CARD like '%' +@param2+ '%' ";


                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", TbxSearchCarteCarb.Text);
                            SqlCmd.Parameters.AddWithValue("param2", TbxSearchCarteCarb.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarteCarb.AutoGenerateColumns = false;
                            DgvCarteCarb.DataSource = tb.Tables[0];
                        }
                        else if (!string.IsNullOrEmpty(checkedListBoxCard.Text) && string.IsNullOrEmpty(TbxSearchCarteCarb.Text))
                        {
                            string reqCar = "select * from CARDPAIEMENT";
                            reqCar += " where TPYE_CARD=@param1 ";


                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", checkedListBoxCard.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarteCarb.AutoGenerateColumns = false;
                            DgvCarteCarb.DataSource = tb.Tables[0];
                        }
                        else if (!string.IsNullOrEmpty(checkedListBoxCard.Text) && !string.IsNullOrEmpty(TbxSearchCarteCarb.Text))
                        {
                            string reqCar = "select * from CARDPAIEMENT";
                            reqCar += " where TPYE_CARD=@param1 ";
                            reqCar += " and NUM_CARD=@param2 ";

                            // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                            SqlCmd = new SqlCommand(reqCar, Conn.cn);
                            SqlCmd.Parameters.AddWithValue("param1", checkedListBoxCard.Text);
                            SqlCmd.Parameters.AddWithValue("param2", TbxSearchCarteCarb.Text);
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet tb = new DataSet();
                            SqlAda.Fill(tb);

                            // Fill DataGridView
                            DgvCarteCarb.AutoGenerateColumns = false;
                            DgvCarteCarb.DataSource = tb.Tables[0];
                        }else
                            DgvCarteCarb.DataSource=null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRechargeCarte_Click(object sender, EventArgs e)
        {
            FormRechargeCarte RechargeCarte = new FormRechargeCarte();
            RechargeCarte.ShowDialog();
        }

        private void IbtnRegisterCarteCarb_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCard = new ToolTip();
            ToolTipBtnCreateCard.AutoPopDelay = 5000;
            ToolTipBtnCreateCard.InitialDelay = 1000;
            ToolTipBtnCreateCard.ReshowDelay = 500;
            ToolTipBtnCreateCard.ShowAlways = true;
            ToolTipBtnCreateCard.SetToolTip(this.IbtnRegisterCarteCarb, "Ajouter une carte");
        }

        private void BtnRechargeCarte_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateRech = new ToolTip();
            ToolTipBtnCreateRech.AutoPopDelay = 5000;
            ToolTipBtnCreateRech.InitialDelay = 1000;
            ToolTipBtnCreateRech.ReshowDelay = 500;
            ToolTipBtnCreateRech.ShowAlways = true;
            ToolTipBtnCreateRech.SetToolTip(this.BtnRechargeCarte, "Recharger une carte");
        }

        private void IbtnExportCarteCarb_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExp = new ToolTip();
            ToolTipBtnExp.AutoPopDelay = 5000;
            ToolTipBtnExp.InitialDelay = 1000;
            ToolTipBtnExp.ReshowDelay = 500;
            ToolTipBtnExp.ShowAlways = true;
            ToolTipBtnExp.SetToolTip(this.IbtnExportCarteCarb, "Export");
        }

        private void DgvCarteCarb_DoubleClick(object sender, EventArgs e)
        {
            displayCardEnergy();
        }

        private void displayCardEnergy()
        {
            FormModifyCarteCarburant formEditCardEnergy = new FormModifyCarteCarburant();
            formEditCardEnergy.TxtCodeCardMod.Text = this.DgvCarteCarb.CurrentRow.Cells[0].Value?.ToString();
            formEditCardEnergy.TxtNumCardMod.Text = this.DgvCarteCarb.CurrentRow.Cells[1].Value?.ToString();
            formEditCardEnergy.TxtSoldeCardMod.Text = this.DgvCarteCarb.CurrentRow.Cells[2].Value?.ToString();
            formEditCardEnergy.TxtStationCardMod.Text = this.DgvCarteCarb.CurrentRow.Cells[3].Value?.ToString();
            formEditCardEnergy.CbxTypeCardMod.Text = this.DgvCarteCarb.CurrentRow.Cells[4].Value?.ToString();
            formEditCardEnergy.ShowDialog();
        }

        private void IbtnExportCarteCarb_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DgvCarteCarb.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvCarteCarb.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DgvCarteCarb.Rows.Count; i++)
            {
                for (int j = 0; j < DgvCarteCarb.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvCarteCarb.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeCarteCarburant";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
