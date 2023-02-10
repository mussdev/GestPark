
namespace GestPark
{
    partial class TableauDeBord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableauDeBord));
            this.MenuItemTablBord = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFormTblBord = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviDesVéhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuEtatCarRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEtatLavageCar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEtatProv = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuListVehicule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEtatChargeCar = new System.Windows.Forms.ToolStripMenuItem();
            this.PanPrincipalTablBord = new System.Windows.Forms.Panel();
            this.MenuItemTablBord.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemTablBord
            // 
            this.MenuItemTablBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.MenuItemTablBord.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemTablBord.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuItemTablBord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.suiviDesVéhiculeToolStripMenuItem,
            this.rapportsToolStripMenuItem});
            this.MenuItemTablBord.Location = new System.Drawing.Point(0, 0);
            this.MenuItemTablBord.Name = "MenuItemTablBord";
            this.MenuItemTablBord.Size = new System.Drawing.Size(1121, 28);
            this.MenuItemTablBord.TabIndex = 0;
            this.MenuItemTablBord.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseFormTblBord});
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // CloseFormTblBord
            // 
            this.CloseFormTblBord.ForeColor = System.Drawing.Color.Black;
            this.CloseFormTblBord.Name = "CloseFormTblBord";
            this.CloseFormTblBord.Size = new System.Drawing.Size(133, 26);
            this.CloseFormTblBord.Text = "Fermer";
            this.CloseFormTblBord.Click += new System.EventHandler(this.CloseFormTblBord_Click);
            // 
            // suiviDesVéhiculeToolStripMenuItem
            // 
            this.suiviDesVéhiculeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.suiviDesVéhiculeToolStripMenuItem.Name = "suiviDesVéhiculeToolStripMenuItem";
            this.suiviDesVéhiculeToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.suiviDesVéhiculeToolStripMenuItem.Text = "Contrôle des véhicule";
            this.suiviDesVéhiculeToolStripMenuItem.Click += new System.EventHandler(this.suiviDesVéhiculeToolStripMenuItem_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuEtatCarRepair,
            this.menuItemEtatLavageCar,
            this.menuItemEtatProv,
            this.itemMenuListVehicule,
            this.menuItemEtatChargeCar});
            this.rapportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.rapportsToolStripMenuItem.Text = "Inventaire/Statistique";
            // 
            // ItemMenuEtatCarRepair
            // 
            this.ItemMenuEtatCarRepair.BackColor = System.Drawing.Color.Honeydew;
            this.ItemMenuEtatCarRepair.ForeColor = System.Drawing.Color.Black;
            this.ItemMenuEtatCarRepair.Name = "ItemMenuEtatCarRepair";
            this.ItemMenuEtatCarRepair.Size = new System.Drawing.Size(264, 26);
            this.ItemMenuEtatCarRepair.Text = "Etat des véhicules reparés";
            this.ItemMenuEtatCarRepair.Click += new System.EventHandler(this.ItemMenuEtatCarRepair_Click);
            // 
            // menuItemEtatLavageCar
            // 
            this.menuItemEtatLavageCar.BackColor = System.Drawing.Color.Honeydew;
            this.menuItemEtatLavageCar.ForeColor = System.Drawing.Color.Black;
            this.menuItemEtatLavageCar.Name = "menuItemEtatLavageCar";
            this.menuItemEtatLavageCar.Size = new System.Drawing.Size(264, 26);
            this.menuItemEtatLavageCar.Text = "Etat de lavage des véhicules";
            this.menuItemEtatLavageCar.Click += new System.EventHandler(this.menuItemEtatLavageCar_Click);
            // 
            // menuItemEtatProv
            // 
            this.menuItemEtatProv.BackColor = System.Drawing.Color.Honeydew;
            this.menuItemEtatProv.ForeColor = System.Drawing.Color.Black;
            this.menuItemEtatProv.Name = "menuItemEtatProv";
            this.menuItemEtatProv.Size = new System.Drawing.Size(264, 26);
            this.menuItemEtatProv.Text = "Etat des dépenses carburants";
            this.menuItemEtatProv.Click += new System.EventHandler(this.menuItemEtatProv_Click);
            // 
            // itemMenuListVehicule
            // 
            this.itemMenuListVehicule.BackColor = System.Drawing.Color.Honeydew;
            this.itemMenuListVehicule.ForeColor = System.Drawing.Color.Black;
            this.itemMenuListVehicule.Name = "itemMenuListVehicule";
            this.itemMenuListVehicule.Size = new System.Drawing.Size(264, 26);
            this.itemMenuListVehicule.Text = "Listes des véhicules";
            this.itemMenuListVehicule.Click += new System.EventHandler(this.itemMenuListVehicule_Click);
            // 
            // menuItemEtatChargeCar
            // 
            this.menuItemEtatChargeCar.BackColor = System.Drawing.Color.Honeydew;
            this.menuItemEtatChargeCar.ForeColor = System.Drawing.Color.Black;
            this.menuItemEtatChargeCar.Name = "menuItemEtatChargeCar";
            this.menuItemEtatChargeCar.Size = new System.Drawing.Size(264, 26);
            this.menuItemEtatChargeCar.Text = "Etat des charges de véhicules";
            this.menuItemEtatChargeCar.Click += new System.EventHandler(this.menuItemEtatChargeCar_Click);
            // 
            // PanPrincipalTablBord
            // 
            this.PanPrincipalTablBord.BackColor = System.Drawing.Color.White;
            this.PanPrincipalTablBord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanPrincipalTablBord.BackgroundImage")));
            this.PanPrincipalTablBord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanPrincipalTablBord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanPrincipalTablBord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrincipalTablBord.Location = new System.Drawing.Point(0, 28);
            this.PanPrincipalTablBord.Name = "PanPrincipalTablBord";
            this.PanPrincipalTablBord.Size = new System.Drawing.Size(1121, 624);
            this.PanPrincipalTablBord.TabIndex = 1;
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 652);
            this.Controls.Add(this.PanPrincipalTablBord);
            this.Controls.Add(this.MenuItemTablBord);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuItemTablBord;
            this.Name = "TableauDeBord";
            this.Text = "TableauDeBord";
            this.MenuItemTablBord.ResumeLayout(false);
            this.MenuItemTablBord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItemTablBord;
        private System.Windows.Forms.ToolStripMenuItem suiviDesVéhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.Panel PanPrincipalTablBord;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseFormTblBord;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuEtatCarRepair;
        private System.Windows.Forms.ToolStripMenuItem menuItemEtatLavageCar;
        private System.Windows.Forms.ToolStripMenuItem menuItemEtatProv;
        private System.Windows.Forms.ToolStripMenuItem itemMenuListVehicule;
        private System.Windows.Forms.ToolStripMenuItem menuItemEtatChargeCar;
    }
}