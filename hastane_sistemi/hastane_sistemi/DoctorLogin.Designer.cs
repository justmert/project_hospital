
namespace hastane_sistemi
{
    partial class DoctorLogin
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
            this.admin_login_groupbox = new System.Windows.Forms.GroupBox();
            this.doctor_credentials_login = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.doctor_password_textbox = new System.Windows.Forms.TextBox();
            this.doctor_username_texbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_login_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_login_groupbox
            // 
            this.admin_login_groupbox.Controls.Add(this.pictureBox1);
            this.admin_login_groupbox.Controls.Add(this.doctor_credentials_login);
            this.admin_login_groupbox.Controls.Add(this.label5);
            this.admin_login_groupbox.Controls.Add(this.doctor_password_textbox);
            this.admin_login_groupbox.Controls.Add(this.doctor_username_texbox);
            this.admin_login_groupbox.Controls.Add(this.label4);
            this.admin_login_groupbox.Controls.Add(this.label3);
            this.admin_login_groupbox.Location = new System.Drawing.Point(12, 12);
            this.admin_login_groupbox.Name = "admin_login_groupbox";
            this.admin_login_groupbox.Size = new System.Drawing.Size(375, 317);
            this.admin_login_groupbox.TabIndex = 1;
            this.admin_login_groupbox.TabStop = false;
            // 
            // doctor_credentials_login
            // 
            this.doctor_credentials_login.Location = new System.Drawing.Point(153, 260);
            this.doctor_credentials_login.Name = "doctor_credentials_login";
            this.doctor_credentials_login.Size = new System.Drawing.Size(81, 30);
            this.doctor_credentials_login.TabIndex = 15;
            this.doctor_credentials_login.Text = "Giriş Yap";
            this.doctor_credentials_login.UseVisualStyleBackColor = true;
            this.doctor_credentials_login.Click += new System.EventHandler(this.doctor_credentials_login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(161, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Doktor Girişi";
            // 
            // doctor_password_textbox
            // 
            this.doctor_password_textbox.Location = new System.Drawing.Point(168, 211);
            this.doctor_password_textbox.MaxLength = 14;
            this.doctor_password_textbox.Name = "doctor_password_textbox";
            this.doctor_password_textbox.PasswordChar = '*';
            this.doctor_password_textbox.Size = new System.Drawing.Size(109, 20);
            this.doctor_password_textbox.TabIndex = 13;
            // 
            // doctor_username_texbox
            // 
            this.doctor_username_texbox.Location = new System.Drawing.Point(169, 171);
            this.doctor_username_texbox.Name = "doctor_username_texbox";
            this.doctor_username_texbox.Size = new System.Drawing.Size(109, 20);
            this.doctor_username_texbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(125, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "TC Kimlik No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hastane_sistemi.Properties.Resources.doctor__1_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(399, 341);
            this.Controls.Add(this.admin_login_groupbox);
            this.Name = "DoctorLogin";
            this.Text = "Doktor Girişi";
            this.admin_login_groupbox.ResumeLayout(false);
            this.admin_login_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox admin_login_groupbox;
        private System.Windows.Forms.Button doctor_credentials_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox doctor_password_textbox;
        private System.Windows.Forms.TextBox doctor_username_texbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}