namespace GoruntuIsleme
{
    partial class Form4
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
            pictureBox2 = new PictureBox();
            genisletmeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Location = new Point(64, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(505, 335);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(726, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(505, 335);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // genisletmeButton
            // 
            genisletmeButton.BackColor = Color.LightSkyBlue;
            genisletmeButton.Location = new Point(482, 437);
            genisletmeButton.Name = "genisletmeButton";
            genisletmeButton.Size = new Size(334, 52);
            genisletmeButton.TabIndex = 2;
            genisletmeButton.Text = "Genişletme ";
            genisletmeButton.UseVisualStyleBackColor = false;
            genisletmeButton.Click += genisletmeButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1295, 653);
            Controls.Add(genisletmeButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Histogram Genişletme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button genisletmeButton;
    }
}