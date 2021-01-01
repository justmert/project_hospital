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
    public partial class Admin_MakeAppointment : Form
    {
        public Admin_MakeAppointment()
        {
            InitializeComponent();
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.patient_tc_texbox.Text) || this.patient_tc_texbox.Text.Length != 11)
            {
                MessageBox.Show("Lütfen hasta kimlik numaranızı doğru girdiğinizden emin olunuz");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.patient_tc_texbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Lütfen hasta kimlik numarasını doğru girdiğinizden emin olunuz");
                    return;
                }
            }
            String name = null;
            String surname = null;
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT * from hastane.dbo.patient where tc = '{0}'", patient_tc_texbox.Text)
;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        name = reader["name"].ToString();
                        surname = reader["surname"].ToString();
                    }

                }
            }
            if (name == null)
            {
                MessageBox.Show("Hasta kimlik numarasını kontrol ediniz");
                return;
            }

            Patient_MakeAppointment make_new_appointment = new Patient_MakeAppointment(name, surname, patient_tc_texbox.Text);
            make_new_appointment.ShowDialog();
            this.Hide();
        }
    }
}
