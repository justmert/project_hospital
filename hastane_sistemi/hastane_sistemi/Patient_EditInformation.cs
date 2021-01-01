using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace hastane_sistemi
{
    public partial class Patient_EditInformation : Form
    {
        private Dictionary<String, String> patient_information;
        public Patient_EditInformation(Dictionary<String, String> patient_information)
        {
            InitializeComponent();
            this.patient_information = patient_information;
            this.patient_edit_name_textbox.Text = patient_information["name"];
            this.patient_edit_surname_textbox.Text = patient_information["surname"];
            this.patient_edit_mail_textbox.Text = patient_information["mail"];
            this.patient_edit_phone_textbox.Text = patient_information["phone"];
            this.patient_edit_password_textbox.Text = patient_information["password"];
        }

        private void patient_sign_up_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.patient_edit_name_textbox.Text))
            {
                MessageBox.Show("Lütfen isminizi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.patient_edit_surname_textbox.Text))
            {
                MessageBox.Show("Lütfen soyisminizi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.patient_edit_mail_textbox.Text))
            {
                MessageBox.Show("Lütfen doğru mail adresi girdiğinizden emin olunuz");
                return;
            }
            else
            {
                String mail = this.patient_edit_mail_textbox.Text;
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
            if (String.IsNullOrEmpty(this.patient_edit_phone_textbox.Text) || this.patient_edit_phone_textbox.Text.Length != 10)
            {
                MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.patient_edit_phone_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                    return;
                }
            }

            if (String.IsNullOrEmpty(this.patient_edit_password_textbox.Text) || this.patient_edit_password_textbox.Text.Length != 8)
            {
                MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.patient_edit_password_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                    return;
                }
            }

            saveFields();

        }

        private void saveFields()
        {
            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("UPDATE hastane.dbo.patient SET name = @name, surname = @surname, phone = @phone, mail = @mail, password = @password Where tc = '{0}'", patient_information["tc"]); ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", this.patient_edit_name_textbox.Text);
                    command.Parameters.AddWithValue("@surname", this.patient_edit_surname_textbox.Text);
                    command.Parameters.AddWithValue("@phone", this.patient_edit_phone_textbox.Text);
                    command.Parameters.AddWithValue("@mail", this.patient_edit_mail_textbox.Text);
                    command.Parameters.AddWithValue("@password", this.patient_edit_password_textbox.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Bilgileriniz Güncellenemedi!");

                    else
                    {
                        MessageBox.Show("Bilgileriniz Güncellendi");
                        this.Close();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
