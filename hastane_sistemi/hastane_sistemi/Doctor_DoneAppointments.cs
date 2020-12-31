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
    public partial class Doctor_DoneAppointments : Form
    {
        private String doctor_tc;
        public Doctor_DoneAppointments(String doctor_tc)
        {
            InitializeComponent();
            this.doctor_tc = doctor_tc; 
        }

        private void Doctor_DoneAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.FillBy4(this.hastaneDataSet.appointment, this.doctor_tc);
        }

        private void search_by_patient_tcToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointmentTableAdapter.search_by_patient_tc(this.hastaneDataSet.appointment, patient_tcToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_by_patient_nameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointmentTableAdapter.search_by_patient_name(this.hastaneDataSet.appointment, patient_nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_by_patient_surnameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointmentTableAdapter.search_by_patient_surname(this.hastaneDataSet.appointment, patient_surnameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.patient_nameToolStripTextBox.Text = "";
            this.patient_surnameToolStripTextBox.Text = "";
            this.patient_tcToolStripTextBox.Text = "";
            this.appointmentTableAdapter.FillBy4(this.hastaneDataSet.appointment, this.doctor_tc);

        }
    }
}
