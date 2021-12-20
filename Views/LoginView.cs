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
    public partial class LoginView : Form
    {
        // Подключение базы данных
        SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

        public static string userRole;

        public LoginView()
        {
            InitializeComponent();
        }

        private void OnSignUpButton_Click(object sender, EventArgs e)
        {
            SignUpView signUp = new SignUpView();
            signUp.Show();
            this.Hide();
        }

        private void OnCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnLoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text) || usernameBox.Text == "Имя пользователя")
            {
                BoxInteract.ShowBox(usernameBox, "Введите логин.");
                return;
            }

            if (string.IsNullOrEmpty(passwordBox.Text) || passwordBox.Text == "Password")
            {
                BoxInteract.ShowBox(passwordBox, "Введите пароль.");
                return;
            }

            try
            {
                conn.Open();

                SqlDataAdapter dataAdapter;

                if (adminCheck.Checked == true)
                {
                    // Получаем данные Админа и Пароля учитывая все строки в UserTable
                    dataAdapter = new SqlDataAdapter("SELECT * FROM UserTable WHERE UserName='" + usernameBox.Text +
                                                                    "'AND UserPass='" + passwordBox.Text +
                                                                    "'AND UserProfession = N'Админ'", conn);
                    DataTable dataTable = new DataTable();

                    // Заполняем dataTable соответсвие строк в источник данных 
                    dataAdapter.Fill(dataTable);

                    var asrt = dataTable.Rows.Count;

                    // Проверка, где результатом будет кол-во строк соответствующих введенным данным
                    if (dataTable.Rows.Count == 1)
                    {
                        userRole = "admin";
                        MainWindowView mainWindow = new MainWindowView();
                        mainWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                    conn.Close();
                }
                else
                {
                    // Получаем данные Админа и Пароля учитывая все строки в UserTable
                    dataAdapter = new SqlDataAdapter("SELECT * FROM UserTable WHERE UserName = '" + usernameBox.Text +
                                                                    "'AND UserPass='" + passwordBox.Text +
                                                                    "'AND UserProfession =  N'Работник'", conn);
                    DataTable dataTable = new DataTable();

                    // Заполняем dataTable соответсвие строк в источник данных 
                    dataAdapter.Fill(dataTable);

                    // Проверка, где результатом будет кол-во строк соответствующих введенным данным
                    if (dataTable.Rows.Count == 1)
                    {
                        userRole = "guest";
                        MainWindowView mainWindow = new MainWindowView();
                        mainWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(usernameBox, "Имя пользователя");
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(usernameBox, "Имя пользователя");
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(passwordBox, "Password");
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(passwordBox, "Password");
        }
    }
}
