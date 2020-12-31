
namespace hastane_sistemi
{
    partial class Doctor_DoneAppointments
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_by_patient_nameToolStrip = new System.Windows.Forms.ToolStrip();
            this.patient_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.patient_nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_by_patient_nameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.search_by_patient_surnameToolStrip = new System.Windows.Forms.ToolStrip();
            this.patient_surnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.patient_surnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_by_patient_surnameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.search_by_patient_tcToolStrip = new System.Windows.Forms.ToolStrip();
            this.patient_tcToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.patient_tcToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_by_patient_tcToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new hastane_sistemi.hastaneDataSet();
            this.appointmentTableAdapter = new hastane_sistemi.hastaneDataSetTableAdapters.appointmentTableAdapter();
            this.fillBy4ToolStrip = new System.Windows.Forms.ToolStrip();
            this.doctor_tc_numToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.doctor_tc_numToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy4ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.search_by_patient_nameToolStrip.SuspendLayout();
            this.search_by_patient_surnameToolStrip.SuspendLayout();
            this.search_by_patient_tcToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.fillBy4ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Geçmişi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.search_by_patient_nameToolStrip);
            this.groupBox2.Controls.Add(this.search_by_patient_surnameToolStrip);
            this.groupBox2.Controls.Add(this.search_by_patient_tcToolStrip);
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ara";
            // 
            // search_by_patient_nameToolStrip
            // 
            this.search_by_patient_nameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.search_by_patient_nameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patient_nameToolStripLabel,
            this.patient_nameToolStripTextBox,
            this.search_by_patient_nameToolStripButton});
            this.search_by_patient_nameToolStrip.Location = new System.Drawing.Point(3, 66);
            this.search_by_patient_nameToolStrip.Name = "search_by_patient_nameToolStrip";
            this.search_by_patient_nameToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.search_by_patient_nameToolStrip.Size = new System.Drawing.Size(273, 25);
            this.search_by_patient_nameToolStrip.TabIndex = 0;
            this.search_by_patient_nameToolStrip.Text = "search_by_patient_nameToolStrip";
            // 
            // patient_nameToolStripLabel
            // 
            this.patient_nameToolStripLabel.Margin = new System.Windows.Forms.Padding(0, 1, 30, 2);
            this.patient_nameToolStripLabel.Name = "patient_nameToolStripLabel";
            this.patient_nameToolStripLabel.Size = new System.Drawing.Size(65, 22);
            this.patient_nameToolStripLabel.Text = "Hasta İsim:";
            // 
            // patient_nameToolStripTextBox
            // 
            this.patient_nameToolStripTextBox.Name = "patient_nameToolStripTextBox";
            this.patient_nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_by_patient_nameToolStripButton
            // 
            this.search_by_patient_nameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_by_patient_nameToolStripButton.Name = "search_by_patient_nameToolStripButton";
            this.search_by_patient_nameToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.search_by_patient_nameToolStripButton.Text = "Ara";
            this.search_by_patient_nameToolStripButton.Click += new System.EventHandler(this.search_by_patient_nameToolStripButton_Click);
            // 
            // search_by_patient_surnameToolStrip
            // 
            this.search_by_patient_surnameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.search_by_patient_surnameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patient_surnameToolStripLabel,
            this.patient_surnameToolStripTextBox,
            this.search_by_patient_surnameToolStripButton});
            this.search_by_patient_surnameToolStrip.Location = new System.Drawing.Point(3, 41);
            this.search_by_patient_surnameToolStrip.Name = "search_by_patient_surnameToolStrip";
            this.search_by_patient_surnameToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.search_by_patient_surnameToolStrip.Size = new System.Drawing.Size(273, 25);
            this.search_by_patient_surnameToolStrip.TabIndex = 1;
            this.search_by_patient_surnameToolStrip.Text = "search_by_patient_surnameToolStrip";
            // 
            // patient_surnameToolStripLabel
            // 
            this.patient_surnameToolStripLabel.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.patient_surnameToolStripLabel.Name = "patient_surnameToolStripLabel";
            this.patient_surnameToolStripLabel.Size = new System.Drawing.Size(87, 22);
            this.patient_surnameToolStripLabel.Text = "Hasta Soyisim: ";
            // 
            // patient_surnameToolStripTextBox
            // 
            this.patient_surnameToolStripTextBox.Name = "patient_surnameToolStripTextBox";
            this.patient_surnameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_by_patient_surnameToolStripButton
            // 
            this.search_by_patient_surnameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_by_patient_surnameToolStripButton.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.search_by_patient_surnameToolStripButton.Name = "search_by_patient_surnameToolStripButton";
            this.search_by_patient_surnameToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.search_by_patient_surnameToolStripButton.Text = "Ara";
            this.search_by_patient_surnameToolStripButton.Click += new System.EventHandler(this.search_by_patient_surnameToolStripButton_Click);
            // 
            // search_by_patient_tcToolStrip
            // 
            this.search_by_patient_tcToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.search_by_patient_tcToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patient_tcToolStripLabel,
            this.patient_tcToolStripTextBox,
            this.search_by_patient_tcToolStripButton});
            this.search_by_patient_tcToolStrip.Location = new System.Drawing.Point(3, 16);
            this.search_by_patient_tcToolStrip.Name = "search_by_patient_tcToolStrip";
            this.search_by_patient_tcToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.search_by_patient_tcToolStrip.Size = new System.Drawing.Size(273, 25);
            this.search_by_patient_tcToolStrip.TabIndex = 2;
            this.search_by_patient_tcToolStrip.Text = "search_by_patient_tcToolStrip";
            // 
            // patient_tcToolStripLabel
            // 
            this.patient_tcToolStripLabel.Name = "patient_tcToolStripLabel";
            this.patient_tcToolStripLabel.Size = new System.Drawing.Size(95, 22);
            this.patient_tcToolStripLabel.Text = "Hasta Kimlik No:";
            // 
            // patient_tcToolStripTextBox
            // 
            this.patient_tcToolStripTextBox.Name = "patient_tcToolStripTextBox";
            this.patient_tcToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_by_patient_tcToolStripButton
            // 
            this.search_by_patient_tcToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_by_patient_tcToolStripButton.Name = "search_by_patient_tcToolStripButton";
            this.search_by_patient_tcToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.search_by_patient_tcToolStripButton.Text = "Ara";
            this.search_by_patient_tcToolStripButton.Click += new System.EventHandler(this.search_by_patient_tcToolStripButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(292, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 150);
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
            // fillBy4ToolStrip
            // 
            this.fillBy4ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctor_tc_numToolStripLabel,
            this.doctor_tc_numToolStripTextBox,
            this.fillBy4ToolStripButton});
            this.fillBy4ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy4ToolStrip.Name = "fillBy4ToolStrip";
            this.fillBy4ToolStrip.Size = new System.Drawing.Size(645, 25);
            this.fillBy4ToolStrip.TabIndex = 1;
            this.fillBy4ToolStrip.Text = "fillBy4ToolStrip";
            this.fillBy4ToolStrip.Visible = false;
            // 
            // doctor_tc_numToolStripLabel
            // 
            this.doctor_tc_numToolStripLabel.Name = "doctor_tc_numToolStripLabel";
            this.doctor_tc_numToolStripLabel.Size = new System.Drawing.Size(90, 22);
            this.doctor_tc_numToolStripLabel.Text = "doctor_tc_num:";
            // 
            // doctor_tc_numToolStripTextBox
            // 
            this.doctor_tc_numToolStripTextBox.Name = "doctor_tc_numToolStripTextBox";
            this.doctor_tc_numToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy4ToolStripButton
            // 
            this.fillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy4ToolStripButton.Name = "fillBy4ToolStripButton";
            this.fillBy4ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy4ToolStripButton.Text = "FillBy4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aramayı Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Doctor_DoneAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 221);
            this.Controls.Add(this.fillBy4ToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doctor_DoneAppointments";
            this.Text = "Geçmiş Randevu Sistemi";
            this.Load += new System.EventHandler(this.Doctor_DoneAppointments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.search_by_patient_nameToolStrip.ResumeLayout(false);
            this.search_by_patient_nameToolStrip.PerformLayout();
            this.search_by_patient_surnameToolStrip.ResumeLayout(false);
            this.search_by_patient_surnameToolStrip.PerformLayout();
            this.search_by_patient_tcToolStrip.ResumeLayout(false);
            this.search_by_patient_tcToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.fillBy4ToolStrip.ResumeLayout(false);
            this.fillBy4ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private hastaneDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy4ToolStrip;
        private System.Windows.Forms.ToolStripLabel doctor_tc_numToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox doctor_tc_numToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy4ToolStripButton;
        private System.Windows.Forms.ToolStrip search_by_patient_tcToolStrip;
        private System.Windows.Forms.ToolStripLabel patient_tcToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox patient_tcToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search_by_patient_tcToolStripButton;
        private System.Windows.Forms.ToolStrip search_by_patient_nameToolStrip;
        private System.Windows.Forms.ToolStripLabel patient_nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox patient_nameToolStripTextBox;
        private System.Windows.Forms.ToolStrip search_by_patient_surnameToolStrip;
        private System.Windows.Forms.ToolStripLabel patient_surnameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox patient_surnameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search_by_patient_surnameToolStripButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton search_by_patient_nameToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}