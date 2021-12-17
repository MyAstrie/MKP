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
    public partial class OrderWindowView : Form
    {
        public OrderWindowView()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainWindowView mainWindowView = new MainWindowView();
            mainWindowView.Show();
            this.Hide();
        }

        // Подключение базы данных
        SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

        private void createOrderButton_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(companyBox.Text) || companyBox.Text == "Компания")
            {
                MessageBox.Show("Введите компанию.", caption, btn, ico);
                companyBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(deviceBox.Text) || deviceBox.Text == "Оборудование")
            {
                MessageBox.Show("Введите оборудование.", caption, btn, ico);
                deviceBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(deviceTypeBox.Text) || deviceTypeBox.Text == "Тип оборудования")
            {
                MessageBox.Show("Введите тип оборудования.", caption, btn, ico);
                deviceTypeBox.Select();
                return;
            }

            if (DateTime.Compare(DateTime.Now, createYearDatePicker.Value) <= 0)
            {
                MessageBox.Show("Проверьте год выпуска.", caption, btn, ico);
                createYearDatePicker.Select();
                return;
            }

            if (string.IsNullOrEmpty(countryOfOriginBox.Text) || countryOfOriginBox.Text == "Страна производитель")
            {
                MessageBox.Show("Введите страну производителя.", caption, btn, ico);
                countryOfOriginBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(deviceTypeContext.Text) ||
                deviceTypeContext.Text != "Малый" && 
                deviceTypeContext.Text != "Средний" &&
                deviceTypeContext.Text != "Капитальный")
            {
                MessageBox.Show("Введите вид работы.", caption, btn, ico);
                deviceTypeContext.Select();
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(timesInRepairBox.Text) || timesInRepairBox.Text == "Кол-во раз в ремонте" ||
                    Convert.ToInt32(timesInRepairBox.Text) <= 0)
                {
                    MessageBox.Show("Проверьте кол-во раз в ремонте.", caption, btn, ico);
                    timesInRepairBox.Select();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте кол-во раз в ремонте.", caption, btn, ico);
                return;
            }

            if (DateTime.Compare(DateTime.Now, startDatePicker.Value) > 0)
            {
                MessageBox.Show($"Проверьте дату.", caption, btn, ico); ;
                startDatePicker.Select();
                return;
            }

            try
            {
                var days = Convert.ToInt32(daysInOperationBox.Text);
                if (string.IsNullOrEmpty(daysInOperationBox.Text) || daysInOperationBox.Text == "Дней в работе" ||
                    days <= 0)
                {
                    MessageBox.Show("Проверьте сколько дней вам необходимо.", caption, btn, ico);
                    daysInOperationBox.Select();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте сколько дней вам необходимо.", caption, btn, ico);
                return;
            }

            try
            {
                conn.Open();
                // Работа с таблицей пользователей расположенной в базе данных
                SqlCommand command = new SqlCommand("INSERT INTO OrderTable(OrderName, OrderLastName, " +
                                                    "OrderCompany, OrderDevice, OrderTypeDevice, OrderReleaseYear, " +
                                                    "OrderDevCountry, OrderTypeRepair, OrderTimesInRepair," +
                                                    "OrderStartDate, OrderDaysInRepair, OrderEndDate, OrderCost) " +
                                                    "VALUES(@OName, @OLastName, @OCompany, @ODevice, @OTypeDevice, " +
                                                    "@OReleaseYear, @ODevCountry, @OTypeRepair, @TimesInRepair, " +
                                                    "@StartDate, @DaysInRepair, @EndDate, @Cost)", conn);

                // Считывание данных с полей
                command.Parameters.AddWithValue("@OName", nameBox.Text);
                command.Parameters.AddWithValue("@OLastName", lastNameBox.Text);
                command.Parameters.AddWithValue("@OCompany", companyBox.Text);
                command.Parameters.AddWithValue("@ODevice", deviceBox.Text);
                command.Parameters.AddWithValue("@OTypeDevice", deviceTypeBox.Text);
                command.Parameters.AddWithValue("@OReleaseYear", createYearDatePicker.Value.Date);
                command.Parameters.AddWithValue("@ODevCountry", countryOfOriginBox.Text);
                command.Parameters.AddWithValue("@OTypeRepair", deviceTypeContext.Text);
                command.Parameters.AddWithValue("@TimesInRepair", timesInRepairBox.Text);
                command.Parameters.AddWithValue("@StartDate", startDatePicker.Value.Date);
                command.Parameters.AddWithValue("@DaysInRepair", daysInOperationBox.Text);
                command.Parameters.AddWithValue("@EndDate", startDatePicker.Value.Date.AddDays(Convert.ToInt32(daysInOperationBox.Text)));
                command.Parameters.AddWithValue("@Cost", costLabel.Text);

                // Обновление записей в базе данных
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый заказ создан!");
                Clear();

                // Возврат на экран логина
                MainWindowView mainWindow = new MainWindowView();
                mainWindow.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                conn.Open();
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Очистка полей
        private void Clear()
        {
            nameBox.Text = "";
            lastNameBox.Text = "";
            companyBox.Text = "";
            deviceBox.Text = "";
            deviceTypeBox.Text = "";
            countryOfOriginBox.Text = "";
            deviceTypeContext.Text = "";
            timesInRepairBox.Text = "";
            daysInOperationBox.Text = "";
        }

        private void daysInOperationBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var endDate = startDatePicker.Value.Date.AddDays(Convert.ToInt32(daysInOperationBox.Text));
                endDateLabel.Text = endDate.Date.ToString();
            }
            catch
            {
                endDateLabel.Text = "";
            }
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var endDate = startDatePicker.Value.Date.AddDays(Convert.ToInt32(daysInOperationBox.Text));
                endDateLabel.Text = endDate.Date.ToString();
            }
            catch
            {
                endDateLabel.Text = "";
            }
        }

        private void deviceTypeContext_TextChanged(object sender, EventArgs e)
        {
            if(deviceTypeContext.Text == "Малый")
            {
                costLabel.Text = "10000 руб";
            }

            if(deviceTypeContext.Text == "Средний")
            {
                costLabel.Text = "20000 руб";
            }

            if(deviceTypeContext.Text == "Капитальный")
            {
                costLabel.Text = "30000 руб";
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Имя")
            {
                nameBox.Clear();
            }
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == string.Empty)
            {
                nameBox.Text = "Имя";
            }
        }

        private void lastNameBox_Enter(object sender, EventArgs e)
        {
            if (lastNameBox.Text == "Фамилия")
            {
                lastNameBox.Clear();
            }
        }

        private void lastNameBox_Leave(object sender, EventArgs e)
        {
            if (lastNameBox.Text == string.Empty)
            {
                lastNameBox.Text = "Фамилия";
            }
        }

        private void companyBox_Enter(object sender, EventArgs e)
        {
            if (companyBox.Text == "Компания")
            {
                companyBox.Clear();
            }
        }

        private void companyBox_Leave(object sender, EventArgs e)
        {
            if (companyBox.Text == string.Empty)
            {
                companyBox.Text = "Компания";
            }
        }

        private void deviceBox_Enter(object sender, EventArgs e)
        {
            if (deviceBox.Text == "Оборудование")
            {
                deviceBox.Clear();
            }
        }

        private void deviceBox_Leave(object sender, EventArgs e)
        {
            if (deviceBox.Text == string.Empty)
            {
                deviceBox.Text = "Оборудование";
            }
        }

        private void deviceTypeBox_Enter(object sender, EventArgs e)
        {
            if (deviceTypeBox.Text == "Тип оборудования")
            {
                deviceTypeBox.Clear();
            }
        }

        private void deviceTypeBox_Leave(object sender, EventArgs e)
        {
            if (deviceTypeBox.Text == string.Empty)
            {
                deviceTypeBox.Text = "Тип оборудования";
            }
        }

        private void countryOfOriginBox_Enter(object sender, EventArgs e)
        {
            if (countryOfOriginBox.Text == "Страна производитель")
            {
                countryOfOriginBox.Clear();
            }
        }

        private void countryOfOriginBox_Leave(object sender, EventArgs e)
        {
            if (countryOfOriginBox.Text == string.Empty)
            {
                countryOfOriginBox.Text = "Страна производитель";
            }
        }

        private void timesInRepairBox_Enter(object sender, EventArgs e)
        {
            if (timesInRepairBox.Text == "Кол-во раз в ремонте")
            {
                timesInRepairBox.Clear();
            }
        }

        private void timesInRepairBox_Leave(object sender, EventArgs e)
        {
            if (timesInRepairBox.Text == string.Empty)
            {
                timesInRepairBox.Text = "Кол-во раз в ремонте";
            }
        }

        private void daysInOperationBox_Enter(object sender, EventArgs e)
        {
            if (daysInOperationBox.Text == "Дней в работе")
            {
                daysInOperationBox.Clear();
            }
        }

        private void daysInOperationBox_Leave(object sender, EventArgs e)
        {
            if (daysInOperationBox.Text == string.Empty)
            {
                daysInOperationBox.Text = "Дней в работе";
            }
        }
    }
}
