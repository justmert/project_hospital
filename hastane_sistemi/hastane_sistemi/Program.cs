using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace hastane_sistemi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Utility.ConnectionStr = "Data Source=LAPTOP-QC3TVQQG\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True";
            EntryForm entry_form = new EntryForm();
            Application.Run(entry_form);

        }
    }
}
