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
    public partial class FormMainCleanCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataAdapter MyReader;
        public FormMainCleanCar()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormCleanCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnCreateCleanCar_Click(object sender, EventArgs e)
        {
            FormCreateWatchCar FanWatch = new FormCreateWatchCar();
            FanWatch.ShowDialog();
        }

        private void IbtnSearchWatchCar_Click(object sender, EventArgs e)
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
                        SqlCmd = new SqlCommand("SELECT ID_WTCH,CODE_WTCH,IMMATRICULATION_VEHICULE As VehMatriWatch,CODE_VEHICULE,MONTANT_WTCH,LIEU_WTCH,NOTE_WTCH,DATECREATE_WTCH,DATEREGISTER,USERCREATE_WTCH,DATEMODIFY FROM LAVAGE LEFT OUTER JOIN VEHICULE ON LAVAGE.ID_WTCH=VEHICULE.ID_VEHICULE", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet Tb = new DataSet();
                        SqlAda.Fill(Tb);

                        // Fill DataGridView
                        Dgv_WatchCar.AutoGenerateColumns = false;
                        Dgv_WatchCar.DataSource = Tb.Tables[0];
                    }
                }
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_WatchCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyWatchCar ModiFyWatchCar = new FormModifyWatchCar();

            ModiFyWatchCar.TbxCodeWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells[1].Value?.ToString();
            ModiFyWatchCar.CbxVehiculeWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells[2].Value?.ToString();
            ModiFyWatchCar.TxtBMontantModi.Text = this.Dgv_WatchCar.CurrentRow.Cells[3].Value?.ToString();
            ModiFyWatchCar.TxtBLieuWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells[4].Value?.ToString();
            ModiFyWatchCar.RbtxNoteWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells[5].Value?.ToString();
            ModiFyWatchCar.DatePikerWatchCarModi.Text = this.Dgv_WatchCar.CurrentRow.Cells[6].Value?.ToString();
            
            ModiFyWatchCar.ShowDialog();
        }
    }
}
