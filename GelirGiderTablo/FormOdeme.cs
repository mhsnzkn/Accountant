using GelirGiderTablo.Data;
using System;
using System.Windows.Forms;

namespace GelirGiderTablo
{
    public partial class FormOdeme : Form
    {
        public FormOdeme(string odemeturu)
        {
            InitializeComponent();
            if (odemeturu=="odemeyap")
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
                rdo_odemeyap.Visible = true;
                rdo_odemeyap.Checked = true;
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


        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_firm.Text))
            {
                MessageBox.Show("İsim veya Cari girmediniz!");
            }
            else if (string.IsNullOrEmpty(cbx_para.Text))
            {
                MessageBox.Show("Para cinsini seçmediniz!");
            }
            else if (string.IsNullOrEmpty(txt_total.Text))
            {
                MessageBox.Show("Tutarı girmediniz!");
            }
            else if (!rdo_odeme.Checked && !rdo_diger.Checked)
            {
                MessageBox.Show("Gider türünü seçmediniz!");
            }
            else if (!rdo_nakit.Checked && !rdo_vadeli.Checked && !rdo_taksit.Checked)
            {
                MessageBox.Show("Ödeme türünü seçmediniz!");
            }
            else 
            {
                if (repo.GetCari_Kod(txt_firm.Text).CariKod != null)
                {
                    var tip = rdo_odeme.Checked ? "ODEME" : "DIGER";
                    if (rdo_nakit.Checked || rdo_vadeli.Checked)
                    {
                        var insertmodel = new Cahar();

                        insertmodel.CariKod = txt_firm.Text;
                        insertmodel.Tarih = dtp_date.Value;
                        insertmodel.Aciklama = txt_desc.Text;
                        insertmodel.Alacak = Methods.GetDecimal(txt_total);
                        insertmodel.Tip = tip;
                        insertmodel.ParaCinsi = cbx_para.Text;
                        insertmodel.BirimFiyat = Methods.GetDecimal(txt_unitprice);
                        insertmodel.Adet = Methods.GetDecimal(txt_qtt);
                        if (rdo_vadeli.Checked)
                        {
                            insertmodel.VadeTarihi = dtp_vade.Value;
                            insertmodel.Borc = Methods.GetDecimal(txt_pay);
                            insertmodel.OdemeSekli = "VADELI";
                        }
                        else if (rdo_nakit.Checked)
                        {
                            insertmodel.VadeTarihi = DateTime.Now;
                            insertmodel.Borc = Methods.GetDecimal(txt_total);
                            insertmodel.OdemeSekli = "NAKIT";
                        }

                        if (repo.AddCahar(insertmodel))
                        {
                            MessageBox.Show("Başarıyla Eklendi");
                            txt_desc.Clear();
                            txt_firm.Clear();
                            txt_pay.Clear();
                            txt_total.Clear();
                            dtp_vade.Value = DateTime.Now;
                            txt_unitprice.Clear();
                            txt_qtt.Clear();
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
                                for (int i = 1; i <= taksit; i++)
                                {
                                    var insertmodel = new Cahar();

                                    insertmodel.OdemeSekli = i + ". TAKSİT (" + taksit + ")";
                                    insertmodel.CariKod = txt_firm.Text;
                                    insertmodel.Tarih = dtp_date.Value;
                                    insertmodel.Aciklama = txt_desc.Text;
                                    insertmodel.Alacak = taksittutar;
                                    insertmodel.Tip = tip;
                                    insertmodel.ParaCinsi = cbx_para.Text;
                                    insertmodel.BirimFiyat = Methods.GetDecimal(txt_unitprice);
                                    insertmodel.Adet = Methods.GetDecimal(txt_qtt);
                                    if (i == 1)
                                        insertmodel.Borc = Methods.GetDecimal(txt_pay);
                                    else insertmodel.Borc = 0;
                                    insertmodel.VadeTarihi = curdate;
                                    curdate = curdate.AddMonths(1);

                                    result = repo.AddCahar(insertmodel);

                                }
                                if (result)
                                {
                                    MessageBox.Show("Başarıyla Eklendi");
                                    txt_desc.Clear();
                                    txt_firm.Clear();
                                    txt_pay.Clear();
                                    txt_total.Clear();
                                    dtp_vade.Value = DateTime.Now;
                                    txt_unitprice.Clear();
                                    txt_qtt.Clear();
                                    txt_taksit.Clear();
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


        private void Txt_taksit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
                dtp_vade.Visible = false;
                //alınan tutar
                lbl_pay.Visible = true;
                txt_pay.Visible = true;
                //taksit
                lbl_taksit.Visible = true;
                txt_taksit.Visible = true;
                lbl_taksittarihi.Visible = true;
            }
        }

        private void Btn_carisearch_Click(object sender, EventArgs e)
        {
            var cariler = repo.GetCariler(txt_carisearch.Text);

            dgv_cariler.DataSource = cariler;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            grp_cari.Visible = !grp_cari.Visible;
            button3.BackColor = grp_cari.Visible ? System.Drawing.SystemColors.ButtonHighlight : System.Drawing.SystemColors.Control;
        }

        private void Dgv_cariler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_cariler.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_cariler.CurrentRow.Selected = true;
                txt_firm.Text = dgv_cariler.Rows[e.RowIndex].Cells["CariKod"].FormattedValue.ToString();
            }
        }

        private void Grp_cari_Enter(object sender, EventArgs e)
        {

        }
    }
}
