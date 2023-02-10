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

namespace GestPark.Vues.CreateItems
{
    public partial class FormModifierRoles : Form
    {
        public FormModifierRoles()
        {
            InitializeComponent();
        }

        private void btnValideRoleMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(txtCodeRoleMod.Text) && !string.IsNullOrEmpty(txtDescriptionRoleMod.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifiactions faites sur cette habilitation ?", "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (Conn.IsConnection)
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "UPDATE ROLES SET CODE_ROLE=@CODE_ROLE,DESCRIPTION_ROLE=@DESCRIPTION_ROLE,NOTE_ROLE=@NOTE_ROLE,MODULEADMIN_ROLE=@MODULEADMIN_ROLE,MODULEPARAM_ROLE=@MODULEPARAM_ROLE,MODULEGESTPOOL_ROLE=@MODULEGESTPOOL_ROLE,MODULESUIVIVEHI_ROLE=@MODULESUIVIVEHI_ROLE,MODULETABLBORD_ROLE=@MODULETABLBORD_ROLE,MODULEGESTMISSION_ROLE=@MODULEGESTMISSION_ROLE,DATEMODIFIER_ROLE=GETDATE() WHERE ID_ROLE='" + Guid.Parse(txtIdRoles.Text)+ "'";
                                Cmd.Parameters.AddWithValue("@CODE_ROLE", txtCodeRoleMod.Text);
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_ROLE", txtDescriptionRoleMod.Text);
                                Cmd.Parameters.AddWithValue("@NOTE_ROLE", RtxtNoteRoleMod.Text);
                                Cmd.Parameters.AddWithValue("@MODULEADMIN_ROLE", chkAdminRoleMod.Checked);
                                Cmd.Parameters.AddWithValue("@MODULEPARAM_ROLE", chkParamRoleMod.Checked);
                                Cmd.Parameters.AddWithValue("@MODULEGESTPOOL_ROLE", chkGestVehiPoolRoleMod.Checked);
                                Cmd.Parameters.AddWithValue("@MODULESUIVIVEHI_ROLE", chkSuiviVheiRoleMod.Checked);
                                Cmd.Parameters.AddWithValue("@MODULETABLBORD_ROLE", chkTablBordRoleMod.Checked);
                                Cmd.Parameters.AddWithValue("@MODULEGESTMISSION_ROLE", checkBoxMissionMod.Checked);
                                Cmd.ExecuteNonQuery();
                                Cmd.Parameters.Clear();
                            }
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Veillez saisir les champs obligatoire (*)", "Fleet: Gestion des erreus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
