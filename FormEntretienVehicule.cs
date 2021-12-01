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
    public partial class FormEntretienVehicule : Form
    {
        private SqlDataAdapter SqlAda;
        public FormEntretienVehicule()
        {
            InitializeComponent();
        }

        private void iconBtnCloseFormEntretien_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateEntretien_Click(object sender, EventArgs e)
        {
            Form FormEntretien = new FormCreateEntretien();
            FormEntretien.ShowDialog();
        }

        private void BtnExportCarEntretien_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnSearchFormEntretien_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using(var Cmd = Conn.cn.CreateCommand())
                        {
                            Cmd.CommandText = "SELECT ID_MAINT,CODE_MAINT,STATUT_MAINT,VEHICULE.IMMATRICULATION_VEHICULE,PRIX_MAINT,DATE_MAINT,TYPE_MAINT,STATTION_MAINT,NOTE_MAINT,DATECREATE_MAINT FROM MAINTENANCE INNER JOIN VEHICULE ON VEHICULE.ID_VEHICULE=MAINTENANCE.ID_VEHICULE";
                            SqlAda = new SqlDataAdapter(Cmd);
                            DataSet Ds = new DataSet();
                            SqlAda.Fill(Ds);

                            // Fill DataGridView
                            DgvEntretien.AutoGenerateColumns = false;
                            DgvEntretien.DataSource = Ds.Tables[0];
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvEntretien_DoubleClick(object sender, EventArgs e)
        {
            FormModifierEntretien ModifierEntretien = new FormModifierEntretien();
            ModifierEntretien.TxtCodeModiEntretien.Text = this.DgvEntretien.CurrentRow.Cells[1].Value?.ToString();
            ModifierEntretien.CbxStatutMaintEntretienMod.Text = this.DgvEntretien.CurrentRow.Cells[2].Value?.ToString();
            ModifierEntretien.CbxCarEntretienMod.Text = this.DgvEntretien.CurrentRow.Cells[3].Value?.ToString();
            ModifierEntretien.CbxGarageModiEntretien.Text = this.DgvEntretien.CurrentRow.Cells[4].Value?.ToString();
            ModifierEntretien.TxtMontantEntretienMod.Text = this.DgvEntretien.CurrentRow.Cells[5].Value?.ToString();
            ModifierEntretien.DatePickerCreateEntretienMod.Text = this.DgvEntretien.CurrentRow.Cells[6].Value?.ToString();
            ModifierEntretien.CbxTypeEntretienEntretienMod.Text = this.DgvEntretien.CurrentRow.Cells[7].Value?.ToString();
            ModifierEntretien.TxtStationEntretienMod.Text = this.DgvEntretien.CurrentRow.Cells[8].Value?.ToString();
            ModifierEntretien.RtxtNotesModiEntretien.Text = this.DgvEntretien.CurrentRow.Cells[9].Value?.ToString();
            ModifierEntretien.ShowDialog();
        }
    }
}
