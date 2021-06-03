namespace Deneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMutasyon = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalıstır = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIterasyon = new System.Windows.Forms.TextBox();
            this.txtPopulasyon = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridIslem = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridAntijen = new System.Windows.Forms.DataGridView();
            this.txtAntijen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridMutasyonx1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridSıralama = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridMutasyonx2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridMutasyon2 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridMutasyon3 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridMutasyon4 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridYeniPopulasyon = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCozum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIslem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAntijen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyonx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSıralama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyonx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYeniPopulasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMutasyon);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCalıstır);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBeta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIterasyon);
            this.groupBox1.Controls.Add(this.txtPopulasyon);
            this.groupBox1.Location = new System.Drawing.Point(106, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optimizasyon Parametreleri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "(Mutasyon oranı 0 ile 1 arasında olmalıdır.)\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mutasyon Oranı:";
            // 
            // txtMutasyon
            // 
            this.txtMutasyon.Location = new System.Drawing.Point(631, 15);
            this.txtMutasyon.Name = "txtMutasyon";
            this.txtMutasyon.Size = new System.Drawing.Size(100, 20);
            this.txtMutasyon.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(936, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "İterasyon Sayısı:";
            // 
            // btnCalıstır
            // 
            this.btnCalıstır.Location = new System.Drawing.Point(936, 25);
            this.btnCalıstır.Name = "btnCalıstır";
            this.btnCalıstır.Size = new System.Drawing.Size(99, 24);
            this.btnCalıstır.TabIndex = 4;
            this.btnCalıstır.Text = "Oluştur";
            this.btnCalıstır.UseVisualStyleBackColor = true;
            this.btnCalıstır.Click += new System.EventHandler(this.btnCalıstır_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beta Değeri:";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(175, 54);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 20);
            this.txtn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "n Değeri:\r\n";
            // 
            // txtBeta
            // 
            this.txtBeta.Location = new System.Drawing.Point(404, 19);
            this.txtBeta.Name = "txtBeta";
            this.txtBeta.Size = new System.Drawing.Size(100, 20);
            this.txtBeta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Populasyonu:\r\n";
            // 
            // txtIterasyon
            // 
            this.txtIterasyon.Location = new System.Drawing.Point(404, 54);
            this.txtIterasyon.Name = "txtIterasyon";
            this.txtIterasyon.Size = new System.Drawing.Size(100, 20);
            this.txtIterasyon.TabIndex = 1;
            // 
            // txtPopulasyon
            // 
            this.txtPopulasyon.Location = new System.Drawing.Point(175, 19);
            this.txtPopulasyon.Name = "txtPopulasyon";
            this.txtPopulasyon.Size = new System.Drawing.Size(100, 20);
            this.txtPopulasyon.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(81, 116);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(376, 198);
            this.dataGrid.TabIndex = 1;
            // 
            // dataGridIslem
            // 
            this.dataGridIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIslem.Location = new System.Drawing.Point(81, 343);
            this.dataGridIslem.Name = "dataGridIslem";
            this.dataGridIslem.Size = new System.Drawing.Size(376, 181);
            this.dataGridIslem.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "İşleme Alınacak Antikorlar";
            // 
            // dataGridAntijen
            // 
            this.dataGridAntijen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAntijen.Location = new System.Drawing.Point(478, 343);
            this.dataGridAntijen.Name = "dataGridAntijen";
            this.dataGridAntijen.Size = new System.Drawing.Size(376, 181);
            this.dataGridAntijen.TabIndex = 6;
            this.dataGridAntijen.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridAntijen_RowsAdded);
            // 
            // txtAntijen
            // 
            this.txtAntijen.Location = new System.Drawing.Point(681, 529);
            this.txtAntijen.Name = "txtAntijen";
            this.txtAntijen.Size = new System.Drawing.Size(100, 20);
            this.txtAntijen.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Toplam Antijen Sayısı:\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Antijenler Listesi";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Başlangıç Populasyonu";
            // 
            // dataGridMutasyonx1
            // 
            this.dataGridMutasyonx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMutasyonx1.Location = new System.Drawing.Point(892, 116);
            this.dataGridMutasyonx1.Name = "dataGridMutasyonx1";
            this.dataGridMutasyonx1.Size = new System.Drawing.Size(364, 198);
            this.dataGridMutasyonx1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(943, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "x1 Değerine Göre Mutasyona Uğrayacak Örnekler";
            // 
            // dataGridSıralama
            // 
            this.dataGridSıralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSıralama.Location = new System.Drawing.Point(478, 116);
            this.dataGridSıralama.Name = "dataGridSıralama";
            this.dataGridSıralama.Size = new System.Drawing.Size(376, 198);
            this.dataGridSıralama.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(576, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Sıralanmış Populasyon";
            // 
            // dataGridMutasyonx2
            // 
            this.dataGridMutasyonx2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMutasyonx2.Location = new System.Drawing.Point(892, 343);
            this.dataGridMutasyonx2.Name = "dataGridMutasyonx2";
            this.dataGridMutasyonx2.Size = new System.Drawing.Size(364, 181);
            this.dataGridMutasyonx2.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(943, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(241, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "x2 Değerine göre Mutasyona Uğrayacak Örnekler";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridMutasyon2
            // 
            this.dataGridMutasyon2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMutasyon2.Location = new System.Drawing.Point(81, 568);
            this.dataGridMutasyon2.Name = "dataGridMutasyon2";
            this.dataGridMutasyon2.Size = new System.Drawing.Size(376, 176);
            this.dataGridMutasyon2.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(191, 552);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Mutasyona Uğrayan Örnekler\r\n";
            // 
            // dataGridMutasyon3
            // 
            this.dataGridMutasyon3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMutasyon3.Location = new System.Drawing.Point(478, 568);
            this.dataGridMutasyon3.Name = "dataGridMutasyon3";
            this.dataGridMutasyon3.Size = new System.Drawing.Size(376, 176);
            this.dataGridMutasyon3.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(594, 552);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = " Sıralanmış Mutasyon Örnekleri\r\n";
            // 
            // dataGridMutasyon4
            // 
            this.dataGridMutasyon4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMutasyon4.Location = new System.Drawing.Point(892, 568);
            this.dataGridMutasyon4.Name = "dataGridMutasyon4";
            this.dataGridMutasyon4.Size = new System.Drawing.Size(364, 176);
            this.dataGridMutasyon4.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(990, 552);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Seçilmiş Sıralı Mutasyon Örnekleri\r\n";
            // 
            // dataGridYeniPopulasyon
            // 
            this.dataGridYeniPopulasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYeniPopulasyon.Location = new System.Drawing.Point(338, 772);
            this.dataGridYeniPopulasyon.Name = "dataGridYeniPopulasyon";
            this.dataGridYeniPopulasyon.Size = new System.Drawing.Size(443, 171);
            this.dataGridYeniPopulasyon.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(507, 756);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Yeni Populasyon";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(854, 797);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "En İyi Çözüm:";
            // 
            // lblCozum
            // 
            this.lblCozum.AutoSize = true;
            this.lblCozum.Location = new System.Drawing.Point(932, 797);
            this.lblCozum.Name = "lblCozum";
            this.lblCozum.Size = new System.Drawing.Size(41, 13);
            this.lblCozum.TabIndex = 28;
            this.lblCozum.Text = "label19";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblCozum);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dataGridYeniPopulasyon);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridMutasyon4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridMutasyon3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridMutasyon2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridMutasyonx2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridSıralama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridMutasyonx1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAntijen);
            this.Controls.Add(this.dataGridAntijen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridIslem);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIslem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAntijen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyonx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSıralama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyonx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMutasyon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYeniPopulasyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalıstır;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPopulasyon;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridIslem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridAntijen;
        private System.Windows.Forms.TextBox txtAntijen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMutasyon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridMutasyonx1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridSıralama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridMutasyonx2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIterasyon;
        private System.Windows.Forms.DataGridView dataGridMutasyon2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridMutasyon3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridMutasyon4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridYeniPopulasyon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCozum;
    }
}

