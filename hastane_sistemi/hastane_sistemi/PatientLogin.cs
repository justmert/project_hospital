using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }

        private void patient_credentials_login_Click(object sender, EventArgs e)
        {
            String tc = this.patient_username_textbox.Text;
            String password = this.patient_password_textbox.Text;
            String name = null, surname = null;

            String connection_str = Utility.ConnectionStr;
            using (SqlConnection connection = new SqlConnection(connection_str))
            {
                String query = String.Format("SELECT * from hastane.dbo.patient where tc = '{0}' AND password ='{1}'", tc, password)
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
            if( name == null)
            {
                MessageBox.Show("Giriş bilgilerinizi kontrol ediniz");
                return;
            }

            this.Hide();
            PatientPanel new_patient_panel = new PatientPanel(name,surname,tc);
            new_patient_panel.ShowDialog();
        }
    }
}
