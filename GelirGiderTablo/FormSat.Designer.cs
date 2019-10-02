namespace GelirGiderTablo
{
    partial class FormSat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSat));
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_firm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.lbl_pay = new System.Windows.Forms.Label();
            this.lbl_vadetarihi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_odemeal = new System.Windows.Forms.RadioButton();
            this.lbl_taksit = new System.Windows.Forms.Label();
            this.txt_taksit = new System.Windows.Forms.TextBox();
            this.rdo_taksit = new System.Windows.Forms.RadioButton();
            this.rdo_vadeli = new System.Windows.Forms.RadioButton();
            this.rdo_nakit = new System.Windows.Forms.RadioButton();
            this.txt_qtt = new System.Windows.Forms.TextBox();
            this.lbl_qtt = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.lbl_unitprice = new System.Windows.Forms.Label();
            this.grp_cari = new System.Windows.Forms.GroupBox();
            this.dgv_cariler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_carisearch = new System.Windows.Forms.Button();
            this.txt_carisearch = new System.Windows.Forms.TextBox();
            this.cbx_para = new System.Windows.Forms.ComboBox();
            this.dtp_vade = new System.Windows.Forms.DateTimePicker();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_taksittarihi = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_cari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cariler)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(47, 415);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(534, 146);
            this.txt_desc.TabIndex = 8;
            this.txt_desc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tarih";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(161, 235);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(148, 26);
            this.txt_total.TabIndex = 6;
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_total_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Toplam Tutar";
            // 
            // txt_firm
            // 
            this.txt_firm.Location = new System.Drawing.Point(162, 69);
            this.txt_firm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_firm.Name = "txt_firm";
            this.txt_firm.Size = new System.Drawing.Size(148, 26);
            this.txt_firm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cari Kodu";
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(161, 279);
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
            this.lbl_pay.Location = new System.Drawing.Point(47, 283);
            this.lbl_pay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pay.Name = "lbl_pay";
            this.lbl_pay.Size = new System.Drawing.Size(94, 20);
            this.lbl_pay.TabIndex = 34;
            this.lbl_pay.Text = "Alınan Tutar";
            this.lbl_pay.Visible = false;
            // 
            // lbl_vadetarihi
            // 
            this.lbl_vadetarihi.AutoSize = true;
            this.lbl_vadetarihi.Location = new System.Drawing.Point(48, 112);
            this.lbl_vadetarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vadetarihi.Name = "lbl_vadetarihi";
            this.lbl_vadetarihi.Size = new System.Drawing.Size(89, 20);
            this.lbl_vadetarihi.TabIndex = 36;
            this.lbl_vadetarihi.Text = "Vade Tarihi";
            this.lbl_vadetarihi.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_odemeal);
            this.groupBox1.Controls.Add(this.lbl_taksit);
            this.groupBox1.Controls.Add(this.txt_taksit);
            this.groupBox1.Controls.Add(this.rdo_taksit);
            this.groupBox1.Controls.Add(this.rdo_vadeli);
            this.groupBox1.Controls.Add(this.rdo_nakit);
            this.groupBox1.Location = new System.Drawing.Point(484, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Türü";
            // 
            // rdo_odemeal
            // 
            this.rdo_odemeal.AutoSize = true;
            this.rdo_odemeal.Location = new System.Drawing.Point(35, 32);
            this.rdo_odemeal.Name = "rdo_odemeal";
            this.rdo_odemeal.Size = new System.Drawing.Size(97, 24);
            this.rdo_odemeal.TabIndex = 83;
            this.rdo_odemeal.TabStop = true;
            this.rdo_odemeal.Text = "Odeme Al";
            this.rdo_odemeal.UseVisualStyleBackColor = true;
            this.rdo_odemeal.Visible = false;
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
            this.txt_taksit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_taksit_KeyPress);
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
            // txt_qtt
            // 
            this.txt_qtt.Location = new System.Drawing.Point(162, 193);
            this.txt_qtt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_qtt.Name = "txt_qtt";
            this.txt_qtt.Size = new System.Drawing.Size(148, 26);
            this.txt_qtt.TabIndex = 5;
            this.txt_qtt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_total_KeyPress);
            this.txt_qtt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_unitprice_KeyUp);
            // 
            // lbl_qtt
            // 
            this.lbl_qtt.AutoSize = true;
            this.lbl_qtt.Location = new System.Drawing.Point(48, 197);
            this.lbl_qtt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qtt.Name = "lbl_qtt";
            this.lbl_qtt.Size = new System.Drawing.Size(43, 20);
            this.lbl_qtt.TabIndex = 46;
            this.lbl_qtt.Text = "Adet";
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Location = new System.Drawing.Point(162, 151);
            this.txt_unitprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(148, 26);
            this.txt_unitprice.TabIndex = 4;
            this.txt_unitprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_total_KeyPress);
            this.txt_unitprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_unitprice_KeyUp);
            // 
            // lbl_unitprice
            // 
            this.lbl_unitprice.AutoSize = true;
            this.lbl_unitprice.Location = new System.Drawing.Point(48, 155);
            this.lbl_unitprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_unitprice.Name = "lbl_unitprice";
            this.lbl_unitprice.Size = new System.Drawing.Size(77, 20);
            this.lbl_unitprice.TabIndex = 44;
            this.lbl_unitprice.Text = "Birim fiyat";
            // 
            // grp_cari
            // 
            this.grp_cari.Controls.Add(this.dgv_cariler);
            this.grp_cari.Controls.Add(this.label2);
            this.grp_cari.Controls.Add(this.btn_carisearch);
            this.grp_cari.Controls.Add(this.txt_carisearch);
            this.grp_cari.Location = new System.Drawing.Point(403, 66);
            this.grp_cari.Name = "grp_cari";
            this.grp_cari.Size = new System.Drawing.Size(715, 360);
            this.grp_cari.TabIndex = 83;
            this.grp_cari.TabStop = false;
            this.grp_cari.Text = "Cari Bul";
            this.grp_cari.Visible = false;
            // 
            // dgv_cariler
            // 
            this.dgv_cariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cariler.Location = new System.Drawing.Point(35, 85);
            this.dgv_cariler.Name = "dgv_cariler";
            this.dgv_cariler.Size = new System.Drawing.Size(654, 251);
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
            this.btn_carisearch.Location = new System.Drawing.Point(283, 39);
            this.btn_carisearch.Name = "btn_carisearch";
            this.btn_carisearch.Size = new System.Drawing.Size(60, 28);
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
            // cbx_para
            // 
            this.cbx_para.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_para.FormattingEnabled = true;
            this.cbx_para.Items.AddRange(new object[] {
            "TL",
            "DOLAR",
            "EURO"});
            this.cbx_para.Location = new System.Drawing.Point(330, 234);
            this.cbx_para.Name = "cbx_para";
            this.cbx_para.Size = new System.Drawing.Size(75, 28);
            this.cbx_para.TabIndex = 84;
            // 
            // dtp_vade
            // 
            this.dtp_vade.Location = new System.Drawing.Point(161, 110);
            this.dtp_vade.Name = "dtp_vade";
            this.dtp_vade.Size = new System.Drawing.Size(244, 26);
            this.dtp_vade.TabIndex = 85;
            this.dtp_vade.Visible = false;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(547, 71);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(248, 26);
            this.dtp_date.TabIndex = 86;
            // 
            // lbl_taksittarihi
            // 
            this.lbl_taksittarihi.AutoSize = true;
            this.lbl_taksittarihi.Location = new System.Drawing.Point(45, 113);
            this.lbl_taksittarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_taksittarihi.Name = "lbl_taksittarihi";
            this.lbl_taksittarihi.Size = new System.Drawing.Size(113, 20);
            this.lbl_taksittarihi.TabIndex = 87;
            this.lbl_taksittarihi.Text = "İlk Taksit Tarihi";
            this.lbl_taksittarihi.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GelirGiderTablo.Properties.Resources.find_my_friend;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(330, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 43);
            this.button3.TabIndex = 82;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GelirGiderTablo.Properties.Resources.house;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1004, 499);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 62);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImage = global::GelirGiderTablo.Properties.Resources.check;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(882, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lbl_taksittarihi);
            this.Controls.Add(this.grp_cari);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.dtp_vade);
            this.Controls.Add(this.cbx_para);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_qtt);
            this.Controls.Add(this.lbl_qtt);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.lbl_unitprice);
            this.Controls.Add(this.groupBox1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Gir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_cari.ResumeLayout(false);
            this.grp_cari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_firm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Label lbl_pay;
        private System.Windows.Forms.Label lbl_vadetarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_vadeli;
        private System.Windows.Forms.RadioButton rdo_nakit;
        private System.Windows.Forms.TextBox txt_qtt;
        private System.Windows.Forms.Label lbl_qtt;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label lbl_unitprice;
        private System.Windows.Forms.Label lbl_taksit;
        private System.Windows.Forms.TextBox txt_taksit;
        private System.Windows.Forms.RadioButton rdo_taksit;
        private System.Windows.Forms.GroupBox grp_cari;
        private System.Windows.Forms.DataGridView dgv_cariler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_carisearch;
        private System.Windows.Forms.TextBox txt_carisearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbx_para;
        private System.Windows.Forms.DateTimePicker dtp_vade;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_taksittarihi;
        private System.Windows.Forms.RadioButton rdo_odemeal;
    }
}