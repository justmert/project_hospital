using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastane_sistemi
{
    public partial class PatientSignForm : Form
    {
        public PatientSignForm()
        {
            InitializeComponent();
        }

        private void saveFields()
        {
            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = "INSERT INTO hastane.dbo.patient (name,surname,tc,phone,mail,password) VALUES (@name,@surname,@tc,@phone, @mail, @password)"; ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", this.patient_sign_name_textbox.Text);
                    command.Parameters.AddWithValue("@surname", this.patient_sign_surname_textbox.Text);
                    command.Parameters.AddWithValue("@tc", this.patient_sign_tc_textbox.Text);
                    command.Parameters.AddWithValue("@phone", this.patient_sign_phone_textbox.Text);
                    command.Parameters.AddWithValue("@mail", this.patient_sign_mail_textbox.Text);
                    command.Parameters.AddWithValue("@password", this.patient_sign_password_textbox.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Kaydedilemedi!");

                    else
                    {
                        MessageBox.Show("Başarılı şekilde kayıt oldunuz");
                        this.Close();
                    }
                }
            }

        }

        private void patient_sign_up_button_Click(object sender, EventArgs e)
        {
            // checking all inputs

            if (String.IsNullOrEmpty(this.patient_sign_name_textbox.Text))
            {
                MessageBox.Show("Lütfen isminizi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.patient_sign_surname_textbox.Text))
            {
                MessageBox.Show("Lütfen soyisminizi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.patient_sign_tc_textbox.Text) || this.patient_sign_tc_textbox.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı doğru girdiğinizden emin olunuz");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.patient_sign_tc_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Lütfen TC kimlik numaranızı doğru girdiğinizden emin olunuz");
                    return;
                }
            }

            if (String.IsNullOrEmpty(this.patient_sign_mail_textbox.Text))
            {
                MessageBox.Show("Lütfen doğru mail adresi girdiğinizden emin olunuz");
                return;
            }
            else
            {
                String mail = this.patient_sign_mail_textbox.Text;
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
            if (String.IsNullOrEmpty(this.patient_sign_phone_textbox.Text) || this.patient_sign_phone_textbox.Text.Length != 10)
            {
                MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.patient_sign_phone_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Lütfen telefon numaranızı doğru girdiğinizden emin olunuz\nAyrıca numaranızı başında 0 olmadan giriniz");
                    return;
                }
            }

            if(String.IsNullOrEmpty(this.patient_sign_password_textbox.Text) || this.patient_sign_password_textbox.Text.Length != 8)
            {
                MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.patient_sign_password_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Şifreniz 8 haneden, ve tamamı rakamlardan oluşmalı!");
                    return;
                }
            }

            saveFields();

        }

        private void patient_sign_clear_button_Click(object sender, EventArgs e)
        {
            this.patient_sign_name_textbox.Text = "";
            this.patient_sign_surname_textbox.Text = "";
            this.patient_sign_tc_textbox.Text = "";
            this.patient_sign_password_textbox.Text = "";
            this.patient_sign_phone_textbox.Text = "";
            this.patient_sign_mail_textbox.Text = "";
        }


    }
}
