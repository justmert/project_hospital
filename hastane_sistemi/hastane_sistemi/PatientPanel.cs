using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class PatientPanel : Form
    {
        private String name;
        private String surname;
        private String tc;

        private Dictionary<String, String> patient_information;
        public PatientPanel(String name, String surname, String Tc)
        {
            InitializeComponent();
            this.name = name;
            this.surname = surname;
            this.tc = Tc;
            this.patient_information = new Dictionary<string, string>();
            
            get_patient_information();
            update_panel_informations();
        }


        private void appointment_selection_panel_Click(object sender, EventArgs e)
        {
            Patient_MakeAppointment appointment_form = new Patient_MakeAppointment(this.name, this.surname, this.tc);
            appointment_form.ShowDialog();
            update_panel_informations();
        }

        private void edit_information_panel_Click(object sender, EventArgs e)
        {
            get_patient_information();
            Patient_EditInformation edit_form = new Patient_EditInformation(this.patient_information);
            edit_form.ShowDialog();
            get_patient_information();
        }

        private void update_patient_information()
        {
            this.info_tc_label.Text = "Kimlik Numarası: " + this.patient_information["tc"];
            this.greeting_label.Text = String.Format("Sayın {0} {1}", Utility.first_upper(this.patient_information["name"]), Utility.first_upper(this.patient_information["surname"]));
            this.info_mail_label.Text = "Mail: " + this.patient_information["mail"];
            this.info_phone_label.Text = "Telefon Numarası: " + this.patient_information["phone"];

            this.name = this.patient_information["name"];
            this.surname = this.patient_information["surname"];
            this.tc = this.patient_information["tc"];
        }

        private void update_panel_informations()
        {
            int active_appointment_num = 0;
            int passive_appointment_num = 0;
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT COUNT(*) from hastane.dbo.appointment where tc = '{0}' and status = 1", this.patient_information["tc"]);
;
                connection.Open();
                SqlCommand command1 = new SqlCommand(query, connection);
                active_appointment_num = (int)command1.ExecuteScalar();

                String query2 = String.Format("SELECT COUNT(*) from hastane.dbo.appointment where tc = '{0}' and status = 0", this.patient_information["tc"]);
                SqlCommand command2 = new SqlCommand(query2, connection);
                passive_appointment_num = (int)command2.ExecuteScalar();

            }

            this.info_current_appointments_label.Text = String.Format("Aktif olan {0} randevunuz var", active_appointment_num.ToString());
            this.info_past_appointments_label.Text = String.Format("Geçmiş olan {0} randevunuz var", passive_appointment_num.ToString());

        }

        private void get_patient_information()
        {
            this.patient_information.Clear();
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT * from hastane.dbo.patient where tc = '{0}'", tc)
;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        this.patient_information.Add("name", reader["name"].ToString());
                        this.patient_information.Add("surname", reader["surname"].ToString());
                        this.patient_information.Add("tc", reader["tc"].ToString());
                        this.patient_information.Add("phone", reader["phone"].ToString());
                        this.patient_information.Add("mail", reader["mail"].ToString());
                        this.patient_information.Add("password", reader["password"].ToString());
                        break;
                    }

                }
            }
            update_patient_information();
        }

        private void manage_past_appoinments_Click(object sender, EventArgs e)
        {
            Patient_PastAppointments show_appoinments = new Patient_PastAppointments(this.tc);
            show_appoinments.ShowDialog();
            update_panel_informations();

        }

        private void manage_current_appointments_Click(object sender, EventArgs e)
        {
            Patient_CurrentAppointments show_appointments = new Patient_CurrentAppointments(this.tc);
            show_appointments.ShowDialog();
            update_panel_informations();
        }
    }
}
