namespace GelirGiderTablo
{
    partial class FormCahar
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
            this.txt_carikod = new System.Windows.Forms.TextBox();
            this.lbl_carikod = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.grp_cari = new System.Windows.Forms.GroupBox();
            this.dgv_cariler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_carisearch = new System.Windows.Forms.Button();
            this.txt_carisearch = new System.Windows.Forms.TextBox();
            this.btn_carifind = new System.Windows.Forms.Button();
            this.dgv_cahar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_toplamsat_tl = new System.Windows.Forms.Label();
            this.lbl_toplamsat_do = new System.Windows.Forms.Label();
            this.lbl_toplamsat_eu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_toplamode_eu = new System.Windows.Forms.Label();
            this.lbl_toplamode_do = new System.Windows.Forms.Label();
            this.lbl_toplamode_tl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_genel_eu = new System.Windows.Forms.Label();
            this.lbl_genel_do = new System.Windows.Forms.Label();
            this.lbl_genel_tl = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.chck_date = new System.Windows.Forms.CheckBox();
            this.chck_vadeli = new System.Windows.Forms.CheckBox();
            this.chck_satis = new System.Windows.Forms.CheckBox();
            this.chck_odeme = new System.Windows.Forms.CheckBox();
            this.chck_diger = new System.Windows.Forms.CheckBox();
            this.grp_cari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cahar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_carikod
            // 
            this.txt_carikod.Location = new System.Drawing.Point(500, 43);
            this.txt_carikod.Name = "txt_carikod";
            this.txt_carikod.Size = new System.Drawing.Size(131, 26);
            this.txt_carikod.TabIndex = 0;
            // 
            // lbl_carikod
            // 
            this.lbl_carikod.AutoSize = true;
            this.lbl_carikod.Location = new System.Drawing.Point(500, 14);
            this.lbl_carikod.Name = "lbl_carikod";
            this.lbl_carikod.Size = new System.Drawing.Size(82, 20);
            this.lbl_carikod.TabIndex = 1;
            this.lbl_carikod.Text = "Cari Kodu ";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(1048, 43);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(123, 60);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "Getir";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.Btn_ara_Click);
            // 
            // grp_cari
            // 
            this.grp_cari.Controls.Add(this.dgv_cariler);
            this.grp_cari.Controls.Add(this.label2);
            this.grp_cari.Controls.Add(this.btn_carisearch);
            this.grp_cari.Controls.Add(this.txt_carisearch);
            this.grp_cari.Location = new System.Drawing.Point(345, 110);
            this.grp_cari.Name = "grp_cari";
            this.grp_cari.Size = new System.Drawing.Size(715, 349);
            this.grp_cari.TabIndex = 83;
            this.grp_cari.TabStop = false;
            this.grp_cari.Text = "Cari Bul";
            this.grp_cari.Visible = false;
            // 
            // dgv_cariler
            // 
            this.dgv_cariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cariler.Location = new System.Drawing.Point(32, 74);
            this.dgv_cariler.Name = "dgv_cariler";
            this.dgv_cariler.Size = new System.Drawing.Size(657, 251);
            this.dgv_cariler.TabIndex = 3;
            this.dgv_cariler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_cariler_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Kodu veya Adı";
            // 
            // btn_carisearch
            // 
            this.btn_carisearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carisearch.Location = new System.Drawing.Point(284, 32);
            this.btn_carisearch.Name = "btn_carisearch";
            this.btn_carisearch.Size = new System.Drawing.Size(81, 23);
            this.btn_carisearch.TabIndex = 1;
            this.btn_carisearch.Text = "Ara";
            this.btn_carisearch.UseVisualStyleBackColor = true;
            this.btn_carisearch.Click += new System.EventHandler(this.Btn_carisearch_Click);
            // 
            // txt_carisearch
            // 
            this.txt_carisearch.Location = new System.Drawing.Point(165, 30);
            this.txt_carisearch.Name = "txt_carisearch";
            this.txt_carisearch.Size = new System.Drawing.Size(100, 26);
            this.txt_carisearch.TabIndex = 0;
            // 
            // btn_carifind
            // 
            this.btn_carifind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carifind.Location = new System.Drawing.Point(500, 79);
            this.btn_carifind.Name = "btn_carifind";
            this.btn_carifind.Size = new System.Drawing.Size(75, 26);
            this.btn_carifind.TabIndex = 82;
            this.btn_carifind.Text = "Bul";
            this.btn_carifind.UseVisualStyleBackColor = true;
            this.btn_carifind.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dgv_cahar
            // 
            this.dgv_cahar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cahar.Location = new System.Drawing.Point(12, 109);
            this.dgv_cahar.Name = "dgv_cahar";
            this.dgv_cahar.RowHeadersVisible = false;
            this.dgv_cahar.Size = new System.Drawing.Size(1159, 408);
            this.dgv_cahar.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(283, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "Toplam Gelir";
            // 
            // lbl_toplamsat_tl
            // 
            this.lbl_toplamsat_tl.AutoSize = true;
            this.lbl_toplamsat_tl.Location = new System.Drawing.Point(325, 575);
            this.lbl_toplamsat_tl.Name = "lbl_toplamsat_tl";
            this.lbl_toplamsat_tl.Size = new System.Drawing.Size(40, 20);
            this.lbl_toplamsat_tl.TabIndex = 86;
            this.lbl_toplamsat_tl.Text = "0,00";
            // 
            // lbl_toplamsat_do
            // 
            this.lbl_toplamsat_do.AutoSize = true;
            this.lbl_toplamsat_do.Location = new System.Drawing.Point(325, 606);
            this.lbl_toplamsat_do.Name = "lbl_toplamsat_do";
            this.lbl_toplamsat_do.Size = new System.Drawing.Size(40, 20);
            this.lbl_toplamsat_do.TabIndex = 87;
            this.lbl_toplamsat_do.Text = "0,00";
            // 
            // lbl_toplamsat_eu
            // 
            this.lbl_toplamsat_eu.AutoSize = true;
            this.lbl_toplamsat_eu.Location = new System.Drawing.Point(325, 636);
            this.lbl_toplamsat_eu.Name = "lbl_toplamsat_eu";
            this.lbl_toplamsat_eu.Size = new System.Drawing.Size(40, 20);
            this.lbl_toplamsat_eu.TabIndex = 88;
            this.lbl_toplamsat_eu.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 635);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 91;
            this.label7.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 90;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "₺";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(539, 635);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 98;
            this.label10.Text = "€";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(539, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 574);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 96;
            this.label12.Text = "₺";
            // 
            // lbl_toplamode_eu
            // 
            this.lbl_toplamode_eu.AutoSize = true;
            this.lbl_toplamode_eu.Location = new System.Drawing.Point(565, 636);
            this.lbl_toplamode_eu.Name = "lbl_toplamode_eu";
            this.lbl_toplamode_eu.Size = new System.Drawing.Size(40, 20);
            this.lbl_toplamode_eu.TabIndex = 95;
            this.lbl_toplamode_eu.Text = "0,00";
            // 
            // lbl_toplamode_do
            // 
            this.lbl_toplamode_do.AutoSize = true;
            this.lbl_toplamode_do.Location = new System.Drawing.Point(565, 606);
            this.lbl_toplamode_do.Name = "lbl_toplamode_do";
            this.lbl_toplamode_do.Size = new System.Drawing.Size(40, 20);
            this.lbl_toplamode_do.TabIndex = 94;
            this.lbl_toplamode_do.Text = "0,00";
            // 
            // lbl_toplamode_tl
            // 
            this.lbl_toplamode_tl.AutoSize = true;
            this.lbl_toplamode_tl.Location = new System.Drawing.Point(565, 575);
            this.lbl_toplamode_tl.Name = "lbl_toplamode_tl";
            this.lbl_toplamode_tl.Size = new System.Drawing.Size(40, 20);
            this.lbl_toplamode_tl.TabIndex = 93;
            this.lbl_toplamode_tl.Text = "0,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(514, 535);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 22);
            this.label16.TabIndex = 92;
            this.label16.Text = "Toplam Gider";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(777, 635);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 20);
            this.label17.TabIndex = 105;
            this.label17.Text = "€";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(777, 605);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 20);
            this.label18.TabIndex = 104;
            this.label18.Text = "$";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(777, 574);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 20);
            this.label19.TabIndex = 103;
            this.label19.Text = "₺";
            // 
            // lbl_genel_eu
            // 
            this.lbl_genel_eu.AutoSize = true;
            this.lbl_genel_eu.Location = new System.Drawing.Point(803, 636);
            this.lbl_genel_eu.Name = "lbl_genel_eu";
            this.lbl_genel_eu.Size = new System.Drawing.Size(40, 20);
            this.lbl_genel_eu.TabIndex = 102;
            this.lbl_genel_eu.Text = "0,00";
            // 
            // lbl_genel_do
            // 
            this.lbl_genel_do.AutoSize = true;
            this.lbl_genel_do.Location = new System.Drawing.Point(803, 606);
            this.lbl_genel_do.Name = "lbl_genel_do";
            this.lbl_genel_do.Size = new System.Drawing.Size(40, 20);
            this.lbl_genel_do.TabIndex = 101;
            this.lbl_genel_do.Text = "0,00";
            // 
            // lbl_genel_tl
            // 
            this.lbl_genel_tl.AutoSize = true;
            this.lbl_genel_tl.Location = new System.Drawing.Point(803, 575);
            this.lbl_genel_tl.Name = "lbl_genel_tl";
            this.lbl_genel_tl.Size = new System.Drawing.Size(40, 20);
            this.lbl_genel_tl.TabIndex = 100;
            this.lbl_genel_tl.Text = "0,00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(764, 535);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 22);
            this.label23.TabIndex = 99;
            this.label23.Text = "Genel Toplam";
            // 
            // dtp_from
            // 
            this.dtp_from.Checked = false;
            this.dtp_from.Location = new System.Drawing.Point(737, 43);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 26);
            this.dtp_from.TabIndex = 112;
            this.dtp_from.Visible = false;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(737, 75);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 26);
            this.dtp_to.TabIndex = 113;
            this.dtp_to.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1048, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 60);
            this.button1.TabIndex = 114;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // chck_date
            // 
            this.chck_date.AutoSize = true;
            this.chck_date.Location = new System.Drawing.Point(780, 10);
            this.chck_date.Name = "chck_date";
            this.chck_date.Size = new System.Drawing.Size(110, 24);
            this.chck_date.TabIndex = 115;
            this.chck_date.Text = "Tarih Aralığı";
            this.chck_date.UseVisualStyleBackColor = true;
            this.chck_date.CheckedChanged += new System.EventHandler(this.Chck_date_CheckedChanged);
            // 
            // chck_vadeli
            // 
            this.chck_vadeli.AutoSize = true;
            this.chck_vadeli.Location = new System.Drawing.Point(50, 20);
            this.chck_vadeli.Name = "chck_vadeli";
            this.chck_vadeli.Size = new System.Drawing.Size(135, 24);
            this.chck_vadeli.TabIndex = 117;
            this.chck_vadeli.Text = "Vadeli Hesapla";
            this.chck_vadeli.UseVisualStyleBackColor = true;
            // 
            // chck_satis
            // 
            this.chck_satis.AutoSize = true;
            this.chck_satis.Location = new System.Drawing.Point(220, 19);
            this.chck_satis.Name = "chck_satis";
            this.chck_satis.Size = new System.Drawing.Size(81, 24);
            this.chck_satis.TabIndex = 118;
            this.chck_satis.Text = "Satışlar";
            this.chck_satis.UseVisualStyleBackColor = true;
            // 
            // chck_odeme
            // 
            this.chck_odeme.AutoSize = true;
            this.chck_odeme.Location = new System.Drawing.Point(220, 47);
            this.chck_odeme.Name = "chck_odeme";
            this.chck_odeme.Size = new System.Drawing.Size(97, 24);
            this.chck_odeme.TabIndex = 119;
            this.chck_odeme.Text = "Ödemeler";
            this.chck_odeme.UseVisualStyleBackColor = true;
            // 
            // chck_diger
            // 
            this.chck_diger.AutoSize = true;
            this.chck_diger.Location = new System.Drawing.Point(220, 75);
            this.chck_diger.Name = "chck_diger";
            this.chck_diger.Size = new System.Drawing.Size(66, 24);
            this.chck_diger.TabIndex = 120;
            this.chck_diger.Text = "Diğer";
            this.chck_diger.UseVisualStyleBackColor = true;
            // 
            // FormCahar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.chck_diger);
            this.Controls.Add(this.chck_odeme);
            this.Controls.Add(this.chck_satis);
            this.Controls.Add(this.chck_vadeli);
            this.Controls.Add(this.chck_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl_genel_eu);
            this.Controls.Add(this.lbl_genel_do);
            this.Controls.Add(this.lbl_genel_tl);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_toplamode_eu);
            this.Controls.Add(this.lbl_toplamode_do);
            this.Controls.Add(this.lbl_toplamode_tl);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_toplamsat_eu);
            this.Controls.Add(this.lbl_toplamsat_do);
            this.Controls.Add(this.lbl_toplamsat_tl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grp_cari);
            this.Controls.Add(this.btn_carifind);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.lbl_carikod);
            this.Controls.Add(this.txt_carikod);
            this.Controls.Add(this.dgv_cahar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCahar";
            this.Text = "Cari Hareketler";
            this.grp_cari.ResumeLayout(false);
            this.grp_cari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cahar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_carikod;
        private System.Windows.Forms.Label lbl_carikod;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.GroupBox grp_cari;
        private System.Windows.Forms.DataGridView dgv_cariler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_carisearch;
        private System.Windows.Forms.TextBox txt_carisearch;
        private System.Windows.Forms.Button btn_carifind;
        private System.Windows.Forms.DataGridView dgv_cahar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_toplamsat_tl;
        private System.Windows.Forms.Label lbl_toplamsat_do;
        private System.Windows.Forms.Label lbl_toplamsat_eu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_toplamode_eu;
        private System.Windows.Forms.Label lbl_toplamode_do;
        private System.Windows.Forms.Label lbl_toplamode_tl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_genel_eu;
        private System.Windows.Forms.Label lbl_genel_do;
        private System.Windows.Forms.Label lbl_genel_tl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chck_date;
        private System.Windows.Forms.CheckBox chck_vadeli;
        private System.Windows.Forms.CheckBox chck_satis;
        private System.Windows.Forms.CheckBox chck_odeme;
        private System.Windows.Forms.CheckBox chck_diger;
    }
}