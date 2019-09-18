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
    public partial class FormUpdate : Form
    {
        private string _param;
        public FormUpdate(string searchParameter)
        {
            InitializeComponent();
            _param = searchParameter;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var caharlist = repo.GetCaharbyTip(_param);
            dgv_cahar.DataSource = caharlist;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_cahar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cahar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_cahar.CurrentRow.Selected = true;
                txt_carikod.Text = dgv_cahar.Rows[e.RowIndex].Cells["CariKod"].FormattedValue.ToString();
                dtp_tarih.Value = Convert.ToDateTime(dgv_cahar.Rows[e.RowIndex].Cells["Tarih"].FormattedValue);
                dtp_vadetarihi.Value = Convert.ToDateTime(dgv_cahar.Rows[e.RowIndex].Cells["VadeTarihi"].FormattedValue);
                txt_borc.Text = dgv_cahar.Rows[e.RowIndex].Cells["Borc"].FormattedValue.ToString();
                txt_alacak.Text = dgv_cahar.Rows[e.RowIndex].Cells["Alacak"].FormattedValue.ToString();
                cbx_paracinsi.Text= dgv_cahar.Rows[e.RowIndex].Cells["ParaCinsi"].FormattedValue.ToString();
                txt_odemesekli.Text = dgv_cahar.Rows[e.RowIndex].Cells["OdemeSekli"].FormattedValue.ToString();
                txt_birimfiyat.Text = dgv_cahar.Rows[e.RowIndex].Cells["BirimFiyat"].FormattedValue.ToString();
                txt_adet.Text = dgv_cahar.Rows[e.RowIndex].Cells["Adet"].FormattedValue.ToString();
                txt_aciklama.Text = dgv_cahar.Rows[e.RowIndex].Cells["Aciklama"].FormattedValue.ToString();
                lbl_id.Text= dgv_cahar.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                lbl_tip.Text= dgv_cahar.Rows[e.RowIndex].Cells["Tip"].FormattedValue.ToString();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_id.Text))
            {
                MessageBox.Show("Seçim yapmadınız!");

            }
            else
            {
                var confirmResult = MessageBox.Show("Düzenlemeyi onaylıyor musunuz?", "Emin misiniz?", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    var cahar = new Cahar()
                    {
                        Id = Convert.ToInt32(lbl_id.Text),
                        CariKod = txt_carikod.Text,
                        Aciklama = txt_aciklama.Text,
                        Adet = Convert.ToDecimal(txt_adet.Text),
                        BirimFiyat = Convert.ToDecimal(txt_birimfiyat.Text),
                        Alacak = Convert.ToDecimal(txt_alacak.Text),
                        Borc = Convert.ToDecimal(txt_borc.Text),
                        OdemeSekli = txt_odemesekli.Text,
                        ParaCinsi = cbx_paracinsi.Text,
                        Tarih = dtp_tarih.Value,
                        VadeTarihi = dtp_vadetarihi.Value,
                        Tip = lbl_tip.Text
                    };

                    if(repo.UpdateCahar(cahar))
                        MessageBox.Show("Başarıyla Güncellendi!");
                    else MessageBox.Show("Güncelleme Başarısız!");

                }
                else
                {
                    // If 'No', do something here.
                }
            }
            
        }
    }
}
