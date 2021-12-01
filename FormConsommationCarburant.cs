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
        public FormConsommationCarburant()
        {
            InitializeComponent();
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
                        SqlCmd = new SqlCommand("SELECT PROVISION.ID_PROV,PROVISION.CODE_PROV,PROVISION.DESCRIPTION_PROV,PROVISION.KILO_AVANT,PROVISION.KILOMETRAGE_EFFECT_HEBDO_VEHICULE,PROVISION.STATUT_PROV,VEHICULE.IMMATRICULATION_VEHICULE AS IMMAT,TYPECONSOMMATION.DESCRIPTION_TYPCONSO AS TYPCONSO,PROVISION.NOTE_PROV,PROVISION.DATE_PROV,PROVISION.DATECREATE_PROV FROM PROVISION LEFT OUTER JOIN VEHICULE ON PROVISION.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO=VEHICULE.ID_TYPCONSO", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        DataGridViewConsoCar.AutoGenerateColumns = false;
                        DataGridViewConsoCar.DataSource = Ds.Tables[0];
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewConsoCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyConsoCarbCar modifyConsoCarbCar = new FormModifyConsoCarbCar();
            modifyConsoCarbCar.TxtCodeConsoCarbModi.Text = this.DataGridViewConsoCar.CurrentRow.Cells[1].Value?.ToString();
            modifyConsoCarbCar.TxtDescriptionConsoCarbModi.Text = this.DataGridViewConsoCar.CurrentRow.Cells[2].Value?.ToString();
            //modifyConsoCarbCar.TxtLiterConsoCarbModi.Text = this.DataGridViewConsoCar.CurrentRow.Cells[3].Value?.ToString();
            modifyConsoCarbCar.CbxVehiConsoCabModi.Text = this.DataGridViewConsoCar.CurrentRow.Cells[3].Value?.ToString();
           // modifyConsoCarbCar.Tx.Text = this.DataGridViewConsoCar.CurrentRow.Cells[6].Value?.ToString();
            modifyConsoCarbCar.TxtTypConsoCarbModi.Text = this.DataGridViewConsoCar.CurrentRow.Cells[4].Value?.ToString();
            modifyConsoCarbCar.TxtKiloAvantCarMod.Text = this.DataGridViewConsoCar.CurrentRow.Cells[5].Value?.ToString();
            modifyConsoCarbCar.TxtKilometrageEffectHebdo.Text = this.DataGridViewConsoCar.CurrentRow.Cells[6].Value?.ToString();
            modifyConsoCarbCar.RtxtNoteConsoCarbModi.Text = this.DataGridViewConsoCar.CurrentRow.Cells[7].Value?.ToString();
            modifyConsoCarbCar.CbxStatutCarbMod.Text = this.DataGridViewConsoCar.CurrentRow.Cells[8].Value?.ToString();
            modifyConsoCarbCar.DateRegisterConsoCarbModi.Text = this.DataGridViewConsoCar.CurrentRow.Cells[9].Value?.ToString();
            modifyConsoCarbCar.ShowDialog();
        }
    }
}
