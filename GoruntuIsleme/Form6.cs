

namespace GoruntuIsleme
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void rgbButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçin.");
                return;
            }

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap transformedImage = TransformRGB(originalImage,
                                                   (int)numericUpDown1.Value,
                                                   (int)numericUpDown2.Value,
                                                   (int)numericUpDown3.Value);

            pictureBox1.Image = transformedImage;
        }

        private Bitmap TransformRGB(Bitmap originalImage, int redValue, int greenValue, int blueValue)
        {
            Bitmap transformedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                    int newRed = (originalColor.R * redValue) / 255;
                    int newGreen = (originalColor.G * greenValue) / 255;
                    int newBlue = (originalColor.B * blueValue) / 255;

                    newRed = Math.Max(0, Math.Min(255, newRed));
                    newGreen = Math.Max(0, Math.Min(255, newGreen));
                    newBlue = Math.Max(0, Math.Min(255, newBlue));

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    transformedImage.SetPixel(x, y, newColor);
                }
            }

            return transformedImage;
        }

        private void cmyButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçin.");
                return;
            }

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap transformedImage = TransformCMY(originalImage);

            pictureBox1.Image = transformedImage;
        }

        private Bitmap TransformCMY(Bitmap originalImage)
        {
            Bitmap transformedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                    int c = 255 - originalColor.R;
                    int m = 255 - originalColor.G;
                    int newY = 255 - originalColor.B;


                    Color newColor = Color.FromArgb(c, m, newY);
                    transformedImage.SetPixel(x, y, newColor);
                }
            }

            return transformedImage;
        }

        private void hsiButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçin.");
                return;
            }

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap transformedImage = TransformHSI(originalImage);

            pictureBox1.Image = transformedImage;
        }

        private Bitmap TransformHSI(Bitmap originalImage)
        {
            Bitmap transformedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);
                    double hue, saturation, intensity;
                    RGBtoHSI(originalColor.R, originalColor.G, originalColor.B, out hue, out saturation, out intensity);

                    Color newColor = HSItoRGB(hue, saturation, intensity);
                    transformedImage.SetPixel(x, y, newColor);
                }
            }

            return transformedImage;
        }

        private void RGBtoHSI(int r, int g, int b, out double hue, out double saturation, out double intensity)
        {
            double rPrime = (double)r / 255.0;
            double gPrime = (double)g / 255.0;
            double bPrime = (double)b / 255.0;

            double cMax = Math.Max(rPrime, Math.Max(gPrime, bPrime));
            double cMin = Math.Min(rPrime, Math.Min(gPrime, bPrime));
            double delta = cMax - cMin;

            hue = 0;
            if (delta != 0)
            {
                if (cMax == rPrime)
                    hue = 60 * (((gPrime - bPrime) / delta) % 6);
                else if (cMax == gPrime)
                    hue = 60 * (((bPrime - rPrime) / delta) + 2);
                else if (cMax == bPrime)
                    hue = 60 * (((rPrime - gPrime) / delta) + 4);
            }
            if (hue < 0)
                hue += 360;

            saturation = (cMax == 0) ? 0 : (delta / cMax);
            intensity = (cMax + cMin) / 2;
        }

        private Color HSItoRGB(double hue, double saturation, double intensity)
        {
            double r = 0, g = 0, b = 0;

            if (saturation == 0)
            {
                r = g = b = intensity;
            }
            else
            {
                double h = hue / 60;
                int i = (int)Math.Floor(h);
                double f = h - i;
                double p = intensity * (1 - saturation);
                double q = intensity * (1 - saturation * f);
                double t = intensity * (1 - saturation * (1 - f));

                switch (i)
                {
                    case 0:
                        r = intensity; g = t; b = p;
                        break;
                    case 1:
                        r = q; g = intensity; b = p;
                        break;
                    case 2:
                        r = p; g = intensity; b = t;
                        break;
                    case 3:
                        r = p; g = q; b = intensity;
                        break;
                    case 4:
                        r = t; g = p; b = intensity;
                        break;
                    case 5:
                        r = intensity; g = p; b = q;
                        break;
                }
            }

            int red = (int)Math.Round(r * 255);
            int green = (int)Math.Round(g * 255);
            int blue = (int)Math.Round(b * 255);

            red = Math.Max(0, Math.Min(255, red));
            green = Math.Max(0, Math.Min(255, green));
            blue = Math.Max(0, Math.Min(255, blue));

            return Color.FromArgb(red, green, blue);
        }

        private void yuvButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçin.");
                return;
            }

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap transformedImage = TransformYUV(originalImage);

            pictureBox1.Image = transformedImage;
        }

        private Bitmap TransformYUV(Bitmap originalImage)
        {
            Bitmap transformedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);
                    double yValue, uValue, vValue;
                    RGBtoYUV(originalColor.R, originalColor.G, originalColor.B, out yValue, out uValue, out vValue);

                    uValue = uValue * 1.2;
                    vValue = vValue * 1.2;

                    Color newColor = YUVtoRGB(yValue, uValue, vValue);
                    transformedImage.SetPixel(x, y, newColor);
                }
            }

            return transformedImage;
        }
        private void RGBtoYUV(int r, int g, int b, out double y, out double u, out double v)
        {
            y = 0.299 * r + 0.587 * g + 0.114 * b;
            u = 0.492 * (b - y);
            v = 0.877 * (r - y);
        }

        private Color YUVtoRGB(double y, double u, double v)
        {
            int red = (int)Math.Round(y + 1.140 * v);
            int green = (int)Math.Round(y - 0.395 * u - 0.581 * v);
            int blue = (int)Math.Round(y + 2.032 * u);

            red = Math.Max(0, Math.Min(255, red));
            green = Math.Max(0, Math.Min(255, green));
            blue = Math.Max(0, Math.Min(255, blue));

            return Color.FromArgb(red, green, blue);
        }
    }
}