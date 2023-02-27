using GestPark.Vues.CreateItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark.Vues.Consult
{
    public partial class FormMainMission : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        public FormMainMission()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormMission_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnRegisterMission_Click(object sender, EventArgs e)
        {
            FormCreateDemandeMission DemandeMission = new FormCreateDemandeMission();

            if (FormConnectionUser.rolesUser.Equals("Utilisateur simple"))
            {
                DemandeMission.panMoyenDeplacement.Enabled = false;
                DemandeMission.checkBoxSignAgentMission.Enabled = true;
                DemandeMission.checkBoxAnnulDarhMission.Enabled = false;
                DemandeMission.checkBoxAnnulDGMission.Enabled = false;
                DemandeMission.checkBoxAnnulDirDepMission.Enabled = false;
                DemandeMission.checkBoxSignAgentSupMission.Enabled = false;
                DemandeMission.checkBoxSignDarhMission.Enabled = false;
                DemandeMission.checkBoxSignDGMission.Enabled = false;
                DemandeMission.checkBoxSignDirecDepMission.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSupMission.Enabled = false;
                DemandeMission.ShowDialog();
            }else if (FormConnectionUser.rolesUser.Equals("Gestionnaire"))
            {
                DemandeMission.panMoyenDeplacement.Enabled = true;
                DemandeMission.panSignture.Enabled = false;
                DemandeMission.checkBoxSignAgentMission.Enabled = false;
                DemandeMission.checkBoxAnnulDarhMission.Enabled = false;
                DemandeMission.checkBoxAnnulDGMission.Enabled = false;
                DemandeMission.checkBoxAnnulDirDepMission.Enabled = false;
                DemandeMission.checkBoxSignAgentSupMission.Enabled = false;
                DemandeMission.checkBoxSignDarhMission.Enabled = false;
                DemandeMission.checkBoxSignDGMission.Enabled = false;
                DemandeMission.checkBoxSignDirecDepMission.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSupMission.Enabled = false;
                DemandeMission.ShowDialog();
            }else if (FormConnectionUser.rolesUser.Equals("DARH"))
            {
                DemandeMission.panMoyenDeplacement.Enabled = true;
                DemandeMission.panSignture.Enabled = true;
                DemandeMission.checkBoxSignAgentMission.Enabled = false;
                DemandeMission.checkBoxAnnulDarhMission.Enabled = true;
                DemandeMission.checkBoxAnnulDGMission.Enabled = true;
                DemandeMission.checkBoxAnnulDirDepMission.Enabled = false;
                DemandeMission.checkBoxSignAgentSupMission.Enabled = false;
                DemandeMission.checkBoxSignDarhMission.Enabled = true;
                DemandeMission.checkBoxSignDGMission.Enabled = true;
                DemandeMission.checkBoxSignDirecDepMission.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSupMission.Enabled = false;
                DemandeMission.panSMG.Enabled = false;
                DemandeMission.ShowDialog();
            }
            else
            {
                DemandeMission.ShowDialog();
            }
        }

        private void BtnMissionGroupe_Click(object sender, EventArgs e)
        {
            Form MissionGroupe = new FormProjetDeMissionGroupe();
            MissionGroupe.ShowDialog();
        }

        private void BtnSearchMiss_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM MISSION AS M INNER JOIN PERSLINEMISS AS P ON M.ID_MISS=P.ID_MISS LEFT OUTER JOIN VEHICULE AS V ON M.ID_VEHI=V.ID_VEHICULE LEFT OUTER JOIN CONDUCTEURS AS COND ON COND.ID_COND=M.ID_CONDUC LEFT OUTER JOIN PERSONNELS AS PERS ON P.ID_PERS=PERS.ID_PERS ORDER BY CODE_MISS", Conn.cn);
                        //sqlCmd.Parameters.Add("@NOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        //sqlCmd.Parameters.Add("@PRENOM_PERS", string.Format("%{0}%", textBxSearchPers.Text));
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill DataGridView
                        dgvMission.AutoGenerateColumns = false;
                        dgvMission.DataSource = dtbl;

                    }
                }
                //TxtTotalPers.Text = $"Total = {DgvPerson.RowCount - 1}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
