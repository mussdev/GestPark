
namespace GestPark
{
    partial class FormMainParking
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
            this.gestionDuStationnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreerEmplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelAddFormParcking = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDuStationnementToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDuStationnementToolStripMenuItem
            // 
            this.gestionDuStationnementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreerEmplacementToolStripMenuItem,
            this.FermerToolStripMenuItem});
            this.gestionDuStationnementToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDuStationnementToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.gestionDuStationnementToolStripMenuItem.Name = "gestionDuStationnementToolStripMenuItem";
            this.gestionDuStationnementToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.gestionDuStationnementToolStripMenuItem.Text = "Gestion du stationnement";
            // 
            // CreerEmplacementToolStripMenuItem
            // 
            this.CreerEmplacementToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.CreerEmplacementToolStripMenuItem.Name = "CreerEmplacementToolStripMenuItem";
            this.CreerEmplacementToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.CreerEmplacementToolStripMenuItem.Text = "Créer emplacement";
            this.CreerEmplacementToolStripMenuItem.Click += new System.EventHandler(this.CreerEmplacementToolStripMenuItem_Click);
            // 
            // FermerToolStripMenuItem
            // 
            this.FermerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem";
            this.FermerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.FermerToolStripMenuItem.Text = "Fermer";
            this.FermerToolStripMenuItem.Click += new System.EventHandler(this.FermerToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réservationToolStripMenuItem});
            this.servicesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // réservationToolStripMenuItem
            // 
            this.réservationToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
            this.réservationToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.réservationToolStripMenuItem.Text = "Réservation";
            // 
            // PanelAddFormParcking
            // 
            this.PanelAddFormParcking.BackColor = System.Drawing.Color.Khaki;
            this.PanelAddFormParcking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAddFormParcking.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelAddFormParcking.Location = new System.Drawing.Point(0, 24);
            this.PanelAddFormParcking.Name = "PanelAddFormParcking";
            this.PanelAddFormParcking.Size = new System.Drawing.Size(1095, 721);
            this.PanelAddFormParcking.TabIndex = 2;
            // 
            // FormMainParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 745);
            this.Controls.Add(this.PanelAddFormParcking);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainParking";
            this.Text = "FormMainParking";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDuStationnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private System.Windows.Forms.Panel PanelAddFormParcking;
        private System.Windows.Forms.ToolStripMenuItem CreerEmplacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FermerToolStripMenuItem;
    }
}