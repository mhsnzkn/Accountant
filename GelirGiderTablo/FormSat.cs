﻿using GelirGiderTablo.Data;
using GelirGiderTablo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GelirGiderTablo
{
    public partial class FormSat : Form
    {
        public FormSat(string odemeturu)
        {
            InitializeComponent();
            cbx_para.Text = "TL";
            if (odemeturu == "odemeal")
            {
                //Vade tarihi
                lbl_vadetarihi.Visible = false;
                dtp_vade.Visible = false;
                //alınan tutar
                lbl_pay.Visible = false;
                txt_pay.Visible = false;
                //taksit
                lbl_taksit.Visible = false;
                txt_taksit.Visible = false;
                lbl_taksittarihi.Visible = false;
                //BirimFiyat/Adet
                lbl_qtt.Visible = false;
                lbl_unitprice.Visible = false;
                txt_unitprice.Visible = false;
                txt_qtt.Visible = false;
                //Satış türü
                rdo_nakit.Visible = false;
                rdo_taksit.Visible = false;
                rdo_vadeli.Visible = false;
                rdo_odemeal.Visible = true;
                rdo_odemeal.Checked = true;
                //Stok
                grp_stok.Visible = false;
            }
            else
            {
                var stoklist = repo.GetStok(null).ToArray();

                cbx_stok1.Items.AddRange(stoklist);
                cbx_stok1.DisplayMember = "StokAdi";
                cbx_stok1.ValueMember = "StokAdi";

                cbx_stok2.Items.AddRange(stoklist);
                cbx_stok2.DisplayMember = "StokAdi";
                cbx_stok2.ValueMember = "StokAdi";

                cbx_stok3.Items.AddRange(stoklist);
                cbx_stok3.DisplayMember = "StokAdi";
                cbx_stok3.ValueMember = "StokAdi";

                cbx_stok4.Items.AddRange(stoklist);
                cbx_stok4.DisplayMember = "StokAdi";
                cbx_stok4.ValueMember = "StokAdi";

                cbx_stok5.Items.AddRange(stoklist);
                cbx_stok5.DisplayMember = "StokAdi";
                cbx_stok5.ValueMember = "StokAdi";

                cbx_stok6.Items.AddRange(stoklist);
                cbx_stok6.DisplayMember = "StokAdi";
                cbx_stok6.ValueMember = "StokAdi";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_firm.Text))
            {
                MessageBox.Show("Cari girmediniz!");
            }
            else if(string.IsNullOrEmpty(cbx_para.Text))
            {
                MessageBox.Show("Para cinsini seçmediniz!");
            }
            else if (string.IsNullOrEmpty(txt_total.Text))
            {
                MessageBox.Show("Tutarı girmediniz!");
            }
            else
            {
                if (repo.GetCari_Kod(txt_firm.Text).CariKod != null)
                {
                    if (rdo_nakit.Checked || rdo_vadeli.Checked)
                    {
                        var insertmodel = new Cahar();

                        insertmodel.CariKod = txt_firm.Text;
                        insertmodel.Tarih = dtp_date.Value;
                        insertmodel.Aciklama = txt_desc.Text;
                        insertmodel.Borc = Methods.GetDecimal(txt_total);
                        insertmodel.Tip = "SATIS";
                        insertmodel.ParaCinsi = cbx_para.Text;
                        insertmodel.BirimFiyat = Methods.GetDecimal(txt_unitprice);
                        insertmodel.Adet = Methods.GetDecimal(txt_qtt);
                        if (rdo_vadeli.Checked)
                        {
                            insertmodel.VadeTarihi = dtp_vade.Value;
                            insertmodel.Alacak = Methods.GetDecimal(txt_pay);
                            insertmodel.OdemeSekli = "VADELI";
                        }
                        else if (rdo_nakit.Checked)
                        {
                            insertmodel.VadeTarihi = DateTime.Now;
                            insertmodel.Alacak = Methods.GetDecimal(txt_total);
                            insertmodel.OdemeSekli = "NAKIT";
                        }
                        var caharid = repo.AddCahar(insertmodel);

                        if (caharid>0)
                        {
                            
                            var stok1 = StokCikar(txt_stok1,cbx_stok1,caharid);
                            if (stok1 != null)
                                repo.AddStokHar(stok1);

                            var stok2 = StokCikar(txt_stok2, cbx_stok2, caharid);
                            if (stok2 != null)
                                repo.AddStokHar(stok2);

                            var stok3 = StokCikar(txt_stok3, cbx_stok3, caharid);
                            if (stok3 != null)
                                repo.AddStokHar(stok3);

                            var stok4 = StokCikar(txt_stok4, cbx_stok4, caharid);
                            if (stok4 != null)
                                repo.AddStokHar(stok4);

                            var stok5 = StokCikar(txt_stok5, cbx_stok5, caharid);
                            if (stok5 != null)
                                repo.AddStokHar(stok5);

                            var stok6 = StokCikar(txt_stok6, cbx_stok6, caharid);
                            if (stok6 != null)
                                repo.AddStokHar(stok6);


                            MessageBox.Show("Başarıyla Eklendi");
                            txt_desc.Clear();
                            txt_firm.Clear();
                            txt_pay.Clear();
                            txt_total.Clear();
                            txt_unitprice.Clear();
                            txt_qtt.Clear();
                            txt_desc.Clear();
                            txt_firm.Clear();
                            txt_pay.Clear();
                            txt_total.Clear();
                            dtp_vade.Value = DateTime.Now;
                            txt_unitprice.Clear();
                            txt_qtt.Clear();
                            txt_taksit.Clear();
                            cbx_stok1.ResetText();
                            cbx_stok2.Text = "";
                            cbx_stok3.Text = "";
                            cbx_stok4.Text = "";
                            cbx_stok5.Text = "";
                            cbx_stok6.Text = "";
                            txt_stok1.Clear();
                            txt_stok2.Clear();
                            txt_stok3.Clear();
                            txt_stok4.Clear();
                            txt_stok5.Clear();
                            txt_stok6.Clear();
                        }
                        else MessageBox.Show("Ekleme Başarısız! Girdiğiniz bilgileri kontrol ediniz.");
                    }
                    else if (rdo_taksit.Checked)
                    {
                        if (!string.IsNullOrEmpty(txt_taksit.Text))
                        {
                            var taksit = Methods.Getint(txt_taksit);
                            if (taksit > 0)
                            {
                                var taksittutar = Methods.GetDecimal(txt_total) / taksit;
                                var curdate = dtp_vade.Value;
                                bool result = true;
                                long caharid = 0;
                                for (int i = 1; i <= taksit; i++)
                                {
                                    var insertmodel = new Cahar();

                                    insertmodel.OdemeSekli = i + ". TAKSIT (" + taksit + ")";
                                    insertmodel.CariKod = txt_firm.Text;
                                    insertmodel.Tarih = dtp_date.Value;
                                    insertmodel.Aciklama = txt_desc.Text;
                                    insertmodel.Borc = taksittutar;
                                    insertmodel.Tip = "SATIS";
                                    insertmodel.ParaCinsi = cbx_para.Text;
                                    insertmodel.BirimFiyat = Methods.GetDecimal(txt_unitprice);
                                    insertmodel.Adet = Methods.GetDecimal(txt_qtt);
                                    if (i == 1)
                                        insertmodel.Alacak = Methods.GetDecimal(txt_pay);
                                    else insertmodel.Alacak = 0;
                                    insertmodel.VadeTarihi = curdate;
                                    curdate = curdate.AddMonths(1);
                                    if (i == 1)
                                    {
                                        caharid = repo.AddCahar(insertmodel);
                                        result = caharid > 0 ? true : false;
                                    }
                                    else
                                    {
                                        result = repo.AddCahar(insertmodel) > 0 ? true : false;
                                    }
                                        
                                }

                                if (result && caharid>0 )
                                {
                                    var stok1 = StokCikar(txt_stok1, cbx_stok1, caharid);
                                    if (stok1 != null)
                                        repo.AddStokHar(stok1);

                                    var stok2 = StokCikar(txt_stok2, cbx_stok2, caharid);
                                    if (stok2 != null)
                                        repo.AddStokHar(stok2);

                                    var stok3 = StokCikar(txt_stok3, cbx_stok3, caharid);
                                    if (stok3 != null)
                                        repo.AddStokHar(stok3);

                                    var stok4 = StokCikar(txt_stok4, cbx_stok4, caharid);
                                    if (stok4 != null)
                                        repo.AddStokHar(stok4);

                                    var stok5 = StokCikar(txt_stok5, cbx_stok5, caharid);
                                    if (stok5 != null)
                                        repo.AddStokHar(stok5);

                                    var stok6 = StokCikar(txt_stok6, cbx_stok6, caharid);
                                    if (stok6 != null)
                                        repo.AddStokHar(stok6);

                                    MessageBox.Show("Başarıyla Eklendi");
                                    txt_desc.Clear();
                                    txt_firm.Clear();
                                    txt_pay.Clear();
                                    txt_total.Clear();
                                    dtp_vade.Value = DateTime.Now;
                                    txt_unitprice.Clear();
                                    txt_qtt.Clear();
                                    txt_taksit.Clear();
                                    cbx_stok1.Text="";
                                    cbx_stok2.Text = "";
                                    cbx_stok3.Text = "";
                                    cbx_stok4.Text = "";
                                    cbx_stok5.Text = "";
                                    cbx_stok6.Text = "";
                                    txt_stok1.Clear();
                                    txt_stok2.Clear();
                                    txt_stok3.Clear();
                                    txt_stok4.Clear();
                                    txt_stok5.Clear();
                                    txt_stok6.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Bir hata oluştu");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Taksit sayısı hatalı");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Taksit sayısını giriniz.");
                        }

                    }else if (rdo_odemeal.Checked)
                    {
                        var insertmodel = new Cahar();

                        insertmodel.CariKod = txt_firm.Text;
                        insertmodel.Tarih = dtp_date.Value;
                        insertmodel.Aciklama = txt_desc.Text;
                        insertmodel.Borc = 0;
                        insertmodel.Tip = "SATIS";
                        insertmodel.ParaCinsi = cbx_para.Text;
                        //insertmodel.BirimFiyat = Methods.GetDecimal(txt_unitprice);
                        //insertmodel.Adet = Methods.GetDecimal(txt_qtt);
                        insertmodel.VadeTarihi = DateTime.Now;
                        insertmodel.Alacak = Methods.GetDecimal(txt_total);
                        insertmodel.OdemeSekli = "NAKIT";

                        if (repo.AddCahar(insertmodel)>0)
                        {
                            MessageBox.Show("Başarıyla Eklendi");
                            txt_desc.Clear();
                            txt_firm.Clear();
                            txt_total.Clear();
                        }
                        else MessageBox.Show("Ekleme Başarısız! Girdiğiniz bilgileri kontrol ediniz.");
                    }
                    else
                    {
                        MessageBox.Show("Satış türünü seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz cari kayıtlı değil. Lütfen Cari işlemler bölümünden kaydediniz!");
                }

                
            }
        }

        private StokHar StokCikar(TextBox txtbox,ComboBox cbox,long caharid)
        {
            var newstok = new StokHar();
            try
            {
                var miktar = Convert.ToDecimal(txtbox.Text);
                if (miktar > 0 && cbox.SelectedItem != null)
                {
                    Stok item = (Stok)cbox.SelectedItem;
                    newstok.StokKodu = item.StokKodu;
                    newstok.Cikan = miktar;
                    newstok.Giren = 0;
                    newstok.Aciklama = "SATIŞ";
                    newstok.Cahar = caharid;
                }
                else
                {
                    newstok = null;
                }
            }
            catch (Exception)
            {
                newstok = null;
            }
            return newstok;
        }

        private void Rdo_nakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_nakit.Checked)
            {
                //Vade tarihi
                lbl_vadetarihi.Visible = false;
                dtp_vade.Visible = false;
                //alınan tutar
                lbl_pay.Visible = false;
                txt_pay.Visible = false;
                //taksit
                lbl_taksit.Visible = false;
                txt_taksit.Visible = false;
                lbl_taksittarihi.Visible = false;
            }
            else if (rdo_vadeli.Checked)
            {
                //Vade tarihi
                lbl_vadetarihi.Visible = true;
                dtp_vade.Visible = true;
                //alınan tutar
                lbl_pay.Visible = true;
                txt_pay.Visible = true;
                //taksit
                lbl_taksit.Visible = false;
                txt_taksit.Visible = false;
                lbl_taksittarihi.Visible = false;
            }
            else if (rdo_taksit.Checked)
            {
                //Vade tarihi
                lbl_vadetarihi.Visible = false;
                dtp_vade.Visible = true;
                //alınan tutar
                lbl_pay.Visible = true;
                txt_pay.Visible = true;
                //taksit
                lbl_taksit.Visible = true;
                txt_taksit.Visible = true;
                lbl_taksittarihi.Visible = true;
            }
        }

        private void Txt_total_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_unitprice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_unitprice.Text.Length > 0 && txt_qtt.Text.Length > 0)
            {
                var unt_p = Convert.ToDecimal(txt_unitprice.Text);
                var qtt = Convert.ToDecimal(txt_qtt.Text);
                txt_total.Text = (unt_p * qtt).ToString("N");
            }
        }


        private void Txt_taksit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            grp_cari.Visible = !grp_cari.Visible;
            button3.BackColor = grp_cari.Visible ? System.Drawing.SystemColors.ButtonHighlight : System.Drawing.SystemColors.Control;
            var cariler = repo.GetCariler(txt_carisearch.Text);
            dgv_cariler.DataSource = cariler;
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
                txt_firm.Text = dgv_cariler.Rows[e.RowIndex].Cells["CariKod"].FormattedValue.ToString();
            }
        }
    }

}