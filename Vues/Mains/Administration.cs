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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void CloseFormAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form FormMenuAdmin = null;
        public void DisplayFormOfMenuAdmin(Form FormOfMenuAdmin)
        {
            if (FormMenuAdmin != null)
                FormMenuAdmin.Close();
            FormMenuAdmin = FormOfMenuAdmin;
            FormOfMenuAdmin.TopLevel = false;
            FormOfMenuAdmin.FormBorderStyle = FormBorderStyle.None;
            FormOfMenuAdmin.Dock = DockStyle.Fill;
            PanPrincipalAdmin.Controls.Add(FormOfMenuAdmin);
            PanPrincipalAdmin.Tag = FormOfMenuAdmin;
            FormOfMenuAdmin.BringToFront();
            FormOfMenuAdmin.Show();
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuAdmin(new FormUtilisateur());
        }

        private void MenuRoles_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuAdmin(new FormRoles());
        }
    }
}
