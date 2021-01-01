
namespace hastane_sistemi
{
    partial class Admin_AllAppointments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.close_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.remove_appointment_button = new System.Windows.Forms.Button();
            this.add_appointment_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new hastane_sistemi.hastaneDataSet();
            this.appointmentTableAdapter = new hastane_sistemi.hastaneDataSetTableAdapters.appointmentTableAdapter();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.close_button);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 347);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Başvurular";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(786, 304);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(93, 33);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Kapat";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.remove_appointment_button);
            this.groupBox3.Controls.Add(this.add_appointment_button);
            this.groupBox3.Location = new System.Drawing.Point(7, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlem Yap";
            // 
            // remove_appointment_button
            // 
            this.remove_appointment_button.Location = new System.Drawing.Point(240, 41);
            this.remove_appointment_button.Name = "remove_appointment_button";
            this.remove_appointment_button.Size = new System.Drawing.Size(179, 60);
            this.remove_appointment_button.TabIndex = 1;
            this.remove_appointment_button.Text = "Başvuru Sil";
            this.remove_appointment_button.UseVisualStyleBackColor = true;
            this.remove_appointment_button.Click += new System.EventHandler(this.remove_appointment_button_Click);
            // 
            // add_appointment_button
            // 
            this.add_appointment_button.Location = new System.Drawing.Point(6, 41);
            this.add_appointment_button.Name = "add_appointment_button";
            this.add_appointment_button.Size = new System.Drawing.Size(189, 60);
            this.add_appointment_button.TabIndex = 0;
            this.add_appointment_button.Text = "Başvuru Ekle";
            this.add_appointment_button.UseVisualStyleBackColor = true;
            this.add_appointment_button.Click += new System.EventHandler(this.add_doctor_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.tc,
            this.doctor_name,
            this.doctor_surname,
            this.doctor_tc,
            this.description,
            this.section,
            this.status});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "hastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Hasta İsim";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Hasta Soyisim";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // tc
            // 
            this.tc.DataPropertyName = "tc";
            this.tc.HeaderText = "Hasta Kimlik No";
            this.tc.Name = "tc";
            this.tc.ReadOnly = true;
            // 
            // doctor_name
            // 
            this.doctor_name.DataPropertyName = "doctor_name";
            this.doctor_name.HeaderText = "Doktor İsim";
            this.doctor_name.Name = "doctor_name";
            this.doctor_name.ReadOnly = true;
            // 
            // doctor_surname
            // 
            this.doctor_surname.DataPropertyName = "doctor_surname";
            this.doctor_surname.HeaderText = "Doktor Soyisim";
            this.doctor_surname.Name = "doctor_surname";
            this.doctor_surname.ReadOnly = true;
            // 
            // doctor_tc
            // 
            this.doctor_tc.DataPropertyName = "doctor_tc";
            this.doctor_tc.HeaderText = "Doktor Kimlik No";
            this.doctor_tc.Name = "doctor_tc";
            this.doctor_tc.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Hasta Şikayeti";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // section
            // 
            this.section.DataPropertyName = "section";
            this.section.HeaderText = "Bölüm";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Devam Ediyor mu";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Admin_AllAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 366);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_AllAppointments";
            this.Text = "Başvurular Sistemi";
            this.Load += new System.EventHandler(this.Admin_AllAppointments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button remove_appointment_button;
        private System.Windows.Forms.Button add_appointment_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private hastaneDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}