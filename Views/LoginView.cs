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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpView signUp = new SignUpView();
            signUp.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Имя пользователя")
            {
                usernameBox.Clear();
            }
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == string.Empty)
            {
                usernameBox.Text = "Имя пользователя";
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.Clear();
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == string.Empty)
            {
                passwordBox.Text = "Password";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainWindowView mainWindowView = new MainWindowView();
            mainWindowView.Show();
            this.Hide();
        }
    }
}
