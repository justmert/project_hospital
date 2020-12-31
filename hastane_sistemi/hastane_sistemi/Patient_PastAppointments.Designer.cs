
namespace hastane_sistemi
{
    partial class Patient_PastAppointments
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new hastane_sistemi.hastaneDataSet();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.get_tc_numToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.get_tc_numToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy3ToolStrip = new System.Windows.Forms.ToolStrip();
            this.get_tc_numToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.get_tc_numToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.patient_current_appointments_fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.get_tc_numToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.get_tc_numToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.patient_current_appointments_fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.appointmentTableAdapter = new hastane_sistemi.hastaneDataSetTableAdapters.appointmentTableAdapter();
            this.appointmentTableAdapter1 = new hastane_sistemi.hastaneDataSetTableAdapters.appointmentTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            this.fillBy3ToolStrip.SuspendLayout();
            this.patient_current_appointments_fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geçmiş Randevular";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctornameDataGridViewTextBoxColumn,
            this.doctorsurnameDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // doctornameDataGridViewTextBoxColumn
            // 
            this.doctornameDataGridViewTextBoxColumn.DataPropertyName = "doctor_name";
            this.doctornameDataGridViewTextBoxColumn.HeaderText = "Doctor İsim";
            this.doctornameDataGridViewTextBoxColumn.Name = "doctornameDataGridViewTextBoxColumn";
            this.doctornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorsurnameDataGridViewTextBoxColumn
            // 
            this.doctorsurnameDataGridViewTextBoxColumn.DataPropertyName = "doctor_surname";
            this.doctorsurnameDataGridViewTextBoxColumn.HeaderText = "Doctor Soyisim";
            this.doctorsurnameDataGridViewTextBoxColumn.Name = "doctorsurnameDataGridViewTextBoxColumn";
            this.doctorsurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Hasta Şikayeti";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.get_tc_numToolStripLabel,
            this.get_tc_numToolStripTextBox,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(483, 25);
            this.fillBy2ToolStrip.TabIndex = 1;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Visible = false;
            // 
            // get_tc_numToolStripLabel
            // 
            this.get_tc_numToolStripLabel.Name = "get_tc_numToolStripLabel";
            this.get_tc_numToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.get_tc_numToolStripLabel.Text = "get_tc_num:";
            // 
            // get_tc_numToolStripTextBox
            // 
            this.get_tc_numToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get_tc_numToolStripTextBox.Name = "get_tc_numToolStripTextBox";
            this.get_tc_numToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataMember = "appointment";
            this.appointmentBindingSource1.DataSource = this.hastaneDataSet;
            // 
            // fillBy3ToolStrip
            // 
            this.fillBy3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.get_tc_numToolStripLabel1,
            this.get_tc_numToolStripTextBox1,
            this.fillBy3ToolStripButton});
            this.fillBy3ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy3ToolStrip.Name = "fillBy3ToolStrip";
            this.fillBy3ToolStrip.Size = new System.Drawing.Size(513, 25);
            this.fillBy3ToolStrip.TabIndex = 3;
            this.fillBy3ToolStrip.Text = "fillBy3ToolStrip";
            this.fillBy3ToolStrip.Visible = false;
            // 
            // get_tc_numToolStripLabel1
            // 
            this.get_tc_numToolStripLabel1.Name = "get_tc_numToolStripLabel1";
            this.get_tc_numToolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.get_tc_numToolStripLabel1.Text = "get_tc_num:";
            this.get_tc_numToolStripLabel1.Visible = false;
            // 
            // get_tc_numToolStripTextBox1
            // 
            this.get_tc_numToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get_tc_numToolStripTextBox1.Name = "get_tc_numToolStripTextBox1";
            this.get_tc_numToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy3ToolStripButton
            // 
            this.fillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy3ToolStripButton.Name = "fillBy3ToolStripButton";
            this.fillBy3ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy3ToolStripButton.Text = "FillBy3";
            // 
            // patient_current_appointments_fillToolStrip
            // 
            this.patient_current_appointments_fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.get_tc_numToolStripLabel2,
            this.get_tc_numToolStripTextBox2,
            this.patient_current_appointments_fillToolStripButton});
            this.patient_current_appointments_fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.patient_current_appointments_fillToolStrip.Name = "patient_current_appointments_fillToolStrip";
            this.patient_current_appointments_fillToolStrip.Size = new System.Drawing.Size(513, 25);
            this.patient_current_appointments_fillToolStrip.TabIndex = 4;
            this.patient_current_appointments_fillToolStrip.Text = "patient_current_appointments_fillToolStrip";
            this.patient_current_appointments_fillToolStrip.Visible = false;
            // 
            // get_tc_numToolStripLabel2
            // 
            this.get_tc_numToolStripLabel2.Name = "get_tc_numToolStripLabel2";
            this.get_tc_numToolStripLabel2.Size = new System.Drawing.Size(72, 22);
            this.get_tc_numToolStripLabel2.Text = "get_tc_num:";
            // 
            // get_tc_numToolStripTextBox2
            // 
            this.get_tc_numToolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get_tc_numToolStripTextBox2.Name = "get_tc_numToolStripTextBox2";
            this.get_tc_numToolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // patient_current_appointments_fillToolStripButton
            // 
            this.patient_current_appointments_fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.patient_current_appointments_fillToolStripButton.Name = "patient_current_appointments_fillToolStripButton";
            this.patient_current_appointments_fillToolStripButton.Size = new System.Drawing.Size(188, 22);
            this.patient_current_appointments_fillToolStripButton.Text = "patient_current_appointments_fill";
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // Patient_PastAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(561, 265);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.fillBy3ToolStrip);
            this.Controls.Add(this.patient_current_appointments_fillToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "Patient_PastAppointments";
            this.Text = "Geçmiş Randevu Sistemi";
            this.Load += new System.EventHandler(this.Patient_Appointments_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            this.fillBy3ToolStrip.ResumeLayout(false);
            this.fillBy3ToolStrip.PerformLayout();
            this.patient_current_appointments_fillToolStrip.ResumeLayout(false);
            this.patient_current_appointments_fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private hastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private hastaneDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel get_tc_numToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox get_tc_numToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.ToolStrip fillBy3ToolStrip;
        private System.Windows.Forms.ToolStripLabel get_tc_numToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox get_tc_numToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillBy3ToolStripButton;
        private System.Windows.Forms.ToolStrip patient_current_appointments_fillToolStrip;
        private System.Windows.Forms.ToolStripLabel get_tc_numToolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox get_tc_numToolStripTextBox2;
        private System.Windows.Forms.ToolStripButton patient_current_appointments_fillToolStripButton;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private hastaneDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}