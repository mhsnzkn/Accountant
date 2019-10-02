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
            var formOdeme = new FormOdeme(null);
            formOdeme.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var formCariler = new FormCariler();
            formCariler.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            backgroundWorker1.RunWorkerAsync();
            RefreshPage();

        }

        private void SatışGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVsat = new FormSat(null);
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

        private void ÖdemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVsat = new FormSat("odemeal");
            formVsat.Show();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void ÖdemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formOdeme = new FormOdeme("odemeyap");
            formOdeme.Show();
        }

        private void RefreshPage()
        {
            var cahars = repo.GetCaharVadesiGecmisBorcAlacak();

            dgv_borclucariler.DataSource = cahars.Where(a => a.Bakiye > 0).OrderByDescending(s => s.Bakiye).ToList();

            dgv_alacaklicariler.DataSource = cahars.Where(a => a.Bakiye < 0).OrderBy(s => s.Bakiye).ToList();

            var today = DateTime.Now;
            var soon = today.AddDays(30);

            var sooncahars = repo.GetCaharGelecekBorcAlacak(soon);
            var yalacak = from c in sooncahars
                          where c.Borc > 0 && c.Tip == "SATIS"
                          select new IncomigDepth
                          {
                              CariKod = c.CariKod,
                              Tutar = c.Borc - c.Alacak,
                              VadeTarihi = c.VadeTarihi,
                              OdemeSekli = c.OdemeSekli
                          };

            dgv_yalacak.DataSource = yalacak.ToList();

            var yborclar = from c in sooncahars
                           where c.Alacak > 0 && c.Tip != "SATIS"
                           select new IncomigDepth
                           {
                               CariKod = c.CariKod,
                               Tutar = c.Alacak - c.Borc,
                               VadeTarihi = c.VadeTarihi,
                               OdemeSekli = c.OdemeSekli
                           };

            dgv_yborclar.DataSource = yborclar.ToList();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var user = auth.GetUser();
            var now = DateTime.Now;
            if (user != null)
            {
                if (user.DateEnd < now)
                {
                    menuStrip.Enabled = false;
                    lbl_license.Text = "Lisans süreniz bitmiştir. Lütfen lisansınızı yenileyin";
                    lbl_license.Visible = true;
                }
                else if ((user.DateEnd - now).TotalDays <= 10)
                {
                    lbl_license.Text = "Lisans süreniz " + Math.Floor((user.DateEnd - now).TotalDays) + " gün sonra dolacaktır. Programı kullanmaya devam etmek için Lütfen lisansınızı yenileyin";
                    lbl_license.Visible = true;
                }
                if (user.Cpu != auth.getCPUID())
                {
                    menuStrip.Enabled = false;
                    lbl_license.Text = "Lisansınız geçerli değildir. Lütfen geçerli bir lisans satın alın.";
                    lbl_license.Visible = true;
                }
            }
            else
            {
                menuStrip.Enabled = false;
                lbl_license.Text = "Programda hata oluştu Lütfen aşağıdaki numara ile iletişime geçiniz.";
                lbl_license.Visible = true;
            }

        }

        private void stokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormStokAdd();
            form.Show();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormStokAdd();
            form.Show();
        }
    }
}
