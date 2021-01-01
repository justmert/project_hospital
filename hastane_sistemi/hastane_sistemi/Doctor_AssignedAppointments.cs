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
    public partial class Doctor_AssignedAppointments : Form
    {
        private String doctor_tc;
        public Doctor_AssignedAppointments(String doctor_tc)
        {
            InitializeComponent();
            this.doctor_tc = doctor_tc;
        }

        private void Doctor_AssignedAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.active_appointments(this.hastaneDataSet.appointment, this.doctor_tc);

        }

        private void appointment_done_button_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                String tc = row.Cells["tc"].Value.ToString();
                String description = row.Cells["description"].Value.ToString();

                String connection_str = Utility.ConnectionStr;
                using (SqlConnection connection = new SqlConnection(connection_str))
                {
                    String query = String.Format("update hastane.dbo.appointment SET status = 0 Where tc = '{0}'  and description = '{1}'",
                        tc, description); ;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Randevu Gerçekleştirilemedi!");

                        else
                        {
                            MessageBox.Show("Randevu Gerçekleştirildi");
                        }
                    }
                }

                this.appointmentTableAdapter.active_appointments(this.hastaneDataSet.appointment, this.doctor_tc);
            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
            this.appointmentTableAdapter.active_appointments(this.hastaneDataSet.appointment, this.doctor_tc);

        }

        private void cancel_appointment_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                String tc = row.Cells["tc"].Value.ToString();
                String doctor_tc = row.Cells["doctor_tc"].Value.ToString();
                String description = row.Cells["description"].Value.ToString();

                String connection_str = Utility.ConnectionStr;
                using (SqlConnection connection = new SqlConnection(connection_str))
                {
                    String query = String.Format("delete from hastane.dbo.appointment Where tc = '{0}' and doctor_tc = '{1}' and description = '{2}'",
                        tc, doctor_tc, description); ;
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

                this.appointmentTableAdapter.active_appointments(this.hastaneDataSet.appointment, this.doctor_tc);
            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
            this.appointmentTableAdapter.active_appointments(this.hastaneDataSet.appointment, this.doctor_tc);

        }
    }
}
