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
    public partial class SignUpView : Form
    {
        public SignUpView()
        {
            InitializeComponent();
            if(LoginView.userRole == "admin")
            {
                registerLabel.Text = "Добавить менеджера";
                onSignUpButton.Text = "Добавить";
            }
            else
            {
                registerLabel.Text = "Регистрация";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if(LoginView.userRole == "admin")
            {
                MainWindowView mainWindow = new MainWindowView();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                LoginView login = new LoginView();
                login.Show();
                this.Hide();
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

        private void OnSignUpButton_Click(object sender, EventArgs e)
        {
            // Параметры для окна ошибок при незаполненных полях
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
                whoUserContext.Text != "Работник" && whoUserContext.Text != "Админ")
            {
                MessageBox.Show("Выберите кем вы являетесь.", caption, btn, ico);
                whoUserContext.Select();
                return;
            }

            try
            {
                conn.Open();
                // Работа с таблицей пользователей расположенной в базе данных
                SqlCommand command = new SqlCommand("INSERT INTO UserTable(UserName, UserLastName, UserLogin, UserPass, UserProfession) VALUES(@UName, @ULastName, @ULogin, @UPass, @UProf)", conn);

                // Получаем данные Логина учитывая все строки в UserTbl
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM UserTable WHERE UserLogin ='" + loginBox.Text + "'", conn);

                DataTable dataTable = new DataTable();

                // Заполняем dataTable соответсвием строк в источник данных 
                dataAdapter.Fill(dataTable);

                // Проверка, где результатом будет кол-во строк соответствующих введенным данным
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Логин Занят.", caption, btn, ico);
                    loginBox.Select();
                    return;
                }

                // Считывание данных с полей
                command.Parameters.AddWithValue("@UName", nameBox.Text);
                command.Parameters.AddWithValue("@ULastName", lastNameBox.Text);
                command.Parameters.AddWithValue("@ULogin", loginBox.Text);
                command.Parameters.AddWithValue("@UPass", passBox.Text);
                command.Parameters.AddWithValue("@UProf", whoUserContext.Text);

                // Обновление записей в базе данных
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый аккаунт создан!");
                Clear();

                if (LoginView.userRole == "admin")
                {
                    MainWindowView mainWindow = new MainWindowView();
                    mainWindow.Show();
                    this.Hide();
                }
                else
                {
                    LoginView login = new LoginView();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Open();
                conn.Close();
            }
        }

        // Очистка полей
        private void Clear()
        {
            nameBox.Text = "";
            lastNameBox.Text = "";
            loginBox.Text = "";
            passBox.Text = "";
            whoUserContext.Text = "";
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
