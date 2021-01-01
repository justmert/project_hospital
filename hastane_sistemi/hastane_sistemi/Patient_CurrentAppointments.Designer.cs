
namespace hastane_sistemi
{
    partial class Patient_CurrentAppointments
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new hastane_sistemi.hastaneDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new hastane_sistemi.hastaneDataSetTableAdapters.appointmentTableAdapter();
            this.current_appoinments_fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.tc_numToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tc_numToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.current_appoinments_fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.current_appoinments_fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tc_numToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tc_numToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.current_appoinments_fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.doctor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.current_appoinments_fillToolStrip.SuspendLayout();
            this.current_appoinments_fillToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devam Eden Randevular";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctor_name,
            this.doctor_surname,
            this.description,
            this.section});
            this.dataGridView1.DataSource = this.appointmentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(53, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataMember = "appointment";
            this.appointmentBindingSource1.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "hastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Randevuyu İptal Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.hastaneDataSet;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // current_appoinments_fillToolStrip
            // 
            this.current_appoinments_fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tc_numToolStripLabel,
            this.tc_numToolStripTextBox,
            this.current_appoinments_fillToolStripButton});
            this.current_appoinments_fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.current_appoinments_fillToolStrip.Name = "current_appoinments_fillToolStrip";
            this.current_appoinments_fillToolStrip.Size = new System.Drawing.Size(718, 25);
            this.current_appoinments_fillToolStrip.TabIndex = 1;
            this.current_appoinments_fillToolStrip.Text = "current_appoinments_fillToolStrip";
            this.current_appoinments_fillToolStrip.Visible = false;
            // 
            // tc_numToolStripLabel
            // 
            this.tc_numToolStripLabel.Name = "tc_numToolStripLabel";
            this.tc_numToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.tc_numToolStripLabel.Text = "tc_num:";
            // 
            // tc_numToolStripTextBox
            // 
            this.tc_numToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tc_numToolStripTextBox.Name = "tc_numToolStripTextBox";
            this.tc_numToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // current_appoinments_fillToolStripButton
            // 
            this.current_appoinments_fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.current_appoinments_fillToolStripButton.Name = "current_appoinments_fillToolStripButton";
            this.current_appoinments_fillToolStripButton.Size = new System.Drawing.Size(142, 22);
            this.current_appoinments_fillToolStripButton.Text = "current_appoinments_fill";
            // 
            // current_appoinments_fillToolStrip1
            // 
            this.current_appoinments_fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tc_numToolStripLabel1,
            this.tc_numToolStripTextBox1,
            this.current_appoinments_fillToolStripButton1});
            this.current_appoinments_fillToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.current_appoinments_fillToolStrip1.Name = "current_appoinments_fillToolStrip1";
            this.current_appoinments_fillToolStrip1.Size = new System.Drawing.Size(487, 25);
            this.current_appoinments_fillToolStrip1.TabIndex = 3;
            this.current_appoinments_fillToolStrip1.Text = "current_appoinments_fillToolStrip1";
            this.current_appoinments_fillToolStrip1.Visible = false;
            // 
            // tc_numToolStripLabel1
            // 
            this.tc_numToolStripLabel1.Name = "tc_numToolStripLabel1";
            this.tc_numToolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.tc_numToolStripLabel1.Text = "tc_num:";
            // 
            // tc_numToolStripTextBox1
            // 
            this.tc_numToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tc_numToolStripTextBox1.Name = "tc_numToolStripTextBox1";
            this.tc_numToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // current_appoinments_fillToolStripButton1
            // 
            this.current_appoinments_fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.current_appoinments_fillToolStripButton1.Name = "current_appoinments_fillToolStripButton1";
            this.current_appoinments_fillToolStripButton1.Size = new System.Drawing.Size(142, 22);
            this.current_appoinments_fillToolStripButton1.Text = "current_appoinments_fill";
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
            // Patient_CurrentAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(575, 298);
            this.Controls.Add(this.current_appoinments_fillToolStrip1);
            this.Controls.Add(this.current_appoinments_fillToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "Patient_CurrentAppointments";
            this.Text = "Devam Eden Randevular";
            this.Load += new System.EventHandler(this.Patient_CurrentAppointments_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.current_appoinments_fillToolStrip.ResumeLayout(false);
            this.current_appoinments_fillToolStrip.PerformLayout();
            this.current_appoinments_fillToolStrip1.ResumeLayout(false);
            this.current_appoinments_fillToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private hastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private hastaneDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.ToolStrip current_appoinments_fillToolStrip;
        private System.Windows.Forms.ToolStripLabel tc_numToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tc_numToolStripTextBox;
        private System.Windows.Forms.ToolStripButton current_appoinments_fillToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private System.Windows.Forms.ToolStrip current_appoinments_fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel tc_numToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tc_numToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton current_appoinments_fillToolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
    }
}