namespace GoruntuIsleme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            griDonusumButton = new Button();
            binaryDonusumButton = new Button();
            convertToOriginalPicture = new Button();
            kontrastNumericUpDown = new NumericUpDown();
            kontrastLabel = new Label();
            kontrastButton = new Button();
            konvolusyonButton = new Button();
            esiklemeButton = new Button();
            esiklemeNumericUpDown = new NumericUpDown();
            kenarBulButton = new Button();
            gurultuEkleButton = new Button();
            gurultuSilButton = new Button();
            filtreButton = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            morfolojiButton = new Button();
            goruntuYaklastir = new Button();
            goruntuUzaklastir = new Button();
            goruntuDondurmeButton = new Button();
            label2 = new Label();
            goruntuDondurmeNumericUpDown = new NumericUpDown();
            goruntuEklemeButton = new Button();
            goruntuBolmeButton = new Button();
            histogramGenisletmeButton = new Button();
            histogramGermeButton = new Button();
            goruntuKirpmaButton = new Button();
            renkDonusumleriButton = new Button();
            alanSecButton = new Button();
            comboBox2 = new ComboBox();
            resimKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kontrastNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)esiklemeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goruntuDondurmeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(424, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // griDonusumButton
            // 
            griDonusumButton.BackColor = Color.LightSkyBlue;
            griDonusumButton.Location = new Point(38, 128);
            griDonusumButton.Name = "griDonusumButton";
            griDonusumButton.Size = new Size(261, 29);
            griDonusumButton.TabIndex = 1;
            griDonusumButton.Text = "Gri Dönüşüm";
            griDonusumButton.UseVisualStyleBackColor = false;
            griDonusumButton.Click += griDonusumButton_Click;
            // 
            // binaryDonusumButton
            // 
            binaryDonusumButton.BackColor = Color.LightSkyBlue;
            binaryDonusumButton.Location = new Point(38, 163);
            binaryDonusumButton.Name = "binaryDonusumButton";
            binaryDonusumButton.Size = new Size(261, 29);
            binaryDonusumButton.TabIndex = 2;
            binaryDonusumButton.Text = "Binary Dönüşüm";
            binaryDonusumButton.UseVisualStyleBackColor = false;
            binaryDonusumButton.Click += binaryDonusumButton_Click;
            // 
            // convertToOriginalPicture
            // 
            convertToOriginalPicture.BackColor = Color.DodgerBlue;
            convertToOriginalPicture.Location = new Point(487, 584);
            convertToOriginalPicture.Name = "convertToOriginalPicture";
            convertToOriginalPicture.Size = new Size(369, 29);
            convertToOriginalPicture.TabIndex = 3;
            convertToOriginalPicture.Text = "Orijinal Haline Getir";
            convertToOriginalPicture.UseVisualStyleBackColor = false;
            convertToOriginalPicture.Click += convertToOriginalPicture_Click;
            // 
            // kontrastNumericUpDown
            // 
            kontrastNumericUpDown.BackColor = Color.LightSkyBlue;
            kontrastNumericUpDown.Location = new Point(1074, 240);
            kontrastNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            kontrastNumericUpDown.Name = "kontrastNumericUpDown";
            kontrastNumericUpDown.Size = new Size(100, 27);
            kontrastNumericUpDown.TabIndex = 7;
            kontrastNumericUpDown.ValueChanged += kontrastNumericUpDown_ValueChanged;
            // 
            // kontrastLabel
            // 
            kontrastLabel.AutoSize = true;
            kontrastLabel.BackColor = Color.LightSkyBlue;
            kontrastLabel.Location = new Point(918, 242);
            kontrastLabel.Name = "kontrastLabel";
            kontrastLabel.Size = new Size(150, 20);
            kontrastLabel.TabIndex = 8;
            kontrastLabel.Text = "Kontrast Oranı Seçin :";
            // 
            // kontrastButton
            // 
            kontrastButton.BackColor = Color.LightSkyBlue;
            kontrastButton.Location = new Point(1208, 235);
            kontrastButton.Name = "kontrastButton";
            kontrastButton.Size = new Size(122, 34);
            kontrastButton.TabIndex = 9;
            kontrastButton.Text = "Kontrast Arttır";
            kontrastButton.UseVisualStyleBackColor = false;
            kontrastButton.Click += kontrastButton_Click;
            // 
            // konvolusyonButton
            // 
            konvolusyonButton.BackColor = Color.LightSkyBlue;
            konvolusyonButton.Location = new Point(38, 498);
            konvolusyonButton.Name = "konvolusyonButton";
            konvolusyonButton.Size = new Size(380, 29);
            konvolusyonButton.TabIndex = 10;
            konvolusyonButton.Text = "Konvolüsyon Uygula";
            konvolusyonButton.UseVisualStyleBackColor = false;
            konvolusyonButton.Click += konvolusyonButton_Click;
            // 
            // esiklemeButton
            // 
            esiklemeButton.BackColor = Color.LightSkyBlue;
            esiklemeButton.Location = new Point(38, 208);
            esiklemeButton.Name = "esiklemeButton";
            esiklemeButton.Size = new Size(113, 54);
            esiklemeButton.TabIndex = 11;
            esiklemeButton.Text = "Eşikleme İşlemi";
            esiklemeButton.UseVisualStyleBackColor = false;
            esiklemeButton.Click += esiklemeButton_Click;
            // 
            // esiklemeNumericUpDown
            // 
            esiklemeNumericUpDown.BackColor = Color.LightSkyBlue;
            esiklemeNumericUpDown.Location = new Point(157, 225);
            esiklemeNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            esiklemeNumericUpDown.Name = "esiklemeNumericUpDown";
            esiklemeNumericUpDown.Size = new Size(261, 27);
            esiklemeNumericUpDown.TabIndex = 7;
            esiklemeNumericUpDown.ValueChanged += kontrastNumericUpDown_ValueChanged;
            // 
            // kenarBulButton
            // 
            kenarBulButton.BackColor = Color.LightSkyBlue;
            kenarBulButton.Location = new Point(38, 279);
            kenarBulButton.Name = "kenarBulButton";
            kenarBulButton.Size = new Size(380, 29);
            kenarBulButton.TabIndex = 11;
            kenarBulButton.Text = "Kenar Bulma";
            kenarBulButton.UseVisualStyleBackColor = false;
            kenarBulButton.Click += kenarBulButton_Click_1;
            // 
            // gurultuEkleButton
            // 
            gurultuEkleButton.BackColor = Color.LightSkyBlue;
            gurultuEkleButton.Location = new Point(918, 128);
            gurultuEkleButton.Name = "gurultuEkleButton";
            gurultuEkleButton.Size = new Size(122, 74);
            gurultuEkleButton.TabIndex = 11;
            gurultuEkleButton.Text = "Gürültü Ekle";
            gurultuEkleButton.UseVisualStyleBackColor = false;
            gurultuEkleButton.Click += gurultuEkleButton_Click;
            // 
            // gurultuSilButton
            // 
            gurultuSilButton.BackColor = Color.LightSkyBlue;
            gurultuSilButton.Location = new Point(1208, 128);
            gurultuSilButton.Name = "gurultuSilButton";
            gurultuSilButton.Size = new Size(122, 74);
            gurultuSilButton.TabIndex = 11;
            gurultuSilButton.Text = "Gürültü Sil";
            gurultuSilButton.UseVisualStyleBackColor = false;
            gurultuSilButton.Click += gurultuSilButton_Click;
            // 
            // filtreButton
            // 
            filtreButton.BackColor = Color.LightSkyBlue;
            filtreButton.Location = new Point(38, 449);
            filtreButton.Name = "filtreButton";
            filtreButton.Size = new Size(380, 29);
            filtreButton.TabIndex = 12;
            filtreButton.Text = "Unsharp Filtresi Uygula";
            filtreButton.UseVisualStyleBackColor = false;
            filtreButton.Click += filtreButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightSkyBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1087, 309);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(87, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Location = new Point(918, 312);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 14;
            label1.Text = "Morfolojik İşlem Seçin :";
            // 
            // morfolojiButton
            // 
            morfolojiButton.BackColor = Color.LightSkyBlue;
            morfolojiButton.Location = new Point(1208, 306);
            morfolojiButton.Name = "morfolojiButton";
            morfolojiButton.Size = new Size(122, 33);
            morfolojiButton.TabIndex = 15;
            morfolojiButton.Text = "Uygula";
            morfolojiButton.UseVisualStyleBackColor = false;
            morfolojiButton.Click += morfolojiButton_Click;
            // 
            // goruntuYaklastir
            // 
            goruntuYaklastir.BackColor = Color.LightSkyBlue;
            goruntuYaklastir.Location = new Point(918, 498);
            goruntuYaklastir.Name = "goruntuYaklastir";
            goruntuYaklastir.Size = new Size(202, 29);
            goruntuYaklastir.TabIndex = 18;
            goruntuYaklastir.Text = "Görüntü Yaklaştır";
            goruntuYaklastir.UseVisualStyleBackColor = false;
            goruntuYaklastir.Click += goruntuYaklastir_Click;
            // 
            // goruntuUzaklastir
            // 
            goruntuUzaklastir.BackColor = Color.LightSkyBlue;
            goruntuUzaklastir.Location = new Point(1128, 498);
            goruntuUzaklastir.Name = "goruntuUzaklastir";
            goruntuUzaklastir.Size = new Size(202, 29);
            goruntuUzaklastir.TabIndex = 19;
            goruntuUzaklastir.Text = "Görüntü Uzaklaştır";
            goruntuUzaklastir.UseVisualStyleBackColor = false;
            goruntuUzaklastir.Click += goruntuUzaklastir_Click;
            // 
            // goruntuDondurmeButton
            // 
            goruntuDondurmeButton.BackColor = Color.LightSkyBlue;
            goruntuDondurmeButton.Location = new Point(918, 429);
            goruntuDondurmeButton.Name = "goruntuDondurmeButton";
            goruntuDondurmeButton.Size = new Size(412, 29);
            goruntuDondurmeButton.TabIndex = 20;
            goruntuDondurmeButton.Text = "Goruntu Dondurme";
            goruntuDondurmeButton.UseVisualStyleBackColor = false;
            goruntuDondurmeButton.Click += goruntuDondurmeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Location = new Point(918, 377);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 21;
            label2.Text = "Görüntü Döndürme Oranı :";
            // 
            // goruntuDondurmeNumericUpDown
            // 
            goruntuDondurmeNumericUpDown.BackColor = Color.LightSkyBlue;
            goruntuDondurmeNumericUpDown.Location = new Point(1108, 375);
            goruntuDondurmeNumericUpDown.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            goruntuDondurmeNumericUpDown.Name = "goruntuDondurmeNumericUpDown";
            goruntuDondurmeNumericUpDown.Size = new Size(222, 27);
            goruntuDondurmeNumericUpDown.TabIndex = 22;
            // 
            // goruntuEklemeButton
            // 
            goruntuEklemeButton.BackColor = Color.LightSkyBlue;
            goruntuEklemeButton.Location = new Point(38, 336);
            goruntuEklemeButton.Name = "goruntuEklemeButton";
            goruntuEklemeButton.Size = new Size(202, 30);
            goruntuEklemeButton.TabIndex = 24;
            goruntuEklemeButton.Text = "Görüntü Ekleme";
            goruntuEklemeButton.UseVisualStyleBackColor = false;
            goruntuEklemeButton.Click += goruntuEklemeButton_Click;
            // 
            // goruntuBolmeButton
            // 
            goruntuBolmeButton.BackColor = Color.LightSkyBlue;
            goruntuBolmeButton.Location = new Point(246, 336);
            goruntuBolmeButton.Name = "goruntuBolmeButton";
            goruntuBolmeButton.Size = new Size(172, 29);
            goruntuBolmeButton.TabIndex = 25;
            goruntuBolmeButton.Text = "Görüntü Bölme";
            goruntuBolmeButton.UseVisualStyleBackColor = false;
            goruntuBolmeButton.Click += goruntuBolmeButton_Click;
            // 
            // histogramGenisletmeButton
            // 
            histogramGenisletmeButton.BackColor = Color.LightSkyBlue;
            histogramGenisletmeButton.Location = new Point(38, 388);
            histogramGenisletmeButton.Name = "histogramGenisletmeButton";
            histogramGenisletmeButton.Size = new Size(202, 30);
            histogramGenisletmeButton.TabIndex = 26;
            histogramGenisletmeButton.Text = "Histogram Genişletme";
            histogramGenisletmeButton.UseVisualStyleBackColor = false;
            histogramGenisletmeButton.Click += histogramGenisletmeButton_Click_1;
            // 
            // histogramGermeButton
            // 
            histogramGermeButton.BackColor = Color.LightSkyBlue;
            histogramGermeButton.Location = new Point(246, 387);
            histogramGermeButton.Name = "histogramGermeButton";
            histogramGermeButton.Size = new Size(172, 31);
            histogramGermeButton.TabIndex = 27;
            histogramGermeButton.Text = "Histogram Germe";
            histogramGermeButton.UseVisualStyleBackColor = false;
            histogramGermeButton.Click += histogramGermeButton_Click;
            // 
            // goruntuKirpmaButton
            // 
            goruntuKirpmaButton.BackColor = Color.LightSkyBlue;
            goruntuKirpmaButton.Location = new Point(677, 536);
            goruntuKirpmaButton.Name = "goruntuKirpmaButton";
            goruntuKirpmaButton.Size = new Size(179, 29);
            goruntuKirpmaButton.TabIndex = 28;
            goruntuKirpmaButton.Text = "Görüntü Kırp";
            goruntuKirpmaButton.UseVisualStyleBackColor = false;
            goruntuKirpmaButton.Click += goruntuKirpmaButton_Click_1;
            // 
            // renkDonusumleriButton
            // 
            renkDonusumleriButton.BackColor = Color.LightSkyBlue;
            renkDonusumleriButton.Location = new Point(305, 128);
            renkDonusumleriButton.Name = "renkDonusumleriButton";
            renkDonusumleriButton.Size = new Size(113, 64);
            renkDonusumleriButton.TabIndex = 31;
            renkDonusumleriButton.Text = "Renk Dönüşümleri";
            renkDonusumleriButton.UseVisualStyleBackColor = false;
            renkDonusumleriButton.Click += renkDonusumleriButton_Click;
            // 
            // alanSecButton
            // 
            alanSecButton.BackColor = Color.LightSkyBlue;
            alanSecButton.Location = new Point(487, 536);
            alanSecButton.Name = "alanSecButton";
            alanSecButton.Size = new Size(184, 29);
            alanSecButton.TabIndex = 32;
            alanSecButton.Text = "Alan Seç";
            alanSecButton.UseVisualStyleBackColor = false;
            alanSecButton.Click += alanSecButton_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightSkyBlue;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1074, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 28);
            comboBox2.TabIndex = 33;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // resimKaydet
            // 
            resimKaydet.BackColor = Color.DodgerBlue;
            resimKaydet.Location = new Point(487, 637);
            resimKaydet.Name = "resimKaydet";
            resimKaydet.Size = new Size(369, 29);
            resimKaydet.TabIndex = 34;
            resimKaydet.Text = "Resmi Kaydet";
            resimKaydet.UseVisualStyleBackColor = false;
            resimKaydet.Click += resimKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1442, 687);
            Controls.Add(resimKaydet);
            Controls.Add(comboBox2);
            Controls.Add(alanSecButton);
            Controls.Add(renkDonusumleriButton);
            Controls.Add(goruntuKirpmaButton);
            Controls.Add(histogramGermeButton);
            Controls.Add(histogramGenisletmeButton);
            Controls.Add(goruntuBolmeButton);
            Controls.Add(goruntuEklemeButton);
            Controls.Add(goruntuDondurmeNumericUpDown);
            Controls.Add(label2);
            Controls.Add(goruntuDondurmeButton);
            Controls.Add(goruntuUzaklastir);
            Controls.Add(goruntuYaklastir);
            Controls.Add(morfolojiButton);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(filtreButton);
            Controls.Add(gurultuSilButton);
            Controls.Add(gurultuEkleButton);
            Controls.Add(kenarBulButton);
            Controls.Add(esiklemeButton);
            Controls.Add(konvolusyonButton);
            Controls.Add(kontrastButton);
            Controls.Add(kontrastLabel);
            Controls.Add(esiklemeNumericUpDown);
            Controls.Add(kontrastNumericUpDown);
            Controls.Add(convertToOriginalPicture);
            Controls.Add(binaryDonusumButton);
            Controls.Add(griDonusumButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Görüntü İşleme Teknikleri ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kontrastNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)esiklemeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)goruntuDondurmeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button griDonusumButton;
        private Button binaryDonusumButton;
        private Button convertToOriginalPicture;
        private NumericUpDown kontrastNumericUpDown;
        private Label kontrastLabel;
        private Button kontrastButton;
        private Button konvolusyonButton;
        private Button esiklemeButton;
        private NumericUpDown esiklemeNumericUpDown;
        private Button kenarBulButton;
        private Button gurultuEkleButton;
        private Button gurultuSilButton;
        private Button filtreButton;
        private ComboBox comboBox1;
        private Label label1;
        private Button morfolojiButton;
        private Button button1;
        private Button button2;
        private Button goruntuYaklastir;
        private Button goruntuUzaklastir;
        private Button goruntuDondurmeButton;
        private Label label2;
        private NumericUpDown goruntuDondurmeNumericUpDown;
        private Button goruntuEklemeButton;
        private Button goruntuBolmeButton;
        private Button histogramGenisletmeButton;
        private Button histogramGermeButton;
        private Button goruntuKirpmaButton;
        private Button renkDonusumleriButton;
        private Button alanSecButton;
        private ComboBox comboBox2;
        private Button resimKaydet;
    }
}