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
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void CloseFormMaint_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form FormMenuLav = null;
        public void DisplayFormOfMenuMain(Form FormOfMenuLav)
        {
            if (FormMenuLav != null)
                FormMenuLav.Close();
            FormMenuLav = FormOfMenuLav;
            FormOfMenuLav.TopLevel = false;
            FormOfMenuLav.FormBorderStyle = FormBorderStyle.None;
            FormOfMenuLav.Dock = DockStyle.Fill;
            PanPrincipalMaint.Controls.Add(FormOfMenuLav);
            PanPrincipalMaint.Tag = FormOfMenuLav;
            FormOfMenuLav.BringToFront();
            FormOfMenuLav.Show();
        }

        private void MenuVisitTech_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormMainVisiteTech());
        }

        private void MenuConsulterPreparVisit_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormMainPrepareVisit());
        }

        private void MenuSaisirVisit_Click(object sender, EventArgs e)
        {
            FormCreatePreparVisit CreatePrepaVisit = new FormCreatePreparVisit();
            CreatePrepaVisit.ShowDialog();
        }

        private void ViewLavageAuto_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormMainCleanCar());
        }

        private void SaisirLavageAuto_Click(object sender, EventArgs e)
        {
            FormCreateWatchCar WatchClean = new FormCreateWatchCar();
            WatchClean.ShowDialog();
        }

        private void ViewReparationCar_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormRepairCar());
        }

        private void CreateRepairCar_Click(object sender, EventArgs e)
        {
            FormCreateRepairCar RepairCar = new FormCreateRepairCar();
            RepairCar.ShowDialog();
        }

        private void SaisirRevision_Click(object sender, EventArgs e)
        {
            FormCreateEntretien CreateEntretien = new FormCreateEntretien();
            CreateEntretien.ShowDialog();
        }

        private void SaisirPrepaVisit_Click(object sender, EventArgs e)
        {
            Form PrepaVist = new FormCreatePreparVisit();
            PrepaVist.ShowDialog();
        }

        private void ViewPrepaVisit_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormMainPrepareVisit());
        }

        private void itemMenuConsultingVidange_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormMainRevision());
        }

        private void menuItemsConsultAssur_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormMainAssurance());
        }

        private void menuItemsCreateAssur_Click(object sender, EventArgs e)
        {
            Form creatAssur = new FormCreateAssurance();
            creatAssur.ShowDialog();
        }

        private void consulterLesVisitesTechniquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenuMain(new FormMainVisiteTech());
        }

        private void itemMenuRevision_Click(object sender, EventArgs e)
        {
            FormCreateEntretien createRevision = new FormCreateEntretien();
            createRevision.ShowDialog();
        }
    }
}
