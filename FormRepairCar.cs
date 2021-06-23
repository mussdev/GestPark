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
    public partial class FormRepairCar : Form
    {
        public FormRepairCar()
        {
            InitializeComponent();
        }

        private void IbtnCloseFanRepairCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
