using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GestPark
{
    public partial class Gestion : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        public Gestion()
        {
            InitializeComponent();
        }

        private void CloseFormGestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form FormMenuGest = null;
        public void DisplayFormOfMenuGest(Form FormOfMenuGest)
        {
            if (FormMenuGest != null)
                FormMenuGest.Close();
            FormMenuGest = FormOfMenuGest;
            FormOfMenuGest.TopLevel = false;
            FormOfMenuGest.FormBorderStyle = FormBorderStyle.None;
            FormOfMenuGest.Dock = DockStyle.Fill;
            PanPrincipalGestion.Controls.Add(FormOfMenuGest);
            PanPrincipalGestion.Tag = FormOfMenuGest;
            FormOfMenuGest.BringToFront();
            FormOfMenuGest.Show();
        }

        private void RechargeCarteMenu_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuGest(new FormMainRechargeCarte());
        }

        private void ViewPaieCarburant_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuGest(new FormMainPaiement());
        }

        private void ViewRavitaillementCarburant_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuGest(new FormConsommationCarburant());
        }

        private void SaisirRavitaillement_Click(object sender, EventArgs e)
        {
            Form CreateRaviEnergi = new FormCreateConsoCarburant();
            CreateRaviEnergi.ShowDialog();
        }

        private void ViewMvtCar_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuGest(new FormMainMouvement());
        }

        private void SaisirDemandeCar_Click(object sender, EventArgs e)
        {
            FormCreateMouvement SaisirDemandCar = new FormCreateMouvement();
            if (FormConnectionUser.rolesUser.Equals("Gérant") || FormConnectionUser.rolesUser.Equals("Administrateur"))
            {
                SaisirDemandCar.cbxConducteur.Enabled = true;
                SaisirDemandCar.CbxVehiculeMvt.Enabled = true;
                SaisirDemandCar.ShowDialog();
            }
            else
            {
                SaisirDemandCar.cbxConducteur.Enabled = false;
                SaisirDemandCar.CbxVehiculeMvt.Enabled = false;
                SaisirDemandCar.ShowDialog();
            }  
        }

        private void ViewAttribuCar_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuGest(new FormAttributeCarToPerson());
        }

        private void AttribuCar_Click(object sender, EventArgs e)
        {
            Form AttributionCar = new FormCreateAttributeCar();
            AttributionCar.ShowDialog();
        }

    }
}
