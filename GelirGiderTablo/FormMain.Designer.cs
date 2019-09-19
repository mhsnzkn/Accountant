namespace GelirGiderTablo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.satışGirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahsilatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeGirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_borclucariler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_alacaklicariler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_yalacak = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_yborclar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borclucariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alacaklicariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yalacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yborclar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tahsilatToolStripMenuItem,
            this.ödemeToolStripMenuItem,
            this.cariİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışGirToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "Satış";
            // 
            // satışGirToolStripMenuItem
            // 
            this.satışGirToolStripMenuItem.Name = "satışGirToolStripMenuItem";
            this.satışGirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.satışGirToolStripMenuItem.Text = "Satış Gir";
            this.satışGirToolStripMenuItem.Click += new System.EventHandler(this.SatışGirToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzelt";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.DüzenleToolStripMenuItem_Click);
            // 
            // tahsilatToolStripMenuItem
            // 
            this.tahsilatToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tahsilatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeGirToolStripMenuItem,
            this.düzeltToolStripMenuItem});
            this.tahsilatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.tahsilatToolStripMenuItem.Name = "tahsilatToolStripMenuItem";
            this.tahsilatToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.tahsilatToolStripMenuItem.Text = "Ödeme Gir";
            // 
            // ödemeGirToolStripMenuItem
            // 
            this.ödemeGirToolStripMenuItem.Name = "ödemeGirToolStripMenuItem";
            this.ödemeGirToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ödemeGirToolStripMenuItem.Text = "Ödeme Gir";
            this.ödemeGirToolStripMenuItem.Click += new System.EventHandler(this.Button4_Click);
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.düzeltToolStripMenuItem.Text = "Düzelt";
            this.düzeltToolStripMenuItem.Click += new System.EventHandler(this.DüzeltToolStripMenuItem_Click);
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ödemeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.ödemeToolStripMenuItem.Text = "Cari Hareketler";
            this.ödemeToolStripMenuItem.Click += new System.EventHandler(this.Button3_Click);
            // 
            // cariİşlemleriToolStripMenuItem
            // 
            this.cariİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cariİşlemleriToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.cariİşlemleriToolStripMenuItem.Name = "cariİşlemleriToolStripMenuItem";
            this.cariİşlemleriToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cariİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cariİşlemleriToolStripMenuItem.Text = "Cari İşlemleri";
            this.cariİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgv_borclucariler
            // 
            this.dgv_borclucariler.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_borclucariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borclucariler.Location = new System.Drawing.Point(12, 70);
            this.dgv_borclucariler.Name = "dgv_borclucariler";
            this.dgv_borclucariler.RowHeadersVisible = false;
            this.dgv_borclucariler.Size = new System.Drawing.Size(608, 225);
            this.dgv_borclucariler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(250, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Borçlu Cariler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(250, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alacaklı Cariler";
            // 
            // dgv_alacaklicariler
            // 
            this.dgv_alacaklicariler.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_alacaklicariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alacaklicariler.Location = new System.Drawing.Point(12, 381);
            this.dgv_alacaklicariler.Name = "dgv_alacaklicariler";
            this.dgv_alacaklicariler.RowHeadersVisible = false;
            this.dgv_alacaklicariler.Size = new System.Drawing.Size(608, 225);
            this.dgv_alacaklicariler.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(851, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yaklaşan Alacaklar";
            // 
            // dgv_yalacak
            // 
            this.dgv_yalacak.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_yalacak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yalacak.Location = new System.Drawing.Point(659, 70);
            this.dgv_yalacak.Name = "dgv_yalacak";
            this.dgv_yalacak.RowHeadersVisible = false;
            this.dgv_yalacak.Size = new System.Drawing.Size(529, 225);
            this.dgv_yalacak.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(853, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yaklaşan Borçlar";
            // 
            // dgv_yborclar
            // 
            this.dgv_yborclar.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_yborclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yborclar.Location = new System.Drawing.Point(659, 381);
            this.dgv_yborclar.Name = "dgv_yborclar";
            this.dgv_yborclar.RowHeadersVisible = false;
            this.dgv_yborclar.Size = new System.Drawing.Size(529, 225);
            this.dgv_yborclar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1012, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Developed by";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1013, 671);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "muhsinozkan12@gmail.com";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_yborclar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_yalacak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_alacaklicariler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_borclucariler);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Gelir-Gider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borclucariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alacaklicariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yalacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yborclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahsilatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariİşlemleriToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_borclucariler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_alacaklicariler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_yalacak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_yborclar;
        private System.Windows.Forms.ToolStripMenuItem satışGirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeGirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

