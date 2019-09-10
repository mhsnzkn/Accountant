using GelirGiderTablo.Data;
using System;
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
            var cahar = repo.GetCahar_Carikod(txt_firm.Text);

            dgv_cahar.DataSource = cahar;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            grp_cari.Visible = !grp_cari.Visible;
            button3.BackColor = grp_cari.Visible ? System.Drawing.SystemColors.ButtonHighlight : System.Drawing.SystemColors.Control;
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
