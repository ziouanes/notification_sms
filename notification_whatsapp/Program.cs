using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notification_whatsapp
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
            Application.Run(new Form1());
        }
        public static SqlConnection sql_con = new SqlConnection("Data Source=AANDROID-123122;Initial Catalog=CLIENT;Integrated Security=True");


        internal static SqlCommand sql_cmd;

        public static SqlDataReader db;


    }
}
