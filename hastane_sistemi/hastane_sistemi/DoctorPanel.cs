using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class DoctorPanel : Form
    {
        private String doctor_name;
        private String doctor_surname;
        private String doctor_tc;
        private Dictionary<String, String> doctor_information;
        public DoctorPanel(String name, String surname, String tc)
        {
            InitializeComponent();
            this.doctor_name = name;
            this.doctor_surname = surname;
            this.doctor_tc = tc;
            this.doctor_information = new Dictionary<string, string>();

            get_doctor_information();
            update_panel_informations();
        }

        private void update_doctor_information()
        {
            this.info_tc_label.Text = "Kimlik Numarası: " + this.doctor_information["tc"];
            this.greeting_label.Text = String.Format("Sayın Dr. {0} {1}", Utility.first_upper(this.doctor_information["name"]),
                Utility.first_upper(this.doctor_information["surname"]));

            this.info_mail_label.Text = "Mail: " + this.doctor_information["mail"];
            this.info_phone_label.Text = "Telefon Numarası: " + this.doctor_information["phone"];

            this.doctor_name = this.doctor_information["name"];
            this.doctor_surname = this.doctor_information["surname"];
            this.doctor_tc = this.doctor_information["tc"];
        }

        private void update_panel_informations()
        {
            int active_appointment_num = 0;
            int passive_appointment_num = 0;
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT COUNT(*) from hastane.dbo.appointment where doctor_tc = '{0}' and status = 1", this.doctor_information["tc"]);
                ;
                connection.Open();
                SqlCommand command1 = new SqlCommand(query, connection);
                active_appointment_num = (int)command1.ExecuteScalar();

                String query2 = String.Format("SELECT COUNT(*) from hastane.dbo.appointment where doctor_tc = '{0}' and status = 0", this.doctor_information["tc"]);
                SqlCommand command2 = new SqlCommand(query2, connection);
                passive_appointment_num = (int)command2.ExecuteScalar();

            }

            this.info_current_appointments_label.Text = String.Format("Bakmanız gereken {0} \nrandevu var", active_appointment_num.ToString());
            this.info_past_appointments_label.Text = String.Format("Şuana kadar {0} \nrandevuya baktınız", passive_appointment_num.ToString());

        }


        private void get_doctor_information()
        {
            this.doctor_information.Clear();
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT * from hastane.dbo.doctor where tc = '{0}'", this.doctor_tc)
;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        this.doctor_information.Add("name", reader["name"].ToString());
                        this.doctor_information.Add("surname", reader["surname"].ToString());
                        this.doctor_information.Add("tc", reader["tc"].ToString());
                        this.doctor_information.Add("phone", reader["phone"].ToString());
                        this.doctor_information.Add("mail", reader["mail"].ToString());
                        this.doctor_information.Add("password", reader["password"].ToString());
                        this.doctor_information.Add("department", reader["department"].ToString());
                        break;
                    }

                }
            }
            update_doctor_information();
        }

        private void update_doktor_information_choice_Click(object sender, EventArgs e)
        {
            get_doctor_information();
            Doctor_UpdateInformation edit_information_form = new Doctor_UpdateInformation(this.doctor_information);
            edit_information_form.ShowDialog();
            update_doctor_information();
        }

        private void appointments_done_choice_Click(object sender, EventArgs e)
        {
            Doctor_DoneAppointments show_past_appointments_form = new Doctor_DoneAppointments(this.doctor_tc);
            show_past_appointments_form.ShowDialog();

        }

        private void appointments_assigned_choice_Click(object sender, EventArgs e)
        {
            Doctor_AssignedAppointments show_active_appointments_form = new Doctor_AssignedAppointments(this.doctor_tc);
            show_active_appointments_form.ShowDialog();
            update_panel_informations();

        }
    }
}
