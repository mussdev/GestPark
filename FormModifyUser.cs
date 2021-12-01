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
    public partial class FormModifyUser : Form
    {
        private SqlCommand SqlCmd;
       FormUtilisateur User = new FormUtilisateur();
        public FormModifyUser()
        {
            InitializeComponent();
        }

        private void IbtnValideUserEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDescriptionUserEdit.Text))
            {
                if (!string.IsNullOrEmpty(TxtUserNameEdit.Text))
                {                   
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            try
                            {
                                //MessageBox.Show(CbxActifUser.Checked.ToString());
                                DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    // Guid IdUserEdit = Guid.Parse(TxtIdUser.Text);
                                    SqlCmd = new SqlCommand("UPDATE PSEUDO_USERS=@PSEUDO_USERS,DESCRIPTION_USER=@DESCRIPTION_USER,ACTIF=@ACTIF,EMAIL_USERS=@EMAIL_USERS,TEL_USERS=@TEL_USERS FROM UTILISATEURS WHERE ID_USER='" + TxtUserNameEdit.Text + "'", Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("@PSEUDO_USERS", TxtUserNameEdit);
                                    SqlCmd.Parameters.AddWithValue("@ACTIF", UserTestStatut());
                                    SqlCmd.Parameters.AddWithValue("@EMAIL_USERS", TxtMailUserEdit.Text);
                                    SqlCmd.Parameters.AddWithValue("@TEL_USERS", TxtTelUserEdit.Text);
                                    SqlCmd.ExecuteNonQuery();
                                    MessageBox.Show("Enregistré avec succès");
                                    this.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                  
                }
                else
                {
                    MessageBox.Show("Saisir le nom utilisateur !!!");
                }
            }
            else
            {
                MessageBox.Show("Saisir le nom et le prénom de l'utilisateur !!!");
            }
        }

        private string UserTestStatut()
        {
            if(CbxActifUserEdit.Checked == true)
            {
                return "Actif";
            }
            else
                return "Inactif";
        }

        private void BtnInitializePasswordUser_Click(object sender, EventArgs e)
        {
            FormInitializePassword FormInitPassword = new FormInitializePassword();
            FormInitPassword.ShowDialog();
        }
    }
}
