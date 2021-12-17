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
        public static string userRole;

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

        // Представляем подключение к локальной базе данных
        SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";

            if (string.IsNullOrEmpty(usernameBox.Text) || usernameBox.Text == "Имя пользователя")
            {
                MessageBox.Show("Введите логин.", caption, btn, ico);
                usernameBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(passwordBox.Text) || passwordBox.Text == "Password")
            {
                MessageBox.Show("Введите пароль.", caption, btn, ico);
                passwordBox.Select();
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Open();
                conn.Close();
            }
        }
    }
}
