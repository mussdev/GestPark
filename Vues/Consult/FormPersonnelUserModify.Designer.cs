namespace GestPark.Vues.Consult
{
    partial class FormPersonnelUserModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonnelUserModify));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxPersMod = new System.Windows.Forms.ListBox();
            this.txtFilterPersonnelMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFilterPersonnelMod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 27);
            this.panel1.TabIndex = 0;
            // 
            // listBoxPersMod
            // 
            this.listBoxPersMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPersMod.ForeColor = System.Drawing.Color.Black;
            this.listBoxPersMod.FormattingEnabled = true;
            this.listBoxPersMod.ItemHeight = 19;
            this.listBoxPersMod.Location = new System.Drawing.Point(0, 0);
            this.listBoxPersMod.Name = "listBoxPersMod";
            this.listBoxPersMod.Size = new System.Drawing.Size(347, 387);
            this.listBoxPersMod.TabIndex = 1;
            this.listBoxPersMod.DoubleClick += new System.EventHandler(this.listBoxPersMod_DoubleClick);
            // 
            // txtFilterPersonnelMod
            // 
            this.txtFilterPersonnelMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterPersonnelMod.BackColor = System.Drawing.Color.White;
            this.txtFilterPersonnelMod.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterPersonnelMod.ForeColor = System.Drawing.Color.Black;
            this.txtFilterPersonnelMod.Location = new System.Drawing.Point(111, -1);
            this.txtFilterPersonnelMod.Name = "txtFilterPersonnelMod";
            this.txtFilterPersonnelMod.Size = new System.Drawing.Size(236, 28);
            this.txtFilterPersonnelMod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rechercher...";
            // 
            // FormPersonnelUserModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(347, 414);
            this.Controls.Add(this.listBoxPersMod);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPersonnelUserModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sélectionner un personnel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListBox listBoxPersMod;
        private System.Windows.Forms.TextBox txtFilterPersonnelMod;
        private System.Windows.Forms.Label label1;
    }
}