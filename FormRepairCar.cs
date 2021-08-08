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
    public partial class FormRepairCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormRepairCar()
        {
            InitializeComponent();
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
                        SqlCmd = new SqlCommand("SELECT* FROM REPARATION LEFT OUTER JOIN PANNE ON REPARATION.ID_PAN=PANNE.ID_PAN LEFT OUTER JOIN GARAGE ON PANNE.ID_GARAGE=GARAGE.ID_GARAGE LEFT OUTER JOIN VEHICULE ON PANNE.ID_VEHICULE=VEHICULE.ID_VEHICULE", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        DgvCarRepair.AutoGenerateColumns = false;
                        DgvCarRepair.DataSource = Ds.Tables[0];
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
