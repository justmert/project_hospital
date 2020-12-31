
namespace hastane_sistemi
{
    partial class AdminLogin
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
            this.admin_credentials_login = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.admin_password_textbox = new System.Windows.Forms.TextBox();
            this.admin_username_texbox = new System.Windows.Forms.TextBox();
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
            this.admin_login_groupbox.Controls.Add(this.admin_credentials_login);
            this.admin_login_groupbox.Controls.Add(this.label5);
            this.admin_login_groupbox.Controls.Add(this.admin_password_textbox);
            this.admin_login_groupbox.Controls.Add(this.admin_username_texbox);
            this.admin_login_groupbox.Controls.Add(this.label4);
            this.admin_login_groupbox.Controls.Add(this.label3);
            this.admin_login_groupbox.Location = new System.Drawing.Point(13, 13);
            this.admin_login_groupbox.Name = "admin_login_groupbox";
            this.admin_login_groupbox.Size = new System.Drawing.Size(364, 307);
            this.admin_login_groupbox.TabIndex = 0;
            this.admin_login_groupbox.TabStop = false;
            // 
            // admin_credentials_login
            // 
            this.admin_credentials_login.Location = new System.Drawing.Point(142, 260);
            this.admin_credentials_login.Name = "admin_credentials_login";
            this.admin_credentials_login.Size = new System.Drawing.Size(86, 30);
            this.admin_credentials_login.TabIndex = 15;
            this.admin_credentials_login.Text = "Giriş Yap";
            this.admin_credentials_login.UseVisualStyleBackColor = true;
            this.admin_credentials_login.Click += new System.EventHandler(this.admin_credentials_login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(151, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Admin Girişi";
            // 
            // admin_password_textbox
            // 
            this.admin_password_textbox.Location = new System.Drawing.Point(158, 211);
            this.admin_password_textbox.MaxLength = 14;
            this.admin_password_textbox.Name = "admin_password_textbox";
            this.admin_password_textbox.PasswordChar = '*';
            this.admin_password_textbox.Size = new System.Drawing.Size(109, 20);
            this.admin_password_textbox.TabIndex = 13;
            // 
            // admin_username_texbox
            // 
            this.admin_username_texbox.Location = new System.Drawing.Point(158, 168);
            this.admin_username_texbox.Name = "admin_username_texbox";
            this.admin_username_texbox.Size = new System.Drawing.Size(109, 20);
            this.admin_username_texbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(115, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hastane_sistemi.Properties.Resources.administrator;
            this.pictureBox1.Location = new System.Drawing.Point(26, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(389, 332);
            this.Controls.Add(this.admin_login_groupbox);
            this.Name = "AdminLogin";
            this.Text = "Admin Girişi";
            this.admin_login_groupbox.ResumeLayout(false);
            this.admin_login_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox admin_login_groupbox;
        private System.Windows.Forms.Button admin_credentials_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox admin_password_textbox;
        private System.Windows.Forms.TextBox admin_username_texbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}