using GestPark.Models.Data;

namespace GestPark
{
    partial class FormEtatVehiculeRepare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtatVehiculeRepare));
            this.viewReparationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestParkDataSet = new GestPark.GestParkDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseEtatReapir = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetRepairCar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchReapir = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMultiCritereRepair = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxVehiRepair = new System.Windows.Forms.ComboBox();
            this.dateRepairTo = new System.Windows.Forms.DateTimePicker();
            this.dateRepaiFrom = new System.Windows.Forms.DateTimePicker();
            this.cbxPeriodeRepair = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewerRepaiCar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewReparationTableAdapter = new GestPark.GestParkDataSetTableAdapters.ViewReparationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewReparationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewReparationBindingSource
            // 
            this.viewReparationBindingSource.DataMember = "ViewReparation";
            this.viewReparationBindingSource.DataSource = this.gestParkDataSet;
            // 
            // gestParkDataSet
            // 
            this.gestParkDataSet.DataSetName = "GestParkDataSet";
            this.gestParkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseEtatReapir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 23);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(609, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETAT DES PANNES DE VEHICULE";
            // 
            // btnCloseEtatReapir
            // 
            this.btnCloseEtatReapir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseEtatReapir.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseEtatReapir.IconColor = System.Drawing.Color.Red;
            this.btnCloseEtatReapir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseEtatReapir.IconSize = 20;
            this.btnCloseEtatReapir.Location = new System.Drawing.Point(1351, -2);
            this.btnCloseEtatReapir.Name = "btnCloseEtatReapir";
            this.btnCloseEtatReapir.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnCloseEtatReapir.Size = new System.Drawing.Size(23, 23);
            this.btnCloseEtatReapir.TabIndex = 0;
            this.btnCloseEtatReapir.UseVisualStyleBackColor = true;
            this.btnCloseEtatReapir.Click += new System.EventHandler(this.btnCloseEtatReapir_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnResetRepairCar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSearchReapir);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMultiCritereRepair);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbxVehiRepair);
            this.panel3.Controls.Add(this.dateRepairTo);
            this.panel3.Controls.Add(this.dateRepaiFrom);
            this.panel3.Controls.Add(this.cbxPeriodeRepair);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 155);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(127, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Début";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(804, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rafraichir";
            // 
            // btnResetRepairCar
            // 
            this.btnResetRepairCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetRepairCar.IconChar = FontAwesome.Sharp.IconChar.CircleDown;
            this.btnResetRepairCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnResetRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetRepairCar.IconSize = 20;
            this.btnResetRepairCar.Location = new System.Drawing.Point(877, 106);
            this.btnResetRepairCar.Name = "btnResetRepairCar";
            this.btnResetRepairCar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnResetRepairCar.Size = new System.Drawing.Size(28, 23);
            this.btnResetRepairCar.TabIndex = 10;
            this.btnResetRepairCar.UseVisualStyleBackColor = true;
            this.btnResetRepairCar.Click += new System.EventHandler(this.btnResetRepairCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(794, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rechercher";
            // 
            // btnSearchReapir
            // 
            this.btnSearchReapir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchReapir.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchReapir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnSearchReapir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchReapir.IconSize = 20;
            this.btnSearchReapir.Location = new System.Drawing.Point(877, 77);
            this.btnSearchReapir.Name = "btnSearchReapir";
            this.btnSearchReapir.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSearchReapir.Size = new System.Drawing.Size(28, 23);
            this.btnSearchReapir.TabIndex = 8;
            this.btnSearchReapir.UseVisualStyleBackColor = true;
            this.btnSearchReapir.Click += new System.EventHandler(this.btnSearchReapir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(535, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rech. multi-critère";
            // 
            // txtMultiCritereRepair
            // 
            this.txtMultiCritereRepair.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiCritereRepair.Location = new System.Drawing.Point(659, 32);
            this.txtMultiCritereRepair.Name = "txtMultiCritereRepair";
            this.txtMultiCritereRepair.Size = new System.Drawing.Size(246, 27);
            this.txtMultiCritereRepair.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(267, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste véhicule";
            // 
            // cbxVehiRepair
            // 
            this.cbxVehiRepair.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiRepair.FormattingEnabled = true;
            this.cbxVehiRepair.Items.AddRange(new object[] {
            ""});
            this.cbxVehiRepair.Location = new System.Drawing.Point(270, 32);
            this.cbxVehiRepair.Name = "cbxVehiRepair";
            this.cbxVehiRepair.Size = new System.Drawing.Size(237, 27);
            this.cbxVehiRepair.TabIndex = 4;
            this.cbxVehiRepair.SelectedIndexChanged += new System.EventHandler(this.cbxVehiRepair_SelectedIndexChanged);
            // 
            // dateRepairTo
            // 
            this.dateRepairTo.Enabled = false;
            this.dateRepairTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRepairTo.Location = new System.Drawing.Point(130, 82);
            this.dateRepairTo.Name = "dateRepairTo";
            this.dateRepairTo.Size = new System.Drawing.Size(110, 25);
            this.dateRepairTo.TabIndex = 3;
            // 
            // dateRepaiFrom
            // 
            this.dateRepaiFrom.Enabled = false;
            this.dateRepaiFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRepaiFrom.Location = new System.Drawing.Point(10, 82);
            this.dateRepaiFrom.Name = "dateRepaiFrom";
            this.dateRepaiFrom.Size = new System.Drawing.Size(114, 25);
            this.dateRepaiFrom.TabIndex = 2;
            // 
            // cbxPeriodeRepair
            // 
            this.cbxPeriodeRepair.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodeRepair.FormattingEnabled = true;
            this.cbxPeriodeRepair.Items.AddRange(new object[] {
            "",
            "Aujourd\'hui",
            "Mois en cours",
            "Mois précedent",
            "Année en cours",
            "Année précédente",
            "Personnalisé"});
            this.cbxPeriodeRepair.Location = new System.Drawing.Point(6, 32);
            this.cbxPeriodeRepair.Name = "cbxPeriodeRepair";
            this.cbxPeriodeRepair.Size = new System.Drawing.Size(234, 27);
            this.cbxPeriodeRepair.TabIndex = 1;
            this.cbxPeriodeRepair.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodeRepair_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Période";
            // 
            // reportViewerRepaiCar
            // 
            this.reportViewerRepaiCar.BackColor = System.Drawing.Color.Honeydew;
            this.reportViewerRepaiCar.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRepairCar";
            reportDataSource1.Value = this.viewReparationBindingSource;
            this.reportViewerRepaiCar.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRepaiCar.LocalReport.ReportEmbeddedResource = "GestPark.Rapports.ReportReapirCar.rdlc";
            this.reportViewerRepaiCar.Location = new System.Drawing.Point(0, 178);
            this.reportViewerRepaiCar.Name = "reportViewerRepaiCar";
            this.reportViewerRepaiCar.ServerReport.BearerToken = null;
            this.reportViewerRepaiCar.Size = new System.Drawing.Size(1376, 553);
            this.reportViewerRepaiCar.TabIndex = 3;
            // 
            // viewReparationTableAdapter
            // 
            this.viewReparationTableAdapter.ClearBeforeFill = true;
            // 
            // FormEtatVehiculeRepare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1376, 731);
            this.Controls.Add(this.reportViewerRepaiCar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEtatVehiculeRepare";
            this.Text = "FormEtatVehiculeRepare";
            this.Load += new System.EventHandler(this.FormEtatVehiculeRepare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewReparationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCloseEtatReapir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRepaiCar;
        private FontAwesome.Sharp.IconButton btnSearchReapir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMultiCritereRepair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxVehiRepair;
        private System.Windows.Forms.DateTimePicker dateRepairTo;
        private System.Windows.Forms.DateTimePicker dateRepaiFrom;
        private System.Windows.Forms.ComboBox cbxPeriodeRepair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnResetRepairCar;
        private GestParkDataSet gestParkDataSet;
        private System.Windows.Forms.BindingSource viewReparationBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private GestParkDataSetTableAdapters.ViewReparationTableAdapter viewReparationTableAdapter;
    }
}