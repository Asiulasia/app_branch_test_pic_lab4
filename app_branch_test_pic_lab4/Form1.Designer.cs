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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UltraGreenWhite);
            Controls.Add(OnlyGreen);
            Controls.Add(pictureBox1);
            Controls.Add(loadImage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button loadImage;
        private PictureBox pictureBox1;
        private Button OnlyGreen;
        private Button UltraGreenWhite;
    }
}
