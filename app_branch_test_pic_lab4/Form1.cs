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

        private void RotateImage_Click(object sender, EventArgs e)
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
    }
}
