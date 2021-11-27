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
    public partial class SignUpView : Form
    {
        public SignUpView()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }

        private void OnSignUpButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";
        }

        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            if(UsernameBox.Text == "Имя")
            {
                UsernameBox.Clear();
            }
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (UsernameBox.Text == string.Empty)
            {
                UsernameBox.Text = "Имя";
            }
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (LastName.Text == "Фамилия")
            {
                LastName.Clear();
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (LastName.Text == string.Empty)
            {
                LastName.Text = "Фамилия";
            }
        }

        private void LoginTxt_Enter(object sender, EventArgs e)
        {
            if(LoginTxt.Text == "Логин")
            {
                LoginTxt.Clear();
            }
        }

        private void LoginTxt_Leave(object sender, EventArgs e)
        {
            if(LoginTxt.Text == string.Empty)
            {
                LoginTxt.Text = "Логин";
            }
        }

        private void PassTxt_Enter(object sender, EventArgs e)
        {
            if (PassTxt.Text == "Пароль")
            {
                PassTxt.Clear();
            }
        }

        private void PassTxt_Leave(object sender, EventArgs e)
        {
            if(PassTxt.Text == string.Empty)
            {
                PassTxt.Text = "Пароль";
            }
        }

        private void RepeatPassTxt_Enter(object sender, EventArgs e)
        {
            if (RepeatPassTxt.Text == "Повторите пароль")
            {
                RepeatPassTxt.Clear();
            }
        }

        private void RepeatPassTxt_Leave(object sender, EventArgs e)
        {
            if(RepeatPassTxt.Text == string.Empty)
            {
                RepeatPassTxt.Text = "Повторите пароль";
            }    
        }

        private void UsernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled=(e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Пробелы не разрешены");
            }
        }

        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Пробелы не разрешены");
            }
        }

        private void LoginTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Пробелы не разрешены");
            }
        }

        private void PassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Пробелы не разрешены");
            }
        }

        private void RepeatPassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Пробелы не разрешены");
            }
        }
    }
}
