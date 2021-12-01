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
    public partial class FormMainCarteCarburant : Form
    {
        public FormMainCarteCarburant()
        {
            InitializeComponent();
        }

        private void IbtnRegisterCarteCarb_Click(object sender, EventArgs e)
        {
            FormAddCarteCarburant AddCarteCarburant = new FormAddCarteCarburant();
            AddCarteCarburant.ShowDialog();
        }

        private void IbtnCloseFormMvt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
