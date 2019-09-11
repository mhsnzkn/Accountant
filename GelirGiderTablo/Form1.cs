using GelirGiderTablo.Data;
using GelirGiderTablo.Dtos;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            var cahars = repo.GetCaharBorcAlacak(null);

            dgv_borclucariler.DataSource = cahars.Where(a => a.Bakiye > 0).OrderByDescending(s=>s.Bakiye).ToList();

            dgv_alacaklicariler.DataSource = cahars.Where(a => a.Bakiye < 0).OrderBy(s => s.Bakiye).ToList();

            var today = DateTime.Now;
            var soon = today.AddDays(10);

            var sooncahars = repo.GetCaharBorcAlacak(soon);
            var yalacak = from c in sooncahars
                          where c.Bakiye>0
                          select new IncomigDepth
                          {
                              CariKod = c.CariKod,
                              Tutar = c.Borc,
                              VadeTarihi = c.VadeTarihi
                          };

            dgv_yalacak.DataSource = yalacak.ToList();

            var yborclar = from c in sooncahars
                          where c.Bakiye < 0
                          select new IncomigDepth
                          {
                              CariKod = c.CariKod,
                              Tutar = c.Alacak,
                              VadeTarihi = c.VadeTarihi
                          };

            dgv_yborclar.DataSource = yborclar.ToList();

        }
    }
}
