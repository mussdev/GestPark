
namespace GestPark
{
    partial class FormMainVehicule
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItemConsultVe = new System.Windows.Forms.ToolStripMenuItem();
            this.AttribuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsommationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepairTlStpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WhatchingAutoTlStpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionTlStpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuVehicule = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.PanneToolStripMenuItem,
            this.ConsommationToolStripMenuItem,
            this.mouvementsToolStripMenuItem,
            this.RepairTlStpMenuItem,
            this.WhatchingAutoTlStpMenuItem,
            this.GestionTlStpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.consulterToolStripMenuItemConsultVe,
            this.AttribuerToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "Vehicule";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.créerToolStripMenuItem.Text = "Créer";
            this.créerToolStripMenuItem.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItemConsultVe
            // 
            this.consulterToolStripMenuItemConsultVe.ForeColor = System.Drawing.Color.DarkGreen;
            this.consulterToolStripMenuItemConsultVe.Name = "consulterToolStripMenuItemConsultVe";
            this.consulterToolStripMenuItemConsultVe.Size = new System.Drawing.Size(129, 22);
            this.consulterToolStripMenuItemConsultVe.Text = "Consulter";
            this.consulterToolStripMenuItemConsultVe.Click += new System.EventHandler(this.consulterToolStripMenuItemConsultVe_Click);
            // 
            // AttribuerToolStripMenuItem
            // 
            this.AttribuerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.AttribuerToolStripMenuItem.Name = "AttribuerToolStripMenuItem";
            this.AttribuerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.AttribuerToolStripMenuItem.Text = "Attribuer";
            this.AttribuerToolStripMenuItem.Click += new System.EventHandler(this.AttribuerToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // PanneToolStripMenuItem
            // 
            this.PanneToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanneToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.PanneToolStripMenuItem.Name = "PanneToolStripMenuItem";
            this.PanneToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.PanneToolStripMenuItem.Text = "Panne";
            this.PanneToolStripMenuItem.Click += new System.EventHandler(this.PanneToolStripMenuItem_Click);
            // 
            // ConsommationToolStripMenuItem
            // 
            this.ConsommationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsommationToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.ConsommationToolStripMenuItem.Name = "ConsommationToolStripMenuItem";
            this.ConsommationToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.ConsommationToolStripMenuItem.Text = "Consommation";
            this.ConsommationToolStripMenuItem.Click += new System.EventHandler(this.ConsommationToolStripMenuItem_Click);
            // 
            // mouvementsToolStripMenuItem
            // 
            this.mouvementsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouvementsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.mouvementsToolStripMenuItem.Name = "mouvementsToolStripMenuItem";
            this.mouvementsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mouvementsToolStripMenuItem.Text = "Mouvements";
            this.mouvementsToolStripMenuItem.Click += new System.EventHandler(this.mouvementsToolStripMenuItem_Click);
            // 
            // RepairTlStpMenuItem
            // 
            this.RepairTlStpMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairTlStpMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.RepairTlStpMenuItem.Name = "RepairTlStpMenuItem";
            this.RepairTlStpMenuItem.Size = new System.Drawing.Size(79, 20);
            this.RepairTlStpMenuItem.Text = "Reparation";
            this.RepairTlStpMenuItem.Click += new System.EventHandler(this.RepairTlStpMenuItem_Click);
            // 
            // WhatchingAutoTlStpMenuItem
            // 
            this.WhatchingAutoTlStpMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatchingAutoTlStpMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.WhatchingAutoTlStpMenuItem.Name = "WhatchingAutoTlStpMenuItem";
            this.WhatchingAutoTlStpMenuItem.Size = new System.Drawing.Size(83, 20);
            this.WhatchingAutoTlStpMenuItem.Text = "Lavage auto";
            this.WhatchingAutoTlStpMenuItem.Click += new System.EventHandler(this.WhatchingAutoTlStpMenuItem_Click);
            // 
            // GestionTlStpMenuItem
            // 
            this.GestionTlStpMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionTlStpMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.GestionTlStpMenuItem.Name = "GestionTlStpMenuItem";
            this.GestionTlStpMenuItem.Size = new System.Drawing.Size(61, 20);
            this.GestionTlStpMenuItem.Text = "Gestion";
            // 
            // panelMenuVehicule
            // 
            this.panelMenuVehicule.BackColor = System.Drawing.Color.Khaki;
            this.panelMenuVehicule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuVehicule.Location = new System.Drawing.Point(0, 24);
            this.panelMenuVehicule.Name = "panelMenuVehicule";
            this.panelMenuVehicule.Size = new System.Drawing.Size(1095, 721);
            this.panelMenuVehicule.TabIndex = 1;
            // 
            // FormMainVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 745);
            this.Controls.Add(this.panelMenuVehicule);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainVehicule";
            this.Text = "FormMainVehicule";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItemConsultVe;
        private System.Windows.Forms.ToolStripMenuItem AttribuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PanneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsommationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RepairTlStpMenuItem;
        private System.Windows.Forms.Panel panelMenuVehicule;
        private System.Windows.Forms.ToolStripMenuItem WhatchingAutoTlStpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionTlStpMenuItem;
    }
}