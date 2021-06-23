
namespace GestPark
{
    partial class FormEntretienVehicule
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
            this.panelTitleEntretien = new System.Windows.Forms.Panel();
            this.panelSearchFormEntretien = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconBtnSearchFormEntretien = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormEntretien = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreateEntretien = new FontAwesome.Sharp.IconButton();
            this.panelTitleEntretien.SuspendLayout();
            this.panelSearchFormEntretien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleEntretien
            // 
            this.panelTitleEntretien.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTitleEntretien.Controls.Add(this.iconBtnCloseFormEntretien);
            this.panelTitleEntretien.Controls.Add(this.iconBtnCreateEntretien);
            this.panelTitleEntretien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleEntretien.Location = new System.Drawing.Point(0, 0);
            this.panelTitleEntretien.Name = "panelTitleEntretien";
            this.panelTitleEntretien.Size = new System.Drawing.Size(1118, 33);
            this.panelTitleEntretien.TabIndex = 0;
            // 
            // panelSearchFormEntretien
            // 
            this.panelSearchFormEntretien.BackColor = System.Drawing.Color.White;
            this.panelSearchFormEntretien.Controls.Add(this.iconButton1);
            this.panelSearchFormEntretien.Controls.Add(this.iconBtnSearchFormEntretien);
            this.panelSearchFormEntretien.Controls.Add(this.textBox1);
            this.panelSearchFormEntretien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchFormEntretien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearchFormEntretien.Location = new System.Drawing.Point(0, 33);
            this.panelSearchFormEntretien.Name = "panelSearchFormEntretien";
            this.panelSearchFormEntretien.Size = new System.Drawing.Size(1118, 142);
            this.panelSearchFormEntretien.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 22);
            this.textBox1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1006, 106);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Exporter";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconBtnSearchFormEntretien
            // 
            this.iconBtnSearchFormEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchFormEntretien.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchFormEntretien.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSearchFormEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchFormEntretien.IconSize = 20;
            this.iconBtnSearchFormEntretien.Location = new System.Drawing.Point(863, 55);
            this.iconBtnSearchFormEntretien.Name = "iconBtnSearchFormEntretien";
            this.iconBtnSearchFormEntretien.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconBtnSearchFormEntretien.Size = new System.Drawing.Size(44, 23);
            this.iconBtnSearchFormEntretien.TabIndex = 1;
            this.iconBtnSearchFormEntretien.UseVisualStyleBackColor = false;
            // 
            // iconBtnCloseFormEntretien
            // 
            this.iconBtnCloseFormEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormEntretien.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseFormEntretien.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormEntretien.IconSize = 35;
            this.iconBtnCloseFormEntretien.Location = new System.Drawing.Point(1079, 0);
            this.iconBtnCloseFormEntretien.Name = "iconBtnCloseFormEntretien";
            this.iconBtnCloseFormEntretien.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconBtnCloseFormEntretien.Size = new System.Drawing.Size(39, 33);
            this.iconBtnCloseFormEntretien.TabIndex = 2;
            this.iconBtnCloseFormEntretien.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormEntretien.Click += new System.EventHandler(this.iconBtnCloseFormEntretien_Click_1);
            // 
            // iconBtnCreateEntretien
            // 
            this.iconBtnCreateEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnCreateEntretien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCreateEntretien.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreateEntretien.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnCreateEntretien.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreateEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCreateEntretien.IconSize = 30;
            this.iconBtnCreateEntretien.Location = new System.Drawing.Point(0, 0);
            this.iconBtnCreateEntretien.Name = "iconBtnCreateEntretien";
            this.iconBtnCreateEntretien.Size = new System.Drawing.Size(152, 33);
            this.iconBtnCreateEntretien.TabIndex = 0;
            this.iconBtnCreateEntretien.Text = "Saisir entretien";
            this.iconBtnCreateEntretien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCreateEntretien.UseVisualStyleBackColor = false;
            this.iconBtnCreateEntretien.Click += new System.EventHandler(this.iconBtnCreateEntretien_Click);
            // 
            // FormEntretienVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.panelSearchFormEntretien);
            this.Controls.Add(this.panelTitleEntretien);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntretienVehicule";
            this.Text = "FormEntretienVehicule";
            this.panelTitleEntretien.ResumeLayout(false);
            this.panelSearchFormEntretien.ResumeLayout(false);
            this.panelSearchFormEntretien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleEntretien;
        private FontAwesome.Sharp.IconButton iconBtnCreateEntretien;
        private System.Windows.Forms.Panel panelSearchFormEntretien;
        private FontAwesome.Sharp.IconButton iconBtnSearchFormEntretien;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormEntretien;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}