
namespace hastane_sistemi
{
    partial class Patient_MakeAppointment
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
            this.tableAdapterManager1 = new hastane_sistemi.hastaneDataSetTableAdapters.TableAdapterManager();
            this.adminTableAdapter1 = new hastane_sistemi.hastaneDataSetTableAdapters.adminTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.description_textbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.take_appointment_button = new System.Windows.Forms.Button();
            this.department_doctors_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deparment_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.adminTableAdapter = this.adminTableAdapter1;
            this.tableAdapterManager1.appointmentTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.departmentTableAdapter = null;
            this.tableAdapterManager1.doctorTableAdapter = null;
            this.tableAdapterManager1.patientTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = hastane_sistemi.hastaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.description_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.take_appointment_button);
            this.groupBox1.Controls.Add(this.department_doctors_combobox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deparment_combobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Al";
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(362, 50);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(181, 84);
            this.description_textbox.TabIndex = 7;
            this.description_textbox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hastalık\r\nTanımı\r\n";
            // 
            // take_appointment_button
            // 
            this.take_appointment_button.Location = new System.Drawing.Point(244, 219);
            this.take_appointment_button.Name = "take_appointment_button";
            this.take_appointment_button.Size = new System.Drawing.Size(86, 31);
            this.take_appointment_button.TabIndex = 5;
            this.take_appointment_button.Text = "Randevu Al";
            this.take_appointment_button.UseVisualStyleBackColor = true;
            this.take_appointment_button.Click += new System.EventHandler(this.take_appointment_button_Click);
            // 
            // department_doctors_combobox
            // 
            this.department_doctors_combobox.FormattingEnabled = true;
            this.department_doctors_combobox.Location = new System.Drawing.Point(118, 113);
            this.department_doctors_combobox.Name = "department_doctors_combobox";
            this.department_doctors_combobox.Size = new System.Drawing.Size(121, 21);
            this.department_doctors_combobox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor";
            // 
            // deparment_combobox
            // 
            this.deparment_combobox.FormattingEnabled = true;
            this.deparment_combobox.Location = new System.Drawing.Point(118, 53);
            this.deparment_combobox.Name = "deparment_combobox";
            this.deparment_combobox.Size = new System.Drawing.Size(121, 21);
            this.deparment_combobox.TabIndex = 1;
            this.deparment_combobox.SelectedIndexChanged += new System.EventHandler(this.fetchDoctorsByDepartment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm";
            // 
            // Patient_MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(591, 317);
            this.Controls.Add(this.groupBox1);
            this.Name = "Patient_MakeAppointment";
            this.Text = "Hasta Randevu Sistemi ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private hastaneDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private hastaneDataSetTableAdapters.adminTableAdapter adminTableAdapter1;
        private System.Windows.Forms.Button take_appointment_button;
        private System.Windows.Forms.ComboBox department_doctors_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deparment_combobox;
        private System.Windows.Forms.RichTextBox description_textbox;
        private System.Windows.Forms.Label label3;
    }
}