
namespace GoruntuIsleme
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçin.");
                return;
            }

            Bitmap originalImage = new Bitmap(pictureBox1.Image);

            decimal divisor = numericUpDown1.Value;

            if (divisor == 0)
            {
                MessageBox.Show("Bölünen sayı sıfır olamaz.");
                return;
            }

            Bitmap resultImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                    int newR = (int)(originalColor.R / divisor);
                    int newG = (int)(originalColor.G / divisor);
                    int newB = (int)(originalColor.B / divisor);

                    Color newColor = Color.FromArgb(
                        Math.Max(0, Math.Min(255, newR)),//yeni renkler olusturuyor
                        Math.Max(0, Math.Min(255, newG)),
                        Math.Max(0, Math.Min(255, newB))
                    );

                    resultImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = resultImage;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}