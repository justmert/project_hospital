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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void admin_credentials_login_Click(object sender, EventArgs e)
        {
            String username = this.admin_username_texbox.Text;
            String password = this.admin_password_textbox.Text;
            String name = null, surname = null;

            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT * from hastane.dbo.admin where username = '{0}' AND password ='{1}'", username, password)
;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader["name"].ToString();
                        surname = reader["surname"].ToString();
                        break;
                    }

                }
            }
            if (name == null)
            {
                MessageBox.Show("Giriş bilgilerinizi kontrol ediniz");
                return;
            }

            this.Hide();
            AdminPanel new_admin_panel = new AdminPanel(name, surname, username, password);
            new_admin_panel.ShowDialog();
        }
    }
}

