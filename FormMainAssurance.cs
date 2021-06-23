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
    public partial class FormMainAssurance : Form
    {
        public FormMainAssurance()
        {
            InitializeComponent();
        }

        private void iconBtnCloseFormAssur_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateAssur_Click(object sender, EventArgs e)
        {
            Form CreateAssurance = new FormCreateAssurance();
            CreateAssurance.ShowDialog();
        }
    }
}
