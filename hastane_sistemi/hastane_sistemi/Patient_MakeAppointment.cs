using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class Patient_MakeAppointment : Form
    {
        private List<Tuple<String, String, String>> doctors;
        private String patientName;
        private String patientSurname;
        private String patientTc;

        public Patient_MakeAppointment(String name, String surname, String tc)
        {
            InitializeComponent();
            this.patientName = name;
            this.patientSurname = surname;
            this.patientTc = tc;
            doctors = new List<Tuple<string, string, string>>();
            fetchDepartments();
        }

        public void fetchDepartments()
        {
            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = "SELECT * from hastane.dbo.department";
                ;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        deparment_combobox.Items.Add(reader["department_id"].ToString());
                    }

                }
            }
        }

        public void fetchDoctorsByDepartment(object sender, EventArgs e)
        {
            department_doctors_combobox.Items.Clear();
            department_doctors_combobox.Text = "";
            String department = deparment_combobox.SelectedItem.ToString();
            if (String.IsNullOrEmpty(department))
            {
                return;
            }
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT name,surname,tc from hastane.dbo.doctor where department = '{0}'", department);
                ;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String name = reader["name"].ToString();
                        String surname = reader["surname"].ToString();
                        String tc = reader["tc"].ToString();
                        Tuple<String, String, String> name_surname = new Tuple<string, string, string>(name, surname, tc);
                        doctors.Add(name_surname);
                    }
                }
            }
            foreach (var item in doctors)
            {
                department_doctors_combobox.Items.Add(item.Item1 + " " + item.Item2);
            }
        }

        private void take_appointment_button_Click(object sender, EventArgs e)
        {

            int doctor_index = department_doctors_combobox.SelectedIndex;
            if (doctor_index == -1)
            {
                MessageBox.Show("Bu bölümde doktorumuz bulunmamaktadır");
                return;
            }
            var doctor = doctors[doctor_index];

            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = "INSERT INTO hastane.dbo.appointment (name,surname,tc,doctor_name,doctor_surname, doctor_tc, description, section, status)";
                query += " VALUES (@name,@surname,@tc, @doctor_name, @doctor_surname, @doctor_tc, @description, @section, @status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", patientName);
                    command.Parameters.AddWithValue("@surname", patientSurname);
                    command.Parameters.AddWithValue("@tc", patientTc);
                    command.Parameters.AddWithValue("@doctor_name", doctor.Item1);
                    command.Parameters.AddWithValue("@doctor_surname", doctor.Item2);
                    command.Parameters.AddWithValue("@doctor_tc", doctor.Item3);
                    command.Parameters.AddWithValue("@description", this.description_textbox.Text);
                    command.Parameters.AddWithValue("@section", this.deparment_combobox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@status", 1);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Randevunuz Kaydedilemedi!");

                    else
                    {
                        MessageBox.Show("Randevunuz Kaydedildi");
                        this.Close();
                    }
                }
            }
        }

    }
}
