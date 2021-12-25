using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKP_ver1
{
    /// <summary>
    /// Класс для взваимодействия с textBox
    /// </summary>
    internal class BoxInteract
    {
        /// <summary>
        /// Очистка textBox при входе в него
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="field">Строка которая должна быть очищена</param>
        public static void EnterInBox(TextBox textBox, string field)
        {
            if (textBox.Text == field)
            {
                textBox.Clear();
            }
        }

        /// <summary>
        /// Вывод строки при выходе из нее 
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="field">Строка которая должна выведена</param>
        public static void LeaveWithBox(TextBox textBox, string field)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Text = field;
            }
        }

        /// <summary>
        /// Отображение ошибки у textBox
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="field">Строка ошибки</param>
        public static void ShowBox(TextBox textBox, string field)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";
            MessageBox.Show($"{field}", caption, btn, ico);
            textBox.Select();
        }

        /// <summary>
        /// Отображение ошибки
        /// </summary>
        /// <param name="field">Строка ошибки</param>
        public static void ShowBox(string field)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";
            MessageBox.Show($"{field}", caption, btn, ico);
        }

        /// <summary>
        /// Запрещенные символы
        /// </summary>
        /// <param name="e"></param>
        public static void ShowForbiddenSymbols(KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Пробелы не разрешены");
            }
        }
    }
}
