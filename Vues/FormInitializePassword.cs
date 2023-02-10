using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark
{
    public partial class FormInitializePassword : Form
    {
        private SqlCommand SqlCmd;
        private string CodeUserMod;
        public FormInitializePassword()
        {
            InitializeComponent();
        }


        /* Methode pour emcrypter le mot de passe utilisateur */
        public static string EncryptData(string SimpleString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(SimpleString);
            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }
        private void btnCloseWinFormResetPassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValidPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if(!string.IsNullOrEmpty(TxtPassworInit.Text) && !string.IsNullOrEmpty(TxtConfirPasswordInit.Text))
                {
                    if(string.Equals(TxtPassworInit.Text, TxtConfirPasswordInit.Text))
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                SqlCmd = new SqlCommand("UPDATE UTILISATEURS SET MOTPASS_USERS=@MOTPASS_USERS WHERE CODE_USER='" + CodeUserMod + "'", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@MOTPASS_USERS", EncryptData(TxtPassworInit.Text));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Le mot de passe a été changé.", "GestParc: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vos mots de passes ne sont pas conformes. Veillez saisir les mots de passes uniques. !!!", "GestParc: Réinitialiser le mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veillez saisir le nouveau mot de passe ou confirmer en saisissant le même mot de passe au champ suivant !!!","GestParc: Réinitialiser le mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Réinitialiser le mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCloseFormInitPassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInitializePassword_Load(object sender, EventArgs e)
        {
            CodeUserMod = FormModifyUser.CodeUser;
        }
    }
}
