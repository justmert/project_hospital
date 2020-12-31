
namespace hastane_sistemi
{
    partial class Doctor_AssignedAppointments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new hastane_sistemi.hastaneDataSet();
            this.cancel_appointment_button = new System.Windows.Forms.Button();
            this.active_appointmentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.active_appointmentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.appointment_done_button = new System.Windows.Forms.Button();
            this.appointmentTableAdapter = new hastane_sistemi.hastaneDataSetTableAdapters.appointmentTableAdapter();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.active_appointmentsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.appointment_done_button);
            this.groupBox1.Controls.Add(this.cancel_appointment_button);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktif Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 183);
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
            // cancel_appointment_button
            // 
            this.cancel_appointment_button.Location = new System.Drawing.Point(37, 242);
            this.cancel_appointment_button.Name = "cancel_appointment_button";
            this.cancel_appointment_button.Size = new System.Drawing.Size(130, 31);
            this.cancel_appointment_button.TabIndex = 1;
            this.cancel_appointment_button.Text = "Randevuyu İptal Et";
            this.cancel_appointment_button.UseVisualStyleBackColor = true;
            // 
            // active_appointmentsToolStrip
            // 
            this.active_appointmentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.active_appointmentsToolStripButton});
            this.active_appointmentsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.active_appointmentsToolStrip.Name = "active_appointmentsToolStrip";
            this.active_appointmentsToolStrip.Size = new System.Drawing.Size(652, 25);
            this.active_appointmentsToolStrip.TabIndex = 2;
            this.active_appointmentsToolStrip.Text = "active_appointmentsToolStrip";
            this.active_appointmentsToolStrip.Visible = false;
            // 
            // active_appointmentsToolStripButton
            // 
            this.active_appointmentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.active_appointmentsToolStripButton.Name = "active_appointmentsToolStripButton";
            this.active_appointmentsToolStripButton.Size = new System.Drawing.Size(121, 22);
            this.active_appointmentsToolStripButton.Text = "active_appointments";
            // 
            // appointment_done_button
            // 
            this.appointment_done_button.Location = new System.Drawing.Point(390, 242);
            this.appointment_done_button.Name = "appointment_done_button";
            this.appointment_done_button.Size = new System.Drawing.Size(141, 31);
            this.appointment_done_button.TabIndex = 3;
            this.appointment_done_button.Text = "Randevu Gerçekleştirildi";
            this.appointment_done_button.UseVisualStyleBackColor = true;
            this.appointment_done_button.Click += new System.EventHandler(this.appointment_done_button_Click);
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Hasta Kimlik Numarası";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Hasta İsim";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Hasta Soyisim";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Hasta Şikayeti";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Doctor_AssignedAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(592, 313);
            this.Controls.Add(this.active_appointmentsToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doctor_AssignedAppointments";
            this.Text = "Doctor_AssignedAppointments";
            this.Load += new System.EventHandler(this.Doctor_AssignedAppointments_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.active_appointmentsToolStrip.ResumeLayout(false);
            this.active_appointmentsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancel_appointment_button;
        private hastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private hastaneDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.ToolStrip active_appointmentsToolStrip;
        private System.Windows.Forms.ToolStripButton active_appointmentsToolStripButton;
        private System.Windows.Forms.Button appointment_done_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}