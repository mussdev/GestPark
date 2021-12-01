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
    public partial class FormMainPerson : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
        public FormMainPerson()
        {
            InitializeComponent();
        }

        private void iconBtnCreatePers_Click(object sender, EventArgs e)
        {
            Form FormCreatePers = new FormCreatePersonne();
            FormCreatePers.ShowDialog();
        }

        private void iconBtnCloseFormPers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnSearchPers_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        sqlCmd = new SqlCommand("SELECT*FROM PERSONNELS WHERE NOM_PERS=@NOM_PERS OR NOM_PERS LIKE @NOM_PERS OR PRENOM_PERS LIKE @PRENOM_PERS ", Conn.cn);
                        sqlCmd.Parameters.Add("@NOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        sqlCmd.Parameters.Add("@PRENOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        DataTable dtbl = new DataTable();
                        sqlAda.Fill(dtbl);

                        // Fill DataGridView
                        DgvPerson.AutoGenerateColumns = false;
                        DgvPerson.DataSource = dtbl;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifierPerson ModifierPers = new FormModifierPerson();
            ModifierPers.TxtCodePersMod.Text = this.DgvPerson.CurrentRow.Cells[1].Value?.ToString() ;
            ModifierPers.TxtNomPersMod.Text = this.DgvPerson.CurrentRow.Cells[2].Value?.ToString();
            ModifierPers.TxtPrenPersMod.Text = this.DgvPerson.CurrentRow.Cells[3].Value?.ToString();
            ModifierPers.DpDateNaissPersMod.Text = this.DgvPerson.CurrentRow.Cells[4].Value?.ToString();
            ModifierPers.CbxLieuNaissPersMod.Text = this.DgvPerson.CurrentRow.Cells[5].Value?.ToString();
            ModifierPers.TxtTelPersMod.Text = this.DgvPerson.CurrentRow.Cells[6].Value?.ToString();
            ModifierPers.TxtNumPermisPersMod.Text = this.DgvPerson.CurrentRow.Cells[7].Value?.ToString();
            ModifierPers.CbxTypPiecPersMod.Text = this.DgvPerson.CurrentRow.Cells[8].Value?.ToString();
            ModifierPers.TxtNumPieceIdentPersMod.Text = this.DgvPerson.CurrentRow.Cells[9].Value?.ToString();
            ModifierPers.CbxTypPersMod.Text = this.DgvPerson.CurrentRow.Cells[10].Value?.ToString();
            ModifierPers.CbxCountryPersMod.Text = this.DgvPerson.CurrentRow.Cells[11].Value?.ToString();
            ModifierPers.CbxTownPersMod.Text = this.DgvPerson.CurrentRow.Cells[12].Value?.ToString();
            ModifierPers.TxtAdressPersMod.Text = this.DgvPerson.CurrentRow.Cells[13].Value?.ToString();
            ModifierPers.TxtCodePostalPersMod.Text = this.DgvPerson.CurrentRow.Cells[14].Value?.ToString();
            ModifierPers.DtKDateCreateMod.Text = this.DgvPerson.CurrentRow.Cells[15].Value?.ToString();
            ModifierPers.RtxtNotePersMod.Text = this.DgvPerson.CurrentRow.Cells[16].Value?.ToString();
            
            ModifierPers.ShowDialog();
        }
    }
}
