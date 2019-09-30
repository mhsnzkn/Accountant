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


            

            //Satis
            var satis_tl = cahar.Where(s => s.ParaCinsi == "TL" && s.Tip=="SATIS").Sum(a => a.Alacak);
            var satis_do = cahar.Where(s => s.ParaCinsi == "DOLAR" && s.Tip == "SATIS").Sum(a => a.Alacak);
            var satis_eu = cahar.Where(s => s.ParaCinsi == "EURO" && s.Tip == "SATIS").Sum(a => a.Alacak);
            lbl_toplamsat_tl.Text = satis_tl.ToString("N");
            lbl_toplamsat_do.Text = satis_do.ToString("N");
            lbl_toplamsat_eu.Text = satis_eu.ToString("N");

            //Alacak
            var alacak_tl = cahar.Where(s => s.ParaCinsi == "TL" && s.Tip == "SATIS").Sum(a => a.Borc)-satis_tl;
            var alacak_do = cahar.Where(s => s.ParaCinsi == "DOLAR" && s.Tip == "SATIS").Sum(a => a.Borc)-satis_do;
            var alacak_eu = cahar.Where(s => s.ParaCinsi == "EURO" && s.Tip == "SATIS").Sum(a => a.Borc)-satis_eu;
            lbl_topalacak_tl.Text = alacak_tl.ToString("N");
            lbl_topalacak_do.Text = alacak_do.ToString("N");
            lbl_topalacak_eu.Text = alacak_eu.ToString("N");

            //Ödeme
            var odeme_tl = cahar.Where(s => s.ParaCinsi == "TL" && s.Tip != "SATIS").Sum(a => a.Borc);
            var odeme_do = cahar.Where(s => s.ParaCinsi == "DOLAR" && s.Tip != "SATIS").Sum(a => a.Borc);
            var odeme_eu = cahar.Where(s => s.ParaCinsi == "EURO" && s.Tip != "SATIS").Sum(a => a.Borc);
            lbl_toplamode_tl.Text = odeme_tl.ToString("N");
            lbl_toplamode_do.Text = odeme_do.ToString("N");
            lbl_toplamode_eu.Text = odeme_eu.ToString("N");

            //Borç
            var borc_tl = cahar.Where(s => s.ParaCinsi == "TL" && s.Tip != "SATIS").Sum(a => a.Alacak)-odeme_tl;
            var borc_do = cahar.Where(s => s.ParaCinsi == "DOLAR" && s.Tip != "SATIS").Sum(a => a.Alacak)-odeme_do;
            var borc_eu = cahar.Where(s => s.ParaCinsi == "EURO" && s.Tip != "SATIS").Sum(a => a.Alacak)-odeme_eu;
            lbl_topborc_tl.Text = borc_tl.ToString("N");
            lbl_topborc_do.Text = borc_do.ToString("N");
            lbl_topborc_eu.Text = borc_eu.ToString("N");

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
