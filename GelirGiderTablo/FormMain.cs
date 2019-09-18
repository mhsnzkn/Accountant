using GelirGiderTablo.Data;
using GelirGiderTablo.Dtos;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GelirGiderTablo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
            var cahars = repo.GetCaharVadesiGecmisBorcAlacak();

            dgv_borclucariler.DataSource = cahars.Where(a => a.Bakiye > 0).OrderByDescending(s=>s.Bakiye).ToList();

            dgv_alacaklicariler.DataSource = cahars.Where(a => a.Bakiye < 0).OrderBy(s => s.Bakiye).ToList();

            var today = DateTime.Now;
            var soon = today.AddDays(30);

            var sooncahars = repo.GetCaharGelecekBorcAlacak(soon);
            var yalacak = from c in sooncahars
                          where c.Borc>0
                          select new IncomigDepth
                          {
                              CariKod = c.CariKod,
                              Tutar = c.Borc,
                              VadeTarihi=c.VadeTarihi,
                              OdemeSekli=c.OdemeSekli
                          };

            dgv_yalacak.DataSource = yalacak.ToList();

            var yborclar = from c in sooncahars
                           where c.Alacak > 0
                           select new IncomigDepth
                          {
                              CariKod = c.CariKod,
                              Tutar = c.Alacak,
                              VadeTarihi = c.VadeTarihi,
                               OdemeSekli = c.OdemeSekli
                           };

            dgv_yborclar.DataSource = yborclar.ToList();

        }

        private void SatışGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVsat = new FormSat();
            formVsat.Show();
        }

        private void DüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUpdate("SATIS");
            form.Show();
        }

        private void DüzeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUpdate("ODEME");
            form.Show();
        }
    }
}
