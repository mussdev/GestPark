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
    public partial class FormMainPanneCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormMainPanneCar()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormPanCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnCreatePanCar_Click(object sender, EventArgs e)
        {
            FormCreatePanneCar CreatePanneCar = new FormCreatePanneCar();
            CreatePanneCar.ShowDialog();
        }

        private void IbtnSearchPanCar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT PANNE.ID_PAN,PANNE.CODE_PAN,VEHICULE.IMMATRICULATION_VEHICULE AS ImmatCar,PANNE.ETAT_PAN,PANNE.DESCRIPTION_PAN,PANNE.NOTE_PAN,PANNE.INFOS_PAN,PANNE.DATE_PAN,PANNE.DATECREATE_PAN,PANNE.USERCREATE_PAN FROM PANNE LEFT OUTER JOIN VEHICULE ON PANNE.ID_VEHICULE=VEHICULE.ID_VEHICULE", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        DataGridViewCarPan.AutoGenerateColumns = false;
                        DataGridViewCarPan.DataSource = Ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewCarPan_DoubleClick(object sender, EventArgs e)
        {
            FormModifyPanCar ModifyPanCar = new FormModifyPanCar();
            ModifyPanCar.TxtCodeModifyPanCar.Text = this.DataGridViewCarPan.CurrentRow.Cells[1].Value?.ToString();
            ModifyPanCar.CbxVehiModifyPanCar.Text = this.DataGridViewCarPan.CurrentRow.Cells[2].Value?.ToString();
            ModifyPanCar.CbxEtatModifyPanCar.Text = this.DataGridViewCarPan.CurrentRow.Cells[3].Value?.ToString();
            ModifyPanCar.TxtDescriptionModifyPanCar.Text = this.DataGridViewCarPan.CurrentRow.Cells[4].Value?.ToString();
            ModifyPanCar.RtxtNoteModifyPanCar.Text = this.DataGridViewCarPan.CurrentRow.Cells[5].Value?.ToString();
            ModifyPanCar.RichTxtoutheInfosModifyPanCar.Text = this.DataGridViewCarPan.CurrentRow.Cells[6].Value?.ToString();
            ModifyPanCar.DateRegisterModifyPanCar.Text = this.DataGridViewCarPan.CurrentRow.Cells[7].Value?.ToString();
            ModifyPanCar.ShowDialog();
        }
    }
}
