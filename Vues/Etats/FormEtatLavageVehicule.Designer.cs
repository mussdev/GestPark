using GestPark.Models.Data;

namespace GestPark
{
    partial class FormEtatLavageVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtatLavageVehicule));
            this.viewLavageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestParkDataSetLavage = new GestPark.GestParkDataSetLavage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseEtatLavage = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetLavageCar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchLavageCar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMultiCritereLavagCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxVehiLavag = new System.Windows.Forms.ComboBox();
            this.dateLavagTo = new System.Windows.Forms.DateTimePicker();
            this.dateLavagFrom = new System.Windows.Forms.DateTimePicker();
            this.cbxPeriodeLavagCar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerLavageCar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_LavageTableAdapter = new GestPark.GestParkDataSetLavageTableAdapters.View_LavageTableAdapter();
            this.View_LavageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewLavageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSetLavage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_LavageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewLavageBindingSource
            // 
            this.viewLavageBindingSource.DataMember = "View_Lavage";
            this.viewLavageBindingSource.DataSource = this.gestParkDataSetLavage;
            // 
            // gestParkDataSetLavage
            // 
            this.gestParkDataSetLavage.DataSetName = "GestParkDataSetLavage";
            this.gestParkDataSetLavage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseEtatLavage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 23);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(638, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETAT DE LAVAGE  DES VEHICULES";
            // 
            // btnCloseEtatLavage
            // 
            this.btnCloseEtatLavage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseEtatLavage.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseEtatLavage.IconColor = System.Drawing.Color.Red;
            this.btnCloseEtatLavage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseEtatLavage.IconSize = 20;
            this.btnCloseEtatLavage.Location = new System.Drawing.Point(1351, -2);
            this.btnCloseEtatLavage.Name = "btnCloseEtatLavage";
            this.btnCloseEtatLavage.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnCloseEtatLavage.Size = new System.Drawing.Size(23, 23);
            this.btnCloseEtatLavage.TabIndex = 0;
            this.btnCloseEtatLavage.UseVisualStyleBackColor = true;
            this.btnCloseEtatLavage.Click += new System.EventHandler(this.btnCloseEtatLavage_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnResetLavageCar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSearchLavageCar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMultiCritereLavagCar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbxVehiLavag);
            this.panel3.Controls.Add(this.dateLavagTo);
            this.panel3.Controls.Add(this.dateLavagFrom);
            this.panel3.Controls.Add(this.cbxPeriodeLavagCar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 155);
            this.panel3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(125, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 59);
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
            this.label6.Location = new System.Drawing.Point(822, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rafraichir";
            // 
            // btnResetLavageCar
            // 
            this.btnResetLavageCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetLavageCar.IconChar = FontAwesome.Sharp.IconChar.CircleDown;
            this.btnResetLavageCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnResetLavageCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetLavageCar.IconSize = 20;
            this.btnResetLavageCar.Location = new System.Drawing.Point(906, 109);
            this.btnResetLavageCar.Name = "btnResetLavageCar";
            this.btnResetLavageCar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnResetLavageCar.Size = new System.Drawing.Size(28, 23);
            this.btnResetLavageCar.TabIndex = 10;
            this.btnResetLavageCar.UseVisualStyleBackColor = true;
            this.btnResetLavageCar.Click += new System.EventHandler(this.btnResetLavageCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(816, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rechercher";
            // 
            // btnSearchLavageCar
            // 
            this.btnSearchLavageCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchLavageCar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchLavageCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnSearchLavageCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchLavageCar.IconSize = 20;
            this.btnSearchLavageCar.Location = new System.Drawing.Point(906, 76);
            this.btnSearchLavageCar.Name = "btnSearchLavageCar";
            this.btnSearchLavageCar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSearchLavageCar.Size = new System.Drawing.Size(28, 23);
            this.btnSearchLavageCar.TabIndex = 8;
            this.btnSearchLavageCar.UseVisualStyleBackColor = true;
            this.btnSearchLavageCar.Click += new System.EventHandler(this.btnSearchLavageCar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(542, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rech. multi-critère";
            // 
            // txtMultiCritereLavagCar
            // 
            this.txtMultiCritereLavagCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiCritereLavagCar.Location = new System.Drawing.Point(688, 32);
            this.txtMultiCritereLavagCar.Name = "txtMultiCritereLavagCar";
            this.txtMultiCritereLavagCar.Size = new System.Drawing.Size(246, 27);
            this.txtMultiCritereLavagCar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(264, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste véhicule";
            // 
            // cbxVehiLavag
            // 
            this.cbxVehiLavag.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiLavag.FormattingEnabled = true;
            this.cbxVehiLavag.Items.AddRange(new object[] {
            ""});
            this.cbxVehiLavag.Location = new System.Drawing.Point(267, 32);
            this.cbxVehiLavag.Name = "cbxVehiLavag";
            this.cbxVehiLavag.Size = new System.Drawing.Size(201, 27);
            this.cbxVehiLavag.TabIndex = 4;
            // 
            // dateLavagTo
            // 
            this.dateLavagTo.Enabled = false;
            this.dateLavagTo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLavagTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLavagTo.Location = new System.Drawing.Point(129, 81);
            this.dateLavagTo.Name = "dateLavagTo";
            this.dateLavagTo.Size = new System.Drawing.Size(109, 25);
            this.dateLavagTo.TabIndex = 3;
            // 
            // dateLavagFrom
            // 
            this.dateLavagFrom.Enabled = false;
            this.dateLavagFrom.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLavagFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLavagFrom.Location = new System.Drawing.Point(10, 81);
            this.dateLavagFrom.Name = "dateLavagFrom";
            this.dateLavagFrom.Size = new System.Drawing.Size(112, 25);
            this.dateLavagFrom.TabIndex = 2;
            // 
            // cbxPeriodeLavagCar
            // 
            this.cbxPeriodeLavagCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodeLavagCar.FormattingEnabled = true;
            this.cbxPeriodeLavagCar.Items.AddRange(new object[] {
            "",
            "Aujourd\'hui",
            "Mois en cours",
            "Mois précedent",
            "Année en cours",
            "Année précédente",
            "Personnalisé"});
            this.cbxPeriodeLavagCar.Location = new System.Drawing.Point(6, 32);
            this.cbxPeriodeLavagCar.Name = "cbxPeriodeLavagCar";
            this.cbxPeriodeLavagCar.Size = new System.Drawing.Size(231, 27);
            this.cbxPeriodeLavagCar.TabIndex = 1;
            this.cbxPeriodeLavagCar.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodeLavagCar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Période";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerLavageCar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 553);
            this.panel2.TabIndex = 4;
            // 
            // reportViewerLavageCar
            // 
            this.reportViewerLavageCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.reportViewerLavageCar.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLavageCar";
            reportDataSource1.Value = this.View_LavageBindingSource;
            this.reportViewerLavageCar.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerLavageCar.LocalReport.ReportEmbeddedResource = "GestPark.Rapports.ReportLavageCar.rdlc";
            this.reportViewerLavageCar.Location = new System.Drawing.Point(0, 0);
            this.reportViewerLavageCar.Name = "reportViewerLavageCar";
            this.reportViewerLavageCar.ServerReport.BearerToken = null;
            this.reportViewerLavageCar.Size = new System.Drawing.Size(1376, 553);
            this.reportViewerLavageCar.TabIndex = 0;
            // 
            // view_LavageTableAdapter
            // 
            this.view_LavageTableAdapter.ClearBeforeFill = true;
            // 
            // View_LavageBindingSource
            // 
            this.View_LavageBindingSource.DataMember = "View_Lavage";
            this.View_LavageBindingSource.DataSource = this.gestParkDataSetLavage;
            // 
            // FormEtatLavageVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1376, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEtatLavageVehicule";
            this.Text = "Etat de véhicule lavé";
            this.Load += new System.EventHandler(this.FormEtatLavageVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewLavageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestParkDataSetLavage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_LavageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseEtatLavage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnResetLavageCar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnSearchLavageCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMultiCritereLavagCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxVehiLavag;
        private System.Windows.Forms.DateTimePicker dateLavagTo;
        private System.Windows.Forms.DateTimePicker dateLavagFrom;
        private System.Windows.Forms.ComboBox cbxPeriodeLavagCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLavageCar;
        private GestParkDataSetLavage gestParkDataSetLavage;
        private System.Windows.Forms.BindingSource viewLavageBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource View_LavageBindingSource;
        private GestParkDataSetLavageTableAdapters.View_LavageTableAdapter view_LavageTableAdapter;
    }
}