using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class Admin_AllPatients : Form
    {
        public Admin_AllPatients()
        {
            InitializeComponent();
        }

        private void Admin_AllPatients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.FillBy(this.hastaneDataSet.patient);

        }


        private void search_in_full_nameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.search_in_full_name(this.hastaneDataSet.patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_by_full_nameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.search_by_full_name(this.hastaneDataSet.patient, search_full_nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_by_tcToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.search_by_tc(this.hastaneDataSet.patient, search_tcToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_by_mailToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.search_by_mail(this.hastaneDataSet.patient, search_mailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_by_phoneToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.search_by_phone(this.hastaneDataSet.patient, search_phoneToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void add_patient_button_Click(object sender, EventArgs e)
        {
            PatientSignForm add_patient_form = new PatientSignForm();
            add_patient_form.ShowDialog();
            this.patientTableAdapter.FillBy(this.hastaneDataSet.patient);
        }

        private void remove_patient_button_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                String tc = row.Cells["tc"].Value.ToString();
                String connection_str = Utility.ConnectionStr;
                using (SqlConnection connection = new SqlConnection(connection_str))
                {
                    String query = String.Format("delete from hastane.dbo.patient Where tc = '{0}'", tc); ;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Hasta Silinemedi!");

                        else
                        {
                            MessageBox.Show("Hasta Silindi");
                        }
                    }
                }

                this.patientTableAdapter.FillBy(this.hastaneDataSet.patient);
            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
        }

        private void update_patient_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                Dictionary<String, String> patient_info = new Dictionary<string, string>();
                patient_info.Add("name", row.Cells["name"].Value.ToString());
                patient_info.Add("surname", row.Cells["surname"].Value.ToString());
                patient_info.Add("tc", row.Cells["tc"].Value.ToString());
                patient_info.Add("phone", row.Cells["phone"].Value.ToString());
                patient_info.Add("mail", row.Cells["mail"].Value.ToString());
                patient_info.Add("password", row.Cells["password"].Value.ToString());
                Patient_EditInformation update_patient_info = new Patient_EditInformation(patient_info);
                update_patient_info.ShowDialog();
                this.patientTableAdapter.FillBy(this.hastaneDataSet.patient);
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.search_full_nameToolStripTextBox.Text = "";
            this.search_tcToolStripTextBox.Text = "";
            this.search_mailToolStripTextBox.Text = "";
            this.search_phoneToolStripTextBox.Text = "";
            this.patientTableAdapter.FillBy(this.hastaneDataSet.patient);
        }
    }
}
