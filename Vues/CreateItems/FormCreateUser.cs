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
using GestPark.Vues.Consult;

namespace GestPark
{
    public partial class FormCreateUser : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private DataSet Ds;
        private Guid? IdUser, IdRoles, IdUserPers = null;
        public static FormCreateUser FormUser = new FormCreateUser();
        public FormCreateUser()
        {
            InitializeComponent();
            displayRoles();
            FormUser = this;
        }

        public static string EncryptData(string SimpleString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(SimpleString);
            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }

        private void BtnValideUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDescriptionUser.Text))
            {
                if (!string.IsNullOrEmpty(TxtUserName.Text) && TxtUserName.TextLength < 6)
                {
                    if (!string.IsNullOrEmpty(TxtPasswordUser.Text))
                    {
                        if (!string.IsNullOrEmpty(TxtConfirmPassword.Text))
                        {
                            if (string.Equals(TxtPasswordUser.Text.Trim(), TxtConfirmPassword.Text.Trim()))
                            {
                                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                                ConnectDB Conn = new ConnectDB(connectionString);
                                if (CbxActifUser.Checked == true)
                                {
                                    if (Conn.IsConnection)
                                    {
                                        try
                                        {
                                            DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (result == DialogResult.Yes)
                                            {
                                                string CodUsers = generateCodeUser();
                                                Guid? IdPers = null;
                                                IdPers = IdPersonnels();
                                                using (SqlCmd = new SqlCommand("INSERT INTO UTILISATEURS (ID_PERS,CODE_USER,PSEUDO_USERS,DESCRIPTION_USER,MOTPASS_USERS,ACTIF,EMAIL_USERS,TEL_USERS,DATECREATE_USERS) VALUES (@ID_PERS,@CODE_USER,@PSEUDO_USERS,@DESCRIPTION_USER,@MOTPASS_USERS,@ACTIF,@EMAIL_USERS,@TEL_USERS,GETDATE())", Conn.cn))
                                                {
                                                    if (IdPers.HasValue)
                                                    {
                                                        SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPers.Value);
                                                    }else
                                                        SqlCmd.Parameters.AddWithValue("@ID_PERS", DBNull.Value);

                                                    SqlCmd.Parameters.AddWithValue("@CODE_USER", CodUsers);
                                                    SqlCmd.Parameters.AddWithValue("@PSEUDO_USERS", TxtUserName.Text.Trim().ToLower());
                                                    SqlCmd.Parameters.AddWithValue("@DESCRIPTION_USER", TxtDescriptionUser.Text.Trim());
                                                    SqlCmd.Parameters.AddWithValue("@MOTPASS_USERS", EncryptData(TxtPasswordUser.Text.Trim()));
                                                    SqlCmd.Parameters.AddWithValue("@ACTIF", "Actif");
                                                    SqlCmd.Parameters.AddWithValue("@EMAIL_USERS", TxtMailUser.Text.Trim());
                                                    SqlCmd.Parameters.AddWithValue("@TEL_USERS", TxtTelUser.Text.Trim());
                                                    SqlCmd.ExecuteNonQuery();
                                                    SqlCmd.Parameters.Clear();
                                                }

                                                if (!string.IsNullOrEmpty(cbxRolesUser.Text))
                                                {
                                                    using (var Cmd = Conn.cn.CreateCommand())
                                                    {
                                                        Cmd.CommandText = "SELECT TOP 1 ID_USER FROM UTILISATEURS WHERE CODE_USER='" + TxtUserCode.Text + "'";
                                                        MyReader = Cmd.ExecuteReader();
                                                    }

                                                    while (MyReader.Read())
                                                    {
                                                        IdUser = Guid.Parse(MyReader["ID_USER"].ToString());
                                                    }
                                                    MyReader.Close();

                                                    // Recuperer l'id du rôle attrubué à l'utilisateur
                                                    using (var Cmd = Conn.cn.CreateCommand())
                                                    {
                                                        Cmd.CommandText = "SELECT TOP 1 ID_ROLE FROM ROLES WHERE DESCRIPTION_ROLE='" + cbxRolesUser.Text + "'";
                                                        MyReader = Cmd.ExecuteReader();
                                                    }

                                                    while (MyReader.Read())
                                                    {
                                                        IdRoles = Guid.Parse(MyReader["ID_ROLE"].ToString());
                                                    }
                                                    MyReader.Close();

                                                    //
                                                    using (var Cmd = Conn.cn.CreateCommand())
                                                    {
                                                        Cmd.CommandText = "INSERT INTO UTILISATEURROLE (ID_USER,ID_ROLE,DATE_ATTR_ROLE) VALUES (@ID_USER,@ID_ROLE,GETDATE())";
                                                        Cmd.Parameters.AddWithValue("@ID_USER", IdUser);
                                                        Cmd.Parameters.AddWithValue("@ID_ROLE", IdRoles);
                                                        Cmd.ExecuteNonQuery();
                                                        Cmd.Parameters.Clear();
                                                    }
                                                }

                                                MessageBox.Show("L'utilisateur " + TxtDescriptionUser.Text + " a été enregisté avec succès!","Fleet: Informations",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                                // Clear the fields
                                                TxtUserName.Clear(); TxtPasswordUser.Clear(); TxtConfirmPassword.Clear(); TxtDescriptionUser.Clear(); TxtMailUser.Clear(); TxtTelUser.Clear(); cbxRolesUser.Text = null; TxtUserCode.Clear();
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                            DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (result == DialogResult.Yes)
                                            {
                                                string CodUsers = generateCodeUser();
                                                using (SqlCmd = new SqlCommand("INSERT INTO UTILISATEURS (CODE_USER,PSEUDO_USERS,DESCRIPTION_USER,MOTPASS_USERS,ACTIF,EMAIL_USERS,TEL_USERS,DATECREATE_USERS) VALUES (@CODE_USER,@PSEUDO_USERS,@DESCRIPTION_USER,@MOTPASS_USERS,@ACTIF,@EMAIL_USERS,@TEL_USERS,GETDATE())", Conn.cn))
                                                {
                                                    SqlCmd.Parameters.AddWithValue("@CODE_USER", CodUsers);
                                                    SqlCmd.Parameters.AddWithValue("@PSEUDO_USERS", TxtUserName.Text);
                                                    SqlCmd.Parameters.AddWithValue("@DESCRIPTION_USER", TxtDescriptionUser.Text);
                                                    SqlCmd.Parameters.AddWithValue("@MOTPASS_USERS", EncryptData(TxtPasswordUser.Text));
                                                    SqlCmd.Parameters.AddWithValue("@ACTIF", "Inactif");
                                                    SqlCmd.Parameters.AddWithValue("@EMAIL_USERS", TxtMailUser.Text);
                                                    SqlCmd.Parameters.AddWithValue("@TEL_USERS", TxtTelUser.Text);
                                                    SqlCmd.ExecuteNonQuery();
                                                }

                                                if (!string.IsNullOrEmpty(cbxRolesUser.Text))
                                                {
                                                    using (var Cmd = Conn.cn.CreateCommand())
                                                    {
                                                        Cmd.CommandText = "SELECT TOP 1 ID_USER FROM UTILISATEURS WHERE CODE_USER='" + TxtUserCode.Text + "'";
                                                        MyReader = Cmd.ExecuteReader();
                                                    }

                                                    while (MyReader.Read())
                                                    {
                                                        IdUser = Guid.Parse(MyReader["ID_USER"].ToString());
                                                    }
                                                    MyReader.Close();

                                                    // Recuperer l'id du rôle attrubué à l'utilisateur
                                                    using (var Cmd = Conn.cn.CreateCommand())
                                                    {
                                                        Cmd.CommandText = "SELECT TOP 1 ID_ROLE FROM ROLES WHERE DESCRIPTION_ROLE='" + cbxRolesUser.Text + "'";
                                                        MyReader = Cmd.ExecuteReader();
                                                    }

                                                    while (MyReader.Read())
                                                    {
                                                        IdRoles = Guid.Parse(MyReader["ID_ROLE"].ToString());
                                                    }
                                                    MyReader.Close();

                                                    //
                                                    using (var Cmd = Conn.cn.CreateCommand())
                                                    {
                                                        Cmd.CommandText = "INSERT INTO UTILISATEURROLE (ID_USER,ID_ROLE,DATE_ATTR_ROLE) VALUES (@ID_USER,@ID_ROLE,GETDATE())";
                                                        Cmd.Parameters.AddWithValue("@ID_USER", IdUser);
                                                        Cmd.Parameters.AddWithValue("@ID_ROLE", IdRoles);
                                                        Cmd.ExecuteNonQuery();
                                                        Cmd.Parameters.Clear();
                                                    }
                                                }

                                                MessageBox.Show("L'utilisateur " + TxtDescriptionUser.Text + " a été enregisté avec succès!", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                // Clear the fields
                                                TxtUserName.Clear(); TxtPasswordUser.Clear(); TxtConfirmPassword.Clear(); TxtDescriptionUser.Clear(); TxtMailUser.Clear(); TxtTelUser.Clear(); cbxRolesUser.Text = null;TxtUserCode.Clear();

                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Veillez vérifier votre mot de passe !!!","Fleet: Gestion des erreurs",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confirmez le mot de passer !!!","Fleet: Gestion des erreurs",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saisir le mot de passe !!!","Fleet: Gestion des erreurs",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Saisir le nom utilisateur ou la taille du mot est court ou long" + "\n" + "Si oui veillez saisir un mot plus court de 3 caractères ou au plus 6 caractères !","Fleet: Gestion des erreurs",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Saisir le nom et le prénom de l'utilisateur !!!","Fleet: Gestion des erreurs",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        // Methode te generate code
        private string generateCodeUser()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code of car
                        SqlCmd = new SqlCommand("SELECT CODE_USER FROM UTILISATEURS WHERE CODE_USER=(SELECT MAX(CODE_USER) FROM UTILISATEURS)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtUserCode.Text = Ds.Tables[0].Rows[0]["CODE_USER"].ToString();
                        }
                        else
                        {
                            TxtUserCode.Text = "USER0000";
                        }
                        if (!string.IsNullOrEmpty(TxtUserCode.Text))
                        {
                            TxtUserCode.SelectionStart = 4;
                            TxtUserCode.SelectionLength = 4;
                            TxtUserCode.Text = TxtUserCode.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtUserCode.Text))
                        {
                            int codUser = int.Parse(TxtUserCode.Text.ToString()) + 1;
                            TxtUserCode.Text = codUser.ToString("USER0000");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtUserCode.Text;
        }

        private void cbxRolesUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_ROLE FROM ROLES WHERE DESCRIPTION_ROLE = '" + cbxRolesUser.SelectedItem + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdRoles = Guid.Parse(MyReader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonnelUser_Click(object sender, EventArgs e)
        {
            FormPersonnelUser PersonnelUser = new FormPersonnelUser();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM PERSONNELS", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        PersonnelUser.listBoxPers.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_PERS"], (string)MyReader["DESCRIPTION_PERS"].ToString()));
                        PersonnelUser.listBoxPers.DisplayMember = "Value";
                        PersonnelUser.listBoxPers.ValueMember = "Key"; ;
                    }
                    PersonnelUser.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Afficher les rôles dans Combobox
        private void displayRoles()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (Conn.IsConnection)
                {
                    using (var Cmd = Conn.cn.CreateCommand())
                    {
                        Cmd.CommandText = "SELECT ID_ROLE, DESCRIPTION_ROLE FROM ROLES";
                        MyReader = Cmd.ExecuteReader();

                        while (MyReader.Read())
                        {
                            cbxRolesUser.Items.Add(MyReader["DESCRIPTION_ROLE"].ToString());
                            cbxRolesUser.DisplayMember = (MyReader["DESCRIPTION_ROLE"].ToString());
                            cbxRolesUser.ValueMember = (MyReader["ID_ROLE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /**
         *  Methode qui renvoie l'id d'un personnel de l'entreprise
         */
        private Guid? IdPersonnels()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE DESCRIPTION_PERS ='" + TxtDescriptionUser.Text + "'", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdUserPers = Guid.Parse(MyReader["ID_PERS"].ToString());
                    }
                }
                else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdUserPers;
        }

    }
}
