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
    public partial class FormEntretienVehicule : Form
    {
        public FormEntretienVehicule()
        {
            InitializeComponent();
        }

        private void iconBtnCloseFormEntretien_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateEntretien_Click(object sender, EventArgs e)
        {
            Form FormEntretien = new FormCreateEntretient();
            FormEntretien.ShowDialog();
        }
    }
}
