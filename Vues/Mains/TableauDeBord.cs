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
    public partial class TableauDeBord : Form
    {
        public TableauDeBord()
        {
            InitializeComponent();
        }

        private void CloseFormTblBord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form FormMenuTblBord = null;
        public void DisplayFormOfMenuTblBord(Form FormOfMenuTblBord)
        {
            if (FormMenuTblBord != null)
                FormMenuTblBord.Close();
            FormMenuTblBord = FormOfMenuTblBord;
            FormOfMenuTblBord.TopLevel = false;
            FormOfMenuTblBord.FormBorderStyle = FormBorderStyle.None;
            FormOfMenuTblBord.Dock = DockStyle.Fill;
            PanPrincipalTablBord.Controls.Add(FormOfMenuTblBord);
            PanPrincipalTablBord.Tag = FormOfMenuTblBord;
            FormOfMenuTblBord.BringToFront();
            FormOfMenuTblBord.Show();
        }

        private void suiviDesVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuTblBord(new FormSuiviVehicule());
        }

        private void ItemMenuEtatCarRepair_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuTblBord(new FormEtatVehiculeRepare());
        }

        private void menuItemEtatLavageCar_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuTblBord(new FormEtatLavageVehicule());
        }

        private void menuItemEtatProv_Click(object sender, EventArgs e)
        {
            FormEtatProvision etatProvision = new FormEtatProvision();
            etatProvision.Show();
        }

        private void itemMenuListVehicule_Click(object sender, EventArgs e)
        {
            Form EtatVehicule = new FormEtatVehicule();
            EtatVehicule.ShowDialog();
        }

        private void menuItemEtatChargeCar_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuTblBord(new FormEtatChargeDesVehicule());
        }
    }
}
