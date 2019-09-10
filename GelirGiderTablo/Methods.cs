using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelirGiderTablo
{
    public static class Methods
    {
        public static decimal GetDecimal(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return 0;

            return Convert.ToDecimal(textBox.Text);
        }

        public static decimal Getint(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return 0;

            return Convert.ToInt32(textBox.Text);
        }

    }
}
