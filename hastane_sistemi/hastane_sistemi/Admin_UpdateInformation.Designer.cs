
namespace hastane_sistemi
{
    partial class Admin_UpdateInformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update_admin_button = new System.Windows.Forms.Button();
            this.admin_password_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_surname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_name_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update_admin_button);
            this.groupBox1.Controls.Add(this.admin_password_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.admin_surname_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.admin_name_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Bilgilerini Güncelle";
            // 
            // update_admin_button
            // 
            this.update_admin_button.Location = new System.Drawing.Point(216, 169);
            this.update_admin_button.Name = "update_admin_button";
            this.update_admin_button.Size = new System.Drawing.Size(143, 26);
            this.update_admin_button.TabIndex = 8;
            this.update_admin_button.Text = "Güncelle";
            this.update_admin_button.UseVisualStyleBackColor = true;
            this.update_admin_button.Click += new System.EventHandler(this.update_admin_button_Click);
            // 
            // admin_password_textbox
            // 
            this.admin_password_textbox.Location = new System.Drawing.Point(387, 35);
            this.admin_password_textbox.Name = "admin_password_textbox";
            this.admin_password_textbox.PasswordChar = '*';
            this.admin_password_textbox.Size = new System.Drawing.Size(119, 20);
            this.admin_password_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre\r\n\r\n(8 haneli ve rakamlardan oluşmalı)\r\n";
            // 
            // admin_surname_textbox
            // 
            this.admin_surname_textbox.Location = new System.Drawing.Point(93, 77);
            this.admin_surname_textbox.Name = "admin_surname_textbox";
            this.admin_surname_textbox.Size = new System.Drawing.Size(119, 20);
            this.admin_surname_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            // 
            // admin_name_textbox
            // 
            this.admin_name_textbox.Location = new System.Drawing.Point(93, 35);
            this.admin_name_textbox.Name = "admin_name_textbox";
            this.admin_name_textbox.Size = new System.Drawing.Size(119, 20);
            this.admin_name_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // Admin_UpdateInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 246);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_UpdateInformation";
            this.Text = "Admin_UpdateInformation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_admin_button;
        private System.Windows.Forms.TextBox admin_password_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox admin_surname_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox admin_name_textbox;
        private System.Windows.Forms.Label label1;
    }
}