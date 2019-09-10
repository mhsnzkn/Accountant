namespace GelirGiderTablo
{
    partial class FormCariler
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_src = new System.Windows.Forms.TextBox();
            this.btn_src = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_ekle = new System.Windows.Forms.GroupBox();
            this.txt_carikod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_adres = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.grp_update = new System.Windows.Forms.GroupBox();
            this.txt_carikod_up = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_update_ok = new System.Windows.Forms.Button();
            this.txt_adres_up = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email_up = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ilce_up = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_il_up = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tel_up = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ad_up = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_ekle.SuspendLayout();
            this.grp_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Ara";
            // 
            // txt_src
            // 
            this.txt_src.Location = new System.Drawing.Point(37, 65);
            this.txt_src.Name = "txt_src";
            this.txt_src.Size = new System.Drawing.Size(156, 26);
            this.txt_src.TabIndex = 1;
            // 
            // btn_src
            // 
            this.btn_src.Location = new System.Drawing.Point(210, 65);
            this.btn_src.Name = "btn_src";
            this.btn_src.Size = new System.Drawing.Size(114, 26);
            this.btn_src.TabIndex = 2;
            this.btn_src.Text = "Ara";
            this.btn_src.UseVisualStyleBackColor = true;
            this.btn_src.Click += new System.EventHandler(this.Btn_src_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 493);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cari Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grp_ekle
            // 
            this.grp_ekle.Controls.Add(this.txt_carikod);
            this.grp_ekle.Controls.Add(this.label8);
            this.grp_ekle.Controls.Add(this.button2);
            this.grp_ekle.Controls.Add(this.txt_adres);
            this.grp_ekle.Controls.Add(this.label7);
            this.grp_ekle.Controls.Add(this.txt_email);
            this.grp_ekle.Controls.Add(this.label6);
            this.grp_ekle.Controls.Add(this.txt_ilce);
            this.grp_ekle.Controls.Add(this.label5);
            this.grp_ekle.Controls.Add(this.txt_il);
            this.grp_ekle.Controls.Add(this.label4);
            this.grp_ekle.Controls.Add(this.txt_tel);
            this.grp_ekle.Controls.Add(this.label3);
            this.grp_ekle.Controls.Add(this.txt_ad);
            this.grp_ekle.Controls.Add(this.label2);
            this.grp_ekle.Location = new System.Drawing.Point(920, 97);
            this.grp_ekle.Name = "grp_ekle";
            this.grp_ekle.Size = new System.Drawing.Size(268, 449);
            this.grp_ekle.TabIndex = 5;
            this.grp_ekle.TabStop = false;
            this.grp_ekle.Text = "Cari Ekle";
            this.grp_ekle.Visible = false;
            // 
            // txt_carikod
            // 
            this.txt_carikod.Location = new System.Drawing.Point(104, 57);
            this.txt_carikod.Name = "txt_carikod";
            this.txt_carikod.Size = new System.Drawing.Size(149, 26);
            this.txt_carikod.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kodu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(6, 278);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(247, 101);
            this.txt_adres.TabIndex = 11;
            this.txt_adres.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adres";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(104, 217);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(149, 26);
            this.txt_email.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(104, 185);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(149, 26);
            this.txt_ilce.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "İlçe";
            // 
            // txt_il
            // 
            this.txt_il.Location = new System.Drawing.Point(104, 153);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(149, 26);
            this.txt_il.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "İl";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(104, 121);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(149, 26);
            this.txt_tel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(104, 89);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(149, 26);
            this.txt_ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(800, 65);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(114, 26);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Cari Düzenle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // grp_update
            // 
            this.grp_update.Controls.Add(this.button4);
            this.grp_update.Controls.Add(this.txt_carikod_up);
            this.grp_update.Controls.Add(this.label9);
            this.grp_update.Controls.Add(this.btn_update_ok);
            this.grp_update.Controls.Add(this.txt_adres_up);
            this.grp_update.Controls.Add(this.label10);
            this.grp_update.Controls.Add(this.txt_email_up);
            this.grp_update.Controls.Add(this.label11);
            this.grp_update.Controls.Add(this.txt_ilce_up);
            this.grp_update.Controls.Add(this.label12);
            this.grp_update.Controls.Add(this.txt_il_up);
            this.grp_update.Controls.Add(this.label13);
            this.grp_update.Controls.Add(this.txt_tel_up);
            this.grp_update.Controls.Add(this.label14);
            this.grp_update.Controls.Add(this.txt_ad_up);
            this.grp_update.Controls.Add(this.label15);
            this.grp_update.Location = new System.Drawing.Point(646, 97);
            this.grp_update.Name = "grp_update";
            this.grp_update.Size = new System.Drawing.Size(268, 527);
            this.grp_update.TabIndex = 7;
            this.grp_update.TabStop = false;
            this.grp_update.Text = "Cari Düzenle";
            this.grp_update.Visible = false;
            // 
            // txt_carikod_up
            // 
            this.txt_carikod_up.Location = new System.Drawing.Point(68, 51);
            this.txt_carikod_up.Name = "txt_carikod_up";
            this.txt_carikod_up.Size = new System.Drawing.Size(149, 26);
            this.txt_carikod_up.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(65, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Carinin Kodunu yazınız";
            // 
            // btn_update_ok
            // 
            this.btn_update_ok.Enabled = false;
            this.btn_update_ok.Location = new System.Drawing.Point(6, 465);
            this.btn_update_ok.Name = "btn_update_ok";
            this.btn_update_ok.Size = new System.Drawing.Size(247, 54);
            this.btn_update_ok.TabIndex = 12;
            this.btn_update_ok.Text = "Onayla";
            this.btn_update_ok.UseVisualStyleBackColor = true;
            this.btn_update_ok.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txt_adres_up
            // 
            this.txt_adres_up.Location = new System.Drawing.Point(6, 358);
            this.txt_adres_up.Name = "txt_adres_up";
            this.txt_adres_up.Size = new System.Drawing.Size(247, 101);
            this.txt_adres_up.TabIndex = 11;
            this.txt_adres_up.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Adres";
            // 
            // txt_email_up
            // 
            this.txt_email_up.Location = new System.Drawing.Point(104, 297);
            this.txt_email_up.Name = "txt_email_up";
            this.txt_email_up.Size = new System.Drawing.Size(149, 26);
            this.txt_email_up.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Email";
            // 
            // txt_ilce_up
            // 
            this.txt_ilce_up.Location = new System.Drawing.Point(104, 265);
            this.txt_ilce_up.Name = "txt_ilce_up";
            this.txt_ilce_up.Size = new System.Drawing.Size(149, 26);
            this.txt_ilce_up.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "İlçe";
            // 
            // txt_il_up
            // 
            this.txt_il_up.Location = new System.Drawing.Point(104, 233);
            this.txt_il_up.Name = "txt_il_up";
            this.txt_il_up.Size = new System.Drawing.Size(149, 26);
            this.txt_il_up.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "İl";
            // 
            // txt_tel_up
            // 
            this.txt_tel_up.Location = new System.Drawing.Point(104, 201);
            this.txt_tel_up.Name = "txt_tel_up";
            this.txt_tel_up.Size = new System.Drawing.Size(149, 26);
            this.txt_tel_up.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Telefon";
            // 
            // txt_ad_up
            // 
            this.txt_ad_up.Location = new System.Drawing.Point(104, 169);
            this.txt_ad_up.Name = "txt_ad_up";
            this.txt_ad_up.Size = new System.Drawing.Size(149, 26);
            this.txt_ad_up.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Adı";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "Bilgileri Getir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1078, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 62);
            this.button3.TabIndex = 8;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // FormCariler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grp_update);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.grp_ekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_src);
            this.Controls.Add(this.txt_src);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCariler";
            this.Text = "FormCariler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_ekle.ResumeLayout(false);
            this.grp_ekle.PerformLayout();
            this.grp_update.ResumeLayout(false);
            this.grp_update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_src;
        private System.Windows.Forms.Button btn_src;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grp_ekle;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txt_adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_carikod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox grp_update;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_carikod_up;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_update_ok;
        private System.Windows.Forms.RichTextBox txt_adres_up;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email_up;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ilce_up;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_il_up;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tel_up;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ad_up;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
    }
}