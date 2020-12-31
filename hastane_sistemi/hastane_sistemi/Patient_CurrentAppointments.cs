using System;
using System.Windows.Forms;

namespace hastane_sistemi
{
    public partial class Patient_CurrentAppointments : Form
    {
        private String patient_tc;
        public Patient_CurrentAppointments(String tc)
        {
            InitializeComponent();
            this.patient_tc = tc;

        }

        private void Patient_CurrentAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.current_appoinments_fill(this.hastaneDataSet.appointment, this.patient_tc);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);

                }
            }

            //    String connection_str = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            //    using (SqlConnection connection = new SqlConnection(connection_str))
            //    {
            //        string query = "DELETE FROM SpellingList WHERE tc = @rowID";

            //        // Create the connection and the command inside a using block
            //        using (SqlCommand deleteRecord = new SqlCommand(query, connection))
            //        {
            //            connection.Open();

            //            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            //            {
            //                if (oneCell.Selected)
            //                {
            //                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            //                    dataGridView1.Rows[oneCell.RowIndex].Cells[]

            //                }
            //            }

            //            int selectedIndex = dataGridView1.SelectedRows[0].Index;

            //            int rowID = dataGridView1.select;

            //            // Add the parameter to the command collection
            //            deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
            //            deleteRecord.ExecuteNonQuery();

            //            dataGridView1.Rows.RemoveAt(selectedIndex);
            //        }
            //    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
