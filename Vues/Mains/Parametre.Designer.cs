
namespace GestPark
{
    partial class Parametre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametre));
            this.MenuItemsParam = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFormParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarq = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEnergie = new System.Windows.Forms.ToolStripMenuItem();
            this.véhiculeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaisirCar = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCar = new System.Windows.Forms.ToolStripMenuItem();
            this.GarageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CardCarburantMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FourMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuService = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDir = new System.Windows.Forms.ToolStripMenuItem();
            this.niveauDeValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuValMvt = new System.Windows.Forms.ToolStripMenuItem();
            this.transiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuTransDemandVehi = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuNiveauTransition = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuConducteur = new System.Windows.Forms.ToolStripMenuItem();
            this.PanPrincipalParam = new System.Windows.Forms.Panel();
            this.MenuItemsParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemsParam
            // 
            this.MenuItemsParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.MenuItemsParam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemsParam.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuItemsParam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.MenuMarq,
            this.MenuEnergie,
            this.véhiculeToolStripMenuItem1,
            this.GarageMenu,
            this.CardCarburantMenu,
            this.personnelToolStripMenuItem,
            this.MenuService,
            this.MenuDir,
            this.niveauDeValidationToolStripMenuItem,
            this.transiToolStripMenuItem});
            this.MenuItemsParam.Location = new System.Drawing.Point(0, 0);
            this.MenuItemsParam.Name = "MenuItemsParam";
            this.MenuItemsParam.Size = new System.Drawing.Size(1121, 30);
            this.MenuItemsParam.TabIndex = 0;
            this.MenuItemsParam.Text = "MenuItemParam";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseFormParam});
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // CloseFormParam
            // 
            this.CloseFormParam.ForeColor = System.Drawing.Color.Black;
            this.CloseFormParam.Name = "CloseFormParam";
            this.CloseFormParam.Size = new System.Drawing.Size(139, 26);
            this.CloseFormParam.Text = "Fermer";
            this.CloseFormParam.Click += new System.EventHandler(this.CloseFormParam_Click);
            // 
            // MenuMarq
            // 
            this.MenuMarq.ForeColor = System.Drawing.Color.Black;
            this.MenuMarq.Name = "MenuMarq";
            this.MenuMarq.Size = new System.Drawing.Size(74, 26);
            this.MenuMarq.Text = "Marque";
            this.MenuMarq.Click += new System.EventHandler(this.MenuMarq_Click_1);
            // 
            // MenuEnergie
            // 
            this.MenuEnergie.ForeColor = System.Drawing.Color.Black;
            this.MenuEnergie.Name = "MenuEnergie";
            this.MenuEnergie.Size = new System.Drawing.Size(74, 26);
            this.MenuEnergie.Text = "Energie";
            this.MenuEnergie.Click += new System.EventHandler(this.MenuEnergie_Click);
            // 
            // véhiculeToolStripMenuItem1
            // 
            this.véhiculeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaisirCar,
            this.ViewCar});
            this.véhiculeToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.véhiculeToolStripMenuItem1.Name = "véhiculeToolStripMenuItem1";
            this.véhiculeToolStripMenuItem1.Size = new System.Drawing.Size(79, 26);
            this.véhiculeToolStripMenuItem1.Text = "Véhicule";
            // 
            // SaisirCar
            // 
            this.SaisirCar.ForeColor = System.Drawing.Color.Black;
            this.SaisirCar.Name = "SaisirCar";
            this.SaisirCar.Size = new System.Drawing.Size(244, 26);
            this.SaisirCar.Text = "Saisir un véhicule";
            this.SaisirCar.Click += new System.EventHandler(this.SaisirCar_Click);
            // 
            // ViewCar
            // 
            this.ViewCar.ForeColor = System.Drawing.Color.Black;
            this.ViewCar.Name = "ViewCar";
            this.ViewCar.Size = new System.Drawing.Size(244, 26);
            this.ViewCar.Text = "Consulter les véhicules";
            this.ViewCar.Click += new System.EventHandler(this.ViewCar_Click);
            // 
            // GarageMenu
            // 
            this.GarageMenu.ForeColor = System.Drawing.Color.Black;
            this.GarageMenu.Name = "GarageMenu";
            this.GarageMenu.Size = new System.Drawing.Size(69, 26);
            this.GarageMenu.Text = "Garage";
            this.GarageMenu.Click += new System.EventHandler(this.GarageMenu_Click);
            // 
            // CardCarburantMenu
            // 
            this.CardCarburantMenu.ForeColor = System.Drawing.Color.Black;
            this.CardCarburantMenu.Name = "CardCarburantMenu";
            this.CardCarburantMenu.Size = new System.Drawing.Size(125, 26);
            this.CardCarburantMenu.Text = "Carte carburant";
            this.CardCarburantMenu.Click += new System.EventHandler(this.CardCarburantMenu_Click);
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonMenu,
            this.FourMenu,
            this.itemMenuConducteur});
            this.personnelToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.personnelToolStripMenuItem.Text = "Acteurs";
            // 
            // PersonMenu
            // 
            this.PersonMenu.ForeColor = System.Drawing.Color.Black;
            this.PersonMenu.Name = "PersonMenu";
            this.PersonMenu.Size = new System.Drawing.Size(224, 26);
            this.PersonMenu.Text = "Personnels";
            this.PersonMenu.Click += new System.EventHandler(this.PersonMenu_Click);
            // 
            // FourMenu
            // 
            this.FourMenu.ForeColor = System.Drawing.Color.Black;
            this.FourMenu.Name = "FourMenu";
            this.FourMenu.Size = new System.Drawing.Size(224, 26);
            this.FourMenu.Text = "Fournisseur";
            this.FourMenu.Click += new System.EventHandler(this.FourMenu_Click);
            // 
            // MenuService
            // 
            this.MenuService.ForeColor = System.Drawing.Color.Black;
            this.MenuService.Name = "MenuService";
            this.MenuService.Size = new System.Drawing.Size(78, 26);
            this.MenuService.Text = "Services";
            this.MenuService.Click += new System.EventHandler(this.MenuService_Click);
            // 
            // MenuDir
            // 
            this.MenuDir.ForeColor = System.Drawing.Color.Black;
            this.MenuDir.Name = "MenuDir";
            this.MenuDir.Size = new System.Drawing.Size(90, 26);
            this.MenuDir.Text = "Directions";
            this.MenuDir.Click += new System.EventHandler(this.MenuDir_Click);
            // 
            // niveauDeValidationToolStripMenuItem
            // 
            this.niveauDeValidationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuValMvt});
            this.niveauDeValidationToolStripMenuItem.Name = "niveauDeValidationToolStripMenuItem";
            this.niveauDeValidationToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.niveauDeValidationToolStripMenuItem.Text = "Statut de validation";
            // 
            // itemMenuValMvt
            // 
            this.itemMenuValMvt.Name = "itemMenuValMvt";
            this.itemMenuValMvt.Size = new System.Drawing.Size(238, 26);
            this.itemMenuValMvt.Text = "Validation Mouvement";
            this.itemMenuValMvt.Click += new System.EventHandler(this.itemMenuValMvt_Click);
            // 
            // transiToolStripMenuItem
            // 
            this.transiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuTransDemandVehi,
            this.ItemMenuNiveauTransition});
            this.transiToolStripMenuItem.Name = "transiToolStripMenuItem";
            this.transiToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.transiToolStripMenuItem.Text = "Transition/Niveau";
            // 
            // ItemMenuTransDemandVehi
            // 
            this.ItemMenuTransDemandVehi.Name = "ItemMenuTransDemandVehi";
            this.ItemMenuTransDemandVehi.Size = new System.Drawing.Size(298, 26);
            this.ItemMenuTransDemandVehi.Text = "Transition demande de véhicule";
            this.ItemMenuTransDemandVehi.Click += new System.EventHandler(this.ItemMenuTransDemandVehi_Click);
            // 
            // ItemMenuNiveauTransition
            // 
            this.ItemMenuNiveauTransition.Name = "ItemMenuNiveauTransition";
            this.ItemMenuNiveauTransition.Size = new System.Drawing.Size(298, 26);
            this.ItemMenuNiveauTransition.Text = "Niveau de transition";
            this.ItemMenuNiveauTransition.Click += new System.EventHandler(this.ItemMenuNiveauTransition_Click);
            // 
            // itemMenuConducteur
            // 
            this.itemMenuConducteur.Name = "itemMenuConducteur";
            this.itemMenuConducteur.Size = new System.Drawing.Size(224, 26);
            this.itemMenuConducteur.Text = "Conducteur";
            this.itemMenuConducteur.Click += new System.EventHandler(this.itemMenuConducteur_Click);
            // 
            // PanPrincipalParam
            // 
            this.PanPrincipalParam.BackColor = System.Drawing.Color.Transparent;
            this.PanPrincipalParam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanPrincipalParam.BackgroundImage")));
            this.PanPrincipalParam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanPrincipalParam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanPrincipalParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrincipalParam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanPrincipalParam.Location = new System.Drawing.Point(0, 30);
            this.PanPrincipalParam.Name = "PanPrincipalParam";
            this.PanPrincipalParam.Size = new System.Drawing.Size(1121, 622);
            this.PanPrincipalParam.TabIndex = 1;
            // 
            // Parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 652);
            this.Controls.Add(this.PanPrincipalParam);
            this.Controls.Add(this.MenuItemsParam);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuItemsParam;
            this.Name = "Parametre";
            this.Text = "Parametre";
            this.MenuItemsParam.ResumeLayout(false);
            this.MenuItemsParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItemsParam;
        private System.Windows.Forms.ToolStripMenuItem GarageMenu;
        private System.Windows.Forms.ToolStripMenuItem CardCarburantMenu;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonMenu;
        private System.Windows.Forms.ToolStripMenuItem FourMenu;
        private System.Windows.Forms.Panel PanPrincipalParam;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseFormParam;
        private System.Windows.Forms.ToolStripMenuItem MenuMarq;
        private System.Windows.Forms.ToolStripMenuItem MenuEnergie;
        private System.Windows.Forms.ToolStripMenuItem véhiculeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaisirCar;
        private System.Windows.Forms.ToolStripMenuItem ViewCar;
        private System.Windows.Forms.ToolStripMenuItem MenuService;
        private System.Windows.Forms.ToolStripMenuItem MenuDir;
        private System.Windows.Forms.ToolStripMenuItem niveauDeValidationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuValMvt;
        private System.Windows.Forms.ToolStripMenuItem transiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuTransDemandVehi;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuNiveauTransition;
        private System.Windows.Forms.ToolStripMenuItem itemMenuConducteur;
    }
}