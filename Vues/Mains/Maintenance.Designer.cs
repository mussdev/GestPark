
namespace GestPark
{
    partial class Maintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.MenuItemsMaintenance = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFormMaint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntretien = new System.Windows.Forms.ToolStripMenuItem();
            this.lavageAutomobilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaisirLavageAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLavageAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.réparationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRepairCar = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewReparationCar = new System.Windows.Forms.ToolStripMenuItem();
            this.préparationDeVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaisirPrepaVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPrepaVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.vidangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuConsultingVidange = new System.Windows.Forms.ToolStripMenuItem();
            this.autresEntretiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteVéhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirUneVisiteTechniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesVisitesTechniquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piècesDétachéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renouvellementDePièceVéhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsCreateAssur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsConsultAssur = new System.Windows.Forms.ToolStripMenuItem();
            this.PanPrincipalMaint = new System.Windows.Forms.Panel();
            this.MenuItemsMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemsMaintenance
            // 
            this.MenuItemsMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.MenuItemsMaintenance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemsMaintenance.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuItemsMaintenance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.MenuEntretien,
            this.visiteVéhiculeToolStripMenuItem,
            this.piècesDétachéesToolStripMenuItem,
            this.assuranceToolStripMenuItem});
            this.MenuItemsMaintenance.Location = new System.Drawing.Point(0, 0);
            this.MenuItemsMaintenance.Name = "MenuItemsMaintenance";
            this.MenuItemsMaintenance.Size = new System.Drawing.Size(1121, 24);
            this.MenuItemsMaintenance.TabIndex = 0;
            this.MenuItemsMaintenance.Text = "MenuItemMaint";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseFormMaint});
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // CloseFormMaint
            // 
            this.CloseFormMaint.ForeColor = System.Drawing.Color.Black;
            this.CloseFormMaint.Name = "CloseFormMaint";
            this.CloseFormMaint.Size = new System.Drawing.Size(113, 22);
            this.CloseFormMaint.Text = "Fermer";
            this.CloseFormMaint.Click += new System.EventHandler(this.CloseFormMaint_Click);
            // 
            // MenuEntretien
            // 
            this.MenuEntretien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lavageAutomobilleToolStripMenuItem,
            this.réparationToolStripMenuItem,
            this.préparationDeVisiteToolStripMenuItem,
            this.vidangeToolStripMenuItem,
            this.autresEntretiensToolStripMenuItem});
            this.MenuEntretien.ForeColor = System.Drawing.Color.Black;
            this.MenuEntretien.Name = "MenuEntretien";
            this.MenuEntretien.Size = new System.Drawing.Size(88, 20);
            this.MenuEntretien.Text = "Maintenance";
            // 
            // lavageAutomobilleToolStripMenuItem
            // 
            this.lavageAutomobilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaisirLavageAuto,
            this.ViewLavageAuto});
            this.lavageAutomobilleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.lavageAutomobilleToolStripMenuItem.Name = "lavageAutomobilleToolStripMenuItem";
            this.lavageAutomobilleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.lavageAutomobilleToolStripMenuItem.Text = "Lavage automobille";
            // 
            // SaisirLavageAuto
            // 
            this.SaisirLavageAuto.ForeColor = System.Drawing.Color.DimGray;
            this.SaisirLavageAuto.Name = "SaisirLavageAuto";
            this.SaisirLavageAuto.Size = new System.Drawing.Size(186, 22);
            this.SaisirLavageAuto.Text = "Saisie un lavage";
            this.SaisirLavageAuto.Click += new System.EventHandler(this.SaisirLavageAuto_Click);
            // 
            // ViewLavageAuto
            // 
            this.ViewLavageAuto.ForeColor = System.Drawing.Color.DimGray;
            this.ViewLavageAuto.Name = "ViewLavageAuto";
            this.ViewLavageAuto.Size = new System.Drawing.Size(186, 22);
            this.ViewLavageAuto.Text = "Consulter les lavages";
            this.ViewLavageAuto.Click += new System.EventHandler(this.ViewLavageAuto_Click);
            // 
            // réparationToolStripMenuItem
            // 
            this.réparationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateRepairCar,
            this.ViewReparationCar});
            this.réparationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.réparationToolStripMenuItem.Name = "réparationToolStripMenuItem";
            this.réparationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.réparationToolStripMenuItem.Text = "Réparation";
            // 
            // CreateRepairCar
            // 
            this.CreateRepairCar.ForeColor = System.Drawing.Color.DimGray;
            this.CreateRepairCar.Name = "CreateRepairCar";
            this.CreateRepairCar.Size = new System.Drawing.Size(226, 22);
            this.CreateRepairCar.Text = "Saisir une réparation";
            this.CreateRepairCar.Click += new System.EventHandler(this.CreateRepairCar_Click);
            // 
            // ViewReparationCar
            // 
            this.ViewReparationCar.ForeColor = System.Drawing.Color.DimGray;
            this.ViewReparationCar.Name = "ViewReparationCar";
            this.ViewReparationCar.Size = new System.Drawing.Size(226, 22);
            this.ViewReparationCar.Text = "Consultation des réparations";
            this.ViewReparationCar.Click += new System.EventHandler(this.ViewReparationCar_Click);
            // 
            // préparationDeVisiteToolStripMenuItem
            // 
            this.préparationDeVisiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaisirPrepaVisit,
            this.ViewPrepaVisit});
            this.préparationDeVisiteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.préparationDeVisiteToolStripMenuItem.Name = "préparationDeVisiteToolStripMenuItem";
            this.préparationDeVisiteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.préparationDeVisiteToolStripMenuItem.Text = "Préparation de visite";
            // 
            // SaisirPrepaVisit
            // 
            this.SaisirPrepaVisit.ForeColor = System.Drawing.Color.DimGray;
            this.SaisirPrepaVisit.Name = "SaisirPrepaVisit";
            this.SaisirPrepaVisit.Size = new System.Drawing.Size(301, 22);
            this.SaisirPrepaVisit.Text = "Saisir une préparation de visite de véhicule";
            this.SaisirPrepaVisit.Click += new System.EventHandler(this.SaisirPrepaVisit_Click);
            // 
            // ViewPrepaVisit
            // 
            this.ViewPrepaVisit.ForeColor = System.Drawing.Color.DimGray;
            this.ViewPrepaVisit.Name = "ViewPrepaVisit";
            this.ViewPrepaVisit.Size = new System.Drawing.Size(301, 22);
            this.ViewPrepaVisit.Text = "Consultation des visites préparées";
            this.ViewPrepaVisit.Click += new System.EventHandler(this.ViewPrepaVisit_Click);
            // 
            // vidangeToolStripMenuItem
            // 
            this.vidangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuConsultingVidange});
            this.vidangeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vidangeToolStripMenuItem.Name = "vidangeToolStripMenuItem";
            this.vidangeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.vidangeToolStripMenuItem.Text = "Vidange";
            // 
            // itemMenuConsultingVidange
            // 
            this.itemMenuConsultingVidange.ForeColor = System.Drawing.Color.DimGray;
            this.itemMenuConsultingVidange.Name = "itemMenuConsultingVidange";
            this.itemMenuConsultingVidange.Size = new System.Drawing.Size(234, 22);
            this.itemMenuConsultingVidange.Text = "Consulter la liste des vidanges";
            this.itemMenuConsultingVidange.Click += new System.EventHandler(this.itemMenuConsultingVidange_Click);
            // 
            // autresEntretiensToolStripMenuItem
            // 
            this.autresEntretiensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisirToolStripMenuItem,
            this.consulterToolStripMenuItem});
            this.autresEntretiensToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.autresEntretiensToolStripMenuItem.Name = "autresEntretiensToolStripMenuItem";
            this.autresEntretiensToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.autresEntretiensToolStripMenuItem.Text = "Autres entretiens";
            // 
            // saisirToolStripMenuItem
            // 
            this.saisirToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.saisirToolStripMenuItem.Name = "saisirToolStripMenuItem";
            this.saisirToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.saisirToolStripMenuItem.Text = "Saisir un entretien de véhicule";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.consulterToolStripMenuItem.Text = "Consulter la liste des entretiens";
            // 
            // visiteVéhiculeToolStripMenuItem
            // 
            this.visiteVéhiculeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisirUneVisiteTechniqueToolStripMenuItem,
            this.consulterLesVisitesTechniquesToolStripMenuItem});
            this.visiteVéhiculeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.visiteVéhiculeToolStripMenuItem.Name = "visiteVéhiculeToolStripMenuItem";
            this.visiteVéhiculeToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.visiteVéhiculeToolStripMenuItem.Text = "Visite technique de véhicule";
            // 
            // saisirUneVisiteTechniqueToolStripMenuItem
            // 
            this.saisirUneVisiteTechniqueToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saisirUneVisiteTechniqueToolStripMenuItem.Name = "saisirUneVisiteTechniqueToolStripMenuItem";
            this.saisirUneVisiteTechniqueToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.saisirUneVisiteTechniqueToolStripMenuItem.Text = "Saisir une visite technique";
            // 
            // consulterLesVisitesTechniquesToolStripMenuItem
            // 
            this.consulterLesVisitesTechniquesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.consulterLesVisitesTechniquesToolStripMenuItem.Name = "consulterLesVisitesTechniquesToolStripMenuItem";
            this.consulterLesVisitesTechniquesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.consulterLesVisitesTechniquesToolStripMenuItem.Text = "Consulter les visites techniques";
            this.consulterLesVisitesTechniquesToolStripMenuItem.Click += new System.EventHandler(this.consulterLesVisitesTechniquesToolStripMenuItem_Click);
            // 
            // piècesDétachéesToolStripMenuItem
            // 
            this.piècesDétachéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renouvellementDePièceVéhiculeToolStripMenuItem});
            this.piècesDétachéesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.piècesDétachéesToolStripMenuItem.Name = "piècesDétachéesToolStripMenuItem";
            this.piècesDétachéesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.piècesDétachéesToolStripMenuItem.Text = "Pièces détachées";
            // 
            // renouvellementDePièceVéhiculeToolStripMenuItem
            // 
            this.renouvellementDePièceVéhiculeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.renouvellementDePièceVéhiculeToolStripMenuItem.Name = "renouvellementDePièceVéhiculeToolStripMenuItem";
            this.renouvellementDePièceVéhiculeToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.renouvellementDePièceVéhiculeToolStripMenuItem.Text = "Renouvellement de pièce véhicule";
            // 
            // assuranceToolStripMenuItem
            // 
            this.assuranceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemsCreateAssur,
            this.menuItemsConsultAssur});
            this.assuranceToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.assuranceToolStripMenuItem.Name = "assuranceToolStripMenuItem";
            this.assuranceToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.assuranceToolStripMenuItem.Text = "Assurance";
            // 
            // menuItemsCreateAssur
            // 
            this.menuItemsCreateAssur.ForeColor = System.Drawing.Color.Black;
            this.menuItemsCreateAssur.Name = "menuItemsCreateAssur";
            this.menuItemsCreateAssur.Size = new System.Drawing.Size(184, 22);
            this.menuItemsCreateAssur.Text = "Saisir une assurance";
            this.menuItemsCreateAssur.Click += new System.EventHandler(this.menuItemsCreateAssur_Click);
            // 
            // menuItemsConsultAssur
            // 
            this.menuItemsConsultAssur.ForeColor = System.Drawing.Color.Black;
            this.menuItemsConsultAssur.Name = "menuItemsConsultAssur";
            this.menuItemsConsultAssur.Size = new System.Drawing.Size(184, 22);
            this.menuItemsConsultAssur.Text = "Consulter";
            this.menuItemsConsultAssur.Click += new System.EventHandler(this.menuItemsConsultAssur_Click);
            // 
            // PanPrincipalMaint
            // 
            this.PanPrincipalMaint.BackColor = System.Drawing.Color.Honeydew;
            this.PanPrincipalMaint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanPrincipalMaint.BackgroundImage")));
            this.PanPrincipalMaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanPrincipalMaint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanPrincipalMaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrincipalMaint.Location = new System.Drawing.Point(0, 24);
            this.PanPrincipalMaint.Name = "PanPrincipalMaint";
            this.PanPrincipalMaint.Size = new System.Drawing.Size(1121, 628);
            this.PanPrincipalMaint.TabIndex = 1;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1121, 652);
            this.Controls.Add(this.PanPrincipalMaint);
            this.Controls.Add(this.MenuItemsMaintenance);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuItemsMaintenance;
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.MenuItemsMaintenance.ResumeLayout(false);
            this.MenuItemsMaintenance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItemsMaintenance;
        private System.Windows.Forms.ToolStripMenuItem MenuEntretien;
        private System.Windows.Forms.ToolStripMenuItem visiteVéhiculeToolStripMenuItem;
        private System.Windows.Forms.Panel PanPrincipalMaint;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseFormMaint;
        private System.Windows.Forms.ToolStripMenuItem lavageAutomobilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaisirLavageAuto;
        private System.Windows.Forms.ToolStripMenuItem ViewLavageAuto;
        private System.Windows.Forms.ToolStripMenuItem réparationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewReparationCar;
        private System.Windows.Forms.ToolStripMenuItem préparationDeVisiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaisirPrepaVisit;
        private System.Windows.Forms.ToolStripMenuItem ViewPrepaVisit;
        private System.Windows.Forms.ToolStripMenuItem saisirUneVisiteTechniqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesVisitesTechniquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateRepairCar;
        private System.Windows.Forms.ToolStripMenuItem vidangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuConsultingVidange;
        private System.Windows.Forms.ToolStripMenuItem autresEntretiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piècesDétachéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renouvellementDePièceVéhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assuranceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemsCreateAssur;
        private System.Windows.Forms.ToolStripMenuItem menuItemsConsultAssur;
    }
}