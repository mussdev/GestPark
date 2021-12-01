using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;

namespace GestPark
{
    public partial class FormCreateUser : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        
        public FormCreateUser()
        {
            InitializeComponent();
        }

        public static string EncryptData(string SimpleString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(SimpleString);
            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }

        private void IbtnValideUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDescriptionUser.Text))
            {
                if (!string.IsNullOrEmpty(TxtUserName.Text))
                {
                    if (!string.IsNullOrEmpty(TxtPasswordUser.Text))
                    {
                        if (!string.IsNullOrEmpty(TxtConfirmPassword.Text))
                        {
                            if (string.Equals(TxtPasswordUser.Text, TxtConfirmPassword.Text))
                            {
                                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                                ConnectDB Conn = new ConnectDB(connectionString);
                                if (CbxActifUser.Checked == true)
                                {
                                    if (Conn.IsConnection)
                                    {
                                        try
                                        {
                                            //MessageBox.Show(CbxActifUser.Checked.ToString());
                                            DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (result == DialogResult.Yes)
                                            {
                                                SqlCmd = new SqlCommand("INSERT INTO UTILISATEURS (PSEUDO_USERS,DESCRIPTION_USER,MOTPASS_USERS,ACTIF,EMAIL_USERS,TEL_USERS,DATECREATE_USERS) VALUES (@PSEUDO_USERS,@DESCRIPTION_USER,@MOTPASS_USERS,@ACTIF,@EMAIL_USERS,@TEL_USERS,GETDATE())", Conn.cn);
                                                SqlCmd.Parameters.AddWithValue("@PSEUDO_USERS", TxtUserName.Text);
                                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_USER", TxtDescriptionUser.Text);
                                                SqlCmd.Parameters.AddWithValue("@MOTPASS_USERS", EncryptData(TxtPasswordUser.Text));
                                                SqlCmd.Parameters.AddWithValue("@ACTIF", "Actif");
                                                SqlCmd.Parameters.AddWithValue("@EMAIL_USERS", TxtMailUser.Text);
                                                SqlCmd.Parameters.AddWithValue("@TEL_USERS", TxtTelUser.Text);
                                                SqlCmd.ExecuteNonQuery();
                                                // Clear the fields
                                                TxtUserName.Clear(); TxtPasswordUser.Clear(); TxtConfirmPassword.Clear(); TxtDescriptionUser.Clear(); TxtMailUser.Clear(); TxtTelUser.Clear();
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    if (Conn.IsConnection)
                                    {
                                        // Desable user account
                                        try
                                        {
                                            //MessageBox.Show(CbxActifUser.Checked.ToString());
                                            DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (result == DialogResult.Yes)
                                            {
                                                SqlCmd = new SqlCommand("INSERT INTO UTILISATEURS (PSEUDO_USERS,DESCRIPTION_USER,MOTPASS_USERS,ACTIF,EMAIL_USERS,TEL_USERS,DATECREATE_USERS) VALUES (@PSEUDO_USERS,@DESCRIPTION_USER,@MOTPASS_USERS,@ACTIF,@EMAIL_USERS,@TEL_USERS,GETDATE())", Conn.cn);
                                                SqlCmd.Parameters.AddWithValue("@PSEUDO_USERS", TxtUserName.Text);
                                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_USER", TxtDescriptionUser.Text);
                                                SqlCmd.Parameters.AddWithValue("@MOTPASS_USERS", EncryptData(TxtPasswordUser.Text));
                                                SqlCmd.Parameters.AddWithValue("@ACTIF", "Inactif");
                                                SqlCmd.Parameters.AddWithValue("@EMAIL_USERS", TxtMailUser.Text);
                                                SqlCmd.Parameters.AddWithValue("@TEL_USERS", TxtTelUser.Text);
                                                SqlCmd.ExecuteNonQuery();
                                                // Clear the fields
                                                TxtUserName.Clear(); TxtPasswordUser.Clear(); TxtConfirmPassword.Clear(); TxtDescriptionUser.Clear(); TxtMailUser.Clear(); TxtTelUser.Clear();

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
                                MessageBox.Show("Veillez vérifier votre mot de passe !!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confirmez le mot de passer !!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saisir le mot de passe !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Saisir le nom utilisateur !!!");
                }
            }else
            {
                MessageBox.Show("Saisir le nom et le prénom de l'utilisateur !!!");
            }
        }

        private void IbtnViewPassword_Click(object sender, EventArgs e)
        {
            if (TxtPasswordUser.PasswordChar == '*')
            {
                IbtnHidePassword.BringToFront();
                TxtPasswordUser.PasswordChar = '\0';
            }
        }

        private void IbtnHidePassword_Click(object sender, EventArgs e)
        {
            if (TxtPasswordUser.PasswordChar == '\0')
            {
                IbtnHidePassword.BringToFront();
                TxtPasswordUser.PasswordChar = '*';
            }
        }

        private void IbtnViewConfPassword_Click(object sender, EventArgs e)
        {
            if (TxtConfirmPassword.PasswordChar == '*')
            {
                IbtnHideConfPassword.BringToFront();
                TxtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void IbtnHideConfPassword_Click(object sender, EventArgs e)
        {
           if (TxtConfirmPassword.PasswordChar == '\0')
            {
                IbtnHideConfPassword.BringToFront();
                TxtConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
