
namespace GestPark
{
    partial class FormInitializePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitializePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassworInit = new System.Windows.Forms.TextBox();
            this.TxtConfirPasswordInit = new System.Windows.Forms.TextBox();
            this.BtnValidPassword = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormInitPassword = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmer mot de passe";
            // 
            // TxtPassworInit
            // 
            this.TxtPassworInit.Location = new System.Drawing.Point(138, 33);
            this.TxtPassworInit.Name = "TxtPassworInit";
            this.TxtPassworInit.Size = new System.Drawing.Size(230, 20);
            this.TxtPassworInit.TabIndex = 2;
            // 
            // TxtConfirPasswordInit
            // 
            this.TxtConfirPasswordInit.Location = new System.Drawing.Point(138, 89);
            this.TxtConfirPasswordInit.Name = "TxtConfirPasswordInit";
            this.TxtConfirPasswordInit.Size = new System.Drawing.Size(230, 20);
            this.TxtConfirPasswordInit.TabIndex = 3;
            // 
            // BtnValidPassword
            // 
            this.BtnValidPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnValidPassword.IconColor = System.Drawing.Color.Black;
            this.BtnValidPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnValidPassword.Location = new System.Drawing.Point(80, 138);
            this.BtnValidPassword.Name = "BtnValidPassword";
            this.BtnValidPassword.Size = new System.Drawing.Size(75, 25);
            this.BtnValidPassword.TabIndex = 4;
            this.BtnValidPassword.Text = "Valider";
            this.BtnValidPassword.UseVisualStyleBackColor = true;
            // 
            // BtnCloseFormInitPassword
            // 
            this.BtnCloseFormInitPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCloseFormInitPassword.IconColor = System.Drawing.Color.Black;
            this.BtnCloseFormInitPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseFormInitPassword.Location = new System.Drawing.Point(180, 138);
            this.BtnCloseFormInitPassword.Name = "BtnCloseFormInitPassword";
            this.BtnCloseFormInitPassword.Size = new System.Drawing.Size(75, 25);
            this.BtnCloseFormInitPassword.TabIndex = 5;
            this.BtnCloseFormInitPassword.Text = "Annuler";
            this.BtnCloseFormInitPassword.UseVisualStyleBackColor = true;
            this.BtnCloseFormInitPassword.Click += new System.EventHandler(this.BtnCloseFormInitPassword_Click);
            // 
            // FormInitializePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(380, 187);
            this.Controls.Add(this.BtnCloseFormInitPassword);
            this.Controls.Add(this.BtnValidPassword);
            this.Controls.Add(this.TxtConfirPasswordInit);
            this.Controls.Add(this.TxtPassworInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInitializePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rénitialiser mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassworInit;
        private System.Windows.Forms.TextBox TxtConfirPasswordInit;
        private FontAwesome.Sharp.IconButton BtnValidPassword;
        private FontAwesome.Sharp.IconButton BtnCloseFormInitPassword;
    }
}