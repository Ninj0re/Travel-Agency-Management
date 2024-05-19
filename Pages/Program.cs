using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAMS.Pages;

namespace TAMS
{
    internal static class Program
    {
        public static string conString = "Data Source=DESKTOP-SDDC56F\\SQLEXPRESS;Initial Catalog=TamsDb;Integrated Security=True";
        public static SqlConnection connect = new SqlConnection(conString); // I connected to sql server
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
