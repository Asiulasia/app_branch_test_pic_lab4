using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace app_branch_test_pic_lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the selected image file
                        Image img = Image.FromFile(openFileDialog.FileName);
                        // Display the image in PictureBox
                        pictureBox1.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RotateImage_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                else if (radioButton2.Checked)
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                else if (radioButton3.Checked)
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

                pictureBox1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rotating image: " + ex.Message);
            }
        }

        private static Image InvertColorMatrix(Image imgSource)
        {
            Bitmap bmpDest = new Bitmap(imgSource.Width,
               imgSource.Height);

            ColorMatrix clrMatrix = new ColorMatrix(new float[][]
               {
            new float[] {-1, 0, 0, 0, 0},
            new float[] {0, -1, 0, 0, 0},
            new float[] {0, 0, -1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {1, 1, 1, 0, 1}
               });

            using (ImageAttributes attrImage = new ImageAttributes())
            {

                attrImage.SetColorMatrix(clrMatrix);

                using (Graphics g = Graphics.FromImage(bmpDest))
                {
                    g.DrawImage(imgSource, new Rectangle(0, 0,
                    imgSource.Width, imgSource.Height), 0, 0,
                    imgSource.Width, imgSource.Height, GraphicsUnit.Pixel,
                    attrImage);
                }
            }

            return bmpDest;
        }

        private void UpsideDown_Click_1(object sender, EventArgs e)
        {
            try
            {
                Image img = pictureBox1.Image;

                if (img != null)
                {
                    img.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    pictureBox1.Image = img;
                    pictureBox1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error flipping image: " + ex.Message);
            }
        }

        private void InvertColors_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = InvertColorMatrix(pictureBox1.Image);
        }

        private void OnlyGreen_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = pictureBox1.Image;

                if (img != null)
                {
                    Bitmap bmp = new Bitmap(img);

                    for (int x = 0; x < bmp.Width; x++)
                    {
                        for (int y = 0; y < bmp.Height; y++)
                        {
                            Color pixelColor = bmp.GetPixel(x, y);

                            // Check if the pixel is not green
                            if (pixelColor.G < (float)0.7 * (pixelColor.R + pixelColor.B))
                            {
                                // Replace the non-green pixel with black
                                bmp.SetPixel(x, y, Color.Black);
                            }
                        }
                    }

                    pictureBox1.Image = bmp;
                    pictureBox1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing image: " + ex.Message);
            }
        }

        private void UltraGreenWhite_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = pictureBox1.Image;

                if (img != null)
                {
                    Bitmap bmp = new Bitmap(img);

                    for (int x = 0; x < bmp.Width; x++)
                    {
                        for (int y = 0; y < bmp.Height; y++)
                        {
                            Color pixelColor = bmp.GetPixel(x, y);

                            // Check if the pixel is not green
                            if (pixelColor.G < (float)0.7 * (pixelColor.R + pixelColor.B))
                            {
                                // Replace the non-green pixel with black
                                bmp.SetPixel(x, y, Color.Black);
                            }
                            if (pixelColor.R < (float)0.55 * (pixelColor.G + pixelColor.B))
                            {
                                // Replace the non-green pixel with black
                                bmp.SetPixel(x, y, Color.White);
                            }
                            if (pixelColor.B < (float)0.35 * (pixelColor.G + pixelColor.R))
                            {
                                // Replace the non-green pixel with black
                                bmp.SetPixel(x, y, Color.LawnGreen);
                            }
                        }
                    }

                    pictureBox1.Image = bmp;
                    pictureBox1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing image: " + ex.Message);
            }
        }
    }
}
