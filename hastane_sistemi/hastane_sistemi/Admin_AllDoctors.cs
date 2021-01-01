using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastane_sistemi
{
    public partial class Admin_AllDoctors : Form
    {
        public Admin_AllDoctors()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_AllDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.FillBy(this.hastaneDataSet.doctor);

        }


        private void search_by_full_nameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctorTableAdapter.search_by_full_name(this.hastaneDataSet.doctor, search_full_nameToolStripTextBox.Text);
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
                this.doctorTableAdapter.search_by_tc(this.hastaneDataSet.doctor, search_tcToolStripTextBox.Text);
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
                this.doctorTableAdapter.search_by_mail(this.hastaneDataSet.doctor, search_mailToolStripTextBox.Text);
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
                this.doctorTableAdapter.search_by_phone(this.hastaneDataSet.doctor, search_phoneToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void add_doctor_button_Click(object sender, EventArgs e)
        {
            DoctorSignForm add_doctor_form = new DoctorSignForm();
            add_doctor_form.ShowDialog();
            this.doctorTableAdapter.FillBy(this.hastaneDataSet.doctor);
        }

        private void remove_doctor_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                String tc = row.Cells["tc"].Value.ToString();
                String connection_str = Utility.ConnectionStr;
                using (SqlConnection connection = new SqlConnection(connection_str))
                {
                    String query = String.Format("delete from hastane.dbo.doctor Where tc = '{0}'", tc); ;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Doktor Silinemedi!");

                        else
                        {
                            MessageBox.Show("Doktor Silindi");
                        }
                    }
                }
                this.doctorTableAdapter.FillBy(this.hastaneDataSet.doctor);
            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
        }

        private void update_doctor_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                Dictionary<String, String> doctor_info = new Dictionary<string, string>();
                doctor_info.Add("tc", row.Cells["tc"].Value.ToString());
                doctor_info.Add("name", row.Cells["name"].Value.ToString());
                doctor_info.Add("mail", row.Cells["mail"].Value.ToString());
                doctor_info.Add("department", row.Cells["department"].Value.ToString());
                doctor_info.Add("surname", row.Cells["surname"].Value.ToString());
                doctor_info.Add("password", row.Cells["password"].Value.ToString());
                doctor_info.Add("phone", row.Cells["phone"].Value.ToString());
                Doctor_UpdateInformation update_patient_info = new Doctor_UpdateInformation(doctor_info);
                update_patient_info.ShowDialog();
                this.doctorTableAdapter.FillBy(this.hastaneDataSet.doctor);
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.search_full_nameToolStripTextBox.Text = "";
            this.search_tcToolStripTextBox.Text = "";
            this.search_mailToolStripTextBox.Text = "";
            this.search_phoneToolStripTextBox.Text = "";
            this.doctorTableAdapter.FillBy(this.hastaneDataSet.doctor);
        }
    }
    
}
