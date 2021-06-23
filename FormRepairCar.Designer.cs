
namespace GestPark
{
    partial class FormRepairCar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.IbtnExportRepairCar = new FontAwesome.Sharp.IconButton();
            this.IbtnSearchRepairCar = new FontAwesome.Sharp.IconButton();
            this.TxtSeachRepairCar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IbtnCloseFanRepairCar = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.IbtnExportRepairCar);
            this.panel2.Controls.Add(this.IbtnSearchRepairCar);
            this.panel2.Controls.Add(this.TxtSeachRepairCar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 115);
            this.panel2.TabIndex = 3;
            // 
            // IbtnExportRepairCar
            // 
            this.IbtnExportRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnExportRepairCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnExportRepairCar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IbtnExportRepairCar.IconColor = System.Drawing.Color.Black;
            this.IbtnExportRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExportRepairCar.Location = new System.Drawing.Point(1019, 72);
            this.IbtnExportRepairCar.Name = "IbtnExportRepairCar";
            this.IbtnExportRepairCar.Size = new System.Drawing.Size(87, 27);
            this.IbtnExportRepairCar.TabIndex = 5;
            this.IbtnExportRepairCar.Text = "Exporter";
            this.IbtnExportRepairCar.UseVisualStyleBackColor = false;
            // 
            // IbtnSearchRepairCar
            // 
            this.IbtnSearchRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnSearchRepairCar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchRepairCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchRepairCar.IconSize = 20;
            this.IbtnSearchRepairCar.Location = new System.Drawing.Point(868, 35);
            this.IbtnSearchRepairCar.Name = "IbtnSearchRepairCar";
            this.IbtnSearchRepairCar.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.IbtnSearchRepairCar.Size = new System.Drawing.Size(51, 27);
            this.IbtnSearchRepairCar.TabIndex = 4;
            this.IbtnSearchRepairCar.UseVisualStyleBackColor = false;
            // 
            // TxtSeachRepairCar
            // 
            this.TxtSeachRepairCar.Location = new System.Drawing.Point(607, 38);
            this.TxtSeachRepairCar.Name = "TxtSeachRepairCar";
            this.TxtSeachRepairCar.Size = new System.Drawing.Size(255, 22);
            this.TxtSeachRepairCar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.IbtnCloseFanRepairCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 32);
            this.panel1.TabIndex = 2;
            // 
            // IbtnCloseFanRepairCar
            // 
            this.IbtnCloseFanRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFanRepairCar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFanRepairCar.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFanRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFanRepairCar.IconSize = 35;
            this.IbtnCloseFanRepairCar.Location = new System.Drawing.Point(1084, 0);
            this.IbtnCloseFanRepairCar.Name = "IbtnCloseFanRepairCar";
            this.IbtnCloseFanRepairCar.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.IbtnCloseFanRepairCar.Size = new System.Drawing.Size(34, 32);
            this.IbtnCloseFanRepairCar.TabIndex = 5;
            this.IbtnCloseFanRepairCar.UseVisualStyleBackColor = false;
            this.IbtnCloseFanRepairCar.Click += new System.EventHandler(this.IbtnCloseFanRepairCar_Click);
            // 
            // FormRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRepairCar";
            this.Text = "FormRepairCar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton IbtnExportRepairCar;
        private FontAwesome.Sharp.IconButton IbtnSearchRepairCar;
        private System.Windows.Forms.TextBox TxtSeachRepairCar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IbtnCloseFanRepairCar;
    }
}