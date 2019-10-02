namespace GelirGiderTablo
{
    partial class FormStokAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStokAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stokkodu_yeni = new System.Windows.Forms.TextBox();
            this.txt_stokadi_yeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_miktar_yeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_yenistok = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stokkodu = new System.Windows.Forms.TextBox();
            this.lbl_giren = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_cikan = new System.Windows.Forms.Label();
            this.rdo_giris = new System.Windows.Forms.RadioButton();
            this.rdo_cikis = new System.Windows.Forms.RadioButton();
            this.grp_gircik = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_gircik = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_stokara = new System.Windows.Forms.DataGridView();
            this.grp_stokara = new System.Windows.Forms.GroupBox();
            this.txt_stokara = new System.Windows.Forms.TextBox();
            this.btn_stokara = new System.Windows.Forms.Button();
            this.grp_yenistok.SuspendLayout();
            this.grp_gircik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stokara)).BeginInit();
            this.grp_stokara.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu";
            // 
            // txt_stokkodu_yeni
            // 
            this.txt_stokkodu_yeni.Location = new System.Drawing.Point(135, 39);
            this.txt_stokkodu_yeni.Name = "txt_stokkodu_yeni";
            this.txt_stokkodu_yeni.Size = new System.Drawing.Size(100, 26);
            this.txt_stokkodu_yeni.TabIndex = 1;
            // 
            // txt_stokadi_yeni
            // 
            this.txt_stokadi_yeni.Location = new System.Drawing.Point(135, 98);
            this.txt_stokadi_yeni.Name = "txt_stokadi_yeni";
            this.txt_stokadi_yeni.Size = new System.Drawing.Size(218, 26);
            this.txt_stokadi_yeni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Adı";
            // 
            // txt_miktar_yeni
            // 
            this.txt_miktar_yeni.Location = new System.Drawing.Point(135, 162);
            this.txt_miktar_yeni.Name = "txt_miktar_yeni";
            this.txt_miktar_yeni.Size = new System.Drawing.Size(100, 26);
            this.txt_miktar_yeni.TabIndex = 5;
            this.txt_miktar_yeni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giren Miktar";
            // 
            // grp_yenistok
            // 
            this.grp_yenistok.BackColor = System.Drawing.Color.MintCream;
            this.grp_yenistok.Controls.Add(this.btn_yeni);
            this.grp_yenistok.Controls.Add(this.txt_stokadi_yeni);
            this.grp_yenistok.Controls.Add(this.txt_miktar_yeni);
            this.grp_yenistok.Controls.Add(this.label1);
            this.grp_yenistok.Controls.Add(this.label3);
            this.grp_yenistok.Controls.Add(this.txt_stokkodu_yeni);
            this.grp_yenistok.Controls.Add(this.label2);
            this.grp_yenistok.Location = new System.Drawing.Point(22, 78);
            this.grp_yenistok.Name = "grp_yenistok";
            this.grp_yenistok.Size = new System.Drawing.Size(359, 299);
            this.grp_yenistok.TabIndex = 6;
            this.grp_yenistok.TabStop = false;
            this.grp_yenistok.Text = "Yeni Kayıt";
            this.grp_yenistok.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok Kodu";
            // 
            // txt_stokkodu
            // 
            this.txt_stokkodu.Location = new System.Drawing.Point(128, 49);
            this.txt_stokkodu.Name = "txt_stokkodu";
            this.txt_stokkodu.Size = new System.Drawing.Size(100, 26);
            this.txt_stokkodu.TabIndex = 8;
            // 
            // lbl_giren
            // 
            this.lbl_giren.AutoSize = true;
            this.lbl_giren.Location = new System.Drawing.Point(20, 110);
            this.lbl_giren.Name = "lbl_giren";
            this.lbl_giren.Size = new System.Drawing.Size(95, 20);
            this.lbl_giren.TabIndex = 9;
            this.lbl_giren.Text = "Giren Miktar";
            this.lbl_giren.Visible = false;
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(128, 107);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(100, 26);
            this.txt_miktar.TabIndex = 10;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yeni Kayıt";
            // 
            // lbl_cikan
            // 
            this.lbl_cikan.AutoSize = true;
            this.lbl_cikan.Location = new System.Drawing.Point(19, 110);
            this.lbl_cikan.Name = "lbl_cikan";
            this.lbl_cikan.Size = new System.Drawing.Size(96, 20);
            this.lbl_cikan.TabIndex = 12;
            this.lbl_cikan.Text = "Çıkan Miktar";
            this.lbl_cikan.Visible = false;
            // 
            // rdo_giris
            // 
            this.rdo_giris.AutoSize = true;
            this.rdo_giris.Location = new System.Drawing.Point(75, 167);
            this.rdo_giris.Name = "rdo_giris";
            this.rdo_giris.Size = new System.Drawing.Size(59, 24);
            this.rdo_giris.TabIndex = 14;
            this.rdo_giris.TabStop = true;
            this.rdo_giris.Text = "Giriş";
            this.rdo_giris.UseVisualStyleBackColor = true;
            this.rdo_giris.CheckedChanged += new System.EventHandler(this.rdo_cikis_CheckedChanged);
            // 
            // rdo_cikis
            // 
            this.rdo_cikis.AutoSize = true;
            this.rdo_cikis.Location = new System.Drawing.Point(170, 167);
            this.rdo_cikis.Name = "rdo_cikis";
            this.rdo_cikis.Size = new System.Drawing.Size(60, 24);
            this.rdo_cikis.TabIndex = 15;
            this.rdo_cikis.TabStop = true;
            this.rdo_cikis.Text = "Çıkış";
            this.rdo_cikis.UseVisualStyleBackColor = true;
            this.rdo_cikis.CheckedChanged += new System.EventHandler(this.rdo_cikis_CheckedChanged);
            // 
            // grp_gircik
            // 
            this.grp_gircik.BackColor = System.Drawing.Color.MintCream;
            this.grp_gircik.Controls.Add(this.button2);
            this.grp_gircik.Controls.Add(this.txt_miktar);
            this.grp_gircik.Controls.Add(this.rdo_cikis);
            this.grp_gircik.Controls.Add(this.txt_stokkodu);
            this.grp_gircik.Controls.Add(this.rdo_giris);
            this.grp_gircik.Controls.Add(this.label4);
            this.grp_gircik.Controls.Add(this.btn_gircik);
            this.grp_gircik.Controls.Add(this.lbl_giren);
            this.grp_gircik.Controls.Add(this.lbl_cikan);
            this.grp_gircik.Location = new System.Drawing.Point(116, 78);
            this.grp_gircik.Name = "grp_gircik";
            this.grp_gircik.Size = new System.Drawing.Size(305, 299);
            this.grp_gircik.TabIndex = 16;
            this.grp_gircik.TabStop = false;
            this.grp_gircik.Text = "Stok Giriş / Çıkış";
            this.grp_gircik.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GelirGiderTablo.Properties.Resources.find;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(236, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 26);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_gircik
            // 
            this.btn_gircik.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_gircik.BackgroundImage = global::GelirGiderTablo.Properties.Resources.plus;
            this.btn_gircik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gircik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gircik.Location = new System.Drawing.Point(6, 232);
            this.btn_gircik.Name = "btn_gircik";
            this.btn_gircik.Size = new System.Drawing.Size(291, 60);
            this.btn_gircik.TabIndex = 13;
            this.btn_gircik.UseVisualStyleBackColor = false;
            this.btn_gircik.Click += new System.EventHandler(this.btn_gircik_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_yeni.BackgroundImage = global::GelirGiderTablo.Properties.Resources.check;
            this.btn_yeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_yeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni.Location = new System.Drawing.Point(5, 220);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(348, 72);
            this.btn_yeni.TabIndex = 6;
            this.btn_yeni.UseVisualStyleBackColor = false;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.BackgroundImage = global::GelirGiderTablo.Properties.Resources.plus;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(22, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = global::GelirGiderTablo.Properties.Resources.transfer;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(118, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 60);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(113, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giriş / Çıkış";
            // 
            // dgv_stokara
            // 
            this.dgv_stokara.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_stokara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stokara.Location = new System.Drawing.Point(6, 73);
            this.dgv_stokara.Name = "dgv_stokara";
            this.dgv_stokara.Size = new System.Drawing.Size(581, 219);
            this.dgv_stokara.TabIndex = 19;
            this.dgv_stokara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stokara_CellClick);
            // 
            // grp_stokara
            // 
            this.grp_stokara.Controls.Add(this.btn_stokara);
            this.grp_stokara.Controls.Add(this.txt_stokara);
            this.grp_stokara.Controls.Add(this.dgv_stokara);
            this.grp_stokara.Location = new System.Drawing.Point(428, 78);
            this.grp_stokara.Name = "grp_stokara";
            this.grp_stokara.Size = new System.Drawing.Size(593, 299);
            this.grp_stokara.TabIndex = 20;
            this.grp_stokara.TabStop = false;
            this.grp_stokara.Text = "Stok Ara";
            this.grp_stokara.Visible = false;
            // 
            // txt_stokara
            // 
            this.txt_stokara.Location = new System.Drawing.Point(6, 36);
            this.txt_stokara.Name = "txt_stokara";
            this.txt_stokara.Size = new System.Drawing.Size(100, 26);
            this.txt_stokara.TabIndex = 20;
            // 
            // btn_stokara
            // 
            this.btn_stokara.Location = new System.Drawing.Point(121, 36);
            this.btn_stokara.Name = "btn_stokara";
            this.btn_stokara.Size = new System.Drawing.Size(75, 26);
            this.btn_stokara.TabIndex = 21;
            this.btn_stokara.Text = "Ara";
            this.btn_stokara.UseVisualStyleBackColor = true;
            this.btn_stokara.Click += new System.EventHandler(this.btn_stokara_Click);
            // 
            // FormStokAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.grp_gircik);
            this.Controls.Add(this.grp_stokara);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grp_yenistok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStokAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İşlemleri";
            this.grp_yenistok.ResumeLayout(false);
            this.grp_yenistok.PerformLayout();
            this.grp_gircik.ResumeLayout(false);
            this.grp_gircik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stokara)).EndInit();
            this.grp_stokara.ResumeLayout(false);
            this.grp_stokara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stokkodu_yeni;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_miktar_yeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stokadi_yeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.GroupBox grp_yenistok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stokkodu;
        private System.Windows.Forms.Label lbl_giren;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_cikan;
        private System.Windows.Forms.Button btn_gircik;
        private System.Windows.Forms.RadioButton rdo_giris;
        private System.Windows.Forms.RadioButton rdo_cikis;
        private System.Windows.Forms.GroupBox grp_gircik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_stokara;
        private System.Windows.Forms.GroupBox grp_stokara;
        private System.Windows.Forms.Button btn_stokara;
        private System.Windows.Forms.TextBox txt_stokara;
    }
}