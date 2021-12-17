using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MKP_ver1
{
    public partial class AddDbView : Form
    {
        public static string dbPath;

        public AddDbView()
        {
            InitializeComponent();
        }

        private void AddDbView_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.StartupPath
            SqlConnection connection = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");
            
            try
            {
                // Открываем подключение
                connection.Open();
                MessageBox.Show($"Подключение открыто \n {connection.DataSource.ToString()}");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }
    }
}
