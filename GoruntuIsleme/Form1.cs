

namespace GoruntuIsleme
{
    public partial class Form1 : Form
    {

        private Bitmap originalImage;
        private Bitmap currentImage;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            comboBox1.Items.Add("Genişleme");
            comboBox1.Items.Add("Aşınma");
            comboBox1.Items.Add("Açınım");
            comboBox1.Items.Add("Kapanım");
            comboBox2.Items.Add("Median");
            comboBox2.Items.Add("Mean");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalImage = new System.Drawing.Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = originalImage;
                currentImage = new Bitmap(originalImage);
            }
        }


        private void griDonusumButton_Click(object sender, EventArgs e)
        {
            if (currentImage != null)
            {

                Bitmap grayImage = new Bitmap(currentImage);

                for (int y = 0; y < grayImage.Height; y++)
                {
                    for (int x = 0; x < grayImage.Width; x++)
                    {
                        Color originalColor = grayImage.GetPixel(x, y);
                        int grayScale = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11); //Formul
                        Color grayColor = Color.FromArgb(grayScale, grayScale, grayScale);
                        grayImage.SetPixel(x, y, grayColor);
                    }
                }

                pictureBox1.Image = grayImage;
                currentImage = new Bitmap(grayImage);
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }

        private void binaryDonusumButton_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {

                    Bitmap binaryImage = new Bitmap(currentImage);

                    for (int y = 0; y < binaryImage.Height; y++)
                    {
                        for (int x = 0; x < binaryImage.Width; x++)
                        {
                            Color originalColor = binaryImage.GetPixel(x, y);
                            int grayScale = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11); //Formul

                            int threshold = 128; //Esikleme değeri

                            Color binaryColor = (grayScale >= threshold) ? Color.White : Color.Black; //eşikleme işlemi

                            binaryImage.SetPixel(x, y, binaryColor);
                        }
                    }

                    pictureBox1.Image = binaryImage;
                    currentImage = new Bitmap(binaryImage);


                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }

        private void convertToOriginalPicture_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (originalImage != null)
                {

                    pictureBox1.Image = originalImage;


                    currentImage = new Bitmap(originalImage);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Orijinal resim bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Zaten bir resim yok.");
            }
        }

        private void goruntuDondurmeUpDown_ValueChanged(object sender, EventArgs e)
        {

        }



        private void kontrastButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {

                    Bitmap contrastedImage = new Bitmap(currentImage);

                    float contrastValue = (float)kontrastNumericUpDown.Value;

                    KonstratAyarla(contrastedImage, contrastValue);


                    pictureBox1.Image = contrastedImage;
                    currentImage = new Bitmap(contrastedImage);
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }

        }

        private void kontrastNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KonstratAyarla(Bitmap image, float contrast)
        {
            float factor = (259f * (contrast + 255f)) / (255f * (259f - contrast)); // Konstrat faktörü formulu

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    float r = pixel.R / 255f; //degerler 0 ile 1 arasına getirilir 
                    float g = pixel.G / 255f;
                    float b = pixel.B / 255f;

                    float newR = (factor * (r - 0.5f) + 0.5f) * 255f;
                    float newG = (factor * (g - 0.5f) + 0.5f) * 255f;
                    float newB = (factor * (b - 0.5f) + 0.5f) * 255f;

                    newR = Math.Max(0, Math.Min(255, newR));
                    newG = Math.Max(0, Math.Min(255, newG));
                    newB = Math.Max(0, Math.Min(255, newB));

                    Color newColor = Color.FromArgb((int)newR, (int)newG, (int)newB);
                    image.SetPixel(x, y, newColor);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void konvolusyonButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {

                    Bitmap blurredImage = new Bitmap(currentImage);

                    float[,] meanFilter = {
         { 1f/9f, 1f/9f, 1f/9f },
         { 1f/9f, 1f/9f, 1f/9f },
         { 1f/9f, 1f/9f, 1f/9f }
     };//3x3 boyutunda bir ortalama filtredir (mean filtesi).

                    konvolusyonUygula(blurredImage, meanFilter);

                    pictureBox1.Image = blurredImage;

                    currentImage = new Bitmap(blurredImage);
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }


        private void konvolusyonUygula(Bitmap image, float[,] filter)
        {
            int filterWidth = filter.GetLength(1);
            int filterHeight = filter.GetLength(0);
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            Bitmap newImage = new Bitmap(imageWidth, imageHeight);

            for (int y = 0; y < imageHeight; y++)
            {
                for (int x = 0; x < imageWidth; x++)
                {
                    float r = 0, g = 0, b = 0;

                    for (int filterY = 0; filterY < filterHeight; filterY++) //renklerin iç carpımı 
                    {
                        for (int filterX = 0; filterX < filterWidth; filterX++)
                        {
                            int imageX = x - filterWidth / 2 + filterX;
                            int imageY = y - filterHeight / 2 + filterY;

                            if (imageX >= 0 && imageX < imageWidth && imageY >= 0 && imageY < imageHeight)
                            {
                                Color pixel = image.GetPixel(imageX, imageY);
                                r += pixel.R * filter[filterY, filterX];
                                g += pixel.G * filter[filterY, filterX];
                                b += pixel.B * filter[filterY, filterX];
                            }
                        }
                    }


                    int newR = (int)Math.Max(0, Math.Min(255, r));
                    int newG = (int)Math.Max(0, Math.Min(255, g));
                    int newB = (int)Math.Max(0, Math.Min(255, b));

                    Color newColor = Color.FromArgb(newR, newG, newB);
                    newImage.SetPixel(x, y, newColor);
                }
            }

            Graphics.FromImage(image).DrawImage(newImage, Point.Empty);
        }

        private void esiklemeButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {
                    Bitmap thresholdedImage = new Bitmap(currentImage);

                    int thresholdValue = (int)esiklemeNumericUpDown.Value;

                    esikUygula(thresholdedImage, thresholdValue);


                    pictureBox1.Image = thresholdedImage;

                    currentImage = new Bitmap(thresholdedImage);
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }

        private void esikUygula(Bitmap image, int threshold)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int grayscale = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);

                    Color newColor = (grayscale >= threshold) ? Color.White : Color.Black;

                    image.SetPixel(x, y, newColor);
                }
            }
        }
        private void kenarBulButton_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {

                    Bitmap edgeDetectedImage = new Bitmap(currentImage);

                    prewittAlgoritma(edgeDetectedImage);

                    pictureBox1.Image = edgeDetectedImage;

                    currentImage = new Bitmap(edgeDetectedImage);
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }


        private void prewittAlgoritma(Bitmap image)
        {
            int[,] horizontalMask = { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
            int[,] verticalMask = { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };

            int width = image.Width;
            int height = image.Height;

            Bitmap edgeImage = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int horizontalGradient = 0;
                    int verticalGradient = 0;

                    for (int i = -1; i <= 1; i++) //kenar tespiti
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = image.GetPixel(x + i, y + j);
                            int grayscale = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);

                            horizontalGradient += grayscale * horizontalMask[i + 1, j + 1];
                            verticalGradient += grayscale * verticalMask[i + 1, j + 1];
                        }
                    }

                    int edgeMagnitude = (int)Math.Sqrt(horizontalGradient * horizontalGradient + verticalGradient * verticalGradient); //pikselin kenar büyüklüğü hesaplama formülü


                    edgeMagnitude = Math.Min(255, Math.Max(0, edgeMagnitude));

                    edgeImage.SetPixel(x, y, Color.FromArgb(edgeMagnitude, edgeMagnitude, edgeMagnitude));
                }
            }

            using (Graphics g = Graphics.FromImage(image))
            {
                g.DrawImage(edgeImage, 0, 0);
            }
        }

        private void gurultuEkleButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {
                    Bitmap noisyImage = new Bitmap(currentImage);

                    saltPaperFiltresi(noisyImage);

                    pictureBox1.Image = noisyImage;

                    currentImage = new Bitmap(noisyImage);
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }

        private void saltPaperFiltresi(Bitmap image)
        {
            Random rand = new Random();
            int noisePercentage = 5; //Gürültü yüzdesi belirledik max %10 olabilir 

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    if (rand.Next(100) < noisePercentage)
                    {
                        Color randomColor = rand.Next(2) == 0 ? Color.Black : Color.White;
                        image.SetPixel(x, y, randomColor);
                    }
                }
            }

            currentImage = new Bitmap(image);
        }
        private void gurultuSilButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {
                    Bitmap denoisedImage = new Bitmap(currentImage);

                    if (comboBox2.SelectedItem != null)
                    {
                        string selectedFilter = comboBox2.SelectedItem.ToString();
                        switch (selectedFilter)
                        {
                            case "Median":
                                medyanFiltreUygula(denoisedImage);
                                break;
                            case "Mean":
                                meanFiltreUygula(denoisedImage);
                                break;
                            default:
                                MessageBox.Show("Geçersiz filtre seçimi.");
                                return;
                        }

                        pictureBox1.Image = denoisedImage;
                        currentImage = new Bitmap(denoisedImage);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir filtre seçin.");
                    }
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }
        private void medyanFiltreUygula(Bitmap image)
        {
            int filterSize = 3; //Filtre boyutu 3x3 belirlendi
            int filterOffset = (filterSize - 1) / 2; // matrisin ortasına ulasıldı
            Bitmap tempImage = new Bitmap(image.Width, image.Height);

            for (int y = filterOffset; y < image.Height - filterOffset; y++) //yükseklik
            {
                for (int x = filterOffset; x < image.Width - filterOffset; x++) //genişlik
                {
                    List<int> redValues = new List<int>();
                    List<int> greenValues = new List<int>();
                    List<int> blueValues = new List<int>();

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            Color pixel = image.GetPixel(x + filterX, y + filterY);
                            redValues.Add(pixel.R);
                            greenValues.Add(pixel.G);
                            blueValues.Add(pixel.B);
                        }
                    }

                    redValues.Sort();
                    greenValues.Sort();
                    blueValues.Sort();

                    int medianRed = redValues[redValues.Count / 2];
                    int medianGreen = greenValues[greenValues.Count / 2];
                    int medianBlue = blueValues[blueValues.Count / 2];

                    tempImage.SetPixel(x, y, Color.FromArgb(medianRed, medianGreen, medianBlue));
                }
            }

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    image.SetPixel(x, y, tempImage.GetPixel(x, y));
                }
            }
        }

        private void meanFiltreUygula(Bitmap image)
        {
            int filterSize = 3; //filte boyutu 3x3 belirlendi
            int filterOffset = filterSize / 2; //matrisin ortasına ulasmak icin kullanılır 
            Bitmap tempImage = new Bitmap(image.Width, image.Height);

            for (int y = filterOffset; y < image.Height - filterOffset; y++) //yukseklik
            {
                for (int x = filterOffset; x < image.Width - filterOffset; x++)  //genislik 
                {
                    int sumR = 0, sumG = 0, sumB = 0;
                    int count = 0;

                    for (int fy = -filterOffset; fy <= filterOffset; fy++)
                    {
                        for (int fx = -filterOffset; fx <= filterOffset; fx++)
                        {
                            int offsetX = x + fx;
                            int offsetY = y + fy;

                            if (offsetX >= 0 && offsetX < image.Width && offsetY >= 0 && offsetY < image.Height)
                            {
                                Color pixel = image.GetPixel(offsetX, offsetY);
                                sumR += pixel.R;
                                sumG += pixel.G;
                                sumB += pixel.B;
                                count++;
                            }
                        }
                    }

                    int avgR = sumR / count;
                    int avgG = sumG / count;
                    int avgB = sumB / count;

                    tempImage.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }


            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    image.SetPixel(x, y, tempImage.GetPixel(x, y));
                }
            }
        }
        private void filtreButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {

                    Bitmap unsharpImage = new Bitmap(currentImage);

                    unsharpFiltreUygula(unsharpImage);

                    pictureBox1.Image = unsharpImage;

                    currentImage = new Bitmap(unsharpImage);
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }

        private void unsharpFiltreUygula(Bitmap image)
        {
            float[,] kernel = {
        { -1, -1, -1 },
        { -1,  9, -1 },
        { -1, -1, -1 }
    }; //3x3'lük bir matris, unsharp mask filtresini 

            int width = image.Width;
            int height = image.Height;

            Bitmap newImage = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++) //yukseklik
            {
                for (int x = 1; x < width - 1; x++) //genislik
                {
                    float sumR = 0, sumG = 0, sumB = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = image.GetPixel(x + i, y + j);
                            sumR += pixel.R * kernel[i + 1, j + 1];
                            sumG += pixel.G * kernel[i + 1, j + 1];
                            sumB += pixel.B * kernel[i + 1, j + 1];
                        }
                    } //kernel matrisindeki ağırlık değerleri kullanılarak piksellerin renk değerleriyle çarpılır ve toplanır

                    sumR = Math.Max(0, Math.Min(255, sumR));
                    sumG = Math.Max(0, Math.Min(255, sumG));
                    sumB = Math.Max(0, Math.Min(255, sumB));

                    Color newColor = Color.FromArgb((int)sumR, (int)sumG, (int)sumB);
                    newImage.SetPixel(x, y, newColor);
                }
            }

            Graphics.FromImage(image).DrawImage(newImage, Point.Empty);
        }
        private Bitmap Grayscale(Bitmap image)
        {
            Bitmap grayImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int grayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    grayImage.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }

            return grayImage;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOperation = comboBox1.SelectedItem.ToString();

            switch (selectedOperation)
            {
                case "Genişletme":
                    break;
                case "Aşınma":
                    break;
                case "Açma":
                    break;
                case "Kapama":
                    break;
                default:
                    break;
            }
        }


        private void ZoomIn()
        {
            if (pictureBox1.Image != null)
            {
                float zoomFactor = 1.1f; //%10 oranında büyüyecek 

                int newWidth = (int)(pictureBox1.Image.Width * zoomFactor);
                int newHeight = (int)(pictureBox1.Image.Height * zoomFactor); //resmin orjinal boyutlarını alıyoruz

                Bitmap zoomedImage = new Bitmap(newWidth, newHeight);

                using (Graphics g = Graphics.FromImage(zoomedImage))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;  //grafik nesnesi üzerindeki resmin yeniden boyutlandırılmas

                    g.DrawImage(pictureBox1.Image, new Rectangle(0, 0, newWidth, newHeight));
                }


                pictureBox1.Image = zoomedImage;

                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void ZoomOut()
        {
            if (pictureBox1.Image != null)
            {
                float zoomFactor = 0.9f;//%10 oranında kuculecek 

                int newWidth = (int)(pictureBox1.Image.Width * zoomFactor);
                int newHeight = (int)(pictureBox1.Image.Height * zoomFactor); //resmin orjinal boyutlarını alıyoruz

                Bitmap zoomedImage = new Bitmap(newWidth, newHeight);

                using (Graphics g = Graphics.FromImage(zoomedImage))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic; //grafik nesnesi üzerindeki resmin yeniden boyutlandırılması

                    g.DrawImage(pictureBox1.Image, new Rectangle(0, 0, newWidth, newHeight));
                }

                pictureBox1.Image = zoomedImage;

                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void goruntuYaklastir_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void goruntuUzaklastir_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void goruntuDondurmeButton_Click(object sender, EventArgs e)
        {
            float derece = (float)goruntuDondurmeNumericUpDown.Value;

            if (pictureBox1.Image != null)
            {
                if (currentImage != null)
                {

                    Bitmap rotatedImage = imageDondurme(currentImage, derece);


                    if (rotatedImage != null)
                    {
                        pictureBox1.Image = rotatedImage;
                    }
                }
                else
                {
                    MessageBox.Show("Görüntü bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }

        }

        private Bitmap imageDondurme(Bitmap sourceBitmap, float angle)
        {
            int sourceWidth = sourceBitmap.Width;
            int sourceHeight = sourceBitmap.Height;

            // Radian hesaplama 
            double radians = angle * (Math.PI / 180);
            double cos = Math.Abs(Math.Cos(radians));
            double sin = Math.Abs(Math.Sin(radians));

            int newWidth = (int)(sourceWidth * cos + sourceHeight * sin);
            int newHeight = (int)(sourceWidth * sin + sourceHeight * cos);

            Bitmap rotatedBitmap = new Bitmap(newWidth, newHeight);

            // Merkez Noktasını hesaplıyoruz
            int centerX = sourceWidth / 2;
            int centerY = sourceHeight / 2;
            int newCenterX = newWidth / 2;
            int newCenterY = newHeight / 2;

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    // Orijinal görüntüden alınacak pikselleri belirleme
                    int oldX = (int)((x - newCenterX) * Math.Cos(-radians) - (y - newCenterY) * Math.Sin(-radians)) + centerX;
                    int oldY = (int)((x - newCenterX) * Math.Sin(-radians) + (y - newCenterY) * Math.Cos(-radians)) + centerY;

                    if (oldX >= 0 && oldX < sourceWidth && oldY >= 0 && oldY < sourceHeight)
                    {
                        rotatedBitmap.SetPixel(x, y, sourceBitmap.GetPixel(oldX, oldY));
                    }
                }
            }

            return rotatedBitmap;
        }



        private void goruntuEklemeButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void goruntuBolmeButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }


        private void histogramGenisletmeButton_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

        }

        private void histogramGermeButton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void goruntuKirpmaButton_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default; //imlec ayarlanıyor

            Bitmap bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp2, pictureBox1.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            pictureBox1.Image = (Image)crpImg;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }


        private void renkDonusumleriButton_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();

        }

        private void morfolojiButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                Bitmap morphedImage = new Bitmap(pictureBox1.Image);

                string selectedOperation = comboBox1.SelectedItem?.ToString();

                int kernelSize = 3;

                switch (selectedOperation)
                {
                    case "Genişleme":
                        uygulaDilation(morphedImage, kernelSize);
                        break;
                    case "Aşınma":
                        uygulaErosion(morphedImage, kernelSize);
                        break;
                    case "Açınım":
                        uygulaOpening(morphedImage, kernelSize);
                        break;
                    case "Kapanım":
                        uygulaClosing(morphedImage, kernelSize);
                        break;
                    default:
                        MessageBox.Show("Lütfen geçerli bir işlem seçin.");
                        return;
                }


                pictureBox1.Image = morphedImage;
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }

        private void uygulaOpening(Bitmap image, int kernelSize)
        {
            Bitmap tempImage = (Bitmap)image.Clone();
            uygulaErosion(tempImage, kernelSize);
            uygulaDilation(tempImage, kernelSize);
            Graphics.FromImage(image).DrawImage(tempImage, Point.Empty);
        }

        // Kapama işlemi
        private void uygulaClosing(Bitmap image, int kernelSize)
        {
            Bitmap tempImage = (Bitmap)image.Clone();
            uygulaDilation(tempImage, kernelSize);
            uygulaErosion(tempImage, kernelSize);
            Graphics.FromImage(image).DrawImage(tempImage, Point.Empty);
        }

        // Genişletme işlemi
        private void uygulaDilation(Bitmap image, int kernelSize)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap newImage = new Bitmap(width, height);

            int halfKernel = kernelSize / 2;

            for (int y = halfKernel; y < height - halfKernel; y++)
            {
                for (int x = halfKernel; x < width - halfKernel; x++)
                {
                    bool isWhitePixel = false; //beyaz piksel kontrolu
                    for (int i = -halfKernel; i <= halfKernel; i++)
                    {
                        for (int j = -halfKernel; j <= halfKernel; j++)
                        {
                            int newX = x + j;// bulunduğu çekirdeğin kenarlarından biri kadar kaydırılarak atanır.
                            int newY = y + i;

                            if (image.GetPixel(newX, newY).ToArgb() == Color.White.ToArgb())
                            {
                                isWhitePixel = true;
                                break;
                            }
                        }
                        if (isWhitePixel) break;
                    }

                    if (isWhitePixel)
                    {
                        newImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        newImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            Graphics.FromImage(image).DrawImage(newImage, Point.Empty);
        }

        // Aşınma işlemi
        private void uygulaErosion(Bitmap image, int kernelSize)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap newImage = new Bitmap(width, height);

            int halfKernel = kernelSize / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bool isBlackPixel = false;//siyah piksel kontrolu
                    for (int i = -halfKernel; i <= halfKernel; i++)
                    {
                        for (int j = -halfKernel; j <= halfKernel; j++)
                        {
                            int newX = x + j; // bulunduğu çekirdeğin kenarlarından biri kadar kaydırılarak atanır.
                            int newY = y + i;

                            if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                            {
                                if (image.GetPixel(newX, newY).ToArgb() == Color.Black.ToArgb())
                                {
                                    isBlackPixel = true;
                                    break;
                                }
                            }
                        }
                        if (isBlackPixel) break;
                    }

                    if (isBlackPixel)
                    {
                        newImage.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        newImage.SetPixel(x, y, Color.White);
                    }
                }
            }

            Graphics.FromImage(image).DrawImage(newImage, Point.Empty);
        }

        private void alanSecButton_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);

            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);

            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            Controls.Add(pictureBox1);

        }

        int crpX, crpY, rectW, rectH;

        public Pen crpPen = new Pen(Color.White);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                crpX = e.X;
                crpY = e.Y;

            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Refresh();

                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resimKaydet_Click(object sender, EventArgs e)
        {
            if (currentImage != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {

                    string filename = saveFileDialog1.FileName;

                    currentImage.Save(filename);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
            }
        }
    }
}
