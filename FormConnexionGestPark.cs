using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark
{
    public partial class FormConnexionGestPark : Form
    {
        public FormConnexionGestPark()
        {
            InitializeComponent();
        }

        private void FormConnexionGestPark_Load(object sender, EventArgs e)
        {
            cbxServer.Items.Add(".");
            cbxServer.Items.Add("local");
            cbxServer.Items.Add(@".\SQLEXPRESS");
            cbxServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbxServer.SelectedIndex = 3;
        }



        private void icbtnCancelCon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IcbtnConnected_Click(object sender, EventArgs e)
        {
            // FormMainGestPark FormHomeGestPark = new FormMainGestPark();
            FormConnectionUser ConUser = new FormConnectionUser();
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cbxServer.Text, txtDB.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                ConnectDB conDB = new ConnectDB(connectionString);
                if (conDB.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("cn", connectionString);
                  //  MessageBox.Show("Your connection string has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConUser.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcbtnTestConn_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cbxServer.Text, txtDB.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                ConnectDB conDB = new ConnectDB(connectionString);
                if (conDB.IsConnection)
                    MessageBox.Show("Test connection succeded !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
