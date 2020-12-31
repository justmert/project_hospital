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
    public partial class Admin_CreateNewAdmin : Form
    {
        public Admin_CreateNewAdmin()
        {
            InitializeComponent();
        }

        private void saveFields()
        {
            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = "INSERT INTO hastane.dbo.admin (name,surname,username,password) VALUES (@name,@surname,@username, @password)"; ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", this.admin_name_textbox.Text);
                    command.Parameters.AddWithValue("@surname", this.admin_surname_textbox.Text);
                    command.Parameters.AddWithValue("@username", this.admin_username_textbox.Text);
                    command.Parameters.AddWithValue("@password", this.admin_password_textbox.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Kaydedilemedi!");

                    else
                    {
                        MessageBox.Show("Yeni admin başarıyla kaydedildi");
                        this.Close();
                    }
                }
            }
        }

        private void create_admin_button_Click(object sender, EventArgs e)
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
            
            if (String.IsNullOrEmpty(this.admin_username_textbox.Text))
            {
                MessageBox.Show("Lütfen kullanıcı ismini giriniz");
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

        private void clear_create_admin_form_button_Click(object sender, EventArgs e)
        {
            this.admin_name_textbox.Text = "";
            this.admin_surname_textbox.Text = "";
            this.admin_username_textbox.Text = "";
            this.admin_password_textbox.Text = "";
        }
    }
}
