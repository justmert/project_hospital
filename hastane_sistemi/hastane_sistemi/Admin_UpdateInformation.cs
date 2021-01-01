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
using System.Collections.Generic;

namespace hastane_sistemi
{
    public partial class Admin_UpdateInformation : Form
    {
        private String admin_username;
        Dictionary<String, String> admin_information;

        public Admin_UpdateInformation(Dictionary<String, String> admin_information)
        {
            InitializeComponent();
            this.admin_username = admin_information["username"];
            this.admin_information = admin_information;
            this.admin_name_textbox.Text = admin_information["name"];
            this.admin_surname_textbox.Text = admin_information["surname"];
            this.admin_password_textbox.Text = admin_information["password"];
        }

        private void saveFields()
        {
            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("UPDATE hastane.dbo.admin SET name = @name, surname = @surname, password = @password Where username = '{0}", this.admin_username);
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", this.admin_name_textbox.Text);
                    command.Parameters.AddWithValue("@surname", this.admin_surname_textbox.Text);
                    command.Parameters.AddWithValue("@password", this.admin_password_textbox.Text);

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

        private void update_admin_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.admin_name_textbox.Text))
            {
                MessageBox.Show("Lütfen ismi giriniz");
                return;
            }

            if (String.IsNullOrEmpty(this.admin_surname_textbox.Text))
            {
                MessageBox.Show("Lütfen soyismi giriniz");
                return;
            }


            if (String.IsNullOrEmpty(this.admin_password_textbox.Text) || this.admin_password_textbox.Text.Length != 8)
            {
                MessageBox.Show("Şifre 8 haneden, ve tamamı rakamlardan oluşmalı!");
                return;
            }
            else
            {
                var isNumeric = Int64.TryParse(this.admin_password_textbox.Text, out _);
                if (!isNumeric)
                {
                    MessageBox.Show("Şifre 8 haneden, ve tamamı rakamlardan oluşmalı!");
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
