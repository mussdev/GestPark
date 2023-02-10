namespace GestPark.Vues.Consult
{
    partial class FormTraceGPSVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraceGPSVehicule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowserTraceGps = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 660);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 17);
            this.panel1.TabIndex = 0;
            // 
            // webBrowserTraceGps
            // 
            this.webBrowserTraceGps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserTraceGps.Location = new System.Drawing.Point(0, 0);
            this.webBrowserTraceGps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTraceGps.Name = "webBrowserTraceGps";
            this.webBrowserTraceGps.Size = new System.Drawing.Size(1233, 660);
            this.webBrowserTraceGps.TabIndex = 1;
            // 
            // FormTraceGPSVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1233, 677);
            this.Controls.Add(this.webBrowserTraceGps);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTraceGPSVehicule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher un véhicule par GPS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.WebBrowser webBrowserTraceGps;
    }
}