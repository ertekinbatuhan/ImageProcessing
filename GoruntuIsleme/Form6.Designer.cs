namespace GoruntuIsleme
{
    partial class Form6
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            rgbButton = new Button();
            cmyButton = new Button();
            hsiButton = new Button();
            yuvButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Location = new Point(45, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 292);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.LightSkyBlue;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(437, 87);
            numericUpDown1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.LightSkyBlue;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(532, 87);
            numericUpDown2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(75, 27);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.BackColor = Color.LightSkyBlue;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(630, 87);
            numericUpDown3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(75, 27);
            numericUpDown3.TabIndex = 2;
            // 
            // rgbButton
            // 
            rgbButton.BackColor = Color.LightSkyBlue;
            rgbButton.Location = new Point(600, 157);
            rgbButton.Name = "rgbButton";
            rgbButton.Size = new Size(105, 54);
            rgbButton.TabIndex = 3;
            rgbButton.Text = "RGB";
            rgbButton.UseVisualStyleBackColor = false;
            rgbButton.Click += rgbButton_Click;
            // 
            // cmyButton
            // 
            cmyButton.BackColor = Color.LightSkyBlue;
            cmyButton.Location = new Point(437, 157);
            cmyButton.Name = "cmyButton";
            cmyButton.Size = new Size(105, 54);
            cmyButton.TabIndex = 4;
            cmyButton.Text = "CMY";
            cmyButton.UseVisualStyleBackColor = false;
            cmyButton.Click += cmyButton_Click;
            // 
            // hsiButton
            // 
            hsiButton.BackColor = Color.LightSkyBlue;
            hsiButton.Location = new Point(437, 257);
            hsiButton.Name = "hsiButton";
            hsiButton.Size = new Size(105, 54);
            hsiButton.TabIndex = 5;
            hsiButton.Text = "HSİ";
            hsiButton.UseVisualStyleBackColor = false;
            hsiButton.Click += hsiButton_Click;
            // 
            // yuvButton
            // 
            yuvButton.BackColor = Color.LightSkyBlue;
            yuvButton.Location = new Point(600, 257);
            yuvButton.Name = "yuvButton";
            yuvButton.Size = new Size(105, 54);
            yuvButton.TabIndex = 6;
            yuvButton.Text = "YUV";
            yuvButton.UseVisualStyleBackColor = false;
            yuvButton.Click += yuvButton_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(882, 453);
            Controls.Add(yuvButton);
            Controls.Add(hsiButton);
            Controls.Add(cmyButton);
            Controls.Add(rgbButton);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(pictureBox1);
            Name = "Form6";
            Text = "Renk Uzayları";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button rgbButton;
        private Button cmyButton;
        private Button hsiButton;
        private Button yuvButton;
    }
}