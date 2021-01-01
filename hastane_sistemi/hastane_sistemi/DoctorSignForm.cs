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
    public partial class DoctorSignForm : Form
    {
        public DoctorSignForm()
        {
            InitializeComponent();
            fetchDepartment();
        }

        private void fetchDepartment()
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
                        doctor_sign_department_combobox.Items.Add(reader["department_id"].ToString());
                    }

                }
            }
        }

        private void saveFields()
        {
            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = "INSERT INTO hastane.dbo.doctor (name,surname,tc,phone,mail,department, password) VALUES (@name,@surname,@tc,@phone, @mail, @department, @password)"; ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", this.doctor_sign_name_textbox.Text);
                    command.Parameters.AddWithValue("@surname", this.doctor_sign_surname_textbox.Text);
                    command.Parameters.AddWithValue("@tc", this.doctor_sign_tc_textbox.Text);
                    command.Parameters.AddWithValue("@phone", this.doctor_sign_phone_textbox.Text);
                    command.Parameters.AddWithValue("@mail", this.doctor_sign_mail_textbox.Text);
                    command.Parameters.AddWithValue("@department", this.doctor_sign_department_combobox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@password", this.doctor_sign_password_textbox.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Kaydedilemedi!");

                    else
                    {
                        MessageBox.Show("Başarılı şekilde başvurdunuz");
                        this.Close();
                    }
                }
            }

        }

        private void doctor_sign_up_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.doctor_sign_name_textbox.Text))
            {
                MessageBox.Show("Lütfen isminizi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.doctor_sign_surname_textbox.Text))
            {
                MessageBox.Show("Lütfen soyisminizi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.doctor_sign_tc_textbox.Text) || this.doctor_sign_tc_textbox.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı doğru girdiğinizden emin olunuz");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.doctor_sign_tc_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Lütfen TC kimlik numaranızı doğru girdiğinizden emin olunuz");
                    return;
                }
            }

            if (String.IsNullOrEmpty(this.doctor_sign_mail_textbox.Text))
            {
                MessageBox.Show("Lütfen doğru mail adresi girdiğinizden emin olunuz");
                return;
            }
            else
            {
                String mail = this.doctor_sign_mail_textbox.Text;
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
            if (String.IsNullOrEmpty(this.doctor_sign_phone_textbox.Text) || this.doctor_sign_phone_textbox.Text.Length != 10)
            {
                MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.doctor_sign_phone_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                    return;
                }
            }

            var selected = doctor_sign_department_combobox.SelectedIndex;
            if (selected == -1)
            {
                MessageBox.Show("Lütfen başvurmak istediğiniz sağlık alanını seçiniz");
                return;
            }

            if (String.IsNullOrEmpty(this.doctor_sign_password_textbox.Text) || this.doctor_sign_password_textbox.Text.Length != 8)
            {
                MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.doctor_sign_password_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                    return;
                }
            }

            saveFields();
        }

        private void doctor_sign_clear_button_Click(object sender, EventArgs e)
        {
            this.doctor_sign_name_textbox.Text = "";
            this.doctor_sign_surname_textbox.Text = "";
            this.doctor_sign_tc_textbox.Text = "";
            this.doctor_sign_phone_textbox.Text = "";
            this.doctor_sign_password_textbox.Text = "";
            this.doctor_sign_mail_textbox.Text = "";
            this.doctor_sign_department_combobox.Text = "";
        }

    }
}
