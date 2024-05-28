

namespace GoruntuIsleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage; 

        }

    private void pictureBox2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new System.Drawing.Bitmap(openFileDialog2.FileName);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
            }
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            Bitmap image2 = (Bitmap)pictureBox2.Image;

            if (image1 != null && image2 != null)
            {
                int width = Math.Max(image1.Width, image2.Width); //        // İki resmin de maksimum genişliğini ve yüksekliğini bul
                int height = Math.Max(image1.Height, image2.Height);

                image1 = ResizeBitmap(image1, width, height);
                image2 = ResizeBitmap(image2, width, height);

                Bitmap combinedImage = new Bitmap(width, height);

                for (int y = 0; y < combinedImage.Height; y++)
                {
                    for (int x = 0; x < combinedImage.Width; x++)
                    {
                        Color color1 = image1.GetPixel(x, y);
                        Color color2 = image2.GetPixel(x, y);

                        int newRed = Math.Min(color1.R + color2.R, 255);
                        int newGreen = Math.Min(color1.G + color2.G, 255);
                        int newBlue = Math.Min(color1.B + color2.B, 255);

                        Color newColor = Color.FromArgb(newRed, newGreen, newBlue);

                        combinedImage.SetPixel(x, y, newColor);
                    }
                }

                pictureBox3.Image = combinedImage;
            }
            else
            {
                MessageBox.Show("Lütfen her iki resmi de seçiniz.");
            }
        }

        private Bitmap ResizeBitmap(Bitmap bitmap, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bitmap, 0, 0, width, height);
            }
            return result;
        }


    }
}