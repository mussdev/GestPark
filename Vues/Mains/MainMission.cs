using GestPark.Vues.Consult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark.Vues.Mains
{
    public partial class MainMission : Form
    {
        public MainMission()
        {
            InitializeComponent();
        }

        private Form FormMenu = null;
        public void DisplayFormOfMenu(Form FormOfMenu)
        {
            if (FormMenu != null)
                FormMenu.Close();
            FormMenu = FormOfMenu;
            FormOfMenu.TopLevel = false;
            FormOfMenu.FormBorderStyle = FormBorderStyle.None;
            FormOfMenu.Dock = DockStyle.Fill;
            PanPrincipalMission.Controls.Add(FormOfMenu);
            PanPrincipalMission.Tag = FormOfMenu;
            FormOfMenu.BringToFront();
            FormOfMenu.Show();
        }

        private void SubMenuWriteProjectMIssion_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormMainMission());
        }

        private void MenuSubType_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormTypeMission());
        }

        private void MenuSubCat_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormCategorieMission());
        }

        private void MenuPeriodMission_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormPeriodeMission());
        }
    }
}
