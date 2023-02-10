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
                DemandeMission.checkBoxSignAgent.Enabled = true;
                DemandeMission.checkBoxAnnulDarh.Enabled = false;
                DemandeMission.checkBoxAnnulDir.Enabled = false;
                DemandeMission.checkBoxAnnulDirDep.Enabled = false;
                DemandeMission.checkBoxSignAgentSup.Enabled = false;
                DemandeMission.checkBoxSignDarh.Enabled = false;
                DemandeMission.checkBoxSignDir.Enabled = false;
                DemandeMission.checkBoxSignDirecDep.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSup.Enabled = false;
                DemandeMission.ShowDialog();
            }else if (FormConnectionUser.rolesUser.Equals("Gestionnaire"))
            {
                DemandeMission.panMoyenDeplacement.Enabled = true;
                DemandeMission.panSignture.Enabled = false;
                DemandeMission.checkBoxSignAgent.Enabled = false;
                DemandeMission.checkBoxAnnulDarh.Enabled = false;
                DemandeMission.checkBoxAnnulDir.Enabled = false;
                DemandeMission.checkBoxAnnulDirDep.Enabled = false;
                DemandeMission.checkBoxSignAgentSup.Enabled = false;
                DemandeMission.checkBoxSignDarh.Enabled = false;
                DemandeMission.checkBoxSignDir.Enabled = false;
                DemandeMission.checkBoxSignDirecDep.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSup.Enabled = false;
                DemandeMission.ShowDialog();
            }else if (FormConnectionUser.rolesUser.Equals("DARH"))
            {
                DemandeMission.panMoyenDeplacement.Enabled = true;
                DemandeMission.panSignture.Enabled = true;
                DemandeMission.checkBoxSignAgent.Enabled = false;
                DemandeMission.checkBoxAnnulDarh.Enabled = true;
                DemandeMission.checkBoxAnnulDir.Enabled = true;
                DemandeMission.checkBoxAnnulDirDep.Enabled = false;
                DemandeMission.checkBoxSignAgentSup.Enabled = false;
                DemandeMission.checkBoxSignDarh.Enabled = true;
                DemandeMission.checkBoxSignDir.Enabled = true;
                DemandeMission.checkBoxSignDirecDep.Enabled = false;
                DemandeMission.checkBoxAnnulAgentSup.Enabled = false;
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
