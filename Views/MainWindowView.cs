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
    public partial class MainWindowView : Form
    {
        // Подключение базы данных
        SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

        private int _key = 0;

        public MainWindowView()
        {
            InitializeComponent();
        }

        private void MainWindowView_Load(object sender, EventArgs e)
        {
            if (LoginView.userRole == "admin")
            {
                userNameLabel.Text = "Администрация";
                createButton.Text = "Добавить менеджера";
                createButton.Size = new Size(240, 40);
                createButton.Location = new Point(922, 73);
                deleteButton.Location = new Point(723, 73);
                idLabel.Text = "Id пользователя:";
                idLabel.Location = new Point(400, 78);
            }
            else
            {
                userNameLabel.Text = "Менеджмент";
                createButton.Size = new Size(192, 40);
                createButton.Location = new Point(970, 73);
                deleteButton.Location = new Point(772, 73);
                idLabel.Text = "Id заказа:";
                idLabel.Location = new Point(489, 78);
            }
            ShowDataTable();
        }

        private void ShowDataTable()
        {
            if (LoginView.userRole == "admin")
            {
                conn.Open();
                string query = "SELECT * FROM UserTable";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet(); 
                sda.Fill(dataSet);
                dataPrinter.DataSource = dataSet.Tables[0];
                conn.Close();
            }
            else
            {
                conn.Open();
                string query = "SELECT * FROM OrderTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                dataPrinter.DataSource = dataSet.Tables[0];
                conn.Close();
            }
        }

        private void OnCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnCreateButton_Click(object sender, EventArgs e)
        {
            if (LoginView.userRole == "admin")
            {
                SignUpView signUpView = new SignUpView();
                signUpView.Show();
                this.Hide();
            }
            else
            {
                OrderWindowView orderWindowView = new OrderWindowView();
                orderWindowView.Show();
                this.Hide();
            }
        }

        private void OnBackButton_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }

        private void OnDeleteButton_Click(object sender, EventArgs e)
        {
            if (LoginView.userRole == "admin")
            {
                try
                {
                    conn.Open();
                    // Работа с таблицей пользователей расположенной в базе данных
                    SqlCommand command = new SqlCommand("DELETE FROM UserTable WHERE UserId = @UId", conn);

                    // Считывание данных с полей
                    command.Parameters.AddWithValue("@UId", _key);

                    // Обновление записей в базе данных
                    command.ExecuteNonQuery();

                    MessageBox.Show("Аккаунт удален!");

                    conn.Close();
                    ShowDataTable();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    // Работа с таблицей пользователей расположенной в базе данных
                    SqlCommand command = new SqlCommand("DELETE FROM OrderTable WHERE OrderId = @OId", conn);

                    // Считывание данных с полей
                    command.Parameters.AddWithValue("@OId", _key);

                    // Обновление записей в базе данных
                    command.ExecuteNonQuery();

                    MessageBox.Show("Заказ удален!");

                    conn.Close();
                    ShowDataTable();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataPrinter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idBox.Text = dataPrinter.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                _key = Convert.ToInt32(idBox.Text);
            }
            catch
            {
                MessageBox.Show("Вы не выбрали,что удалить");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (LoginView.userRole == "admin")
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM UserTable WHERE UserId like '" + searchBox.Text + "%'" +
                                                          "OR UserName like N'" + searchBox.Text + "%'" +
                                                          "OR UserLastName like N'" + searchBox.Text + "%'" +
                                                          "OR UserLogin like N'" + searchBox.Text + "%'" +
                                                          "OR UserPass like N'" + searchBox.Text + "%'" +
                                                          "OR UserProfession like N'" + searchBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataPrinter.DataSource = dt;
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM OrderTable WHERE OrderId like '" + searchBox.Text + "%'" +
                                                          "OR OrderName like N'" + searchBox.Text + "%'" +
                                                          "OR OrderLastName like N'" + searchBox.Text + "%'" +
                                                          "OR OrderCompany like N'" + searchBox.Text + "%'" +
                                                          "OR OrderDevice like N'" + searchBox.Text + "%'" +
                                                          "OR OrderTypeDevice like N'" + searchBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataPrinter.DataSource = dt;
                conn.Close();
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(searchBox, "Поиск по имени");
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(searchBox, "Поиск по имени");
        }
    }
}
