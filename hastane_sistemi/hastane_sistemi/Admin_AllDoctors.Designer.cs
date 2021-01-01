
namespace hastane_sistemi
{
    partial class Admin_AllDoctors
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
            this.update_doctor_button = new System.Windows.Forms.Button();
            this.remove_doctor_button = new System.Windows.Forms.Button();
            this.add_doctor_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.search_by_mailToolStrip = new System.Windows.Forms.ToolStrip();
            this.search_mailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.search_mailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_by_mailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.search_by_phoneToolStrip = new System.Windows.Forms.ToolStrip();
            this.search_phoneToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.search_phoneToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_by_phoneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.search_by_tcToolStrip = new System.Windows.Forms.ToolStrip();
            this.search_tcToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.search_tcToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_by_tcToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.search_by_full_nameToolStrip = new System.Windows.Forms.ToolStrip();
            this.search_full_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.search_full_nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_by_full_nameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new hastane_sistemi.hastaneDataSet();
            this.doctorTableAdapter = new hastane_sistemi.hastaneDataSetTableAdapters.doctorTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.search_by_mailToolStrip.SuspendLayout();
            this.search_by_phoneToolStrip.SuspendLayout();
            this.search_by_tcToolStrip.SuspendLayout();
            this.search_by_full_nameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.close_button);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Doktorlar";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(652, 356);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(93, 33);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Kapat";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.update_doctor_button);
            this.groupBox3.Controls.Add(this.remove_doctor_button);
            this.groupBox3.Controls.Add(this.add_doctor_button);
            this.groupBox3.Location = new System.Drawing.Point(418, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlem Yap";
            // 
            // update_doctor_button
            // 
            this.update_doctor_button.Location = new System.Drawing.Point(231, 41);
            this.update_doctor_button.Name = "update_doctor_button";
            this.update_doctor_button.Size = new System.Drawing.Size(90, 60);
            this.update_doctor_button.TabIndex = 2;
            this.update_doctor_button.Text = "Doktor Bilgilerini Değiştir";
            this.update_doctor_button.UseVisualStyleBackColor = true;
            this.update_doctor_button.Click += new System.EventHandler(this.update_doctor_button_Click);
            // 
            // remove_doctor_button
            // 
            this.remove_doctor_button.Location = new System.Drawing.Point(119, 41);
            this.remove_doctor_button.Name = "remove_doctor_button";
            this.remove_doctor_button.Size = new System.Drawing.Size(90, 60);
            this.remove_doctor_button.TabIndex = 1;
            this.remove_doctor_button.Text = "Doktoru İşten At";
            this.remove_doctor_button.UseVisualStyleBackColor = true;
            this.remove_doctor_button.Click += new System.EventHandler(this.remove_doctor_button_Click);
            // 
            // add_doctor_button
            // 
            this.add_doctor_button.Location = new System.Drawing.Point(6, 41);
            this.add_doctor_button.Name = "add_doctor_button";
            this.add_doctor_button.Size = new System.Drawing.Size(90, 60);
            this.add_doctor_button.TabIndex = 0;
            this.add_doctor_button.Text = "Doktor Ekle";
            this.add_doctor_button.UseVisualStyleBackColor = true;
            this.add_doctor_button.Click += new System.EventHandler(this.add_doctor_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.search_by_mailToolStrip);
            this.groupBox2.Controls.Add(this.search_by_phoneToolStrip);
            this.groupBox2.Controls.Add(this.search_by_tcToolStrip);
            this.groupBox2.Controls.Add(this.search_by_full_nameToolStrip);
            this.groupBox2.Location = new System.Drawing.Point(42, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ara";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_by_mailToolStrip
            // 
            this.search_by_mailToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.search_by_mailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_mailToolStripLabel,
            this.search_mailToolStripTextBox,
            this.search_by_mailToolStripButton});
            this.search_by_mailToolStrip.Location = new System.Drawing.Point(3, 91);
            this.search_by_mailToolStrip.Name = "search_by_mailToolStrip";
            this.search_by_mailToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.search_by_mailToolStrip.Size = new System.Drawing.Size(361, 25);
            this.search_by_mailToolStrip.TabIndex = 3;
            this.search_by_mailToolStrip.Text = "search_by_mailToolStrip";
            // 
            // search_mailToolStripLabel
            // 
            this.search_mailToolStripLabel.Name = "search_mailToolStripLabel";
            this.search_mailToolStripLabel.Size = new System.Drawing.Size(107, 22);
            this.search_mailToolStripLabel.Text = "Mail Adresinde Ara";
            // 
            // search_mailToolStripTextBox
            // 
            this.search_mailToolStripTextBox.Margin = new System.Windows.Forms.Padding(29, 0, 1, 0);
            this.search_mailToolStripTextBox.Name = "search_mailToolStripTextBox";
            this.search_mailToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_by_mailToolStripButton
            // 
            this.search_by_mailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_by_mailToolStripButton.Name = "search_by_mailToolStripButton";
            this.search_by_mailToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.search_by_mailToolStripButton.Text = "Ara";
            this.search_by_mailToolStripButton.Click += new System.EventHandler(this.search_by_mailToolStripButton_Click);
            // 
            // search_by_phoneToolStrip
            // 
            this.search_by_phoneToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.search_by_phoneToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_phoneToolStripLabel,
            this.search_phoneToolStripTextBox,
            this.search_by_phoneToolStripButton});
            this.search_by_phoneToolStrip.Location = new System.Drawing.Point(3, 66);
            this.search_by_phoneToolStrip.Name = "search_by_phoneToolStrip";
            this.search_by_phoneToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.search_by_phoneToolStrip.Size = new System.Drawing.Size(361, 25);
            this.search_by_phoneToolStrip.TabIndex = 3;
            this.search_by_phoneToolStrip.Text = "Telefonda Ara";
            // 
            // search_phoneToolStripLabel
            // 
            this.search_phoneToolStripLabel.Name = "search_phoneToolStripLabel";
            this.search_phoneToolStripLabel.Size = new System.Drawing.Size(79, 22);
            this.search_phoneToolStripLabel.Text = "Telefonda Ara";
            // 
            // search_phoneToolStripTextBox
            // 
            this.search_phoneToolStripTextBox.Margin = new System.Windows.Forms.Padding(57, 0, 1, 0);
            this.search_phoneToolStripTextBox.Name = "search_phoneToolStripTextBox";
            this.search_phoneToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_by_phoneToolStripButton
            // 
            this.search_by_phoneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_by_phoneToolStripButton.Name = "search_by_phoneToolStripButton";
            this.search_by_phoneToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.search_by_phoneToolStripButton.Text = "Ara";
            this.search_by_phoneToolStripButton.Click += new System.EventHandler(this.search_by_phoneToolStripButton_Click);
            // 
            // search_by_tcToolStrip
            // 
            this.search_by_tcToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.search_by_tcToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_tcToolStripLabel,
            this.search_tcToolStripTextBox,
            this.search_by_tcToolStripButton});
            this.search_by_tcToolStrip.Location = new System.Drawing.Point(3, 41);
            this.search_by_tcToolStrip.Name = "search_by_tcToolStrip";
            this.search_by_tcToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.search_by_tcToolStrip.Size = new System.Drawing.Size(361, 25);
            this.search_by_tcToolStrip.TabIndex = 3;
            this.search_by_tcToolStrip.Text = "search_by_tcToolStrip";
            // 
            // search_tcToolStripLabel
            // 
            this.search_tcToolStripLabel.Name = "search_tcToolStripLabel";
            this.search_tcToolStripLabel.Size = new System.Drawing.Size(135, 22);
            this.search_tcToolStripLabel.Text = "Kimlik Numarasında Ara";
            // 
            // search_tcToolStripTextBox
            // 
            this.search_tcToolStripTextBox.Name = "search_tcToolStripTextBox";
            this.search_tcToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_by_tcToolStripButton
            // 
            this.search_by_tcToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_by_tcToolStripButton.Name = "search_by_tcToolStripButton";
            this.search_by_tcToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.search_by_tcToolStripButton.Text = "Ara";
            this.search_by_tcToolStripButton.Click += new System.EventHandler(this.search_by_tcToolStripButton_Click);
            // 
            // search_by_full_nameToolStrip
            // 
            this.search_by_full_nameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.search_by_full_nameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_full_nameToolStripLabel,
            this.search_full_nameToolStripTextBox,
            this.search_by_full_nameToolStripButton});
            this.search_by_full_nameToolStrip.Location = new System.Drawing.Point(3, 16);
            this.search_by_full_nameToolStrip.Name = "search_by_full_nameToolStrip";
            this.search_by_full_nameToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.search_by_full_nameToolStrip.Size = new System.Drawing.Size(361, 25);
            this.search_by_full_nameToolStrip.TabIndex = 3;
            this.search_by_full_nameToolStrip.Text = "search_by_full_nameToolStrip";
            // 
            // search_full_nameToolStripLabel
            // 
            this.search_full_nameToolStripLabel.Name = "search_full_nameToolStripLabel";
            this.search_full_nameToolStripLabel.Size = new System.Drawing.Size(122, 22);
            this.search_full_nameToolStripLabel.Text = "İsim ve Soyisimde Ara";
            // 
            // search_full_nameToolStripTextBox
            // 
            this.search_full_nameToolStripTextBox.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.search_full_nameToolStripTextBox.Name = "search_full_nameToolStripTextBox";
            this.search_full_nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_by_full_nameToolStripButton
            // 
            this.search_by_full_nameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_by_full_nameToolStripButton.Name = "search_by_full_nameToolStripButton";
            this.search_by_full_nameToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.search_by_full_nameToolStripButton.Text = "Ara";
            this.search_by_full_nameToolStripButton.Click += new System.EventHandler(this.search_by_full_nameToolStripButton_Click);
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
            this.phone,
            this.mail,
            this.department,
            this.password});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(769, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Doktor İsim";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Doktor Soyisim";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 110;
            // 
            // tc
            // 
            this.tc.DataPropertyName = "tc";
            this.tc.HeaderText = "Doktor Kimlik No";
            this.tc.Name = "tc";
            this.tc.ReadOnly = true;
            this.tc.Width = 115;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Doktor Telefon";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 110;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "Doktor Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Doktor Bölüm";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Doktor Şifre";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 90;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "doctor";
            this.doctorBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "hastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // Admin_AllDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(808, 424);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_AllDoctors";
            this.Text = "Doktorlar Sistemi";
            this.Load += new System.EventHandler(this.Admin_AllDoctors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.search_by_mailToolStrip.ResumeLayout(false);
            this.search_by_mailToolStrip.PerformLayout();
            this.search_by_phoneToolStrip.ResumeLayout(false);
            this.search_by_phoneToolStrip.PerformLayout();
            this.search_by_tcToolStrip.ResumeLayout(false);
            this.search_by_tcToolStrip.PerformLayout();
            this.search_by_full_nameToolStrip.ResumeLayout(false);
            this.search_by_full_nameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button update_doctor_button;
        private System.Windows.Forms.Button remove_doctor_button;
        private System.Windows.Forms.Button add_doctor_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip search_by_mailToolStrip;
        private System.Windows.Forms.ToolStripLabel search_mailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox search_mailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search_by_mailToolStripButton;
        private System.Windows.Forms.ToolStrip search_by_phoneToolStrip;
        private System.Windows.Forms.ToolStripLabel search_phoneToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox search_phoneToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search_by_phoneToolStripButton;
        private System.Windows.Forms.ToolStrip search_by_tcToolStrip;
        private System.Windows.Forms.ToolStripLabel search_tcToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox search_tcToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search_by_tcToolStripButton;
        private System.Windows.Forms.ToolStrip search_by_full_nameToolStrip;
        private System.Windows.Forms.ToolStripLabel search_full_nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox search_full_nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search_by_full_nameToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private hastaneDataSetTableAdapters.doctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}