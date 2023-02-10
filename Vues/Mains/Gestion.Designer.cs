
namespace GestPark
{
    partial class Gestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion));
            this.MenuGestion = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFormGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuApproVehicule = new System.Windows.Forms.ToolStripMenuItem();
            this.RechargeCarteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsoCarburant = new System.Windows.Forms.ToolStripMenuItem();
            this.SaisirRavitaillement = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewRavitaillementCarburant = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPaieCarburant = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMvtVehicule = new System.Windows.Forms.ToolStripMenuItem();
            this.SaisirDemandeCar = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMvtCar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAffectationVehicule = new System.Windows.Forms.ToolStripMenuItem();
            this.AttribuCar = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAttribuCar = new System.Windows.Forms.ToolStripMenuItem();
            this.PanPrincipalGestion = new System.Windows.Forms.Panel();
            this.MenuGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuGestion
            // 
            this.MenuGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.MenuGestion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGestion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuGestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.MenuApproVehicule,
            this.MenuMvtVehicule,
            this.MenuAffectationVehicule});
            this.MenuGestion.Location = new System.Drawing.Point(0, 0);
            this.MenuGestion.Name = "MenuGestion";
            this.MenuGestion.Size = new System.Drawing.Size(1121, 28);
            this.MenuGestion.TabIndex = 0;
            this.MenuGestion.Text = "MenuItemGestion";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseFormGestion});
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // CloseFormGestion
            // 
            this.CloseFormGestion.Name = "CloseFormGestion";
            this.CloseFormGestion.Size = new System.Drawing.Size(139, 26);
            this.CloseFormGestion.Text = "Fermer";
            this.CloseFormGestion.Click += new System.EventHandler(this.CloseFormGestion_Click);
            // 
            // MenuApproVehicule
            // 
            this.MenuApproVehicule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RechargeCarteMenu,
            this.MenuConsoCarburant});
            this.MenuApproVehicule.ForeColor = System.Drawing.Color.Black;
            this.MenuApproVehicule.Name = "MenuApproVehicule";
            this.MenuApproVehicule.Size = new System.Drawing.Size(151, 24);
            this.MenuApproVehicule.Text = "Approvisionnement";
            // 
            // RechargeCarteMenu
            // 
            this.RechargeCarteMenu.ForeColor = System.Drawing.Color.Black;
            this.RechargeCarteMenu.Name = "RechargeCarteMenu";
            this.RechargeCarteMenu.Size = new System.Drawing.Size(271, 26);
            this.RechargeCarteMenu.Text = "Rechargement des cartes";
            this.RechargeCarteMenu.Click += new System.EventHandler(this.RechargeCarteMenu_Click);
            // 
            // MenuConsoCarburant
            // 
            this.MenuConsoCarburant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaisirRavitaillement,
            this.ViewRavitaillementCarburant,
            this.ViewPaieCarburant});
            this.MenuConsoCarburant.ForeColor = System.Drawing.Color.Black;
            this.MenuConsoCarburant.Name = "MenuConsoCarburant";
            this.MenuConsoCarburant.Size = new System.Drawing.Size(271, 26);
            this.MenuConsoCarburant.Text = "Ravitaillement en carburant";
            // 
            // SaisirRavitaillement
            // 
            this.SaisirRavitaillement.ForeColor = System.Drawing.Color.Black;
            this.SaisirRavitaillement.Name = "SaisirRavitaillement";
            this.SaisirRavitaillement.Size = new System.Drawing.Size(301, 26);
            this.SaisirRavitaillement.Text = "Saisir un ravitaillement";
            this.SaisirRavitaillement.Click += new System.EventHandler(this.SaisirRavitaillement_Click);
            // 
            // ViewRavitaillementCarburant
            // 
            this.ViewRavitaillementCarburant.ForeColor = System.Drawing.Color.Black;
            this.ViewRavitaillementCarburant.Name = "ViewRavitaillementCarburant";
            this.ViewRavitaillementCarburant.Size = new System.Drawing.Size(301, 26);
            this.ViewRavitaillementCarburant.Text = "Consultation des ravitaillements";
            this.ViewRavitaillementCarburant.Click += new System.EventHandler(this.ViewRavitaillementCarburant_Click);
            // 
            // ViewPaieCarburant
            // 
            this.ViewPaieCarburant.ForeColor = System.Drawing.Color.Black;
            this.ViewPaieCarburant.Name = "ViewPaieCarburant";
            this.ViewPaieCarburant.Size = new System.Drawing.Size(301, 26);
            this.ViewPaieCarburant.Text = "Consultation des paiements";
            this.ViewPaieCarburant.Click += new System.EventHandler(this.ViewPaieCarburant_Click);
            // 
            // MenuMvtVehicule
            // 
            this.MenuMvtVehicule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaisirDemandeCar,
            this.ViewMvtCar});
            this.MenuMvtVehicule.ForeColor = System.Drawing.Color.Black;
            this.MenuMvtVehicule.Name = "MenuMvtVehicule";
            this.MenuMvtVehicule.Size = new System.Drawing.Size(102, 24);
            this.MenuMvtVehicule.Text = "Mouvement";
            // 
            // SaisirDemandeCar
            // 
            this.SaisirDemandeCar.ForeColor = System.Drawing.Color.Black;
            this.SaisirDemandeCar.Name = "SaisirDemandeCar";
            this.SaisirDemandeCar.Size = new System.Drawing.Size(345, 26);
            this.SaisirDemandeCar.Text = "Saisir une demande de véhicule";
            this.SaisirDemandeCar.Click += new System.EventHandler(this.SaisirDemandeCar_Click);
            // 
            // ViewMvtCar
            // 
            this.ViewMvtCar.ForeColor = System.Drawing.Color.Black;
            this.ViewMvtCar.Name = "ViewMvtCar";
            this.ViewMvtCar.Size = new System.Drawing.Size(345, 26);
            this.ViewMvtCar.Text = "Consulter les mouvements de véhicule";
            this.ViewMvtCar.Click += new System.EventHandler(this.ViewMvtCar_Click);
            // 
            // MenuAffectationVehicule
            // 
            this.MenuAffectationVehicule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AttribuCar,
            this.ViewAttribuCar});
            this.MenuAffectationVehicule.ForeColor = System.Drawing.Color.Black;
            this.MenuAffectationVehicule.Name = "MenuAffectationVehicule";
            this.MenuAffectationVehicule.Size = new System.Drawing.Size(93, 24);
            this.MenuAffectationVehicule.Text = "Affectation";
            // 
            // AttribuCar
            // 
            this.AttribuCar.ForeColor = System.Drawing.Color.Black;
            this.AttribuCar.Name = "AttribuCar";
            this.AttribuCar.Size = new System.Drawing.Size(343, 26);
            this.AttribuCar.Text = "Attirbuer un véhicule à un agent";
            this.AttribuCar.Click += new System.EventHandler(this.AttribuCar_Click);
            // 
            // ViewAttribuCar
            // 
            this.ViewAttribuCar.ForeColor = System.Drawing.Color.Black;
            this.ViewAttribuCar.Name = "ViewAttribuCar";
            this.ViewAttribuCar.Size = new System.Drawing.Size(343, 26);
            this.ViewAttribuCar.Text = "Consulter les attributions de véhicules";
            this.ViewAttribuCar.Click += new System.EventHandler(this.ViewAttribuCar_Click);
            // 
            // PanPrincipalGestion
            // 
            this.PanPrincipalGestion.BackColor = System.Drawing.Color.White;
            this.PanPrincipalGestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanPrincipalGestion.BackgroundImage")));
            this.PanPrincipalGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanPrincipalGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanPrincipalGestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrincipalGestion.Location = new System.Drawing.Point(0, 28);
            this.PanPrincipalGestion.Name = "PanPrincipalGestion";
            this.PanPrincipalGestion.Size = new System.Drawing.Size(1121, 624);
            this.PanPrincipalGestion.TabIndex = 3;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 652);
            this.Controls.Add(this.PanPrincipalGestion);
            this.Controls.Add(this.MenuGestion);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuGestion;
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.MenuGestion.ResumeLayout(false);
            this.MenuGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem RechargeCarteMenu;
        private System.Windows.Forms.Panel PanPrincipalGestion;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseFormGestion;
        private System.Windows.Forms.ToolStripMenuItem MenuConsoCarburant;
        private System.Windows.Forms.ToolStripMenuItem SaisirRavitaillement;
        private System.Windows.Forms.ToolStripMenuItem ViewRavitaillementCarburant;
        private System.Windows.Forms.ToolStripMenuItem ViewPaieCarburant;
        private System.Windows.Forms.ToolStripMenuItem SaisirDemandeCar;
        private System.Windows.Forms.ToolStripMenuItem ViewMvtCar;
        private System.Windows.Forms.ToolStripMenuItem AttribuCar;
        private System.Windows.Forms.ToolStripMenuItem ViewAttribuCar;
        public System.Windows.Forms.ToolStripMenuItem MenuApproVehicule;
        public System.Windows.Forms.ToolStripMenuItem MenuMvtVehicule;
        public System.Windows.Forms.ToolStripMenuItem MenuAffectationVehicule;
        public System.Windows.Forms.MenuStrip MenuGestion;
    }
}