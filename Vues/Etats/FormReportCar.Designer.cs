namespace GestPark
{
    partial class FormReportCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportCar));
            this.reportViewerCar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerCar
            // 
            this.reportViewerCar.BackColor = System.Drawing.Color.Honeydew;
            this.reportViewerCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerCar.LocalReport.ReportEmbeddedResource = "GestPark.Rapports.ReportCar.rdlc";
            this.reportViewerCar.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCar.Name = "reportViewerCar";
            this.reportViewerCar.ServerReport.BearerToken = null;
            this.reportViewerCar.Size = new System.Drawing.Size(1061, 562);
            this.reportViewerCar.TabIndex = 0;
            // 
            // FormReportCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 562);
            this.Controls.Add(this.reportViewerCar);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReportCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimer";
            this.Load += new System.EventHandler(this.FormReportCar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCar;
    }
}