using GestPark.Vues.CreateItems;
using GestPark.Vues.ModifierItems;
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
        FormModifierProjetMission modifierProjetMission = new FormModifierProjetMission();
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

        private void dgvMission_DoubleClick(object sender, EventArgs e)
        {
            ModifierProjetMiss();
        }

        /**
         * 
         * Methode qui affiche les informations sur la fenêtre pour une eventuelle modification
         * 
         */
        private void ModifierProjetMiss()
        {
            modifierProjetMission.TxtCodeMissionMod.Text = this.dgvMission.CurrentRow.Cells["CODE_MISS"].Value?.ToString();
            InfosDemandeur(modifierProjetMission.TxtCodeMissionMod.Text);
            modifierProjetMission.cbxDemandeurMissionMod.Text = this.dgvMission.CurrentRow.Cells["DESCRIPTION_PERS"].Value?.ToString();
            modifierProjetMission.TxtDestinationMissionMod.Text = this.dgvMission.CurrentRow.Cells["DESTINATION_MISS"].Value?.ToString();
            modifierProjetMission.cbxImmatVehicule_missMod.Text = this.dgvMission.CurrentRow.Cells["IMMATRICULATION_VEHICULE"].Value?.ToString();
            modifierProjetMission.cbxConducteurMissionMod.Text = this.dgvMission.CurrentRow.Cells["DESCRIPTION_COND"].Value?.ToString();
            modifierProjetMission.TxtAutreMoyenDeplacMissionMod.Text = this.dgvMission.CurrentRow.Cells["AUTRE_MOYEN_DEPLAC"].Value?.ToString();
            modifierProjetMission.RtxtObjetMissionMod.Text = this.dgvMission.CurrentRow.Cells["OBJET_MISS"].Value?.ToString();
            modifierProjetMission.ChkAvionMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["MOYEN_DEPLA_AVION_MISS"].Value);
            modifierProjetMission.ChkVehiPersoMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["MOYEN_DEPLA_VEHI_PERS_MISS"].Value);
            modifierProjetMission.ChkVehiSocMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["MOYEN_DEPLA_VEHI_SOC_MISS"].Value);
            modifierProjetMission.checkBoxSignAgentMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["SIGN_DEMANDEUR_MISS"].Value);
            modifierProjetMission.checkBoxSignAgentSupMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["SIGN_CHEF_SERV_MISS"].Value);
            modifierProjetMission.checkBoxAnnulAgentSupMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["ANNULE_SUP_HIERACHIQ"].Value);
            modifierProjetMission.checkBoxSignDirecDepMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["SIGN_DIR_MISS"].Value);
            modifierProjetMission.checkBoxAnnulDirDepMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["ANNULE_DIR_DEPART"].Value);
            modifierProjetMission.checkBoxSignDarhMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["SIGN_DARH_MISS"].Value);
            modifierProjetMission.checkBoxAnnulDarhMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["ANNULE_DARH"].Value);
            modifierProjetMission.checkBoxSignDGMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["SIGN_DG_MISS"].Value);
            modifierProjetMission.checkBoxAnnulDGMissionMod.Checked = Convert.ToBoolean(this.dgvMission.CurrentRow.Cells["ANNULE_DG"].Value);
            modifierProjetMission.DateRegisterMissionMod.Text = this.dgvMission.CurrentRow.Cells["DATEREGISTER_MISS"].Value?.ToString();
            modifierProjetMission.DateDebutMissionMod.Text = this.dgvMission.CurrentRow.Cells["DATE_DEBUT_MISS"].Value?.ToString();
            modifierProjetMission.DateFinMissionMod.Text = this.dgvMission.CurrentRow.Cells["DATE_FIN_MISS"].Value?.ToString();
            modifierProjetMission.ShowDialog();
        }


        /**
         * Methode qui renvoie les informations sur la personne qui fait la demande de mission
         */
        private void InfosDemandeur(String CodeMiss) {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            Cmd.CommandText = "SELECT P.NOM_PERS, P.PRENOM_PERS, P.FONCTION_PERS FROM PERSONNELS AS P INNER JOIN PERSLINEMISS AS PLINE ON P.ID_PERS=PLINE.ID_PERS INNER JOIN MISSION AS M ON M.ID_MISS=PLINE.ID_MISS WHERE M.CODE_MISS='"+ CodeMiss + "'";
                            MyReader = Cmd.ExecuteReader();
                            
                            while(MyReader.Read())
                            {
                                modifierProjetMission.TxtNameDemandeurMod.Text = MyReader["NOM_PERS"].ToString();
                                modifierProjetMission.txtFirstNameDemandeurMod.Text = MyReader["PRENOM_PERS"].ToString();
                                modifierProjetMission.TxtFonctionDemandeurMod.Text = MyReader["FONCTION_PERS"].ToString();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Fleet: Gestion des erreurs",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
