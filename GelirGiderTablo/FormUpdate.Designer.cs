﻿namespace GelirGiderTablo
{
    partial class FormUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_cahar = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_carikod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_odemesekli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_alacak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_borc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_birimfiyat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.RichTextBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.dtp_vadetarihi = new System.Windows.Forms.DateTimePicker();
            this.cbx_paracinsi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cahar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cahar
            // 
            this.dgv_cahar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cahar.Location = new System.Drawing.Point(12, 103);
            this.dgv_cahar.Name = "dgv_cahar";
            this.dgv_cahar.RowHeadersVisible = false;
            this.dgv_cahar.Size = new System.Drawing.Size(1176, 269);
            this.dgv_cahar.TabIndex = 0;
            this.dgv_cahar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_cahar_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1028, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 64);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Ara";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cari Kod";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1068, 616);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 64);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Geri Dön";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // txt_carikod
            // 
            this.txt_carikod.Location = new System.Drawing.Point(35, 53);
            this.txt_carikod.Name = "txt_carikod";
            this.txt_carikod.Size = new System.Drawing.Size(200, 26);
            this.txt_carikod.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vade Tarihi";
            // 
            // txt_odemesekli
            // 
            this.txt_odemesekli.Location = new System.Drawing.Point(362, 265);
            this.txt_odemesekli.Name = "txt_odemesekli";
            this.txt_odemesekli.Size = new System.Drawing.Size(151, 26);
            this.txt_odemesekli.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Para Cinsi";
            // 
            // txt_alacak
            // 
            this.txt_alacak.Location = new System.Drawing.Point(362, 124);
            this.txt_alacak.Name = "txt_alacak";
            this.txt_alacak.Size = new System.Drawing.Size(151, 26);
            this.txt_alacak.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Alacak";
            // 
            // txt_borc
            // 
            this.txt_borc.Location = new System.Drawing.Point(362, 53);
            this.txt_borc.Name = "txt_borc";
            this.txt_borc.Size = new System.Drawing.Size(151, 26);
            this.txt_borc.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Borç";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Odeme Şekli";
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(662, 124);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(151, 26);
            this.txt_adet.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(714, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Adet";
            // 
            // txt_birimfiyat
            // 
            this.txt_birimfiyat.Location = new System.Drawing.Point(662, 53);
            this.txt_birimfiyat.Name = "txt_birimfiyat";
            this.txt_birimfiyat.Size = new System.Drawing.Size(151, 26);
            this.txt_birimfiyat.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(699, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Birim Fiyat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(699, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Açıklama";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(662, 194);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(151, 96);
            this.txt_aciklama.TabIndex = 45;
            this.txt_aciklama.Text = "";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(35, 124);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(200, 26);
            this.dtp_tarih.TabIndex = 46;
            // 
            // dtp_vadetarihi
            // 
            this.dtp_vadetarihi.Location = new System.Drawing.Point(35, 192);
            this.dtp_vadetarihi.Name = "dtp_vadetarihi";
            this.dtp_vadetarihi.Size = new System.Drawing.Size(200, 26);
            this.dtp_vadetarihi.TabIndex = 47;
            // 
            // cbx_paracinsi
            // 
            this.cbx_paracinsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_paracinsi.FormattingEnabled = true;
            this.cbx_paracinsi.Items.AddRange(new object[] {
            "TL",
            "DOLAR",
            "EURO"});
            this.cbx_paracinsi.Location = new System.Drawing.Point(362, 190);
            this.cbx_paracinsi.Name = "cbx_paracinsi";
            this.cbx_paracinsi.Size = new System.Drawing.Size(151, 28);
            this.cbx_paracinsi.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 64);
            this.button1.TabIndex = 49;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tip);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_paracinsi);
            this.groupBox1.Controls.Add(this.txt_carikod);
            this.groupBox1.Controls.Add(this.dtp_vadetarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_tarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_aciklama);
            this.groupBox1.Controls.Add(this.txt_borc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_alacak);
            this.groupBox1.Controls.Add(this.txt_adet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_odemesekli);
            this.groupBox1.Controls.Add(this.txt_birimfiyat);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(16, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 306);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Düzenle";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(101, 242);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_id.TabIndex = 50;
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(146, 242);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(0, 20);
            this.lbl_tip.TabIndex = 51;
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_cahar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUpdate";
            this.Text = "Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cahar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cahar;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_carikod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_odemesekli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_alacak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_borc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_birimfiyat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txt_aciklama;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.DateTimePicker dtp_vadetarihi;
        private System.Windows.Forms.ComboBox cbx_paracinsi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_tip;
    }
}