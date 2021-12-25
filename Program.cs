using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MKP_ver1
{
    /// <summary>
    /// Стандартный класс от куда начинается программа
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Подключение базы данных
            SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

            try
            {
                conn.Open();
                MessageBox.Show($"Подключение открыто \n {conn.DataSource.ToString()}");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.Run(new LoginView());
        }
    }
}
