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
    public partial class FormMainMouvement : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        public FormMainMouvement()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormMvt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnRegisterMvt_Click(object sender, EventArgs e)
        {
            Form CreateMouvement = new FormCreateMouvement();
            CreateMouvement.ShowDialog();
        }

        private void IbtnSearchMvt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
             //   if (string.IsNullOrEmpty(TbxSearchMvt.Text)) { }
              //  else 
               // {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS LEFT OUTER JOIN VEHICULE ON MOUVEMENTS.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON MOUVEMENTS.ID_PERS=PERSONNELS.ID_PERS", Conn.cn);
                            //SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", string.Format("%{0}%", TbxSearchMvt.Text));
                           // SqlCmd.Parameters.AddWithValue("@CARTE_GRISE_VEHICULE", string.Format("%{0}%", TbxSearchMvt.Text));
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            // Fill DataGridView
                            DataGridViewMvt.AutoGenerateColumns = false;
                            DataGridViewMvt.DataSource = Tb.Tables[0];
                        }
                    }
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewMvt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyMouvement FormModif = new FormModifyMouvement();
            FormModif.CbxStatutMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[1].Value?.ToString();
            FormModif.TbxCodMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[2].Value?.ToString();
            FormModif.CbxVehiculeMod.Text = this.DataGridViewMvt.CurrentRow.Cells[3].Value?.ToString();
            FormModif.TbxDescriptionMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[4].Value?.ToString();
            FormModif.CbxLieuMvtsMod.Text = this.DataGridViewMvt.CurrentRow.Cells[5].Value?.ToString();
            FormModif.CbxConducMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[6].Value?.ToString();
            FormModif.TbxKilometreMvtAvantMod.Text = this.DataGridViewMvt.CurrentRow.Cells[7].Value?.ToString();
            FormModif.TbxKilometreMvtApresMod.Text = this.DataGridViewMvt.CurrentRow.Cells[8].Value?.ToString();
            FormModif.DateDepartMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[9].Value?.ToString();
            FormModif.DateArriveeMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[10].Value?.ToString();
            FormModif.RtbxNoteMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[11].Value?.ToString();
            FormModif.ShowDialog();
        }
    }
}
