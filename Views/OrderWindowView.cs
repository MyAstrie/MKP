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

            //Испрваить условие
            if (string.IsNullOrEmpty(createYearBox.Text) || createYearBox.Text == "Имя")
            {
                MessageBox.Show("Введите год выпуска.", caption, btn, ico);
                createYearBox.Select();
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

            //Исправить
            if (string.IsNullOrEmpty(timesInRepairBox.Text) || timesInRepairBox.Text == "Кол-во раз в ремонте")
            {
                MessageBox.Show("Сколько раз был в ремонте.", caption, btn, ico);
                timesInRepairBox.Select();
                return;
            }

            if (DateTime.Compare(DateTime.Now, startDatePicker.Value) > 0)
            {
                MessageBox.Show($"Проверьте дату.", caption, btn, ico); ;
                startDatePicker.Select();
                return;
            }

            //Исправить
            if (string.IsNullOrEmpty(daysInOperationBox.Text) || daysInOperationBox.Text == "Имя")
            {
                MessageBox.Show("Проверьте сколько дней вам необходимо.", caption, btn, ico);
                daysInOperationBox.Select();
                return;
            }
        }
    }
}
