

namespace GoruntuIsleme
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Resim Dosyalari (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
            }
        }

        private void germeButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap orijinalResim = new Bitmap(pictureBox1.Image);

                Bitmap germisResim = HistogramGerme(orijinalResim);

                pictureBox2.Image = germisResim;
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim yükleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Bitmap HistogramGerme(Bitmap orijinalResim)
        {
            int width = orijinalResim.Width;
            int height = orijinalResim.Height;

            Bitmap germisResim = new Bitmap(width, height);

            int minVal = 255;
            int maxVal = 0;

            for (int y = 0; y < height; y++)         // min ve maks değerler kontrol edilir
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = orijinalResim.GetPixel(x, y);
                    int pixelValue = pixelColor.R;
                    if (pixelValue < minVal)
                        minVal = pixelValue;
                    if (pixelValue > maxVal)
                        maxVal = pixelValue;
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = orijinalResim.GetPixel(x, y); //piksellerin degeri alınır
                    int pixelValue = pixelColor.R;

                    int newValue = (255 * (pixelValue - minVal)) / (maxVal - minVal); // yeniden ölçekleme formülü uygulanır
                    Color newColor = Color.FromArgb(newValue, newValue, newValue);
                    germisResim.SetPixel(x, y, newColor);
                }
            }

            return germisResim;
        }
    }
}