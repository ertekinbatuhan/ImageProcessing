
namespace GoruntuIsleme
{
    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Resim Dosyalarý (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
            }
        }

        private void genisletmeButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap orijinalResim = new Bitmap(pictureBox1.Image);

                Bitmap genisletilmisResim = HistogramGenisletme(orijinalResim);

                pictureBox2.Image = genisletilmisResim;
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim yükleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Bitmap HistogramGenisletme(Bitmap orijinalResim)
        {
            {
                int width = orijinalResim.Width;
                int height = orijinalResim.Height;

                Bitmap genisletilmisResim = new Bitmap(width, height);

                int minVal = 255;
                int maxVal = 0;

                for (int y = 0; y < height; y++)      // Min ve maks piksel değerlerini bulunur
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

                for (int y = 0; y < height; y++)   // her pikselin değerini genişletilir
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixelColor = orijinalResim.GetPixel(x, y);
                        int pixelValue = pixelColor.R;

                        int newValue = (int)(((double)(pixelValue - minVal) / (maxVal - minVal)) * 255.0);// ğiksel değerini yeniden ölçeklendirlir

                        Color newColor = Color.FromArgb(newValue, newValue, newValue);
                        genisletilmisResim.SetPixel(x, y, newColor);
                    }
                }

                return genisletilmisResim;
            }
        }
    }
}