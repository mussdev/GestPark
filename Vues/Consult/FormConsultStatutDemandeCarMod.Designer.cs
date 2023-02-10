namespace GestPark.Vues.Consult
{
    partial class FormConsultStatutDemandeCarMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultStatutDemandeCarMod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxDemandeCarMod = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 24);
            this.panel1.TabIndex = 0;
            // 
            // listBoxDemandeCarMod
            // 
            this.listBoxDemandeCarMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDemandeCarMod.FormattingEnabled = true;
            this.listBoxDemandeCarMod.ItemHeight = 19;
            this.listBoxDemandeCarMod.Location = new System.Drawing.Point(0, 0);
            this.listBoxDemandeCarMod.Name = "listBoxDemandeCarMod";
            this.listBoxDemandeCarMod.Size = new System.Drawing.Size(382, 417);
            this.listBoxDemandeCarMod.TabIndex = 1;
            this.listBoxDemandeCarMod.DoubleClick += new System.EventHandler(this.listBoxDemandeCarMod_DoubleClick);
            // 
            // FormConsultStatutDemandeCarMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(382, 441);
            this.Controls.Add(this.listBoxDemandeCarMod);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConsultStatutDemandeCarMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sélectionner un statut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListBox listBoxDemandeCarMod;
    }
}