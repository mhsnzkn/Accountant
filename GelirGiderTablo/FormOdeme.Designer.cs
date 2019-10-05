namespace GelirGiderTablo
{
    partial class FormOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdeme));
            this.cbx_para = new System.Windows.Forms.ComboBox();
            this.lbl_vadetarihi = new System.Windows.Forms.Label();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.lbl_pay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_firm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_unitprice = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.lbl_qtt = new System.Windows.Forms.Label();
            this.txt_qtt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_diger = new System.Windows.Forms.RadioButton();
            this.rdo_odeme = new System.Windows.Forms.RadioButton();
            this.grp_pay = new System.Windows.Forms.GroupBox();
            this.rdo_odemeyap = new System.Windows.Forms.RadioButton();
            this.lbl_taksit = new System.Windows.Forms.Label();
            this.txt_taksit = new System.Windows.Forms.TextBox();
            this.rdo_taksit = new System.Windows.Forms.RadioButton();
            this.rdo_vadeli = new System.Windows.Forms.RadioButton();
            this.rdo_nakit = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.grp_cari = new System.Windows.Forms.GroupBox();
            this.dgv_cariler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_carisearch = new System.Windows.Forms.Button();
            this.txt_carisearch = new System.Windows.Forms.TextBox();
            this.dtp_vade = new System.Windows.Forms.DateTimePicker();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_taksittarihi = new System.Windows.Forms.Label();
            this.grp_stok = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_stok6 = new System.Windows.Forms.TextBox();
            this.cbx_stok6 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_stok5 = new System.Windows.Forms.TextBox();
            this.cbx_stok5 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_stok4 = new System.Windows.Forms.TextBox();
            this.cbx_stok4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_stok3 = new System.Windows.Forms.TextBox();
            this.cbx_stok3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_stok2 = new System.Windows.Forms.TextBox();
            this.cbx_stok2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_stok1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_stok1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grp_pay.SuspendLayout();
            this.grp_cari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cariler)).BeginInit();
            this.grp_stok.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_para
            // 
            this.cbx_para.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_para.FormattingEnabled = true;
            this.cbx_para.Items.AddRange(new object[] {
            "TL",
            "DOLAR",
            "EURO"});
            this.cbx_para.Location = new System.Drawing.Point(350, 234);
            this.cbx_para.Name = "cbx_para";
            this.cbx_para.Size = new System.Drawing.Size(75, 28);
            this.cbx_para.TabIndex = 9;
            // 
            // lbl_vadetarihi
            // 
            this.lbl_vadetarihi.AutoSize = true;
            this.lbl_vadetarihi.Location = new System.Drawing.Point(71, 110);
            this.lbl_vadetarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vadetarihi.Name = "lbl_vadetarihi";
            this.lbl_vadetarihi.Size = new System.Drawing.Size(89, 20);
            this.lbl_vadetarihi.TabIndex = 66;
            this.lbl_vadetarihi.Text = "Vade Tarihi";
            this.lbl_vadetarihi.Visible = false;
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(184, 277);
            this.txt_pay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(148, 26);
            this.txt_pay.TabIndex = 7;
            this.txt_pay.Visible = false;
            this.txt_pay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_total_KeyPress);
            // 
            // lbl_pay
            // 
            this.lbl_pay.AutoSize = true;
            this.lbl_pay.Location = new System.Drawing.Point(70, 281);
            this.lbl_pay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pay.Name = "lbl_pay";
            this.lbl_pay.Size = new System.Drawing.Size(99, 20);
            this.lbl_pay.TabIndex = 64;
            this.lbl_pay.Text = "Verilen Tutar";
            this.lbl_pay.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GelirGiderTablo.Properties.Resources.house;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1042, 508);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 62);
            this.button2.TabIndex = 63;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(70, 424);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(534, 146);
            this.txt_desc.TabIndex = 8;
            this.txt_desc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 384);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tarih";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(184, 233);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(148, 26);
            this.txt_total.TabIndex = 6;
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_total_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Toplam Tutar";
            // 
            // txt_firm
            // 
            this.txt_firm.Location = new System.Drawing.Point(185, 68);
            this.txt_firm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_firm.Name = "txt_firm";
            this.txt_firm.Size = new System.Drawing.Size(148, 26);
            this.txt_firm.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImage = global::GelirGiderTablo.Properties.Resources.check;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(919, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cari Kodu";
            // 
            // lbl_unitprice
            // 
            this.lbl_unitprice.AutoSize = true;
            this.lbl_unitprice.Location = new System.Drawing.Point(71, 153);
            this.lbl_unitprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_unitprice.Name = "lbl_unitprice";
            this.lbl_unitprice.Size = new System.Drawing.Size(77, 20);
            this.lbl_unitprice.TabIndex = 74;
            this.lbl_unitprice.Text = "Birim fiyat";
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Location = new System.Drawing.Point(185, 149);
            this.txt_unitprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(148, 26);
            this.txt_unitprice.TabIndex = 4;
            this.txt_unitprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_total_KeyPress);
            // 
            // lbl_qtt
            // 
            this.lbl_qtt.AutoSize = true;
            this.lbl_qtt.Location = new System.Drawing.Point(71, 195);
            this.lbl_qtt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qtt.Name = "lbl_qtt";
            this.lbl_qtt.Size = new System.Drawing.Size(43, 20);
            this.lbl_qtt.TabIndex = 76;
            this.lbl_qtt.Text = "Adet";
            // 
            // txt_qtt
            // 
            this.txt_qtt.Location = new System.Drawing.Point(185, 191);
            this.txt_qtt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_qtt.Name = "txt_qtt";
            this.txt_qtt.Size = new System.Drawing.Size(148, 26);
            this.txt_qtt.TabIndex = 5;
            this.txt_qtt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_total_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_diger);
            this.groupBox2.Controls.Add(this.rdo_odeme);
            this.groupBox2.Location = new System.Drawing.Point(478, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gider Türü";
            // 
            // rdo_diger
            // 
            this.rdo_diger.AutoSize = true;
            this.rdo_diger.Location = new System.Drawing.Point(35, 67);
            this.rdo_diger.Name = "rdo_diger";
            this.rdo_diger.Size = new System.Drawing.Size(65, 24);
            this.rdo_diger.TabIndex = 1;
            this.rdo_diger.TabStop = true;
            this.rdo_diger.Text = "Diğer";
            this.rdo_diger.UseVisualStyleBackColor = true;
            // 
            // rdo_odeme
            // 
            this.rdo_odeme.AutoSize = true;
            this.rdo_odeme.Location = new System.Drawing.Point(35, 32);
            this.rdo_odeme.Name = "rdo_odeme";
            this.rdo_odeme.Size = new System.Drawing.Size(79, 24);
            this.rdo_odeme.TabIndex = 0;
            this.rdo_odeme.TabStop = true;
            this.rdo_odeme.Text = "Ödeme";
            this.rdo_odeme.UseVisualStyleBackColor = true;
            // 
            // grp_pay
            // 
            this.grp_pay.Controls.Add(this.rdo_odemeyap);
            this.grp_pay.Controls.Add(this.lbl_taksit);
            this.grp_pay.Controls.Add(this.txt_taksit);
            this.grp_pay.Controls.Add(this.rdo_taksit);
            this.grp_pay.Controls.Add(this.rdo_vadeli);
            this.grp_pay.Controls.Add(this.rdo_nakit);
            this.grp_pay.Location = new System.Drawing.Point(478, 235);
            this.grp_pay.Name = "grp_pay";
            this.grp_pay.Size = new System.Drawing.Size(200, 152);
            this.grp_pay.TabIndex = 79;
            this.grp_pay.TabStop = false;
            this.grp_pay.Text = "Ödeme Türü";
            // 
            // rdo_odemeyap
            // 
            this.rdo_odemeyap.AutoSize = true;
            this.rdo_odemeyap.Location = new System.Drawing.Point(35, 32);
            this.rdo_odemeyap.Name = "rdo_odemeyap";
            this.rdo_odemeyap.Size = new System.Drawing.Size(112, 24);
            this.rdo_odemeyap.TabIndex = 83;
            this.rdo_odemeyap.TabStop = true;
            this.rdo_odemeyap.Text = "Ödeme Yap";
            this.rdo_odemeyap.UseVisualStyleBackColor = true;
            this.rdo_odemeyap.Visible = false;
            // 
            // lbl_taksit
            // 
            this.lbl_taksit.AutoSize = true;
            this.lbl_taksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_taksit.Location = new System.Drawing.Point(47, 119);
            this.lbl_taksit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_taksit.Name = "lbl_taksit";
            this.lbl_taksit.Size = new System.Drawing.Size(91, 17);
            this.lbl_taksit.TabIndex = 82;
            this.lbl_taksit.Text = "Taksit Sayısı:";
            this.lbl_taksit.Visible = false;
            // 
            // txt_taksit
            // 
            this.txt_taksit.Location = new System.Drawing.Point(138, 115);
            this.txt_taksit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_taksit.Name = "txt_taksit";
            this.txt_taksit.Size = new System.Drawing.Size(47, 26);
            this.txt_taksit.TabIndex = 81;
            this.txt_taksit.Visible = false;
            // 
            // rdo_taksit
            // 
            this.rdo_taksit.AutoSize = true;
            this.rdo_taksit.Location = new System.Drawing.Point(35, 92);
            this.rdo_taksit.Name = "rdo_taksit";
            this.rdo_taksit.Size = new System.Drawing.Size(69, 24);
            this.rdo_taksit.TabIndex = 80;
            this.rdo_taksit.TabStop = true;
            this.rdo_taksit.Text = "Taksit";
            this.rdo_taksit.UseVisualStyleBackColor = true;
            this.rdo_taksit.CheckedChanged += new System.EventHandler(this.Rdo_nakit_CheckedChanged);
            // 
            // rdo_vadeli
            // 
            this.rdo_vadeli.AutoSize = true;
            this.rdo_vadeli.Location = new System.Drawing.Point(35, 62);
            this.rdo_vadeli.Name = "rdo_vadeli";
            this.rdo_vadeli.Size = new System.Drawing.Size(71, 24);
            this.rdo_vadeli.TabIndex = 1;
            this.rdo_vadeli.TabStop = true;
            this.rdo_vadeli.Text = "Vadeli";
            this.rdo_vadeli.UseVisualStyleBackColor = true;
            this.rdo_vadeli.CheckedChanged += new System.EventHandler(this.Rdo_nakit_CheckedChanged);
            // 
            // rdo_nakit
            // 
            this.rdo_nakit.AutoSize = true;
            this.rdo_nakit.Location = new System.Drawing.Point(35, 32);
            this.rdo_nakit.Name = "rdo_nakit";
            this.rdo_nakit.Size = new System.Drawing.Size(63, 24);
            this.rdo_nakit.TabIndex = 0;
            this.rdo_nakit.TabStop = true;
            this.rdo_nakit.Text = "Nakit";
            this.rdo_nakit.UseVisualStyleBackColor = true;
            this.rdo_nakit.CheckedChanged += new System.EventHandler(this.Rdo_nakit_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GelirGiderTablo.Properties.Resources.find_my_friend;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(350, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 43);
            this.button3.TabIndex = 80;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // grp_cari
            // 
            this.grp_cari.Controls.Add(this.dgv_cariler);
            this.grp_cari.Controls.Add(this.label2);
            this.grp_cari.Controls.Add(this.btn_carisearch);
            this.grp_cari.Controls.Add(this.txt_carisearch);
            this.grp_cari.Location = new System.Drawing.Point(406, 58);
            this.grp_cari.Name = "grp_cari";
            this.grp_cari.Size = new System.Drawing.Size(715, 360);
            this.grp_cari.TabIndex = 81;
            this.grp_cari.TabStop = false;
            this.grp_cari.Text = "Cari Bul";
            this.grp_cari.Visible = false;
            this.grp_cari.Enter += new System.EventHandler(this.Grp_cari_Enter);
            // 
            // dgv_cariler
            // 
            this.dgv_cariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cariler.Location = new System.Drawing.Point(32, 85);
            this.dgv_cariler.Name = "dgv_cariler";
            this.dgv_cariler.Size = new System.Drawing.Size(657, 251);
            this.dgv_cariler.TabIndex = 3;
            this.dgv_cariler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_cariler_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Kodu veya Adı";
            // 
            // btn_carisearch
            // 
            this.btn_carisearch.BackgroundImage = global::GelirGiderTablo.Properties.Resources.find;
            this.btn_carisearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_carisearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carisearch.Location = new System.Drawing.Point(284, 39);
            this.btn_carisearch.Name = "btn_carisearch";
            this.btn_carisearch.Size = new System.Drawing.Size(57, 26);
            this.btn_carisearch.TabIndex = 1;
            this.btn_carisearch.UseVisualStyleBackColor = true;
            this.btn_carisearch.Click += new System.EventHandler(this.Btn_carisearch_Click);
            // 
            // txt_carisearch
            // 
            this.txt_carisearch.Location = new System.Drawing.Point(165, 39);
            this.txt_carisearch.Name = "txt_carisearch";
            this.txt_carisearch.Size = new System.Drawing.Size(100, 26);
            this.txt_carisearch.TabIndex = 0;
            // 
            // dtp_vade
            // 
            this.dtp_vade.Location = new System.Drawing.Point(185, 107);
            this.dtp_vade.Name = "dtp_vade";
            this.dtp_vade.Size = new System.Drawing.Size(240, 26);
            this.dtp_vade.TabIndex = 82;
            this.dtp_vade.Visible = false;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(541, 67);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(255, 26);
            this.dtp_date.TabIndex = 83;
            // 
            // lbl_taksittarihi
            // 
            this.lbl_taksittarihi.AutoSize = true;
            this.lbl_taksittarihi.Location = new System.Drawing.Point(65, 111);
            this.lbl_taksittarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_taksittarihi.Name = "lbl_taksittarihi";
            this.lbl_taksittarihi.Size = new System.Drawing.Size(113, 20);
            this.lbl_taksittarihi.TabIndex = 84;
            this.lbl_taksittarihi.Text = "İlk Taksit Tarihi";
            this.lbl_taksittarihi.Visible = false;
            // 
            // grp_stok
            // 
            this.grp_stok.Controls.Add(this.label15);
            this.grp_stok.Controls.Add(this.label14);
            this.grp_stok.Controls.Add(this.txt_stok6);
            this.grp_stok.Controls.Add(this.cbx_stok6);
            this.grp_stok.Controls.Add(this.label13);
            this.grp_stok.Controls.Add(this.txt_stok5);
            this.grp_stok.Controls.Add(this.cbx_stok5);
            this.grp_stok.Controls.Add(this.label12);
            this.grp_stok.Controls.Add(this.txt_stok4);
            this.grp_stok.Controls.Add(this.cbx_stok4);
            this.grp_stok.Controls.Add(this.label11);
            this.grp_stok.Controls.Add(this.txt_stok3);
            this.grp_stok.Controls.Add(this.cbx_stok3);
            this.grp_stok.Controls.Add(this.label10);
            this.grp_stok.Controls.Add(this.txt_stok2);
            this.grp_stok.Controls.Add(this.cbx_stok2);
            this.grp_stok.Controls.Add(this.label9);
            this.grp_stok.Controls.Add(this.label8);
            this.grp_stok.Controls.Add(this.txt_stok1);
            this.grp_stok.Controls.Add(this.label7);
            this.grp_stok.Controls.Add(this.cbx_stok1);
            this.grp_stok.Controls.Add(this.label6);
            this.grp_stok.Location = new System.Drawing.Point(770, 116);
            this.grp_stok.Name = "grp_stok";
            this.grp_stok.Size = new System.Drawing.Size(368, 319);
            this.grp_stok.TabIndex = 89;
            this.grp_stok.TabStop = false;
            this.grp_stok.Text = "Stok";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "6.";
            // 
            // txt_stok6
            // 
            this.txt_stok6.Location = new System.Drawing.Point(251, 271);
            this.txt_stok6.Name = "txt_stok6";
            this.txt_stok6.Size = new System.Drawing.Size(100, 26);
            this.txt_stok6.TabIndex = 19;
            // 
            // cbx_stok6
            // 
            this.cbx_stok6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stok6.FormattingEnabled = true;
            this.cbx_stok6.Location = new System.Drawing.Point(70, 271);
            this.cbx_stok6.Name = "cbx_stok6";
            this.cbx_stok6.Size = new System.Drawing.Size(121, 28);
            this.cbx_stok6.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "5.";
            // 
            // txt_stok5
            // 
            this.txt_stok5.Location = new System.Drawing.Point(251, 237);
            this.txt_stok5.Name = "txt_stok5";
            this.txt_stok5.Size = new System.Drawing.Size(100, 26);
            this.txt_stok5.TabIndex = 16;
            // 
            // cbx_stok5
            // 
            this.cbx_stok5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stok5.FormattingEnabled = true;
            this.cbx_stok5.Location = new System.Drawing.Point(70, 237);
            this.cbx_stok5.Name = "cbx_stok5";
            this.cbx_stok5.Size = new System.Drawing.Size(121, 28);
            this.cbx_stok5.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "4.";
            // 
            // txt_stok4
            // 
            this.txt_stok4.Location = new System.Drawing.Point(251, 203);
            this.txt_stok4.Name = "txt_stok4";
            this.txt_stok4.Size = new System.Drawing.Size(100, 26);
            this.txt_stok4.TabIndex = 13;
            // 
            // cbx_stok4
            // 
            this.cbx_stok4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stok4.FormattingEnabled = true;
            this.cbx_stok4.Location = new System.Drawing.Point(70, 203);
            this.cbx_stok4.Name = "cbx_stok4";
            this.cbx_stok4.Size = new System.Drawing.Size(121, 28);
            this.cbx_stok4.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "3.";
            // 
            // txt_stok3
            // 
            this.txt_stok3.Location = new System.Drawing.Point(251, 169);
            this.txt_stok3.Name = "txt_stok3";
            this.txt_stok3.Size = new System.Drawing.Size(100, 26);
            this.txt_stok3.TabIndex = 10;
            // 
            // cbx_stok3
            // 
            this.cbx_stok3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stok3.FormattingEnabled = true;
            this.cbx_stok3.Location = new System.Drawing.Point(70, 169);
            this.cbx_stok3.Name = "cbx_stok3";
            this.cbx_stok3.Size = new System.Drawing.Size(121, 28);
            this.cbx_stok3.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "2.";
            // 
            // txt_stok2
            // 
            this.txt_stok2.Location = new System.Drawing.Point(251, 135);
            this.txt_stok2.Name = "txt_stok2";
            this.txt_stok2.Size = new System.Drawing.Size(100, 26);
            this.txt_stok2.TabIndex = 7;
            // 
            // cbx_stok2
            // 
            this.cbx_stok2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stok2.FormattingEnabled = true;
            this.cbx_stok2.Location = new System.Drawing.Point(70, 135);
            this.cbx_stok2.Name = "cbx_stok2";
            this.cbx_stok2.Size = new System.Drawing.Size(121, 28);
            this.cbx_stok2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "1.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Miktar";
            // 
            // txt_stok1
            // 
            this.txt_stok1.Location = new System.Drawing.Point(251, 101);
            this.txt_stok1.Name = "txt_stok1";
            this.txt_stok1.Size = new System.Drawing.Size(100, 26);
            this.txt_stok1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Stok Adı";
            // 
            // cbx_stok1
            // 
            this.cbx_stok1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stok1.FormattingEnabled = true;
            this.cbx_stok1.Location = new System.Drawing.Point(70, 101);
            this.cbx_stok1.Name = "cbx_stok1";
            this.cbx_stok1.Size = new System.Drawing.Size(121, 28);
            this.cbx_stok1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(66, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ödemeyle eklenecek stok varsa giriniz.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(67, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Yoksa boş bırakınız";
            // 
            // FormOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.grp_cari);
            this.Controls.Add(this.lbl_taksittarihi);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.dtp_vade);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grp_pay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_qtt);
            this.Controls.Add(this.lbl_qtt);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.lbl_unitprice);
            this.Controls.Add(this.cbx_para);
            this.Controls.Add(this.lbl_vadetarihi);
            this.Controls.Add(this.txt_pay);
            this.Controls.Add(this.lbl_pay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_firm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_stok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_pay.ResumeLayout(false);
            this.grp_pay.PerformLayout();
            this.grp_cari.ResumeLayout(false);
            this.grp_cari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cariler)).EndInit();
            this.grp_stok.ResumeLayout(false);
            this.grp_stok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_para;
        private System.Windows.Forms.Label lbl_vadetarihi;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Label lbl_pay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_firm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_unitprice;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label lbl_qtt;
        private System.Windows.Forms.TextBox txt_qtt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_diger;
        private System.Windows.Forms.RadioButton rdo_odeme;
        private System.Windows.Forms.GroupBox grp_pay;
        private System.Windows.Forms.Label lbl_taksit;
        private System.Windows.Forms.TextBox txt_taksit;
        private System.Windows.Forms.RadioButton rdo_taksit;
        private System.Windows.Forms.RadioButton rdo_vadeli;
        private System.Windows.Forms.RadioButton rdo_nakit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grp_cari;
        private System.Windows.Forms.DataGridView dgv_cariler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_carisearch;
        private System.Windows.Forms.TextBox txt_carisearch;
        private System.Windows.Forms.DateTimePicker dtp_vade;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_taksittarihi;
        private System.Windows.Forms.RadioButton rdo_odemeyap;
        private System.Windows.Forms.GroupBox grp_stok;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_stok6;
        private System.Windows.Forms.ComboBox cbx_stok6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_stok5;
        private System.Windows.Forms.ComboBox cbx_stok5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_stok4;
        private System.Windows.Forms.ComboBox cbx_stok4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_stok3;
        private System.Windows.Forms.ComboBox cbx_stok3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_stok2;
        private System.Windows.Forms.ComboBox cbx_stok2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_stok1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_stok1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
    }
}