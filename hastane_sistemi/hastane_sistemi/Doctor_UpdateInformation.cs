using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class Doctor_UpdateInformation : Form
    {
        private Dictionary<String, String> doctor_information;
        public Doctor_UpdateInformation(Dictionary<String, String> doctor)
        {
            InitializeComponent();
            doctor_information = doctor;
            this.doctor_update_name_textbox.Text = doctor["name"];
            this.doctor_update_surname_textbox.Text = doctor["surname"];
            this.doctor_update_phone_textbox.Text = doctor["phone"];
            this.doctor_update_mail_textbox.Text = doctor["mail"];
            this.doctor_update_password_textbox.Text = doctor["password"];
            this.fill_department_combobox();
        }


        private void fill_department_combobox()
        {
            String connection_str = Utility.ConnectionStr;
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
                        String department_name = reader["department_id"].ToString();
                        this.doctor_update_department_combobox.Items.Add(department_name);

                    }

                }
            }

            for (int i = 0; i < this.doctor_update_department_combobox.Items.Count; i++)
            {
                if (this.doctor_update_department_combobox.Items[i].ToString() == this.doctor_information["department"])
                {
                    this.doctor_update_department_combobox.SelectedIndex = this.doctor_update_department_combobox.FindStringExact(this.doctor_information["department"]);

                }
            }


        }
        private void saveFields()
        {
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("UPDATE hastane.dbo.doctor SET name = @name, surname = @surname,phone = @phone, mail = @mail, department = @department, password = @password Where tc = '{0}' and surname = '{1}'"
                    , doctor_information["tc"], doctor_information["surname"]);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", this.doctor_update_name_textbox.Text);
                    command.Parameters.AddWithValue("@surname", this.doctor_update_surname_textbox.Text);
                    command.Parameters.AddWithValue("@phone", this.doctor_update_phone_textbox.Text);
                    command.Parameters.AddWithValue("@mail", this.doctor_update_mail_textbox.Text);
                    command.Parameters.AddWithValue("@department", this.doctor_update_department_combobox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@password", this.doctor_update_password_textbox.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Güncellenemedi!");

                    else
                    {
                        MessageBox.Show("Bilgileriniz Güncellendi");
                        this.Close();
                    }
                }
            }

        }

        private void doctor_update_up_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.doctor_update_name_textbox.Text))
            {
                MessageBox.Show("Lütfen isminizi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.doctor_update_surname_textbox.Text))
            {
                MessageBox.Show("Lütfen soyisminizi giriniz");
                return;
            }


            if (String.IsNullOrEmpty(this.doctor_update_mail_textbox.Text))
            {
                MessageBox.Show("Lütfen doğru mail adresi girdiğinizden emin olunuz");
                return;
            }
            else
            {
                String mail = this.doctor_update_mail_textbox.Text;
                try
                {
                    var addr = new System.Net.Mail.MailAddress(mail);
                    bool valid = (addr.Address == mail);
                    if (!valid)
                    {
                        MessageBox.Show("Lütfen doğru mail adresi girdiğinizden emin olunuz");
                        return;
                    }

                }
                catch
                {
                    MessageBox.Show("Lütfen doğru mail adresi girdiğinizden emin olunuz");
                    return;
                }
            }
            if (String.IsNullOrEmpty(this.doctor_update_phone_textbox.Text) || this.doctor_update_phone_textbox.Text.Length != 10)
            {
                MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.doctor_update_phone_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                    return;
                }
            }

            var selected = doctor_update_department_combobox.SelectedIndex;
            if (selected == -1)
            {
                MessageBox.Show("Lütfen başvurmak istediğiniz sağlık alanını seçiniz");
                return;
            }

            if (String.IsNullOrEmpty(this.doctor_update_password_textbox.Text) || this.doctor_update_password_textbox.Text.Length != 8)
            {
                MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.doctor_update_password_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                    return;
                }
            }

            saveFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
