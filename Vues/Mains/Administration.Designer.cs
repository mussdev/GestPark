
namespace GestPark
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.MenuItemAdmin = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFormAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.PanPrincipalAdmin = new System.Windows.Forms.Panel();
            this.MenuItemAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemAdmin
            // 
            this.MenuItemAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.MenuItemAdmin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuItemAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.MenuUser,
            this.MenuRoles});
            this.MenuItemAdmin.Location = new System.Drawing.Point(0, 0);
            this.MenuItemAdmin.Name = "MenuItemAdmin";
            this.MenuItemAdmin.Size = new System.Drawing.Size(1121, 30);
            this.MenuItemAdmin.TabIndex = 0;
            this.MenuItemAdmin.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseFormAdmin});
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // CloseFormAdmin
            // 
            this.CloseFormAdmin.ForeColor = System.Drawing.Color.Black;
            this.CloseFormAdmin.Name = "CloseFormAdmin";
            this.CloseFormAdmin.Size = new System.Drawing.Size(133, 26);
            this.CloseFormAdmin.Text = "Fermer";
            this.CloseFormAdmin.Click += new System.EventHandler(this.CloseFormAdmin_Click);
            // 
            // MenuUser
            // 
            this.MenuUser.ForeColor = System.Drawing.Color.Black;
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(82, 26);
            this.MenuUser.Text = "Utilisateur";
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // MenuRoles
            // 
            this.MenuRoles.ForeColor = System.Drawing.Color.Black;
            this.MenuRoles.Name = "MenuRoles";
            this.MenuRoles.Size = new System.Drawing.Size(55, 26);
            this.MenuRoles.Text = "Rôles";
            this.MenuRoles.Click += new System.EventHandler(this.MenuRoles_Click);
            // 
            // PanPrincipalAdmin
            // 
            this.PanPrincipalAdmin.BackColor = System.Drawing.Color.White;
            this.PanPrincipalAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanPrincipalAdmin.BackgroundImage")));
            this.PanPrincipalAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanPrincipalAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanPrincipalAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrincipalAdmin.Location = new System.Drawing.Point(0, 30);
            this.PanPrincipalAdmin.Name = "PanPrincipalAdmin";
            this.PanPrincipalAdmin.Size = new System.Drawing.Size(1121, 622);
            this.PanPrincipalAdmin.TabIndex = 1;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 652);
            this.Controls.Add(this.PanPrincipalAdmin);
            this.Controls.Add(this.MenuItemAdmin);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.YellowGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuItemAdmin;
            this.Name = "Administration";
            this.Text = "Administration";
            this.MenuItemAdmin.ResumeLayout(false);
            this.MenuItemAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItemAdmin;
        private System.Windows.Forms.ToolStripMenuItem MenuUser;
        private System.Windows.Forms.ToolStripMenuItem MenuRoles;
        private System.Windows.Forms.Panel PanPrincipalAdmin;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseFormAdmin;
    }
}