
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
            this.BtnExportCarEntretien = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormEntretien = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreateEntretien = new FontAwesome.Sharp.IconButton();
            this.panelSearchFormEntretien = new System.Windows.Forms.Panel();
            this.iconBtnSearchFormEntretien = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTitleEntretien.SuspendLayout();
            this.panelSearchFormEntretien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleEntretien
            // 
            this.panelTitleEntretien.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTitleEntretien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitleEntretien.Controls.Add(this.BtnExportCarEntretien);
            this.panelTitleEntretien.Controls.Add(this.iconBtnCloseFormEntretien);
            this.panelTitleEntretien.Controls.Add(this.iconBtnCreateEntretien);
            this.panelTitleEntretien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleEntretien.Location = new System.Drawing.Point(0, 0);
            this.panelTitleEntretien.Name = "panelTitleEntretien";
            this.panelTitleEntretien.Size = new System.Drawing.Size(1118, 27);
            this.panelTitleEntretien.TabIndex = 0;
            // 
            // BtnExportCarEntretien
            // 
            this.BtnExportCarEntretien.BackColor = System.Drawing.Color.White;
            this.BtnExportCarEntretien.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnExportCarEntretien.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnExportCarEntretien.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnExportCarEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportCarEntretien.IconSize = 20;
            this.BtnExportCarEntretien.Location = new System.Drawing.Point(127, -2);
            this.BtnExportCarEntretien.Name = "BtnExportCarEntretien";
            this.BtnExportCarEntretien.Size = new System.Drawing.Size(96, 27);
            this.BtnExportCarEntretien.TabIndex = 2;
            this.BtnExportCarEntretien.Text = "Exporter";
            this.BtnExportCarEntretien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportCarEntretien.UseVisualStyleBackColor = false;
            this.BtnExportCarEntretien.Click += new System.EventHandler(this.BtnExportCarEntretien_Click);
            // 
            // iconBtnCloseFormEntretien
            // 
            this.iconBtnCloseFormEntretien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormEntretien.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseFormEntretien.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormEntretien.IconSize = 35;
            this.iconBtnCloseFormEntretien.Location = new System.Drawing.Point(1085, 0);
            this.iconBtnCloseFormEntretien.Name = "iconBtnCloseFormEntretien";
            this.iconBtnCloseFormEntretien.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconBtnCloseFormEntretien.Size = new System.Drawing.Size(29, 23);
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
            this.iconBtnCreateEntretien.IconSize = 20;
            this.iconBtnCreateEntretien.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnCreateEntretien.Name = "iconBtnCreateEntretien";
            this.iconBtnCreateEntretien.Size = new System.Drawing.Size(123, 27);
            this.iconBtnCreateEntretien.TabIndex = 0;
            this.iconBtnCreateEntretien.Text = "Saisir entretien";
            this.iconBtnCreateEntretien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCreateEntretien.UseVisualStyleBackColor = false;
            this.iconBtnCreateEntretien.Click += new System.EventHandler(this.iconBtnCreateEntretien_Click);
            // 
            // panelSearchFormEntretien
            // 
            this.panelSearchFormEntretien.BackColor = System.Drawing.Color.DarkOrange;
            this.panelSearchFormEntretien.Controls.Add(this.iconBtnSearchFormEntretien);
            this.panelSearchFormEntretien.Controls.Add(this.textBox1);
            this.panelSearchFormEntretien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchFormEntretien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearchFormEntretien.Location = new System.Drawing.Point(0, 27);
            this.panelSearchFormEntretien.Name = "panelSearchFormEntretien";
            this.panelSearchFormEntretien.Size = new System.Drawing.Size(1118, 142);
            this.panelSearchFormEntretien.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 22);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1118, 562);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormEntretienVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelSearchFormEntretien);
            this.Controls.Add(this.panelTitleEntretien);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntretienVehicule";
            this.Text = "FormEntretienVehicule";
            this.panelTitleEntretien.ResumeLayout(false);
            this.panelSearchFormEntretien.ResumeLayout(false);
            this.panelSearchFormEntretien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleEntretien;
        private FontAwesome.Sharp.IconButton iconBtnCreateEntretien;
        private System.Windows.Forms.Panel panelSearchFormEntretien;
        private FontAwesome.Sharp.IconButton iconBtnSearchFormEntretien;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormEntretien;
        private FontAwesome.Sharp.IconButton BtnExportCarEntretien;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}