using GelirGiderTablo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GelirGiderTablo
{
    public partial class FormCahar : Form
    {
        public FormCahar()
        {
            InitializeComponent();
        }

        private void Btn_ara_Click(object sender, EventArgs e)
        {

            var cahar = repo.GetCahar();

            if (chck_satis.Checked || chck_odeme.Checked || chck_diger.Checked)
            {
                var templist = new List<Cahar>();
                if (chck_satis.Checked)
                {
                    templist.AddRange(cahar.Where(a => a.Tip == "SATIS").ToList());
                }
                if (chck_odeme.Checked)
                {
                    templist.AddRange(cahar.Where(a => a.Tip == "ODEME").ToList());
                }
                if (chck_diger.Checked)
                {
                    templist.AddRange(cahar.Where(a => a.Tip == "DIGER").ToList());
                }
                cahar = templist.OrderBy(s => s.Tarih).ToList();
            }



            if (!string.IsNullOrEmpty(txt_carikod.Text))
                cahar = cahar.Where(a => a.CariKod == txt_carikod.Text).ToList();

            if (chck_date.Checked)
            {
                cahar = cahar.Where(a => a.Tarih.Date >= dtp_from.Value.Date && a.Tarih.Date <= dtp_to.Value.Date).ToList();
            }
            else
            {
                if (chck_vadeli.Checked)
                {
                    cahar = cahar.Where(a => a.VadeTarihi.Date <= DateTime.Today).ToList();
                }

            }


            

            //satis
            var satis_tl = cahar.Where(s => s.ParaCinsi == "TL").Sum(a => a.Borc);
            var satis_do = cahar.Where(s => s.ParaCinsi == "DOLAR").Sum(a => a.Borc);
            var satis_eu = cahar.Where(s => s.ParaCinsi == "EURO").Sum(a => a.Borc);
            lbl_toplamsat_tl.Text = satis_tl.ToString("N");
            lbl_toplamsat_do.Text = satis_do.ToString("N");
            lbl_toplamsat_eu.Text = satis_eu.ToString("N");

            //Ödeme
            var odeme_tl = cahar.Where(s => s.ParaCinsi == "TL").Sum(a => a.Alacak);
            var odeme_do = cahar.Where(s => s.ParaCinsi == "DOLAR").Sum(a => a.Alacak);
            var odeme_eu = cahar.Where(s => s.ParaCinsi == "EURO").Sum(a => a.Alacak);
            lbl_toplamode_tl.Text = odeme_tl.ToString("N");
            lbl_toplamode_do.Text = odeme_do.ToString("N");
            lbl_toplamode_eu.Text = odeme_eu.ToString("N");

            //Genel toplam
            lbl_genel_tl.Text = (satis_tl - odeme_tl).ToString("N");
            lbl_genel_do.Text = (satis_do - odeme_do).ToString("N");
            lbl_genel_eu.Text = (satis_eu - odeme_eu).ToString("N");

            dgv_cahar.DataSource = cahar;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            grp_cari.Visible = !grp_cari.Visible;
            btn_carifind.BackColor = grp_cari.Visible ? System.Drawing.SystemColors.ButtonHighlight : System.Drawing.SystemColors.Control;
        }

        private void Btn_carisearch_Click(object sender, EventArgs e)
        {
            var cariler = repo.GetCariler(txt_carisearch.Text);

            dgv_cariler.DataSource = cariler;
        }

        private void Dgv_cariler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cariler.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_cariler.CurrentRow.Selected = true;
                txt_carikod.Text = dgv_cariler.Rows[e.RowIndex].Cells["CariKod"].FormattedValue.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chck_date_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_date.Checked)
            {
                dtp_from.Visible = true;
                dtp_to.Visible = true;

                //Vadeli
                chck_vadeli.Checked = false;
            }
            else
            {
                dtp_from.Visible = false;
                dtp_to.Visible = false;
            }
        }

    }
}
