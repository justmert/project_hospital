
namespace hastane_sistemi
{
    partial class Admin_MakeAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.patient_tc_texbox = new System.Windows.Forms.TextBox();
            this.approve_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.approve_button);
            this.groupBox1.Controls.Add(this.patient_tc_texbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgilerini Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Kimlik Numarası:";
            // 
            // patient_tc_texbox
            // 
            this.patient_tc_texbox.Location = new System.Drawing.Point(173, 37);
            this.patient_tc_texbox.Name = "patient_tc_texbox";
            this.patient_tc_texbox.Size = new System.Drawing.Size(109, 20);
            this.patient_tc_texbox.TabIndex = 1;
            // 
            // approve_button
            // 
            this.approve_button.Location = new System.Drawing.Point(141, 93);
            this.approve_button.Name = "approve_button";
            this.approve_button.Size = new System.Drawing.Size(75, 23);
            this.approve_button.TabIndex = 2;
            this.approve_button.Text = "Onayla";
            this.approve_button.UseVisualStyleBackColor = true;
            this.approve_button.Click += new System.EventHandler(this.approve_button_Click);
            // 
            // Admin_MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(402, 193);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_MakeAppointment";
            this.Text = "Randevu Oluştur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox patient_tc_texbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button approve_button;
    }
}