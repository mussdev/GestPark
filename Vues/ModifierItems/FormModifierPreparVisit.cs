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
    public partial class FormModifierPreparVisit : Form
    {
        public FormModifierPreparVisit()
        {
            InitializeComponent();
        }

        private void ChekPneusPrepaVisitMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipPneusMod = new ToolTip();
            ToolTipPneusMod.AutoPopDelay = 5000;
            ToolTipPneusMod.InitialDelay = 1000;
            ToolTipPneusMod.ReshowDelay = 500;
            ToolTipPneusMod.ShowAlways = true;
            ToolTipPneusMod.SetToolTip(this.ChekPneusPrepaVisitMod, "Vérification de leur usure et de leur déformation !!!");
        }

        private void CheckGazEchappPrepaVisitMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipGazEchappMod = new ToolTip();
            ToolTipGazEchappMod.AutoPopDelay = 5000;
            ToolTipGazEchappMod.InitialDelay = 1000;
            ToolTipGazEchappMod.ReshowDelay = 500;
            ToolTipGazEchappMod.ShowAlways = true;
            ToolTipGazEchappMod.SetToolTip(this.CheckGazEchappPrepaVisitMod, "Détecter un potentiel trou dans le pot ou encore\n une usure trop importante ou une mauvaise fixation !!!");
        }

        private void CheckFreinagePrepaVisitMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipFreingMod = new ToolTip();
            ToolTipFreingMod.AutoPopDelay = 5000;
            ToolTipFreingMod.InitialDelay = 1000;
            ToolTipFreingMod.ReshowDelay = 500;
            ToolTipFreingMod.ShowAlways = true;
            ToolTipFreingMod.SetToolTip(this.CheckFreinagePrepaVisitMod, "Vérification du niveau de liquide de freins\n et de la fiabilité du système de\n freinage et de ses composantes !!!");
        }

        private void CheckReglagePharePrepaVisitMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipPhareMod = new ToolTip();
            ToolTipPhareMod.AutoPopDelay = 5000;
            ToolTipPhareMod.InitialDelay = 1000;
            ToolTipPhareMod.ReshowDelay = 500;
            ToolTipPhareMod.ShowAlways = true;
            ToolTipPhareMod.SetToolTip(this.CheckReglagePharePrepaVisitMod, "Sur le fonctionnement des feux,\n l'état des ampoules et des phares et\n le réglage de ces derniers !!!");
        }

        private void CheckParallelismePrepaVisitMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipParallMod = new ToolTip();
            ToolTipParallMod.AutoPopDelay = 5000;
            ToolTipParallMod.InitialDelay = 1000;
            ToolTipParallMod.ReshowDelay = 500;
            ToolTipParallMod.ShowAlways = true;
            ToolTipParallMod.SetToolTip(this.CheckParallelismePrepaVisitMod, "Vérifier et régler l'allignement des 4 roues\n en fonction du réglage des suspensions.\n Réglage de l'alignement des 2 roues directrices\n et de l'angle des roues par rapport à la route !!!");
        }

        private void BtnVisitTech_Click(object sender, EventArgs e)
        {
            if(CheckFreinagePrepaVisitMod.Checked == true && CheckGazEchappPrepaVisitMod.Checked==true && CheckParallelismePrepaVisitMod.Checked==true && CheckReglagePharePrepaVisitMod.Checked==true && ChekPneusPrepaVisitMod.Checked ==true)
            {
                FormCreatePreparVisit CreatePreparVisit = new FormCreatePreparVisit();
                CreatePreparVisit.ShowDialog();
            }
        }

        private void BtnSavedPrepaVisitMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnSavedPrepaVisitMod, "Enregistrer");
        }

        private void BtnImportPrepaVisitMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnImportPrepaVisitMod, "Joindre doc.");
        }
    }
}
