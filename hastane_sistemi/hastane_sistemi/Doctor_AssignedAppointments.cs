using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class Doctor_AssignedAppointments : Form
    {
        private String doctor_tc;
        public Doctor_AssignedAppointments(String doctor_tc)
        {
            InitializeComponent();
            this.doctor_tc = doctor_tc;
        }

        private void Doctor_AssignedAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.active_appointments(this.hastaneDataSet.appointment, this.doctor_tc);

        }

        private void appointment_done_button_Click(object sender, EventArgs e)
        {

        }
    }
}
