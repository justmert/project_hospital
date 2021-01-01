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
    public partial class Admin_AllAppointments : Form
    {
        public Admin_AllAppointments()
        {
            InitializeComponent();
        }

        private void Admin_AllAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.hastaneDataSet.appointment);

        }

        private void add_doctor_button_Click(object sender, EventArgs e)
        {
            Admin_MakeAppointment make_new_appointment = new Admin_MakeAppointment();
            make_new_appointment.ShowDialog();
            this.appointmentTableAdapter.Fill(this.hastaneDataSet.appointment);

        }

        private void remove_appointment_button_Click(object sender, EventArgs e)
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

                this.appointmentTableAdapter.Fill(this.hastaneDataSet.appointment);
            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz");
            }
            this.appointmentTableAdapter.Fill(this.hastaneDataSet.appointment);

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();        
        }
    }
}
