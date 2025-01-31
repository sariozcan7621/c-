namespace Kütüphane_Yönetim_Sistemi
{
    partial class FormKitaplar
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
            groupBox1 = new GroupBox();
            buttonSil = new Button();
            buttonKitaplarıGöster = new Button();
            buttonTemizle = new Button();
            buttonAra = new Button();
            labelIdD = new Label();
            buttonGüncelle = new Button();
            buttonKitapEkle = new Button();
            textKitapTürKodu = new TextBox();
            textISBN = new TextBox();
            textYazarSoyadı = new TextBox();
            label7 = new Label();
            textYazarAdı = new TextBox();
            textKitapAdı = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonKitapÖdünçVer = new Button();
            dateTimePickerÖdünçAlmaTarihi = new DateTimePicker();
            labelÖdünçAlan = new Label();
            label2 = new Label();
            textBoxÖdünçAlan = new TextBox();
            groupBox3 = new GroupBox();
            buttonKitabıİadeEt = new Button();
            buttonGecikmeBedeliHesapla = new Button();
            labelTL = new Label();
            labelGecikmeÜcreti = new Label();
            label4 = new Label();
            dataGridViewKitaplar = new DataGridView();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSil);
            groupBox1.Controls.Add(buttonKitaplarıGöster);
            groupBox1.Controls.Add(buttonTemizle);
            groupBox1.Controls.Add(buttonAra);
            groupBox1.Controls.Add(labelIdD);
            groupBox1.Controls.Add(buttonGüncelle);
            groupBox1.Controls.Add(buttonKitapEkle);
            groupBox1.Controls.Add(textKitapTürKodu);
            groupBox1.Controls.Add(textISBN);
            groupBox1.Controls.Add(textYazarSoyadı);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textYazarAdı);
            groupBox1.Controls.Add(textKitapAdı);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 458);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Kayıt Ve Güncelleme";
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(239, 335);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(94, 64);
            buttonSil.TabIndex = 6;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonKitaplarıGöster
            // 
            buttonKitaplarıGöster.Location = new Point(557, 336);
            buttonKitaplarıGöster.Name = "buttonKitaplarıGöster";
            buttonKitaplarıGöster.Size = new Size(86, 63);
            buttonKitaplarıGöster.TabIndex = 5;
            buttonKitaplarıGöster.Text = "Kitapları Göster";
            buttonKitaplarıGöster.UseVisualStyleBackColor = true;
            buttonKitaplarıGöster.Click += buttonKitaplarıGöster_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(339, 336);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(103, 63);
            buttonTemizle.TabIndex = 4;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(448, 336);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(103, 62);
            buttonAra.TabIndex = 4;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // labelIdD
            // 
            labelIdD.AutoSize = true;
            labelIdD.Location = new Point(189, 53);
            labelIdD.Name = "labelIdD";
            labelIdD.Size = new Size(44, 25);
            labelIdD.TabIndex = 3;
            labelIdD.Text = "l----";
            // 
            // buttonGüncelle
            // 
            buttonGüncelle.Location = new Point(17, 335);
            buttonGüncelle.Name = "buttonGüncelle";
            buttonGüncelle.Size = new Size(101, 64);
            buttonGüncelle.TabIndex = 2;
            buttonGüncelle.Text = "Kitap Güncelle";
            buttonGüncelle.UseVisualStyleBackColor = true;
            buttonGüncelle.Click += buttonGüncelle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(123, 335);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(110, 64);
            buttonKitapEkle.TabIndex = 2;
            buttonKitapEkle.Text = "Yeni Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // textKitapTürKodu
            // 
            textKitapTürKodu.Font = new Font("Segoe UI", 12F);
            textKitapTürKodu.Location = new Point(189, 283);
            textKitapTürKodu.Name = "textKitapTürKodu";
            textKitapTürKodu.Size = new Size(240, 34);
            textKitapTürKodu.TabIndex = 1;
            // 
            // textISBN
            // 
            textISBN.Font = new Font("Segoe UI", 12F);
            textISBN.Location = new Point(189, 234);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(240, 34);
            textISBN.TabIndex = 1;
            // 
            // textYazarSoyadı
            // 
            textYazarSoyadı.Font = new Font("Segoe UI", 12F);
            textYazarSoyadı.Location = new Point(189, 189);
            textYazarSoyadı.Name = "textYazarSoyadı";
            textYazarSoyadı.Size = new Size(324, 34);
            textYazarSoyadı.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F);
            label7.Location = new Point(20, 290);
            label7.Name = "label7";
            label7.Size = new Size(163, 23);
            label7.TabIndex = 0;
            label7.Text = "Kitap Tür Kodu:";
            // 
            // textYazarAdı
            // 
            textYazarAdı.Font = new Font("Segoe UI", 12F);
            textYazarAdı.Location = new Point(189, 143);
            textYazarAdı.Name = "textYazarAdı";
            textYazarAdı.Size = new Size(324, 34);
            textYazarAdı.TabIndex = 1;
            // 
            // textKitapAdı
            // 
            textKitapAdı.Font = new Font("Segoe UI", 12F);
            textKitapAdı.Location = new Point(189, 97);
            textKitapAdı.Name = "textKitapAdı";
            textKitapAdı.Size = new Size(324, 34);
            textKitapAdı.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F);
            label6.Location = new Point(34, 234);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 0;
            label6.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F);
            label5.Location = new Point(20, 189);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 0;
            label5.Text = "YazarSoyadı:";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F);
            label8.Location = new Point(20, 104);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 0;
            label8.Text = "Kitap Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F);
            label3.Location = new Point(20, 150);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 0;
            label3.Text = "Yazar Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F);
            label1.Location = new Point(20, 55);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitapÖdünçVer);
            groupBox2.Controls.Add(dateTimePickerÖdünçAlmaTarihi);
            groupBox2.Controls.Add(labelÖdünçAlan);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxÖdünçAlan);
            groupBox2.Location = new Point(667, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 417);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // buttonKitapÖdünçVer
            // 
            buttonKitapÖdünçVer.Location = new Point(154, 256);
            buttonKitapÖdünçVer.Name = "buttonKitapÖdünçVer";
            buttonKitapÖdünçVer.Size = new Size(137, 57);
            buttonKitapÖdünçVer.TabIndex = 1;
            buttonKitapÖdünçVer.Text = "Kitabı Ödünç Ver";
            buttonKitapÖdünçVer.UseVisualStyleBackColor = true;
            buttonKitapÖdünçVer.Click += buttonKitapÖdünçVer_Click;
            // 
            // dateTimePickerÖdünçAlmaTarihi
            // 
            dateTimePickerÖdünçAlmaTarihi.Location = new Point(157, 102);
            dateTimePickerÖdünçAlmaTarihi.Name = "dateTimePickerÖdünçAlmaTarihi";
            dateTimePickerÖdünçAlmaTarihi.Size = new Size(134, 27);
            dateTimePickerÖdünçAlmaTarihi.TabIndex = 2;
            // 
            // labelÖdünçAlan
            // 
            labelÖdünçAlan.AutoSize = true;
            labelÖdünçAlan.Font = new Font("Century", 12F);
            labelÖdünçAlan.Location = new Point(6, 51);
            labelÖdünçAlan.Name = "labelÖdünçAlan";
            labelÖdünçAlan.Size = new Size(125, 23);
            labelÖdünçAlan.TabIndex = 0;
            labelÖdünçAlan.Text = "Ödünç Alan:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 0;
            label2.Text = "Tarih:";
            // 
            // textBoxÖdünçAlan
            // 
            textBoxÖdünçAlan.Font = new Font("Segoe UI", 12F);
            textBoxÖdünçAlan.Location = new Point(157, 44);
            textBoxÖdünçAlan.Name = "textBoxÖdünçAlan";
            textBoxÖdünçAlan.Size = new Size(134, 34);
            textBoxÖdünçAlan.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKitabıİadeEt);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(labelTL);
            groupBox3.Controls.Add(labelGecikmeÜcreti);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(1068, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 399);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade ";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // buttonKitabıİadeEt
            // 
            buttonKitabıİadeEt.Location = new Point(65, 305);
            buttonKitabıİadeEt.Name = "buttonKitabıİadeEt";
            buttonKitabıİadeEt.Size = new Size(137, 55);
            buttonKitabıİadeEt.TabIndex = 1;
            buttonKitabıİadeEt.Text = "Kitabı İade Et";
            buttonKitabıİadeEt.UseVisualStyleBackColor = true;
            buttonKitabıİadeEt.Click += buttonKitabıİadeEt_Click;
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.Location = new Point(65, 202);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(137, 55);
            buttonGecikmeBedeliHesapla.TabIndex = 1;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // labelTL
            // 
            labelTL.AutoSize = true;
            labelTL.Font = new Font("Century", 12F);
            labelTL.Location = new Point(216, 49);
            labelTL.Name = "labelTL";
            labelTL.Size = new Size(36, 23);
            labelTL.TabIndex = 0;
            labelTL.Text = "TL";
            labelTL.Click += label4_Click;
            // 
            // labelGecikmeÜcreti
            // 
            labelGecikmeÜcreti.AutoSize = true;
            labelGecikmeÜcreti.Font = new Font("Century", 12F);
            labelGecikmeÜcreti.Location = new Point(170, 49);
            labelGecikmeÜcreti.Name = "labelGecikmeÜcreti";
            labelGecikmeÜcreti.Size = new Size(21, 23);
            labelGecikmeÜcreti.TabIndex = 0;
            labelGecikmeÜcreti.Text = "0";
            labelGecikmeÜcreti.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F);
            label4.Location = new Point(5, 48);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 0;
            label4.Text = "Gecikme Bedeli:";
            label4.Click += label4_Click;
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 23);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(1451, 194);
            dataGridViewKitaplar.TabIndex = 3;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(-2, 438);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1457, 220);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1452, 657);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormKitaplar";
            Text = "l";
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textKitapTürKodu;
        private TextBox textISBN;
        private TextBox textYazarSoyadı;
        private TextBox textKitapAdı;
        private DataGridView dataGridViewKitaplar;
        private GroupBox groupBox4;
        private Button buttonGüncelle;
        private Button buttonKitapEkle;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePickerÖdünçAlmaTarihi;
        private TextBox textBoxÖdünçAlan;
        private Button buttonGecikmeBedeliHesapla;
        private Label labelGecikmeÜcreti;
        private Button buttonKitapÖdünçVer;
        private Label labelTL;
        private Button buttonKitabıİadeEt;
        private Label labelÖdünçAlan;
        private TextBox textYazarAdı;
        private Label label8;
        private Label labelIdD;
        private Button buttonTemizle;
        private Button buttonAra;
        private Button buttonKitaplarıGöster;
        private Button buttonSil;
    }
}