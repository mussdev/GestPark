using GestPark.Vues.CreateItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark.Vues.Consult
{
    public partial class FormMainMission : Form
    {
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
                DemandeMission.checkBoxAnnulDirMission.Enabled = false;
                DemandeMission.checkBoxAnnulDirDepMission.Enabled = false;
                DemandeMission.checkBoxSignAgentSupMission.Enabled = false;
                DemandeMission.checkBoxSignDarhMission.Enabled = false;
                DemandeMission.checkBoxSignDirMission.Enabled = false;
                DemandeMission.checkBoxSignDirecDepMission.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSupMission.Enabled = false;
                DemandeMission.ShowDialog();
            }else if (FormConnectionUser.rolesUser.Equals("Gestionnaire"))
            {
                DemandeMission.panMoyenDeplacement.Enabled = true;
                DemandeMission.panSignture.Enabled = false;
                DemandeMission.checkBoxSignAgentMission.Enabled = false;
                DemandeMission.checkBoxAnnulDarhMission.Enabled = false;
                DemandeMission.checkBoxAnnulDirMission.Enabled = false;
                DemandeMission.checkBoxAnnulDirDepMission.Enabled = false;
                DemandeMission.checkBoxSignAgentSupMission.Enabled = false;
                DemandeMission.checkBoxSignDarhMission.Enabled = false;
                DemandeMission.checkBoxSignDirMission.Enabled = false;
                DemandeMission.checkBoxSignDirecDepMission.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSupMission.Enabled = false;
                DemandeMission.ShowDialog();
            }else if (FormConnectionUser.rolesUser.Equals("DARH"))
            {
                DemandeMission.panMoyenDeplacement.Enabled = true;
                DemandeMission.panSignture.Enabled = true;
                DemandeMission.checkBoxSignAgentMission.Enabled = false;
                DemandeMission.checkBoxAnnulDarhMission.Enabled = true;
                DemandeMission.checkBoxAnnulDirMission.Enabled = true;
                DemandeMission.checkBoxAnnulDirDepMission.Enabled = false;
                DemandeMission.checkBoxSignAgentSupMission.Enabled = false;
                DemandeMission.checkBoxSignDarhMission.Enabled = true;
                DemandeMission.checkBoxSignDirMission.Enabled = true;
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

    }
}
