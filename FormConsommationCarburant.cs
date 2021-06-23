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
                        SqlCmd = new SqlCommand("SELECT PROVISION.ID_PROV,PROVISION.CODE_PROV,PROVISION.DESCRIPTION_PROV,PROVISION.MONTANT_PROV,PROVISION.QTELITRE_PROV,VEHICULE.IMMATRICULATION_VEHICULE AS IMMAT,PROVISION.STATION_PROV,TYPECONSOMMATION.DESCRIPTION_TYPCONSO AS TYPCONSO,PROVISION.NOTE_PROV,PROVISION.DATE_PROV,PROVISION.DATECREATE_PROV FROM PROVISION LEFT OUTER JOIN VEHICULE ON PROVISION.ID_VEHICULE=VEHICULE.ID_VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO=VEHICULE.ID_TYPCONSO", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
