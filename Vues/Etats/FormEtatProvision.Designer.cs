using GestPark.Models.Data;

namespace GestPark
{
    partial class FormEtatProvision
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtatProvision));
            this.View_ProvisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestParkDataSetProvCarb = new GestPark.GestParkDataSetProvCarb();
            this.viewProvisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetProvCar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchProvCar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMultiCritereProvCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxVehiProv = new System.Windows.Forms.ComboBox();
            this.dateProvTo = new System.Windows.Forms.DateTimePicker();
            this.dateProvFrom = new System.Windows.Forms.DateTimePicker();
            this.cbxPeriodeProvCar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerProvision = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_ProvisionTableAdapter = new GestPark.GestParkDataSetProvCarbTableAdapters.View_ProvisionTableAdapter();
            this.viewReparationTableAdapter1 = new GestPark.GestParkDataSetTableAdapters.ViewReparationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_ProvisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSetProvCarb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProvisionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // View_ProvisionBindingSource
            // 
            this.View_ProvisionBindingSource.DataMember = "View_Provision";
            this.View_ProvisionBindingSource.DataSource = this.gestParkDataSetProvCarb;
            // 
            // gestParkDataSetProvCarb
            // 
            this.gestParkDataSetProvCarb.DataSetName = "GestParkDataSetProvCarb";
            this.gestParkDataSetProvCarb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewProvisionBindingSource
            // 
            this.viewProvisionBindingSource.DataMember = "View_Provision";
            this.viewProvisionBindingSource.DataSource = this.gestParkDataSetProvCarb;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 23);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(603, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETAT D\'APROVISIONNEMENT  DES VEHICULES";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnResetProvCar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSearchProvCar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMultiCritereProvCar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbxVehiProv);
            this.panel3.Controls.Add(this.dateProvTo);
            this.panel3.Controls.Add(this.dateProvFrom);
            this.panel3.Controls.Add(this.cbxPeriodeProvCar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 155);
            this.panel3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(122, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Début";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(827, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rafraichir";
            // 
            // btnResetProvCar
            // 
            this.btnResetProvCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetProvCar.IconChar = FontAwesome.Sharp.IconChar.CircleDown;
            this.btnResetProvCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnResetProvCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetProvCar.IconSize = 20;
            this.btnResetProvCar.Location = new System.Drawing.Point(911, 107);
            this.btnResetProvCar.Name = "btnResetProvCar";
            this.btnResetProvCar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnResetProvCar.Size = new System.Drawing.Size(28, 23);
            this.btnResetProvCar.TabIndex = 10;
            this.btnResetProvCar.UseVisualStyleBackColor = true;
            this.btnResetProvCar.Click += new System.EventHandler(this.btnResetProvCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(817, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rechercher";
            // 
            // btnSearchProvCar
            // 
            this.btnSearchProvCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchProvCar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchProvCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnSearchProvCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchProvCar.IconSize = 20;
            this.btnSearchProvCar.Location = new System.Drawing.Point(911, 74);
            this.btnSearchProvCar.Name = "btnSearchProvCar";
            this.btnSearchProvCar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSearchProvCar.Size = new System.Drawing.Size(28, 23);
            this.btnSearchProvCar.TabIndex = 8;
            this.btnSearchProvCar.UseVisualStyleBackColor = true;
            this.btnSearchProvCar.Click += new System.EventHandler(this.btnSearchProvCar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(547, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rech. multi-critère";
            // 
            // txtMultiCritereProvCar
            // 
            this.txtMultiCritereProvCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiCritereProvCar.Location = new System.Drawing.Point(693, 31);
            this.txtMultiCritereProvCar.Name = "txtMultiCritereProvCar";
            this.txtMultiCritereProvCar.Size = new System.Drawing.Size(246, 27);
            this.txtMultiCritereProvCar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste véhicule";
            // 
            // cbxVehiProv
            // 
            this.cbxVehiProv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiProv.FormattingEnabled = true;
            this.cbxVehiProv.Items.AddRange(new object[] {
            ""});
            this.cbxVehiProv.Location = new System.Drawing.Point(268, 31);
            this.cbxVehiProv.Name = "cbxVehiProv";
            this.cbxVehiProv.Size = new System.Drawing.Size(201, 27);
            this.cbxVehiProv.TabIndex = 4;
            // 
            // dateProvTo
            // 
            this.dateProvTo.Enabled = false;
            this.dateProvTo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateProvTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateProvTo.Location = new System.Drawing.Point(126, 86);
            this.dateProvTo.Name = "dateProvTo";
            this.dateProvTo.Size = new System.Drawing.Size(109, 25);
            this.dateProvTo.TabIndex = 3;
            // 
            // dateProvFrom
            // 
            this.dateProvFrom.Enabled = false;
            this.dateProvFrom.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateProvFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateProvFrom.Location = new System.Drawing.Point(9, 86);
            this.dateProvFrom.Name = "dateProvFrom";
            this.dateProvFrom.Size = new System.Drawing.Size(111, 25);
            this.dateProvFrom.TabIndex = 2;
            // 
            // cbxPeriodeProvCar
            // 
            this.cbxPeriodeProvCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodeProvCar.FormattingEnabled = true;
            this.cbxPeriodeProvCar.Items.AddRange(new object[] {
            "",
            "Aujourd\'hui",
            "Mois en cours",
            "Mois précedent",
            "Année en cours",
            "Année précédente",
            "Personnalisé"});
            this.cbxPeriodeProvCar.Location = new System.Drawing.Point(6, 32);
            this.cbxPeriodeProvCar.Name = "cbxPeriodeProvCar";
            this.cbxPeriodeProvCar.Size = new System.Drawing.Size(229, 27);
            this.cbxPeriodeProvCar.TabIndex = 1;
            this.cbxPeriodeProvCar.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodeProvCar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Période";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerProvision);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 553);
            this.panel2.TabIndex = 5;
            // 
            // reportViewerProvision
            // 
            this.reportViewerProvision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerProvision.ForeColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DataSetProvisionCarb";
            reportDataSource1.Value = this.View_ProvisionBindingSource;
            this.reportViewerProvision.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerProvision.LocalReport.ReportEmbeddedResource = "GestPark.Rapports.ReportProvisionCarb.rdlc";
            this.reportViewerProvision.Location = new System.Drawing.Point(0, 0);
            this.reportViewerProvision.Name = "reportViewerProvision";
            this.reportViewerProvision.ServerReport.BearerToken = null;
            this.reportViewerProvision.Size = new System.Drawing.Size(1376, 553);
            this.reportViewerProvision.TabIndex = 0;
            // 
            // view_ProvisionTableAdapter
            // 
            this.view_ProvisionTableAdapter.ClearBeforeFill = true;
            // 
            // viewReparationTableAdapter1
            // 
            this.viewReparationTableAdapter1.ClearBeforeFill = true;
            // 
            // FormEtatProvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1376, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEtatProvision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etat de provision";
            this.Load += new System.EventHandler(this.FormEtatProvision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_ProvisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSetProvCarb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProvisionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnResetProvCar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnSearchProvCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMultiCritereProvCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxVehiProv;
        private System.Windows.Forms.DateTimePicker dateProvTo;
        private System.Windows.Forms.DateTimePicker dateProvFrom;
        private System.Windows.Forms.ComboBox cbxPeriodeProvCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProvision;
        private GestParkDataSetProvCarb gestParkDataSetProvCarb;
        private System.Windows.Forms.BindingSource viewProvisionBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource View_ProvisionBindingSource;
        private GestParkDataSetProvCarbTableAdapters.View_ProvisionTableAdapter view_ProvisionTableAdapter;
        private GestParkDataSetTableAdapters.ViewReparationTableAdapter viewReparationTableAdapter1;
    }
}