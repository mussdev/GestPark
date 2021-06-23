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
    public partial class FormCreateRepairCar : Form
    {
        public FormCreateRepairCar()
        {
            InitializeComponent();
        }

        private void IcBtnCloseFanRepaiCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
