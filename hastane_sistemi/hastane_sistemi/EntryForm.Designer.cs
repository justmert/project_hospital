
namespace hastane_sistemi
{
    partial class EntryForm
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
            this.adminform_groupbox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_entry_button = new System.Windows.Forms.Button();
            this.doctor_sign_button = new System.Windows.Forms.Button();
            this.doctor_entry_button = new System.Windows.Forms.Button();
            this.patient_entry_button = new System.Windows.Forms.Button();
            this.patient_sign_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new hastane_sistemi.hastaneDataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminform_groupbox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminform_groupbox
            // 
            this.adminform_groupbox.Controls.Add(this.panel1);
            this.adminform_groupbox.Controls.Add(this.pictureBox2);
            this.adminform_groupbox.Controls.Add(this.label2);
            this.adminform_groupbox.Controls.Add(this.label1);
            this.adminform_groupbox.Controls.Add(this.pictureBox1);
            this.adminform_groupbox.Location = new System.Drawing.Point(12, 12);
            this.adminform_groupbox.Name = "adminform_groupbox";
            this.adminform_groupbox.Size = new System.Drawing.Size(581, 386);
            this.adminform_groupbox.TabIndex = 0;
            this.adminform_groupbox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.admin_entry_button);
            this.panel1.Controls.Add(this.doctor_sign_button);
            this.panel1.Controls.Add(this.doctor_entry_button);
            this.panel1.Controls.Add(this.patient_entry_button);
            this.panel1.Controls.Add(this.patient_sign_button);
            this.panel1.Location = new System.Drawing.Point(0, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 221);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kayıt ya da Giriş Yapınız";
            // 
            // admin_entry_button
            // 
            this.admin_entry_button.Location = new System.Drawing.Point(117, 165);
            this.admin_entry_button.Name = "admin_entry_button";
            this.admin_entry_button.Size = new System.Drawing.Size(124, 40);
            this.admin_entry_button.TabIndex = 11;
            this.admin_entry_button.Text = "Admin Girişi";
            this.admin_entry_button.UseVisualStyleBackColor = true;
            this.admin_entry_button.Click += new System.EventHandler(this.admin_entry_button_Click);
            // 
            // doctor_sign_button
            // 
            this.doctor_sign_button.Location = new System.Drawing.Point(208, 119);
            this.doctor_sign_button.Name = "doctor_sign_button";
            this.doctor_sign_button.Size = new System.Drawing.Size(124, 40);
            this.doctor_sign_button.TabIndex = 12;
            this.doctor_sign_button.Text = "Doktor Başvurusu";
            this.doctor_sign_button.UseVisualStyleBackColor = true;
            this.doctor_sign_button.Click += new System.EventHandler(this.doctor_sign_button_Click);
            // 
            // doctor_entry_button
            // 
            this.doctor_entry_button.Location = new System.Drawing.Point(208, 73);
            this.doctor_entry_button.Name = "doctor_entry_button";
            this.doctor_entry_button.Size = new System.Drawing.Size(124, 40);
            this.doctor_entry_button.TabIndex = 11;
            this.doctor_entry_button.Text = "Doktor Girişi";
            this.doctor_entry_button.UseVisualStyleBackColor = true;
            this.doctor_entry_button.Click += new System.EventHandler(this.doctor_entry_button_Click);
            // 
            // patient_entry_button
            // 
            this.patient_entry_button.Location = new System.Drawing.Point(18, 73);
            this.patient_entry_button.Name = "patient_entry_button";
            this.patient_entry_button.Size = new System.Drawing.Size(124, 40);
            this.patient_entry_button.TabIndex = 11;
            this.patient_entry_button.Text = "Hasta Girişi";
            this.patient_entry_button.UseVisualStyleBackColor = true;
            this.patient_entry_button.Click += new System.EventHandler(this.patient_entry_button_Click);
            // 
            // patient_sign_button
            // 
            this.patient_sign_button.Location = new System.Drawing.Point(18, 119);
            this.patient_sign_button.Name = "patient_sign_button";
            this.patient_sign_button.Size = new System.Drawing.Size(124, 40);
            this.patient_sign_button.TabIndex = 12;
            this.patient_sign_button.Text = "Hasta Kaydı";
            this.patient_sign_button.UseVisualStyleBackColor = true;
            this.patient_sign_button.Click += new System.EventHandler(this.patient_sign_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bizim Emeğimiz, Sizin Sağlığınız...\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esra Hastanesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.adminTableAdapter = null;
            this.tableAdapterManager1.appointmentTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.departmentTableAdapter = null;
            this.tableAdapterManager1.doctorTableAdapter = null;
            this.tableAdapterManager1.patientTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = hastane_sistemi.hastaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hastane_sistemi.Properties.Resources.woman_doctor;
            this.pictureBox2.Location = new System.Drawing.Point(357, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hastane_sistemi.Properties.Resources.hospital__1_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 410);
            this.Controls.Add(this.adminform_groupbox);
            this.Name = "EntryForm";
            this.Text = "Esra Hastanesi";
            this.adminform_groupbox.ResumeLayout(false);
            this.adminform_groupbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox adminform_groupbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private hastaneDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button patient_entry_button;
        private System.Windows.Forms.Button admin_entry_button;
        private System.Windows.Forms.Button doctor_entry_button;
        private System.Windows.Forms.Button doctor_sign_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button patient_sign_button;
        private System.Windows.Forms.Label label3;
    }
}

