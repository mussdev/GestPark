using GestPark.Models.Data;

namespace GestPark
{
    partial class FormEtatVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtatVehicule));
            this.View_VehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestParkDataSetListCar = new GestPark.GestParkDataSetListCar();
            this.viewVehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetListCar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchListCar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMultiCritereListCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEtatCar = new System.Windows.Forms.ComboBox();
            this.dateListCarTo = new System.Windows.Forms.DateTimePicker();
            this.dateListCarFrom = new System.Windows.Forms.DateTimePicker();
            this.cbxPeriodeListCar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerListCar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_VehiculeTableAdapter = new GestPark.GestParkDataSetListCarTableAdapters.View_VehiculeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_VehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSetListCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiculeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // View_VehiculeBindingSource
            // 
            this.View_VehiculeBindingSource.DataMember = "View_Vehicule";
            this.View_VehiculeBindingSource.DataSource = this.gestParkDataSetListCar;
            // 
            // gestParkDataSetListCar
            // 
            this.gestParkDataSetListCar.DataSetName = "GestParkDataSetListCar";
            this.gestParkDataSetListCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewVehiculeBindingSource
            // 
            this.viewVehiculeBindingSource.DataMember = "View_Vehicule";
            this.viewVehiculeBindingSource.DataSource = this.gestParkDataSetListCar;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 24);
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETAT  DES VEHICULES";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnResetListCar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSearchListCar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMultiCritereListCar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbxEtatCar);
            this.panel3.Controls.Add(this.dateListCarTo);
            this.panel3.Controls.Add(this.dateListCarFrom);
            this.panel3.Controls.Add(this.cbxPeriodeListCar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 167);
            this.panel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(137, 67);
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
            this.label7.Location = new System.Drawing.Point(2, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Début";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(822, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rafraichir";
            // 
            // btnResetListCar
            // 
            this.btnResetListCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetListCar.IconChar = FontAwesome.Sharp.IconChar.CircleDown;
            this.btnResetListCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnResetListCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetListCar.IconSize = 20;
            this.btnResetListCar.Location = new System.Drawing.Point(906, 101);
            this.btnResetListCar.Name = "btnResetListCar";
            this.btnResetListCar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnResetListCar.Size = new System.Drawing.Size(28, 25);
            this.btnResetListCar.TabIndex = 10;
            this.btnResetListCar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(812, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rechercher";
            // 
            // btnSearchListCar
            // 
            this.btnSearchListCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchListCar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchListCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnSearchListCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchListCar.IconSize = 20;
            this.btnSearchListCar.Location = new System.Drawing.Point(906, 70);
            this.btnSearchListCar.Name = "btnSearchListCar";
            this.btnSearchListCar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSearchListCar.Size = new System.Drawing.Size(28, 25);
            this.btnSearchListCar.TabIndex = 8;
            this.btnSearchListCar.UseVisualStyleBackColor = true;
            this.btnSearchListCar.Click += new System.EventHandler(this.btnSearchListCar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(542, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rech. multi-critère";
            // 
            // txtMultiCritereListCar
            // 
            this.txtMultiCritereListCar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiCritereListCar.Location = new System.Drawing.Point(688, 34);
            this.txtMultiCritereListCar.Name = "txtMultiCritereListCar";
            this.txtMultiCritereListCar.Size = new System.Drawing.Size(246, 26);
            this.txtMultiCritereListCar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(272, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Etat véhicule";
            // 
            // cbxEtatCar
            // 
            this.cbxEtatCar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEtatCar.FormattingEnabled = true;
            this.cbxEtatCar.Items.AddRange(new object[] {
            "",
            "Bon",
            "En panne"});
            this.cbxEtatCar.Location = new System.Drawing.Point(275, 34);
            this.cbxEtatCar.Name = "cbxEtatCar";
            this.cbxEtatCar.Size = new System.Drawing.Size(201, 27);
            this.cbxEtatCar.TabIndex = 4;
            // 
            // dateListCarTo
            // 
            this.dateListCarTo.Enabled = false;
            this.dateListCarTo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateListCarTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateListCarTo.Location = new System.Drawing.Point(141, 90);
            this.dateListCarTo.Name = "dateListCarTo";
            this.dateListCarTo.Size = new System.Drawing.Size(119, 26);
            this.dateListCarTo.TabIndex = 3;
            // 
            // dateListCarFrom
            // 
            this.dateListCarFrom.Enabled = false;
            this.dateListCarFrom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateListCarFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateListCarFrom.Location = new System.Drawing.Point(6, 90);
            this.dateListCarFrom.Name = "dateListCarFrom";
            this.dateListCarFrom.Size = new System.Drawing.Size(126, 26);
            this.dateListCarFrom.TabIndex = 2;
            // 
            // cbxPeriodeListCar
            // 
            this.cbxPeriodeListCar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodeListCar.FormattingEnabled = true;
            this.cbxPeriodeListCar.Items.AddRange(new object[] {
            "",
            "Aujourd\'hui",
            "Mois en cours",
            "Mois précedent",
            "Année en cours",
            "Année précédente",
            "Personnalisé"});
            this.cbxPeriodeListCar.Location = new System.Drawing.Point(6, 34);
            this.cbxPeriodeListCar.Name = "cbxPeriodeListCar";
            this.cbxPeriodeListCar.Size = new System.Drawing.Size(252, 27);
            this.cbxPeriodeListCar.TabIndex = 1;
            this.cbxPeriodeListCar.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodeListCar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Période";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerListCar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 596);
            this.panel2.TabIndex = 6;
            // 
            // reportViewerListCar
            // 
            this.reportViewerListCar.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetListCar";
            reportDataSource1.Value = this.View_VehiculeBindingSource;
            this.reportViewerListCar.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerListCar.LocalReport.ReportEmbeddedResource = "GestPark.Rapports.ReportListCar.rdlc";
            this.reportViewerListCar.Location = new System.Drawing.Point(0, 0);
            this.reportViewerListCar.Name = "reportViewerListCar";
            this.reportViewerListCar.ServerReport.BearerToken = null;
            this.reportViewerListCar.Size = new System.Drawing.Size(1376, 596);
            this.reportViewerListCar.TabIndex = 0;
            // 
            // view_VehiculeTableAdapter
            // 
            this.view_VehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // FormEtatVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1376, 787);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEtatVehicule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etat des véhicules";
            this.Load += new System.EventHandler(this.FormEtatVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_VehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSetListCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVehiculeBindingSource)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnResetListCar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnSearchListCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMultiCritereListCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEtatCar;
        private System.Windows.Forms.DateTimePicker dateListCarTo;
        private System.Windows.Forms.DateTimePicker dateListCarFrom;
        private System.Windows.Forms.ComboBox cbxPeriodeListCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListCar;
        private GestParkDataSetListCar gestParkDataSetListCar;
        private System.Windows.Forms.BindingSource viewVehiculeBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource View_VehiculeBindingSource;
        private GestParkDataSetListCarTableAdapters.View_VehiculeTableAdapter view_VehiculeTableAdapter;
    }
}