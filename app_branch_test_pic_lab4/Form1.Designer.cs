namespace app_branch_test_pic_lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadImage = new Button();
            pictureBox1 = new PictureBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            RotateImage = new Button();
            InvertColors = new Button();
            UpsideDown = new Button();
            OnlyGreen = new Button();
            UltraGreenWhite = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loadImage
            // 
            loadImage.Location = new Point(130, 344);
            loadImage.Name = "loadImage";
            loadImage.Size = new Size(75, 23);
            loadImage.TabIndex = 4;
            loadImage.Text = "Load";
            loadImage.UseVisualStyleBackColor = true;
            loadImage.Click += loadImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(373, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // OnlyGreen
            // 
            OnlyGreen.Location = new Point(130, 254);
            OnlyGreen.Name = "OnlyGreen";
            OnlyGreen.Size = new Size(75, 23);
            OnlyGreen.TabIndex = 9;
            OnlyGreen.Text = "Only Green";
            OnlyGreen.UseVisualStyleBackColor = true;
            OnlyGreen.Click += OnlyGreen_Click;
            // 
            // UltraGreenWhite
            // 
            UltraGreenWhite.Location = new Point(130, 297);
            UltraGreenWhite.Name = "UltraGreenWhite";
            UltraGreenWhite.Size = new Size(112, 23);
            UltraGreenWhite.TabIndex = 10;
            UltraGreenWhite.Text = "Ultra Green White";
            UltraGreenWhite.UseVisualStyleBackColor = true;
            UltraGreenWhite.Click += UltraGreenWhite_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(130, 78);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(48, 19);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "270°";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(130, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 19);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "180°";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(130, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 19);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "90°";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // RotateImage
            // 
            RotateImage.Location = new Point(130, 140);
            RotateImage.Name = "RotateImage";
            RotateImage.Size = new Size(75, 23);
            RotateImage.TabIndex = 9;
            RotateImage.Text = "Rotate";
            RotateImage.UseVisualStyleBackColor = true;
            RotateImage.Click += RotateImage_Click_1;
            // 
            // InvertColors
            // 
            InvertColors.Location = new Point(130, 169);
            InvertColors.Name = "InvertColors";
            InvertColors.Size = new Size(92, 23);
            InvertColors.TabIndex = 16;
            InvertColors.Text = "Invert Colors";
            InvertColors.UseVisualStyleBackColor = true;
            InvertColors.Click += InvertColors_Click_1;
            // 
            // UpsideDown
            // 
            UpsideDown.Location = new Point(130, 198);
            UpsideDown.Name = "UpsideDown";
            UpsideDown.Size = new Size(92, 23);
            UpsideDown.TabIndex = 17;
            UpsideDown.Text = "Upside Down";
            UpsideDown.UseVisualStyleBackColor = true;
            UpsideDown.Click += UpsideDown_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpsideDown);
            Controls.Add(InvertColors);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(RotateImage);
            Controls.Add(UltraGreenWhite);
            Controls.Add(OnlyGreen);
            Controls.Add(pictureBox1);
            Controls.Add(loadImage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loadImage;
        private PictureBox pictureBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button RotateImage;
        private Button InvertColors;
        private Button UpsideDown;
        private Button OnlyGreen;
        private Button UltraGreenWhite;
    }
}
