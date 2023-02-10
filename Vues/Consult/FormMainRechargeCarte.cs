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
    public partial class FormMainRechargeCarte : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        
        public FormMainRechargeCarte()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormRecharge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddRecharge_Click(object sender, EventArgs e)
        {
            FormRechargeCarte RechCarte = new FormRechargeCarte();
            RechCarte.ShowDialog();
        }

        private void IbtnSearchRecharge_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("select * from RECHARGECARTE inner join CARDPAIEMENT on CARDPAIEMENT.ID_CARD=RECHARGECARTE.ID_CARD", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        DgvRecharge.AutoGenerateColumns = false;
                        DgvRecharge.DataSource = Ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvRecharge_DoubleClick(object sender, EventArgs e)
        {
            FormModifierRechargeCarte ModifierRechargeCarte = new FormModifierRechargeCarte();
            ModifierRechargeCarte.TxtCodeRechargMod.Text = this.DgvRecharge.CurrentRow.Cells[0].Value?.ToString();
            ModifierRechargeCarte.TxtMontantRechargMod.Text = this.DgvRecharge.CurrentRow.Cells[1].Value?.ToString();
            ModifierRechargeCarte.CbxTypeCardRechargMod.Text = this.DgvRecharge.CurrentRow.Cells[2].Value?.ToString();
            ModifierRechargeCarte.TxtNumCardRechargMod.Text = this.DgvRecharge.CurrentRow.Cells[3].Value?.ToString();
            ModifierRechargeCarte.DpkRegisterMod.Text = this.DgvRecharge.CurrentRow.Cells[4].Value?.ToString();
            ModifierRechargeCarte.ShowDialog();
        }

        private void BtnImport_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnImportRechgCard = new ToolTip();
            ToolTipBtnImportRechgCard.AutoPopDelay = 5000;
            ToolTipBtnImportRechgCard.InitialDelay = 1000;
            ToolTipBtnImportRechgCard.ReshowDelay = 500;
            ToolTipBtnImportRechgCard.ShowAlways = true;
            ToolTipBtnImportRechgCard.SetToolTip(this.BtnImport, "Importer");
        }

        private void IbtnExportRecharge_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExportRechgCard = new ToolTip();
            ToolTipBtnExportRechgCard.AutoPopDelay = 5000;
            ToolTipBtnExportRechgCard.InitialDelay = 1000;
            ToolTipBtnExportRechgCard.ReshowDelay = 500;
            ToolTipBtnExportRechgCard.ShowAlways = true;
            ToolTipBtnExportRechgCard.SetToolTip(this.IbtnExportRecharge, "Exporter");
        }

        private void BtnAddRecharge_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnExportRechgCard = new ToolTip();
            ToolTipBtnExportRechgCard.AutoPopDelay = 5000;
            ToolTipBtnExportRechgCard.InitialDelay = 1000;
            ToolTipBtnExportRechgCard.ReshowDelay = 500;
            ToolTipBtnExportRechgCard.ShowAlways = true;
            ToolTipBtnExportRechgCard.SetToolTip(this.IbtnExportRecharge, "Recharger votre carte");
        }

        private void SumAndNbrRechCard()
        {
            int Mont = 0;
            for (int i = 0; i < DgvRecharge.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(DgvRecharge.Rows[i].Cells[1].Value);
            }

            LblTotalAmountRecha.Text = $"Coût total = {Mont.ToString("### ### ### ###")} ";
            LbNbrRech.Text = $"Nbr de recharge = {DgvRecharge.RowCount - 1 }";
        }

    }
}
