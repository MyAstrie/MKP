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
        // Подключение базы данных
        SqlConnection conn = new SqlConnection(@"Data Source=maintenance-of-machine-serv.database.windows.net;Initial Catalog=MaintenanceOfMachineToolsDb;Persist Security Info=True;User ID=Ywop;Password=1Q2w3e4r");

        public OrderWindowView()
        {
            InitializeComponent();
        }

        private void OnCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnReturnButton_Click(object sender, EventArgs e)
        {
            MainWindowView mainWindowView = new MainWindowView();
            mainWindowView.Show();
            this.Hide();
        }

        private void OnCreateOrderButton_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(companyBox.Text) || companyBox.Text == "Компания")
            {
                BoxInteract.ShowBox(companyBox, "Введите компанию.");
                return;
            }

            if (string.IsNullOrEmpty(deviceBox.Text) || deviceBox.Text == "Оборудование")
            {
                BoxInteract.ShowBox(deviceBox, "Введите оборудование.");
                return;
            }

            if (string.IsNullOrEmpty(deviceTypeBox.Text) || deviceTypeBox.Text == "Тип оборудования")
            {
                BoxInteract.ShowBox(deviceTypeBox, "Введите тип оборудования.");
                return;
            }

            if (DateTime.Compare(DateTime.Now, createYearDatePicker.Value) <= 0)
            {
                BoxInteract.ShowBox("Проверьте год выпуска.");
                return;
            }

            if (string.IsNullOrEmpty(countryOfOriginBox.Text) || countryOfOriginBox.Text == "Страна производитель")
            {
                BoxInteract.ShowBox(countryOfOriginBox, "Введите страну производителя.");
                return;
            }

            if (string.IsNullOrEmpty(deviceTypeContext.Text) ||
                deviceTypeContext.Text != "Малый" && 
                deviceTypeContext.Text != "Средний" &&
                deviceTypeContext.Text != "Капитальный")
            {
                BoxInteract.ShowBox("Введите вид работы.");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(timesInRepairBox.Text) || timesInRepairBox.Text == "Кол-во раз в ремонте" ||
                    Convert.ToInt32(timesInRepairBox.Text) <= 0)
                {
                    BoxInteract.ShowBox(timesInRepairBox, "Проверьте кол-во раз в ремонте.");
                    return;
                }
            }
            catch
            {
                BoxInteract.ShowBox(timesInRepairBox, "Проверьте кол-во раз в ремонте.");
                return;
            }

            if (DateTime.Compare(DateTime.Now, startDatePicker.Value) > 0)
            {
                BoxInteract.ShowBox("Проверьте дату начала.");
                return;
            }

            try
            {
                var days = Convert.ToInt32(daysInOperationBox.Text);
                if (string.IsNullOrEmpty(daysInOperationBox.Text) || daysInOperationBox.Text == "Дней в работе" ||
                    days <= 0)
                {
                    BoxInteract.ShowBox(daysInOperationBox, "Проверьте сколько дней вам необходимо.");
                    return;
                }
            }
            catch
            {
                BoxInteract.ShowBox(daysInOperationBox, "Проверьте сколько дней вам необходимо.");
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

        private void companyBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(companyBox, "Компания");
        }

        private void companyBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(companyBox, "Компания");
        }

        private void deviceBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(deviceBox, "Оборудование");
        }

        private void deviceBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(deviceBox, "Оборудование");
        }

        private void deviceTypeBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(deviceTypeBox, "Тип оборудования");
        }

        private void deviceTypeBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(deviceTypeBox, "Тип оборудования");
        }

        private void countryOfOriginBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(countryOfOriginBox, "Страна производитель");
        }

        private void countryOfOriginBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(countryOfOriginBox, "Страна производитель");
        }

        private void timesInRepairBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(timesInRepairBox, "Кол-во раз в ремонте");
        }

        private void timesInRepairBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(timesInRepairBox, "Кол-во раз в ремонте");
        }

        private void daysInOperationBox_Enter(object sender, EventArgs e)
        {
            BoxInteract.EnterInBox(daysInOperationBox, "Дней в работе");
        }

        private void daysInOperationBox_Leave(object sender, EventArgs e)
        {
            BoxInteract.LeaveWithBox(daysInOperationBox, "Дней в работе");
        }
    }
}
