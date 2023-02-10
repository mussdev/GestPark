using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark.Vues.Consult
{
    public partial class FormPersonnelUser : Form
    {
        public FormPersonnelUser()
        {
            InitializeComponent();
        }

        private void listBoxPers_DoubleClick(object sender, EventArgs e)
        {
            FormCreateUser.FormUser.TxtDescriptionUser.Text = listBoxPers.Text;
            FormCreateUser.FormUser.txtPersonnelUser.Text = listBoxPers.Text;
            this.Close();
        }

        private void txtFilterPersonnel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
