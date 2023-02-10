namespace GestPark.Vues.Consult
{
    partial class FormConsultStatutDemandeCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultStatutDemandeCar));
            this.listValidationDemandeCar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listValidationDemandeCar
            // 
            this.listValidationDemandeCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listValidationDemandeCar.ForeColor = System.Drawing.Color.Black;
            this.listValidationDemandeCar.FormattingEnabled = true;
            this.listValidationDemandeCar.ItemHeight = 19;
            this.listValidationDemandeCar.Location = new System.Drawing.Point(0, 0);
            this.listValidationDemandeCar.Name = "listValidationDemandeCar";
            this.listValidationDemandeCar.Size = new System.Drawing.Size(331, 398);
            this.listValidationDemandeCar.TabIndex = 0;
            this.listValidationDemandeCar.DoubleClick += new System.EventHandler(this.listValidationDemandeCar_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 20);
            this.panel1.TabIndex = 1;
            // 
            // FormConsultStatutDemandeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(331, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listValidationDemandeCar);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConsultStatutDemandeCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choisir les statuts de la demande de véhicule";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listValidationDemandeCar;
        private System.Windows.Forms.Panel panel1;
    }
}