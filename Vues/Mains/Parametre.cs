using GestPark.Validations;
using GestPark.Vues.Consult;
using GestPark.Workflows.NiveauTransition;
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
    public partial class Parametre : Form
    {
        public Parametre()
        {
            InitializeComponent();
        }

        private void CloseFormParam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form FormMenuParam = null;
        public void DisplayFormOfMenuParam(Form FormOfMenuParam)
        {
            if (FormMenuParam != null)
                FormMenuParam.Close();
            FormMenuParam = FormOfMenuParam;
            FormOfMenuParam.TopLevel = false;
            FormOfMenuParam.FormBorderStyle = FormBorderStyle.None;
            FormOfMenuParam.Dock = DockStyle.Fill;
            PanPrincipalParam.Controls.Add(FormOfMenuParam);
            PanPrincipalParam.Tag = FormOfMenuParam;
            FormOfMenuParam.BringToFront();
            FormOfMenuParam.Show();
        }

        private void CreateCarMenu_Click(object sender, EventArgs e)
        {
            FormRegisterVehicule RegisterCar = new FormRegisterVehicule();
            RegisterCar.ShowDialog();
        }

        private void ConsultCarMenu_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormViewVehicule());
        }

        private void GarageMenu_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormMainGarage());
        }

        private void CardCarburantMenu_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormMainCarteCarburant());
        }

        private void PersonMenu_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormMainPerson());
        }

        private void FourMenu_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormMainFournisseur());
        }

        private void MenuMarq_Click_1(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormMarque());
        }

        private void MenuEnergie_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormTypeConsommation());
        }

        private void SaisirCar_Click(object sender, EventArgs e)
        {
            FormRegisterVehicule RegisterCar = new FormRegisterVehicule();
            RegisterCar.ShowDialog();
        }

        private void ViewCar_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormViewVehicule());
        }

        private void MenuService_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormServices());
        }

        private void MenuDir_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormDirection());
        }

        private void itemMenuValMvt_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormValidationMouvementCar());
        }

        private void ItemMenuTransDemandVehi_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormTransitionDemandeVehicule());
        }

        private void ItemMenuNiveauTransition_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormNiveauTransitionDemandeCar());
        }

        private void itemMenuConducteur_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuParam(new FormConducteur());
        }
    }
}
