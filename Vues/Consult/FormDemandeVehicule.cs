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
    public partial class FormDemandeVehicule : Form
    {
        public FormDemandeVehicule()
        {
            InitializeComponent();
        }

        private void dgvDemandeVehi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDemandeVehi.Columns[e.ColumnIndex].Name == "consulterDemandeVehi")
            {
                //Form CreateMvt = new FormCreateMouvement();
                //CreateMvt.ShowDialog();
                FormModifyMouvement FormModif = new FormModifyMouvement();
                DataGridViewCheckBoxCell checkingVerrous = this.dgvDemandeVehi.CurrentRow.Cells["CHECKVEROUS_VALMVT"] as DataGridViewCheckBoxCell;

                if ((FormConnectionUser.rolesUser.Equals("Gestionnaire") || FormConnectionUser.rolesUser.Equals("Administrateur")) && Convert.ToBoolean(checkingVerrous.Value) == true)
                {
                    //MessageBox.Show("Test niveau 1");
                    FormModif.txtValMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_VALMVT"].Value?.ToString();
                    FormModif.DateExecutionMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATEEXECUTION"].Value?.ToString();
                    FormModif.DateDepartSouhMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATEDEPARTSOUHAITE_MVTS"].Value?.ToString();
                    FormModif.DateRetouProbMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATERETOURPROBABLE"].Value?.ToString();
                    FormModif.DateRetouReelMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATERETOURREEL"].Value?.ToString();
                    FormModif.TimeStartMvtModi.Text = this.dgvDemandeVehi.CurrentRow.Cells["TIMESTART_MVTS"].Value?.ToString();
                    FormModif.TimeEndMvtModi.Text = this.dgvDemandeVehi.CurrentRow.Cells["TIMEEND_MVTS"].Value?.ToString();
                    FormModif.CbxVehiculeMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["IMMATRICULATION_VEHICULE"].Value?.ToString();
                    FormModif.CbxLieuMvtsMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["LIEU_MVTS"].Value?.ToString();
                    FormModif.CbxDemandeurMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_PERS"].Value?.ToString();
                    FormModif.TxtServiceMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_SERV"].Value?.ToString();
                    FormModif.TxtDirMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_DIR"].Value?.ToString();
                    FormModif.cbxConducteurMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["CONDUCTEUR_MVTS"].Value?.ToString();
                    FormModif.RtbxNoteMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["NOTE_MVTS"].Value?.ToString();
                    FormModif.TbxCodMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["CODE_MVTS"].Value?.ToString();
                    FormModif.CbxStatutMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["STATUT_MVTS"].Value?.ToString();
                    FormModif.cbxConducteurMod.Enabled = true;
                    FormModif.CbxVehiculeMod.Enabled = true;
                    FormModif.ShowDialog();
                    //if (verrousFormMvt == 1)
                    //{
                    //    FormModif.Enabled = true;

                    //}

                }
                else if ((!FormConnectionUser.rolesUser.Equals("Gestionnaire") || !FormConnectionUser.rolesUser.Equals("Administrateur")) && Convert.ToBoolean(checkingVerrous.Value) == true)
                {
                    // Recupérer les données dans le formulaire
                    FormModif.txtValMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_VALMVT"].Value?.ToString();
                    FormModif.DateExecutionMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATEEXECUTION"].Value?.ToString();
                    FormModif.DateDepartSouhMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATEDEPARTSOUHAITE_MVTS"].Value?.ToString();
                    FormModif.DateRetouProbMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATERETOURPROBABLE"].Value?.ToString();
                    FormModif.DateRetouReelMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATERETOURREEL"].Value?.ToString();
                    FormModif.TimeStartMvtModi.Text = this.dgvDemandeVehi.CurrentRow.Cells["TIMESTART_MVTS"].Value?.ToString();
                    FormModif.TimeEndMvtModi.Text = this.dgvDemandeVehi.CurrentRow.Cells["TIMEEND_MVTS"].Value?.ToString();
                    FormModif.CbxVehiculeMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["IMMATRICULATION_VEHICULE"].Value?.ToString();
                    FormModif.CbxLieuMvtsMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["LIEU_MVTS"].Value?.ToString();
                    FormModif.CbxDemandeurMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_PERS"].Value?.ToString();
                    FormModif.TxtServiceMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_SERV"].Value?.ToString();
                    FormModif.TxtDirMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_DIR"].Value?.ToString();
                    FormModif.cbxConducteurMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["CONDUCTEUR_MVTS"].Value?.ToString();
                    FormModif.RtbxNoteMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["NOTE_MVTS"].Value?.ToString();
                    FormModif.TbxCodMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["CODE_MVTS"].Value?.ToString();
                    FormModif.CbxStatutMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["STATUT_MVTS"].Value?.ToString();

                    // Mettre le formulaire en mode lecture
                    FormModif.cbxConducteurMod.Enabled = false;
                    FormModif.CbxVehiculeMod.Enabled = false;
                    FormModif.txtValMvtMod.Enabled = false;
                    FormModif.TxtDirMvtMod.Enabled = false;
                    FormModif.TxtServiceMvtMod.Enabled = false;
                    FormModif.CbxDemandeurMvtMod.Enabled = false;
                    FormModif.CbxLieuMvtsMod.Enabled = false;
                    FormModif.CbxStatutMvtMod.Enabled = false;
                    FormModif.TimeEndMvtModi.Enabled = false;
                    FormModif.TimeStartMvtModi.Enabled = false;
                    FormModif.DateDepartSouhMvtMod.Enabled = false;
                    FormModif.DateRetouProbMvtMod.Enabled = false;
                    FormModif.DateRetouReelMod.Enabled = false;
                    FormModif.DateExecutionMod.Enabled = false;
                    FormModif.btnChoiceStatutCarMod.Enabled = false;
                    FormModif.RtbxNoteMvtMod.Enabled = false;

                    FormModif.ShowDialog();

                }
                else
                {
                    FormModif.txtValMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_VALMVT"].Value?.ToString();
                    FormModif.DateExecutionMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATEEXECUTION"].Value?.ToString();
                    FormModif.DateDepartSouhMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATEDEPARTSOUHAITE_MVTS"].Value?.ToString();
                    FormModif.DateRetouProbMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATERETOURPROBABLE"].Value?.ToString();
                    FormModif.DateRetouReelMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DATERETOURREEL"].Value?.ToString();
                    FormModif.TimeStartMvtModi.Text = this.dgvDemandeVehi.CurrentRow.Cells["TIMESTART_MVTS"].Value?.ToString();
                    FormModif.TimeEndMvtModi.Text = this.dgvDemandeVehi.CurrentRow.Cells["TIMEEND_MVTS"].Value?.ToString();
                    FormModif.CbxVehiculeMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["IMMATRICULATION_VEHICULE"].Value?.ToString();
                    FormModif.CbxLieuMvtsMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["LIEU_MVTS"].Value?.ToString();
                    FormModif.CbxDemandeurMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_PERS"].Value?.ToString();
                    FormModif.TxtServiceMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_SERV"].Value?.ToString();
                    FormModif.TxtDirMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["DESCRIPTION_DIR"].Value?.ToString();
                    FormModif.cbxConducteurMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["CONDUCTEUR_MVTS"].Value?.ToString();
                    FormModif.RtbxNoteMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["NOTE_MVTS"].Value?.ToString();
                    FormModif.TbxCodMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["CODE_MVTS"].Value?.ToString();
                    FormModif.CbxStatutMvtMod.Text = this.dgvDemandeVehi.CurrentRow.Cells["STATUT_MVTS"].Value?.ToString();
                    FormModif.cbxConducteurMod.Enabled = false;
                    FormModif.CbxVehiculeMod.Enabled = false;
                    FormModif.ShowDialog();

                }
            }
        }
    }
}
