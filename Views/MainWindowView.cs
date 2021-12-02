using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKP_ver1
{
    public partial class MainWindowView : Form
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            OrderWindowView orderWindowView = new OrderWindowView();
            orderWindowView.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }
    }
}
