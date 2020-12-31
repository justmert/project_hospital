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
    public partial class AdminPanel : Form
    {

        private Dictionary<String, String> admin_information;

        public AdminPanel(String name, String surname, String username, String password)
        {
            InitializeComponent();

            this.admin_information = new Dictionary<string, string>
            {
                ["name"] = name,
                ["surname"] = surname,
                ["username"] = username,
                ["password"] = password
            };
            get_admin_information();
            update_panel_informations();

        }

        private void get_admin_information()
        {

            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT * from hastane.dbo.admin where username = '{0}'", this.admin_information["username"])
;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    this.admin_information.Clear();
                    while (reader.Read())
                    {

                        this.admin_information.Add("name", reader["name"].ToString());
                        this.admin_information.Add("surname", reader["surname"].ToString());
                        this.admin_information.Add("username", reader["username"].ToString());
                        this.admin_information.Add("password", reader["password"].ToString());
                        break;
                    }

                }
            }

            update_admin_information();
        }

        private void update_panel_informations()
        {
            int all_patients_count = 0;
            int all_doctors_count = 0;
            int all_active_appointments_count = 0;
            int all_passive_appointments_count = 0;

            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                connection.Open();

                String query = String.Format("SELECT COUNT(*) from hastane.dbo.appointment where status = 1");
                SqlCommand command1 = new SqlCommand(query, connection);
                all_active_appointments_count = (int)command1.ExecuteScalar();

                String query2 = String.Format("SELECT COUNT(*) from hastane.dbo.appointment where  status = 0");
                SqlCommand command2 = new SqlCommand(query2, connection);
                all_passive_appointments_count = (int)command2.ExecuteScalar();
                
                String query3 = String.Format("SELECT COUNT(*) from hastane.dbo.doctor");
                SqlCommand command3 = new SqlCommand(query3, connection);
                all_doctors_count = (int)command3.ExecuteScalar();
                
                String query4 = String.Format("SELECT COUNT(*) from hastane.dbo.patient");
                SqlCommand command4 = new SqlCommand(query4, connection);
                all_patients_count = (int)command4.ExecuteScalar();

            }

            this.info_patient_count_label.Text = String.Format("Sisteme kayıtlı olan {0} hasta var", all_patients_count.ToString());
            this.info_doctor_count_label.Text = String.Format("Sisteme kayıtlı olan {0} doktor var", all_doctors_count.ToString());
            this.info_active_appointment_count_label.Text = String.Format("Devam eden randevu sayısı: {0}", all_active_appointments_count.ToString());
            this.info_passive_appointment_count_label.Text = String.Format("Geçmiş randevu sayısı: {0}", all_passive_appointments_count.ToString());

        }

        private void update_admin_information()
        {
            this.info_username_label.Text = "Kullanıcı İsmi: " + this.admin_information["username"];
            this.greeting_label.Text = String.Format("Sayın Admin {0} {1}", Utility.first_upper(this.admin_information["name"]),
                Utility.first_upper(this.admin_information["surname"]));
        }

        private void create_new_admin_panel_Click(object sender, EventArgs e)
        {
            Admin_CreateNewAdmin new_admin_form = new Admin_CreateNewAdmin();
            new_admin_form.ShowDialog();
        }

        private void update_admin_information_panel_Click(object sender, EventArgs e)
        {
            Admin_UpdateInformation update_admin_information_form = new Admin_UpdateInformation(this.admin_information["username"]);
            update_admin_information_form.ShowDialog();

        }

        private void all_appointments_panel_Click(object sender, EventArgs e)
        {
            Admin_AllAppointments show_all_appointments_form = new Admin_AllAppointments();
            show_all_appointments_form.ShowDialog();

        }

        private void all_doctors_panel_Click(object sender, EventArgs e)
        {
            Admin_AllDoctors show_all_doctors_form = new Admin_AllDoctors();
            show_all_doctors_form.ShowDialog();

        }

        private void all_patients_panel_Click(object sender, EventArgs e)
        {
            Admin_AllPatients show_all_patients_form = new Admin_AllPatients();
            show_all_patients_form.ShowDialog();
        }
    }
}
