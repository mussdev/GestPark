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

namespace GestPark.Vues.CreateItems
{
    public partial class FormCreateRoles : Form
    {
        private SqlDataAdapter SqlAda;
        public FormCreateRoles()
        {
            InitializeComponent();
        }

        private void btnValideRole_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if(!string.IsNullOrEmpty(txtCodeRole.Text) && !string.IsNullOrEmpty(txtDescriptionRole.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister cette habilitation ?", "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        if (Conn.IsConnection)
                        {
                            using(var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "INSERT INTO ROLES (CODE_ROLE,DESCRIPTION_ROLE,NOTE_ROLE,MODULEADMIN_ROLE,MODULEPARAM_ROLE,MODULEGESTPOOL_ROLE,MODULESUIVIVEHI_ROLE,MODULETABLBORD_ROLE,MODULEGESTMISSION_ROLE,DATECREATE_ROLE) VALUES (@CODE_ROLE,@DESCRIPTION_ROLE,@NOTE_ROLE,@MODULEADMIN_ROLE,@MODULEPARAM_ROLE,@MODULEGESTPOOL_ROLE,@MODULESUIVIVEHI_ROLE,@MODULETABLBORD_ROLE,@MODULEGESTMISSION_ROLE,GETDATE())";
                                Cmd.Parameters.AddWithValue("@CODE_ROLE",txtCodeRole.Text);
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_ROLE",txtDescriptionRole.Text);
                                Cmd.Parameters.AddWithValue("@NOTE_ROLE",RtxtNoteRole.Text);
                                Cmd.Parameters.AddWithValue("@MODULEADMIN_ROLE", chkAdminRol.Checked);
                                Cmd.Parameters.AddWithValue("@MODULEPARAM_ROLE",chkParamRol.Checked);
                                Cmd.Parameters.AddWithValue("@MODULEGESTPOOL_ROLE",chkGestVehiPoolRol.Checked);
                                Cmd.Parameters.AddWithValue("@MODULESUIVIVEHI_ROLE",chkSuiviVheiRol.Checked);
                                Cmd.Parameters.AddWithValue("@MODULETABLBORD_ROLE",chkTablBordRol.Checked);
                                Cmd.Parameters.AddWithValue("@MODULEGESTMISSION_ROLE", checkGestMission.Checked);
                                Cmd.ExecuteNonQuery();
                                Cmd.Parameters.Clear();
                                ViderChamps();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veillez saisir les champs obligatoire (*)","Fleet: Gestion des erreus",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Fleet: Gestion des erreurs",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Vider les champs après insertions
        private void ViderChamps()
        {
            txtCodeRole.Clear();txtDescriptionRole.Clear();RtxtNoteRole.Clear();chkAdminRole.Checked = false;chkGestVehiPoolRole.Checked = false;chkParamRole.Checked = false;  chkSuiviVheiRole.Checked = false;   chkTablBordRole.Checked = false;    
        }
    }
}
