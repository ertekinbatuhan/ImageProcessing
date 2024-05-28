namespace GoruntuIsleme
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            bolmeButton = new Button();
            numericUpDown1 = new NumericUpDown();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Location = new Point(36, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 243);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // bolmeButton
            // 
            bolmeButton.BackColor = Color.LightSkyBlue;
            bolmeButton.Location = new Point(475, 297);
            bolmeButton.Name = "bolmeButton";
            bolmeButton.Size = new Size(350, 35);
            bolmeButton.TabIndex = 2;
            bolmeButton.Text = "Görüntü Bölme";
            bolmeButton.UseVisualStyleBackColor = false;
            bolmeButton.Click += bolmeButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.LightSkyBlue;
            numericUpDown1.Location = new Point(36, 302);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(328, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(475, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 243);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(882, 453);
            Controls.Add(pictureBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(bolmeButton);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Resim Arasında Bölme İşlemi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bolmeButton;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox2;
    }
}