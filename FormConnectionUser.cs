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

namespace GestPark
{
    public partial class FormConnectionUser : Form
    {
       //
        public FormConnectionUser()
        {
            InitializeComponent();
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
                            string Query = "SELECT * FROM UTILISATEURS WHERE PSEUDO_USERS = '" + TxtUsernameFanConUser.Text.Trim() + "' AND MOTPASS_USERS = '" + passWordUser + "'";
                            SqlDataAdapter SqlAda = new SqlDataAdapter(Query, ConDb.cn);
                            DataTable Dta = new DataTable();
                            SqlAda.Fill(Dta);
                            if (Dta.Rows.Count == 1)
                            {
                                FormMainGestPark FormHomeGestPark = new FormMainGestPark();
                                this.Hide();
                                FormHomeGestPark.ShowDialog();
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
            if(TxtUsernameFanConUser.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Entrez un utilisateur valide svp", "Error");
                return false;
            } else if(TxtPasswordFanConUser.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Entrez un mot de passe valide svp", "Error");
                return false;
            }
            return true;
        }

        private void FormConnectionUser_Load(object sender, EventArgs e)
        {
           // 
        }
    }
}
