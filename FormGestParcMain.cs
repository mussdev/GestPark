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
    public partial class FormMainGestPark : Form
    {
        public FormMainGestPark()
        {
            InitializeComponent();
            customiseDesign();
        }

        private void customiseDesign()
        {
            panelGestParkSubMenu.Visible = false;
            panelMaintenanceSubMenu.Visible = false;
            panelTabBordsSubMenu.Visible = false;
            panelAdminSubMenu.Visible = false;
            // SubSubMenuGestParkOutil
            panelOutilGestParkSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelGestParkSubMenu.Visible == true)
                panelGestParkSubMenu.Visible = false;
            if (panelMaintenanceSubMenu.Visible == true)
                panelMaintenanceSubMenu.Visible = false;
            if (panelTabBordsSubMenu.Visible == true)
                panelTabBordsSubMenu.Visible = false;
            if (panelAdminSubMenu.Visible == true)
                panelAdminSubMenu.Visible = false;
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
                
        }

        // Method to show subSubMenu
        private void subSubMenuOutils(Panel subSubOutil)
        {
            if (subSubOutil.Visible == false)
            {
               // hideSubMenu();
                subSubOutil.Visible = true;
            }
            else
                subSubOutil.Visible = false;
        }

        private void iconBtnGestPark_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGestParkSubMenu);
        }

        private void iconBtnMaintenance_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMaintenanceSubMenu);
        }

        private void iconBtnParking_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMainParking());
            hideSubMenu();
        }

        private void iconBtnVehicule_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMainVehicule());
            hideSubMenu();
        }

        private void iconBtnOutilsGestPark_Click(object sender, EventArgs e)
        {
            subSubMenuOutils(panelOutilGestParkSubMenu);
        }

        private void iconBtnVisit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconBtnAssurance_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconBtnTabBord_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTabBordsSubMenu);
        }

        private void iconBtnSuiviVehicul_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSuiviVehicule());
            hideSubMenu();
        }

        private void iconBtnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminSubMenu);
        }

        private void iconBtnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUtilisateur());
            hideSubMenu();
        }

        private void iconBtnRoles_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRoles());
            hideSubMenu();
        }

        private void iconBtnOutilAdmin_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconBtnMarque_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMarque());
            hideSubMenu();
        }

        private void iconBtnTypConso_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTypeConsommation());
            hideSubMenu();
        }

        private void iconBtnConducteur_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMainPerson());
            hideSubMenu();
        }

        private void iconBtnGarage_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMainGarage());
            hideSubMenu();
        }

        private void iconBtnCloseFormParking_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Gestion WindowsForms
        private System.Windows.Forms.Form activeForm = null;
        private void openChildForm(System.Windows.Forms.Form childForm)
        {
            if (childForm != null)
                //activeForm.Close();
                activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormResultMenu.Controls.Add(childForm);
            panelFormResultMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconBtnFournisseur_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMainFournisseur());
            hideSubMenu();
        }

        private void iconBtnEntretien_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEntretienVehicule());
            hideSubMenu();
        }

        private void iconBtnAssurance_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormMainAssurance());
            hideSubMenu();
        }

        private void iconBtnVisit_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormMainVisiteTech());
            hideSubMenu();
        }

        private void BtnCarteCarburant_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMainCarteCarburant());
            hideSubMenu();
        }
    }

}
