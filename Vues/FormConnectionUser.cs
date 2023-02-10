using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace GestPark
{
    public partial class FormConnectionUser : Form
    {
        public static string rolesUser,pseudoUser;
        public FormConnectionUser()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void IcbtnCloseFanCon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Methode to encode user password
        public static string EncryptData(string SimpleString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(SimpleString);
            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }

        private void IcbtnValidFanCon_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB ConDb = new ConnectDB(connectionString);
            try
            {
                using (ConDb.cn)
                {
                    if (ConDb.IsConnection)
                    {
                        if (isValidCon())
                        {
                            string passWordUser = EncryptData(TxtPasswordFanConUser.Text.Trim()); 
                            string Query = "SELECT PSEUDO_USERS,MOTPASS_USERS,DESCRIPTION_ROLE FROM UTILISATEURS LEFT OUTER JOIN UTILISATEURROLE ON UTILISATEURS.ID_USER=UTILISATEURROLE.ID_USER LEFT OUTER JOIN ROLES ON UTILISATEURROLE.ID_ROLE=ROLES.ID_ROLE WHERE PSEUDO_USERS = '" + TxtUsernameFanConUser.Text.Trim().ToLower() + "' AND MOTPASS_USERS = '" + passWordUser + "' AND ACTIF='Actif'";
                            SqlDataAdapter SqlAda = new SqlDataAdapter(Query, ConDb.cn);
                            DataTable Dta = new DataTable();
                            SqlAda.Fill(Dta);
                            if (Dta.Rows.Count == 1)
                            {
                                rolesUser = Dta.Rows[0][2].ToString();
                                pseudoUser = Dta.Rows[0][0].ToString();
                                //MessageBox.Show("l'utilisateur connecté : " + pseudoUser);
                                MainGestPark HomeGestPark = new MainGestPark();
                                
                                if (rolesUser=="Gestionnaire")
                                {
                                    HomeGestPark.BtnAdmin.Visible = false;
                                    HomeGestPark.BtnTablBord.Visible = true;
                                    HomeGestPark.BtnParam.Visible = true;
                                    HomeGestPark.BtnGestion.Visible = true;
                                    HomeGestPark.BtnMaint.Visible = true;
                                    HomeGestPark.btnApropos.Visible = true;
                                    HomeGestPark.BtnMission.Visible = true;

                                    this.Hide();
                                    HomeGestPark.ShowDialog();
                                    this.Close();
                                }
                                else if(rolesUser=="Utilisateur simple" || rolesUser=="DARH")
                                {
                                    HomeGestPark.BtnAdmin.Visible = false;
                                    HomeGestPark.BtnTablBord.Visible = false;
                                    HomeGestPark.BtnParam.Visible = false;
                                    HomeGestPark.BtnGestion.Visible = true;
                                    HomeGestPark.BtnMaint.Visible = false;
                                    HomeGestPark.btnApropos.Visible = true;
                                    HomeGestPark.BtnMission.Visible = true;

                                    this.Hide();
                                    HomeGestPark.ShowDialog();
                                    Gestion PanneauGestionCar = new Gestion();
                                    PanneauGestionCar.MenuApproVehicule.Visible = false;
                                    PanneauGestionCar.MenuMvtVehicule.Visible = true;
                                    PanneauGestionCar.MenuAffectationVehicule.Visible = false;
                                    this.Close();
                                }else if (rolesUser == "Chef Service" || rolesUser == "Directeur")
                                {
                                    HomeGestPark.BtnAdmin.Visible = false;
                                    HomeGestPark.BtnTablBord.Visible = false;
                                    HomeGestPark.BtnParam.Visible = false;
                                    HomeGestPark.BtnGestion.Visible = true;
                                    HomeGestPark.BtnMaint.Visible = false;
                                    HomeGestPark.btnApropos.Visible = true;
                                    HomeGestPark.BtnMission.Visible = true;

                                    this.Hide();
                                    HomeGestPark.ShowDialog();
                                    Gestion PanneauGestionCar = new Gestion();
                                    PanneauGestionCar.MenuApproVehicule.Visible = false;
                                    PanneauGestionCar.MenuMvtVehicule.Visible = true;
                                    PanneauGestionCar.MenuAffectationVehicule.Visible = false;
                                    this.Close();
                                }
                                else if (rolesUser=="Administrateur")
                                {
                                    HomeGestPark.BtnAdmin.Visible = true;
                                    HomeGestPark.BtnTablBord.Visible = true;
                                    HomeGestPark.BtnParam.Visible = true;
                                    HomeGestPark.BtnGestion.Visible = true;
                                    HomeGestPark.BtnMaint.Visible = true;
                                    HomeGestPark.btnApropos.Visible = true;
                                    HomeGestPark.BtnMission.Visible = true;

                                    this.Hide();
                                    HomeGestPark.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    HomeGestPark.BtnAdmin.Visible = false;
                                    HomeGestPark.BtnTablBord.Visible = false;
                                    HomeGestPark.BtnParam.Visible = false;
                                    HomeGestPark.BtnGestion.Visible = false;
                                    HomeGestPark.BtnMaint.Visible = false;
                                    HomeGestPark.BtnMission.Visible = false;
                                    HomeGestPark.btnApropos.Visible = true;
                                    this.Hide();
                                    HomeGestPark.ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Veillez vérifier si l'utilisateur est actif ou si les informations de connexion sont correctes !!!", "Fleet: Connexion", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private bool isValidCon()
        {
            if(string.IsNullOrEmpty(TxtUsernameFanConUser.Text.TrimStart()))
            {
                MessageBox.Show("Entrez un utilisateur valide svp !!!", "Fleet: Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else if(string.IsNullOrEmpty(TxtPasswordFanConUser.Text.TrimStart()))
            {
                MessageBox.Show("Entrez un mot de passe valide svp !!!", "Fleet: Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
    }
}
