using System;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class EntryForm : Form
    {
        private AdminLogin adminLoginForm = null;
        private DoctorLogin doctorLoginForm = null;
        private PatientLogin patientLoginForm = null;
        private PatientSignForm patientSignForm = null;
        private DoctorSignForm doctorSignForm = null;
        public EntryForm()
        {
            InitializeComponent();
        }


        private void admin_entry_button_Click(object sender, EventArgs e)
        {
            adminLoginForm = new AdminLogin();
            adminLoginForm.ShowDialog();
        }

        private void doctor_entry_button_Click(object sender, EventArgs e)
        {
            doctorLoginForm = new DoctorLogin();
            doctorLoginForm.ShowDialog();
        }

        private void patient_entry_button_Click(object sender, EventArgs e)
        {
            patientLoginForm = new PatientLogin();
            patientLoginForm.ShowDialog();
        }

        private void patient_sign_button_Click(object sender, EventArgs e)
        {
            patientSignForm = new PatientSignForm();
            patientSignForm.ShowDialog();
        }

        private void doctor_sign_button_Click(object sender, EventArgs e)
        {
            doctorSignForm = new DoctorSignForm();
            doctorSignForm.ShowDialog();
        }

    }
}
