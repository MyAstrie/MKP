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
        // Подключение базы данных
        SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

        public SignUpView()
        {
            InitializeComponent();
        }

        private void SignUpView_Load(object sender, EventArgs e)
        {
            if (LoginView.userRole == "admin")
            {
                registerLabel.Text = "Добавить менеджера";
                onSignUpButton.Text = "Добавить";
            }
            else
            {
                registerLabel.Text = "Регистрация";
            }
        }

        private void OnCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnReturnButton_Click(object sender, EventArgs e)
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
        
        private void OnSignUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || nameBox.Text == "Имя")
            {
                BoxInteract.ShowBox(nameBox, "Введите имя.");
                return;
            }

            if (string.IsNullOrEmpty(lastNameBox.Text) || lastNameBox.Text == "Фамилия")
            {
                BoxInteract.ShowBox(lastNameBox, "Введите фамилию.");
                return;
            }

            if (string.IsNullOrEmpty(loginBox.Text) || loginBox.Text == "Логин")
            {
                BoxInteract.ShowBox(loginBox, "Введите логин.");
                return;
            }

            if (string.IsNullOrEmpty(passBox.Text) || passBox.Text == "Пароль")
            {
                BoxInteract.ShowBox(passBox, "Введите пароль.");
                return;
            }

            if (repeatPassBox.Text != passBox.Text)
            {
                BoxInteract.ShowBox(repeatPassBox, "Пароли не совпадают.");
                return;
            }

            if (string.IsNullOrEmpty(whoUserContext.Text) ||
                whoUserContext.Text != "Работник" && whoUserContext.Text != "Админ")
            {
                BoxInteract.ShowBox("Выберите кем вы являетесь.");
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
                    BoxInteract.ShowBox(loginBox, "Логин Занят.");
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
                    LoginView loginView = new LoginView();
                    loginView.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
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

        private void nameBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(nameBox, "Имя");
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(nameBox, "Имя");
        }

        private void lastNameBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(lastNameBox, "Фамилия");
        }

        private void lastNameBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(lastNameBox, "Фамилия");
        }

        private void loginBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(loginBox, "Логин");
        }

        private void loginBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(loginBox, "Логин");
        }

        private void passBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(passBox, "Пароль");
        }

        private void passBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(passBox, "Пароль");
        }

        private void repeatPassBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(repeatPassBox, "Повторите пароль");
        }

        private void repeatPassBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(repeatPassBox, "Повторите пароль");
        }

        private void UsernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BoxInteract.ShowForbiddenSymbols(e);
        }

        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            BoxInteract.ShowForbiddenSymbols(e);
        }

        private void LoginTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            BoxInteract.ShowForbiddenSymbols(e);
        }

        private void PassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            BoxInteract.ShowForbiddenSymbols(e);
        }

        private void RepeatPassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            BoxInteract.ShowForbiddenSymbols(e);
        }
    }
}
