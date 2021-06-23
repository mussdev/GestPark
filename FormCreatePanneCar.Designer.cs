
namespace GestPark
{
    partial class FormCreatePanneCar
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
            this.RtxtNotePanCar = new System.Windows.Forms.RichTextBox();
            this.DateRegisterPanCar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescriptionPanCar = new System.Windows.Forms.TextBox();
            this.TxtCodePanCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenuConsoCarb = new System.Windows.Forms.Panel();
            this.JointDocPanCar = new FontAwesome.Sharp.IconButton();
            this.IcBtnSavedPanCar = new FontAwesome.Sharp.IconButton();
            this.IcBtnCloseFanCreatePanCarb = new FontAwesome.Sharp.IconButton();
            this.CbxVehiPanCar = new System.Windows.Forms.ComboBox();
            this.RichTxtoutheInfos = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxEtatCarPan = new System.Windows.Forms.ComboBox();
            this.PanelMenuConsoCarb.SuspendLayout();
            this.SuspendLayout();
            // 
            // RtxtNotePanCar
            // 
            this.RtxtNotePanCar.Location = new System.Drawing.Point(95, 328);
            this.RtxtNotePanCar.Name = "RtxtNotePanCar";
            this.RtxtNotePanCar.Size = new System.Drawing.Size(593, 130);
            this.RtxtNotePanCar.TabIndex = 36;
            this.RtxtNotePanCar.Text = "";
            // 
            // DateRegisterPanCar
            // 
            this.DateRegisterPanCar.Location = new System.Drawing.Point(95, 268);
            this.DateRegisterPanCar.Name = "DateRegisterPanCar";
            this.DateRegisterPanCar.Size = new System.Drawing.Size(240, 22);
            this.DateRegisterPanCar.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Note :";
            // 
            // TxtDescriptionPanCar
            // 
            this.TxtDescriptionPanCar.Location = new System.Drawing.Point(95, 155);
            this.TxtDescriptionPanCar.Name = "TxtDescriptionPanCar";
            this.TxtDescriptionPanCar.Size = new System.Drawing.Size(240, 22);
            this.TxtDescriptionPanCar.TabIndex = 29;
            // 
            // TxtCodePanCar
            // 
            this.TxtCodePanCar.BackColor = System.Drawing.Color.Khaki;
            this.TxtCodePanCar.Location = new System.Drawing.Point(95, 51);
            this.TxtCodePanCar.Name = "TxtCodePanCar";
            this.TxtCodePanCar.ReadOnly = true;
            this.TxtCodePanCar.Size = new System.Drawing.Size(148, 22);
            this.TxtCodePanCar.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Vehicule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Code :";
            // 
            // PanelMenuConsoCarb
            // 
            this.PanelMenuConsoCarb.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelMenuConsoCarb.Controls.Add(this.JointDocPanCar);
            this.PanelMenuConsoCarb.Controls.Add(this.IcBtnSavedPanCar);
            this.PanelMenuConsoCarb.Controls.Add(this.IcBtnCloseFanCreatePanCarb);
            this.PanelMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuConsoCarb.Name = "PanelMenuConsoCarb";
            this.PanelMenuConsoCarb.Size = new System.Drawing.Size(700, 30);
            this.PanelMenuConsoCarb.TabIndex = 22;
            // 
            // JointDocPanCar
            // 
            this.JointDocPanCar.BackColor = System.Drawing.Color.White;
            this.JointDocPanCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.JointDocPanCar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.JointDocPanCar.IconColor = System.Drawing.Color.DarkGreen;
            this.JointDocPanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.JointDocPanCar.IconSize = 25;
            this.JointDocPanCar.Location = new System.Drawing.Point(95, 0);
            this.JointDocPanCar.Name = "JointDocPanCar";
            this.JointDocPanCar.Size = new System.Drawing.Size(128, 30);
            this.JointDocPanCar.TabIndex = 2;
            this.JointDocPanCar.Text = "Joindre fichier";
            this.JointDocPanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JointDocPanCar.UseVisualStyleBackColor = false;
            // 
            // IcBtnSavedPanCar
            // 
            this.IcBtnSavedPanCar.BackColor = System.Drawing.Color.White;
            this.IcBtnSavedPanCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedPanCar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IcBtnSavedPanCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedPanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnSavedPanCar.IconSize = 25;
            this.IcBtnSavedPanCar.Location = new System.Drawing.Point(0, 0);
            this.IcBtnSavedPanCar.Name = "IcBtnSavedPanCar";
            this.IcBtnSavedPanCar.Size = new System.Drawing.Size(101, 30);
            this.IcBtnSavedPanCar.TabIndex = 1;
            this.IcBtnSavedPanCar.Text = "Enregistrer";
            this.IcBtnSavedPanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnSavedPanCar.UseVisualStyleBackColor = false;
            this.IcBtnSavedPanCar.Click += new System.EventHandler(this.IcBtnSavedPanCar_Click);
            // 
            // IcBtnCloseFanCreatePanCarb
            // 
            this.IcBtnCloseFanCreatePanCarb.BackColor = System.Drawing.Color.White;
            this.IcBtnCloseFanCreatePanCarb.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IcBtnCloseFanCreatePanCarb.IconColor = System.Drawing.Color.Red;
            this.IcBtnCloseFanCreatePanCarb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnCloseFanCreatePanCarb.IconSize = 30;
            this.IcBtnCloseFanCreatePanCarb.Location = new System.Drawing.Point(662, 0);
            this.IcBtnCloseFanCreatePanCarb.Name = "IcBtnCloseFanCreatePanCarb";
            this.IcBtnCloseFanCreatePanCarb.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IcBtnCloseFanCreatePanCarb.Size = new System.Drawing.Size(38, 30);
            this.IcBtnCloseFanCreatePanCarb.TabIndex = 0;
            this.IcBtnCloseFanCreatePanCarb.UseVisualStyleBackColor = false;
            this.IcBtnCloseFanCreatePanCarb.Click += new System.EventHandler(this.IcBtnCloseFanCreatePanCarb_Click);
            // 
            // CbxVehiPanCar
            // 
            this.CbxVehiPanCar.FormattingEnabled = true;
            this.CbxVehiPanCar.Location = new System.Drawing.Point(95, 208);
            this.CbxVehiPanCar.Name = "CbxVehiPanCar";
            this.CbxVehiPanCar.Size = new System.Drawing.Size(240, 23);
            this.CbxVehiPanCar.TabIndex = 41;
            this.CbxVehiPanCar.SelectedIndexChanged += new System.EventHandler(this.CbxVehiPanCar_SelectedIndexChanged);
            // 
            // RichTxtoutheInfos
            // 
            this.RichTxtoutheInfos.Location = new System.Drawing.Point(396, 51);
            this.RichTxtoutheInfos.Name = "RichTxtoutheInfos";
            this.RichTxtoutheInfos.Size = new System.Drawing.Size(292, 108);
            this.RichTxtoutheInfos.TabIndex = 43;
            this.RichTxtoutheInfos.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Etat :";
            // 
            // CbxEtatCarPan
            // 
            this.CbxEtatCarPan.FormattingEnabled = true;
            this.CbxEtatCarPan.Items.AddRange(new object[] {
            "",
            "Panne",
            "Reparé"});
            this.CbxEtatCarPan.Location = new System.Drawing.Point(95, 101);
            this.CbxEtatCarPan.Name = "CbxEtatCarPan";
            this.CbxEtatCarPan.Size = new System.Drawing.Size(240, 23);
            this.CbxEtatCarPan.TabIndex = 47;
            this.CbxEtatCarPan.Text = "Panne";
            // 
            // FormCreatePanneCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 469);
            this.Controls.Add(this.CbxEtatCarPan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RichTxtoutheInfos);
            this.Controls.Add(this.CbxVehiPanCar);
            this.Controls.Add(this.RtxtNotePanCar);
            this.Controls.Add(this.DateRegisterPanCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDescriptionPanCar);
            this.Controls.Add(this.TxtCodePanCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMenuConsoCarb);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreatePanneCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreatePanneCar";
            this.PanelMenuConsoCarb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton JointDocPanCar;
        private FontAwesome.Sharp.IconButton IcBtnCloseFanCreatePanCarb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton IcBtnSavedPanCar;
        private System.Windows.Forms.Panel PanelMenuConsoCarb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RtxtNotePanCar;
        private System.Windows.Forms.DateTimePicker DateRegisterPanCar;
        private System.Windows.Forms.TextBox TxtDescriptionPanCar;
        private System.Windows.Forms.TextBox TxtCodePanCar;
        private System.Windows.Forms.ComboBox CbxVehiPanCar;
        private System.Windows.Forms.RichTextBox RichTxtoutheInfos;
        private System.Windows.Forms.ComboBox CbxEtatCarPan;
    }
}