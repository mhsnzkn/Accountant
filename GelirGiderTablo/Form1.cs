using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelirGiderTablo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var formVsat = new FormSat();
            formVsat.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var formRapor = new FormCahar();
            formRapor.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var formOdeme = new FormOdeme();
            formOdeme.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var formCariler = new FormCariler();
            formCariler.Show();
        }
    }
}
