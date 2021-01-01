using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastane_sistemi
{
    public partial class Patient_CurrentAppointments : Form
    {
        private String patient_tc;
        public Patient_CurrentAppointments(String tc)
        {
            InitializeComponent();
            this.patient_tc = tc;

        }

        private void Patient_CurrentAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.current_appoinments_fill(this.hastaneDataSet.appointment, this.patient_tc);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                String doctor_name = row.Cells["doctor_name"].Value.ToString();
                String doctor_surname = row.Cells["doctor_surname"].Value.ToString();
                String description = row.Cells["description"].Value.ToString();

                String connection_str = Utility.ConnectionStr;
                using (SqlConnection connection = new SqlConnection(connection_str))
                {
                    String query = String.Format("delete from hastane.dbo.appointment Where doctor_name = '{0}' and doctor_surname = '{1}' and description = '{2}'",
                        doctor_name, doctor_surname, description); ;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Randevu Silinemedi!");

                        else
                        {
                            MessageBox.Show("Randevu Silindi");
                        }
                    }
                }

                this.appointmentTableAdapter.current_appoinments_fill(this.hastaneDataSet.appointment, this.patient_tc);
            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
            this.appointmentTableAdapter.current_appoinments_fill(this.hastaneDataSet.appointment, this.patient_tc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
