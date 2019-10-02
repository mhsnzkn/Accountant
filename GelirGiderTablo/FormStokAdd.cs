﻿using GelirGiderTablo.Data;
using GelirGiderTablo.Models;
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
    public partial class FormStokAdd : Form
    {
        public FormStokAdd()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grp_gircik.Visible = !grp_gircik.Visible;
            grp_stokara.Visible = false;
        }

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grp_yenistok.Visible = !grp_yenistok.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grp_stokara.Visible = !grp_stokara.Visible;
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_stokkodu_yeni.Text))
            {
                var stok = repo.GetStok_stokkodu(txt_stokkodu_yeni.Text);
                if (string.IsNullOrEmpty(stok.StokKodu))
                {
                    var yenistok = new Stok()
                    {
                        StokKodu = txt_stokkodu_yeni.Text,
                        StokAdi = txt_stokadi_yeni.Text
                    };
                    var stokharbool = true;
                    if (!string.IsNullOrEmpty(txt_miktar_yeni.Text))
                    {
                        var miktar = Convert.ToDecimal(txt_miktar_yeni.Text);
                        if (miktar > 0)
                        {
                            var stokhar = new StokHar()
                            {
                                StokKodu = txt_stokadi_yeni.Text,
                                Giren = Convert.ToDecimal(txt_miktar_yeni.Text),
                                Cikan = 0
                            };
                            stokharbool = repo.AddStokHar(stokhar);
                        }
                    }
                    if (repo.AddStok(yenistok) && stokharbool)
                    {
                        MessageBox.Show("Başarıyla eklendi");
                    }
                    else MessageBox.Show("Eklemede hata oluştu!");
                }
                else
                {
                    MessageBox.Show("Stok Kodu daha öncekullanıldı");
                }


            }
            else
            {
                MessageBox.Show("Stok Kodu boş eklenemez!");
            }
        }

        private void btn_gircik_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_stokkodu.Text))
            {

                if (rdo_cikis.Checked || rdo_giris.Checked)
                {
                    var stok = repo.GetStok_stokkodu(txt_stokkodu.Text);
                    if (!string.IsNullOrEmpty(stok.StokKodu))
                    {
                        if (rdo_giris.Checked)
                        {
                            //if (txt_miktar.Text)
                            //{

                            //}
                            var stokhar = new StokHar();
                            stokhar.StokKodu = txt_stokkodu.Text;
                            stokhar.Giren = txt_miktar.Text.Length>0 ? Convert.ToDecimal(txt_miktar.Text) : 0;
                            stokhar.Cikan = 0;
                            stokhar.Tarih = DateTime.Now;

                            if (repo.AddStokHar(stokhar))
                                MessageBox.Show("Kayıt girildi");
                            else MessageBox.Show("Kayıt girilirken hata oldu");
                        }
                        if (rdo_cikis.Checked)
                        {
                            //if (txt_miktar.Text)
                            //{

                            //}
                            var stokhar = new StokHar();
                            stokhar.StokKodu = txt_stokkodu.Text;
                            stokhar.Cikan = txt_miktar.Text.Length > 0 ? Convert.ToDecimal(txt_miktar.Text) : 0;
                            stokhar.Giren = 0;
                            stokhar.Tarih = DateTime.Now;

                            if (repo.AddStokHar(stokhar))
                                MessageBox.Show("Kayıt girildi");
                            else MessageBox.Show("Kayıt girilirken hata oldu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen stok bulunamadı!");
                    }
                }
                else
                {
                    MessageBox.Show("Giriş veya Çıkış seçmelisiniz!");
                }
            }
            else
            {
                MessageBox.Show("Stok Kodunu girmelisiniz!");
            }
        }

        private void btn_stokara_Click(object sender, EventArgs e)
        {
            dgv_stokara.DataSource = repo.GetStok(txt_stokara.Text);
        }

        private void dgv_stokara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_stokara.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_stokara.CurrentRow.Selected = true;
                txt_stokkodu.Text = dgv_stokara.Rows[e.RowIndex].Cells["StokKodu"].FormattedValue.ToString();
            }
        }

        private void rdo_cikis_CheckedChanged(object sender, EventArgs e)
        {
            lbl_cikan.Visible = rdo_cikis.Checked;
            lbl_giren.Visible = rdo_giris.Checked;
        }
    }
}
