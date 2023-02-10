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
using GestPark.Vues.Consult;

namespace GestPark
{
    public partial class FormModifyUser : Form
    {
        private SqlCommand SqlCmd;
        FormUtilisateur User = new FormUtilisateur();
        private SqlDataReader MyReader;
        public static string CodeUser;
        private Guid? IdRolesMod, IdUserMod, IdRolesTest, IdUserPersMod = null;
        public static FormModifyUser modifyUser = new FormModifyUser();
        public FormModifyUser()
        {
            InitializeComponent();
            displayRolesMod();
            modifyUser = this;
        }

        private void IbtnValideUserEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDescriptionUserEdit.Text))
            {
                if (!string.IsNullOrEmpty(TxtUserNameEdit.Text))
                {                   
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    string StautUser = UserTestStatut();
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            try
                            {
                                //MessageBox.Show(CbxActifUser.Checked.ToString());
                                DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    // Guid IdUserEdit = Guid.Parse(TxtIdUser.Text);
                                    Guid? IdPersUserMod = null;
                                    IdPersUserMod = IdPersonnelsMod();
                                    using (SqlCmd = new SqlCommand("UPDATE UTILISATEURS SET ID_PERS=@ID_PERS,PSEUDO_USERS=@PSEUDO_USERS,DESCRIPTION_USER=@DESCRIPTION_USER,ACTIF=@ACTIF,EMAIL_USERS=@EMAIL_USERS,TEL_USERS=@TEL_USERS WHERE CODE_USER='" + TxtCodeUserMod.Text + "'", Conn.cn))
                                    {
                                        if (IdPersUserMod.HasValue)
                                        {
                                            SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPersUserMod.Value);
                                        }else
                                            SqlCmd.Parameters.AddWithValue("@ID_PERS", DBNull.Value);

                                        SqlCmd.Parameters.AddWithValue("@PSEUDO_USERS", TxtUserNameEdit.Text.Trim().ToLower());
                                        SqlCmd.Parameters.AddWithValue("@DESCRIPTION_USER", TxtDescriptionUserEdit.Text.Trim());
                                        SqlCmd.Parameters.AddWithValue("@ACTIF", StautUser);
                                        SqlCmd.Parameters.AddWithValue("@EMAIL_USERS", TxtMailUserEdit.Text.Trim());
                                        SqlCmd.Parameters.AddWithValue("@TEL_USERS", TxtTelUserEdit.Text.Trim());
                                        //MessageBox.Show("Code user = ", TxtCodeUserMod.Text);
                                        SqlCmd.ExecuteNonQuery();
                                    }


                                    if (!string.IsNullOrEmpty(cbxRolesUserMod.Text))
                                    {
                                        // Récuperer l'id de l'utilisateur

                                        using (var Cmd = Conn.cn.CreateCommand())
                                        {
                                            Cmd.CommandText = "SELECT TOP 1 ID_USER FROM UTILISATEURS WHERE CODE_USER='" + TxtCodeUserMod.Text + "'";
                                            MyReader = Cmd.ExecuteReader();
                                        }

                                        while (MyReader.Read())
                                        {
                                            IdUserMod = Guid.Parse(MyReader["ID_USER"].ToString());
                                        }
                                        MyReader.Close();

                                        // Recuperer l'id du rôle attrubué à l'utilisateur
                                        using (var Cmd = Conn.cn.CreateCommand())
                                        {
                                            Cmd.CommandText = "SELECT TOP 1 ID_ROLE FROM ROLES WHERE DESCRIPTION_ROLE='" + cbxRolesUserMod.Text + "'";
                                            MyReader = Cmd.ExecuteReader();

                                            // Lire les données recupérer
                                            while (MyReader.Read())
                                            {
                                                IdRolesMod = Guid.Parse(MyReader["ID_ROLE"].ToString());
                                            }
                                            MyReader.Close();
                                        }

                                        // MessageBox.Show("Valeur du champ Combobox: " + cbxRolesUserMod.Text + " Valeur id du rôle choisi : " + IdRolesMod.Value);

                                        /**
                                         * 
                                         * Tester l'utilisateur pour savoir s'il a dèjà un rôle
                                         * 
                                         **/

                                        using (var Cmd = Conn.cn.CreateCommand())
                                        {
                                            Cmd.CommandText = "SELECT UTILISATEURROLE.ID_ROLE FROM UTILISATEURROLE WHERE ID_USER='" + IdUserMod + "' ";
                                            MyReader = Cmd.ExecuteReader();

                                            while (MyReader.Read())
                                            {
                                                IdRolesTest = Guid.Parse(MyReader["ID_ROLE"].ToString());
                                            }
                                            MyReader.Close();
                                        }

                                      //  MessageBox.Show("Valeur du rôle: " + IdRolesTest.ToString());



                                        // Modifier le rôle d'utilisateur 
                                        if (!string.IsNullOrEmpty(IdRolesTest.ToString()))
                                        {
                                            using(var Cmd = Conn.cn.CreateCommand())
                                            {
                                                Cmd.CommandText = "UPDATE UTILISATEURROLE SET ID_ROLE=@ID_ROLE,DATE_MOD_ATTR_ROLE=GETDATE() WHERE ID_USER='"+ IdUserMod +"'";
                                                Cmd.Parameters.AddWithValue("ID_ROLE", IdRolesMod.Value);
                                                Cmd.ExecuteNonQuery();
                                            }
                                           // MessageBox.Show("La valeur du rôle n'est pas vide ");
                                        }
                                        else
                                        {
                                            // MessageBox.Show("Valeur du rôle est vide ");
                                            using (var Cmd = Conn.cn.CreateCommand())
                                            {
                                                Cmd.CommandText = "INSERT INTO UTILISATEURROLE (ID_USER,ID_ROLE,DATE_ATTR_ROLE) VALUES (@ID_USER,@ID_ROLE,GETDATE())";
                                                Cmd.Parameters.AddWithValue("@ID_USER", IdUserMod);
                                                Cmd.Parameters.AddWithValue("@ID_ROLE", IdRolesMod);
                                                Cmd.ExecuteNonQuery();
                                                Cmd.Parameters.Clear();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        // Récuperer l'id de l'utilisateur

                                        using (var Cmd = Conn.cn.CreateCommand())
                                        {
                                            Cmd.CommandText = "SELECT TOP 1 ID_USER FROM UTILISATEURS WHERE CODE_USER='" + TxtCodeUserMod.Text + "'";
                                            MyReader = Cmd.ExecuteReader();
                                        }

                                        while (MyReader.Read())
                                        {
                                            IdUserMod = Guid.Parse(MyReader["ID_USER"].ToString());
                                        }
                                        MyReader.Close();

                                        MessageBox.Show("Id user = " + IdUserMod);
                                        using (var Cmd = Conn.cn.CreateCommand())
                                        {
                                            Cmd.CommandText = "DELETE FROM UTILISATEURROLE WHERE ID_USER=@ID_USER";
                                            Cmd.Parameters.AddWithValue("@ID_USER", IdUserMod);
                                            Cmd.ExecuteNonQuery();
                                            Cmd.Parameters.Clear();
                                        }
                                    }

                                    MessageBox.Show("Les informations de l'utilisateur " + TxtDescriptionUserEdit.Text + " ont été modifiées avec succès","Fleet: Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
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
                    MessageBox.Show("Saisir le nom utilisateur !!!","Fleet: Avertissement!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Saisir le nom et le prénom de l'utilisateur !!!", "Fleet: Avertissement!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            CodeUser = TxtCodeUserMod.Text;
            FormInitPassword.ShowDialog();
        }

        private void btnPersonnelUserMod_Click(object sender, EventArgs e)
        {
            FormPersonnelUserModify formPersUserMod = new FormPersonnelUserModify();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                FormConsultStatutDemandeCar CallFallAskCar = new FormConsultStatutDemandeCar();
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM PERSONNELS", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        formPersUserMod.listBoxPersMod.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_PERS"], (string)MyReader["DESCRIPTION_PERS"].ToString()));
                        formPersUserMod.listBoxPersMod.DisplayMember = "Value";
                        formPersUserMod.listBoxPersMod.ValueMember = "Key"; ;
                    }
                    formPersUserMod.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Afficher les rôles dans Combobox
        private void displayRolesMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (Conn.IsConnection)
                {
                    using (var Cmd = Conn.cn.CreateCommand())
                    {
                        Cmd.CommandText = "select ID_ROLE, DESCRIPTION_ROLE from roles";
                        MyReader = Cmd.ExecuteReader();

                        while (MyReader.Read())
                        {
                            cbxRolesUserMod.Items.Add(MyReader["DESCRIPTION_ROLE"].ToString());
                            cbxRolesUserMod.DisplayMember = (MyReader["DESCRIPTION_ROLE"].ToString());
                            cbxRolesUserMod.ValueMember = (MyReader["ID_ROLE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxRolesUserMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_ROLE FROM ROLES WHERE DESCRIPTION_ROLE = '" + cbxRolesUserMod.SelectedItem + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdRolesMod = Guid.Parse(MyReader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         *  Methode qui renvoie l'id d'un personnel de l'entreprise
         */
        private Guid? IdPersonnelsMod()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE DESCRIPTION_PERS ='" + TxtDescriptionUserEdit.Text + "'", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdUserPersMod = Guid.Parse(MyReader["ID_PERS"].ToString());
                    }
                }
                else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdUserPersMod;
        }
    }
}
