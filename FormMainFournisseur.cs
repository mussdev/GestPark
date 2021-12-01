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

namespace GestPark
{
    public partial class FormMainFournisseur : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        public FormMainFournisseur()
        {
            InitializeComponent();
        }


        private void iconBtnCloseFormMainFour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateFourn_Click(object sender, EventArgs e)
        {
            Form FormCreateFourn = new FormCreateFourn();
            FormCreateFourn.ShowDialog();
        }

        private void iconBtnSearchFourn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using(Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM FOURNISSEUR WHERE DESCRIPTION_FOUR LIKE @DESCRIPTION_FOUR", Conn.cn);
                        SqlCmd.Parameters.Add("@DESCRIPTION_FOUR", string.Format("%{0}%", textBoxRecheFour.Text));
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill DataGridView
                        DgvProvider.AutoGenerateColumns = false;
                        DgvProvider.DataSource = dtbl;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifierFourn EditFourn = new FormModifierFourn();
            EditFourn.TxtCodFournMod.Text = this.DgvProvider.CurrentRow.Cells[1].Value?.ToString();
            EditFourn.TxtDescripFournMod.Text = this.DgvProvider.CurrentRow.Cells[2].Value?.ToString();
            EditFourn.TxtTelFournMod.Text = this.DgvProvider.CurrentRow.Cells[3].Value?.ToString();
            EditFourn.TxtMailFournMod.Text = this.DgvProvider.CurrentRow.Cells[4].Value?.ToString();
            EditFourn.RtxtNoteFournMod.Text = this.DgvProvider.CurrentRow.Cells[5].Value?.ToString();
            EditFourn.TxtRCFournMod.Text = this.DgvProvider.CurrentRow.Cells[6].Value?.ToString();
            EditFourn.TxtCCFournMod.Text = this.DgvProvider.CurrentRow.Cells[7].Value?.ToString();
            EditFourn.CbxCountryMod.Text = this.DgvProvider.CurrentRow.Cells[8].Value?.ToString();
            EditFourn.CbxTownMod.Text = this.DgvProvider.CurrentRow.Cells[9].Value?.ToString();
            EditFourn.TxtAdressFournMod.Text = this.DgvProvider.CurrentRow.Cells[10].Value?.ToString();
            EditFourn.TxtCodPostalFournMod.Text = this.DgvProvider.CurrentRow.Cells[11].Value?.ToString();
            EditFourn.DtpRegisterFournMod.Text = this.DgvProvider.CurrentRow.Cells[12].Value?.ToString();
            EditFourn.TxtOtherFieldFournMod.Text = this.DgvProvider.CurrentRow.Cells[13].Value?.ToString();
            EditFourn.ShowDialog();
        }
    }
}
