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
    public partial class FormMainVehicule : Form
    {
        public FormMainVehicule()
        {
            InitializeComponent();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormRegisterVehicule());
        }

        private System.Windows.Forms.Form activeFormVehic = null;
        private void openChildFormVehicul(System.Windows.Forms.Form childFormVehi)
        {
            if (childFormVehi != null)
                //activeForm.Close();
                activeFormVehic = childFormVehi;
            childFormVehi.TopLevel = false;
            childFormVehi.FormBorderStyle = FormBorderStyle.None;
            childFormVehi.Dock = DockStyle.Fill;
            panelMenuVehicule.Controls.Add(childFormVehi);
            panelMenuVehicule.Tag = childFormVehi;
            childFormVehi.BringToFront();
            childFormVehi.Show();
        }

        private void consulterToolStripMenuItemConsultVe_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormViewVehicule());
        }

        private void mouvementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormMainMouvement());
        }

        private void AttribuerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormAttributeCarToPerson());
        }

        private void ConsommationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormConsommationCarburant());
        }

        private void PanneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormMainPanneCar());
        }

        private void WhatchingAutoTlStpMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormMainCleanCar());
        }

        private void RepairTlStpMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormVehicul(new FormRepairCar());
        }
    }
}
