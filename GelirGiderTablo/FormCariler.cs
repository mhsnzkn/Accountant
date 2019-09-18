using GelirGiderTablo.Data;
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
    public partial class FormCariler : Form
    {
        public FormCariler()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            grp_ekle.Visible = !(grp_ekle.Visible);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var cari = new Cari()
            {
                Ad = txt_ad.Text,
                Adres = txt_adres.Text,
                Email = txt_email.Text,
                Il = txt_il.Text,
                Ilce = txt_ilce.Text,
                Telefon = txt_tel.Text,
                CariKod=txt_carikod.Text
            };
            var cariExist = repo.GetCari_Kod(txt_carikod.Text);
            if (cariExist.CariKod == null)
            {
                if (repo.AddCari(cari))
                {
                    MessageBox.Show("Cari Eklendi!");
                    grp_ekle.Visible = false;
                }
                else
                {
                    MessageBox.Show("Cari eklerken hata oldu!");
                }
            }
            else
            {
                MessageBox.Show("Cari Kodu kullanılıyor. Başka bir kod girin!");
            }

            
        }

        private void Btn_src_Click(object sender, EventArgs e)
        {
            
            var cariler = repo.GetCariler(txt_src.Text);

            dataGridView1.DataSource = cariler;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_carikod_up.Text))
            {
                MessageBox.Show("Cari Kodu giriniz!");
            }
            else
            {
                var cari=repo.GetCari_Kod(txt_carikod_up.Text);
                if (cari.CariKod != null)
                {
                    txt_adres_up.Text = cari.Adres;
                    txt_ad_up.Text = cari.Ad;
                    txt_email_up.Text = cari.Email;
                    txt_il_up.Text = cari.Il;
                    txt_ilce_up.Text = cari.Ilce;
                    txt_tel_up.Text = cari.Telefon;
                    btn_update_ok.Enabled = true;
                }
                else
                {
                    txt_adres_up.Clear();
                    txt_ad_up.Clear();
                    txt_email_up.Clear();
                    txt_il_up.Clear();
                    txt_ilce_up.Clear();
                    txt_tel_up.Clear();
                    btn_update_ok.Enabled = false;
                    MessageBox.Show("Cari bulunamadı!");
                }
                
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            grp_update.Visible = !(grp_update.Visible);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var cari=repo.GetCari_Kod(txt_carikod_up.Text);
            if (cari.CariKod == null)
            {
                MessageBox.Show("Cari Kodu bulunamadı");
            }
            else
            {
                var newcari = new Cari()
                {
                    CariKod = txt_carikod_up.Text,
                    Ad = txt_ad_up.Text,
                    Adres = txt_adres_up.Text,
                    Email = txt_email_up.Text,
                    Il = txt_il_up.Text,
                    Ilce = txt_ilce_up.Text,
                    Telefon = txt_tel_up.Text
                };
                if (repo.UpdateCari(newcari))
                {
                    MessageBox.Show("Cari Güncellendi");
                    txt_adres_up.Clear();
                    txt_ad_up.Clear();
                    txt_email_up.Clear();
                    txt_il_up.Clear();
                    txt_ilce_up.Clear();
                    txt_tel_up.Clear();
                    btn_update_ok.Enabled = false;
                    grp_update.Visible = false;
                }
            }


        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
