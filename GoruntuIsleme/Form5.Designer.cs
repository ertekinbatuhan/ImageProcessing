namespace GoruntuIsleme
{
    partial class Form5
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
            germeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Location = new Point(117, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 314);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(725, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(458, 314);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // germeButton
            // 
            germeButton.BackColor = Color.LightSkyBlue;
            germeButton.Location = new Point(511, 422);
            germeButton.Name = "germeButton";
            germeButton.Size = new Size(282, 50);
            germeButton.TabIndex = 2;
            germeButton.Text = "Germe";
            germeButton.UseVisualStyleBackColor = false;
            germeButton.Click += germeButton_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1295, 653);
            Controls.Add(germeButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Histogram Germe";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button germeButton;
    }
}