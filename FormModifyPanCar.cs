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
    public partial class FormModifyPanCar : Form
    {
        public FormModifyPanCar()
        {
            InitializeComponent();
        }

        private void IcBtnCloseFanModifyPanCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnRepaiCarPan_Click(object sender, EventArgs e)
        {
            FormCreateRepairCar RepairCar = new FormCreateRepairCar();
            RepairCar.ShowDialog();
        }

        private void FormModifyPanCar_Load(object sender, EventArgs e)
        {
            IbtnRepaiCarPan.Hide();
        }

        private void CbxEtatModifyPanCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxEtatModifyPanCar.Text == "Reparé")
            {
                IbtnRepaiCarPan.Visible = true;
            }
        }
    }
}
