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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void doctor_credentials_login_Click(object sender, EventArgs e)
        {
            String tc = this.doctor_username_texbox.Text;
            String password = this.doctor_password_textbox.Text;
            String name = null, surname = null;

            String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT * from hastane.dbo.doctor where tc = '{0}' AND password ='{1}'", tc, password)
;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        name = reader["name"].ToString();
                        surname = reader["surname"].ToString();
                    }

                }
            }
            if (name == null)
            {
                MessageBox.Show("Giriş bilgilerinizi kontrol ediniz");
                return;
            }

            this.Hide();
            DoctorPanel new_doctor_panel = new DoctorPanel(name, surname, tc);
            new_doctor_panel.ShowDialog();
        }
    }
}
