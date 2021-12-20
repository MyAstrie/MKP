using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKP_ver1
{
    internal class BoxInteract
    {
        public static void EnterInBox(TextBox textBox, string field)
        {
            if (textBox.Text == field)
            {
                textBox.Clear();
            }
        }

        public static void LeaveWithBox(TextBox textBox, string field)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Text = field;
            }
        }

        public static void ShowBox(TextBox textBox, string field)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";
            MessageBox.Show($"{field}", caption, btn, ico);
            textBox.Select();
        }

        public static void ShowBox(string field)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";
            MessageBox.Show($"{field}", caption, btn, ico);
        }

        public static void ShowForbiddenSymbols(KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Пробелы не разрешены");
            }
        }
    }
}
