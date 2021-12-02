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

            if (string.IsNullOrEmpty(nameBox.Text) || nameBox.Text == "Имя")
            {
                MessageBox.Show("Введите имя.", caption, btn, ico);
                nameBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(lastNameBox.Text) || lastNameBox.Text == "Фамилия")
            {
                MessageBox.Show("Введите фамилию.", caption, btn, ico);
                lastNameBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(loginBox.Text) || loginBox.Text == "Логин")
            {
                MessageBox.Show("Введите логин.", caption, btn, ico);
                loginBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(passBox.Text) || passBox.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль.", caption, btn, ico);
                passBox.Select();
                return;
            }

            if (repeatPassBox.Text != passBox.Text)
            {
                MessageBox.Show("Пароли не совпадают.", caption, btn, ico);
                repeatPassBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(whoUserContext.Text) || 
                whoUserContext.Text != "Работником" && whoUserContext.Text != "Пользователем")
            {
                MessageBox.Show("Выберите кем вы являетесь.", caption, btn, ico);
                whoUserContext.Select();
                return;
            }
        }

        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            if(nameBox.Text == "Имя")
            {
                nameBox.Clear();
            }
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == string.Empty)
            {
                nameBox.Text = "Имя";
            }
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (lastNameBox.Text == "Фамилия")
            {
                lastNameBox.Clear();
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (lastNameBox.Text == string.Empty)
            {
                lastNameBox.Text = "Фамилия";
            }
        }

        private void LoginTxt_Enter(object sender, EventArgs e)
        {
            if(loginBox.Text == "Логин")
            {
                loginBox.Clear();
            }
        }

        private void LoginTxt_Leave(object sender, EventArgs e)
        {
            if(loginBox.Text == string.Empty)
            {
                loginBox.Text = "Логин";
            }
        }

        private void PassTxt_Enter(object sender, EventArgs e)
        {
            if (passBox.Text == "Пароль")
            {
                passBox.Clear();
            }
        }

        private void PassTxt_Leave(object sender, EventArgs e)
        {
            if(passBox.Text == string.Empty)
            {
                passBox.Text = "Пароль";
            }
        }

        private void RepeatPassTxt_Enter(object sender, EventArgs e)
        {
            if (repeatPassBox.Text == "Повторите пароль")
            {
                repeatPassBox.Clear();
            }
        }

        private void RepeatPassTxt_Leave(object sender, EventArgs e)
        {
            if(repeatPassBox.Text == string.Empty)
            {
                repeatPassBox.Text = "Повторите пароль";
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
