using System;
using System.Drawing;
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
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Refresh();
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
