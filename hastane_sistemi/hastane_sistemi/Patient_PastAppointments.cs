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
    public partial class Patient_PastAppointments : Form
    {
        private String patient_tc;
        public Patient_PastAppointments(String tc)
        {
            InitializeComponent();
            this.patient_tc = tc;
        }

        private void Patient_Appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.department' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.FillBy2(this.hastaneDataSet.appointment, this.patient_tc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
