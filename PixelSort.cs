using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSortApp
{
    public partial class PixelSort : Form
    {
        PixelEngine engine = new PixelEngine();

        string currentFilePath;
        Bitmap currentImage;
        double rowChance = 0.5;
        double columnChance = 0.5;

        Random RNG = new Random();

        public PixelSort()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            RowChanceField.Text = rowChance.ToString();
            ColumnChanceField.Text = columnChance.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region save and load

        private void LoadImageButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            currentFilePath = fileDialog.FileName;
            currentImage = (Bitmap)Image.FromFile(currentFilePath);
            pictureBox1.Image = currentImage;
        }

        private void SaveImageClick(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.ShowDialog();
            fileDialog.CheckFileExists = false;
            fileDialog.CheckPathExists = false;
            string targetPath = fileDialog.FileName;
            if(targetPath != "")
            {
                currentImage.Save(targetPath);
            }
        }

        #endregion

        #region buttons
        private void SortRandomRowsButton_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                return;
            }

            for (int i = 0; i < currentImage.Height; i++)
            {
                //Multithread for performance at some point
                if(Chance(rowChance))
                {
                    engine.SortRow(currentImage, i);
                }
            }
            UpdateImagePreview();
        }

        private void SortRandomColumnsButton_Click(object sender, EventArgs e)
        {
            if(currentImage == null)
            {
                return;
            }

            for(int i = 0; i < currentImage.Width; i++)
            {
                if(Chance(rowChance))
                {
                    engine.SortColumn(currentImage, i);
                }
            }

            UpdateImagePreview();
        }

        private void SortAllColumnsButton_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                return;
            }

            for (int i = 0; i < currentImage.Width; i++)
            {
                engine.SortColumn(currentImage, i);
            }

            UpdateImagePreview();
        }

        private void SortAllRowsButton_Click(object sender, EventArgs e)
        {
            if(currentImage == null)
            {
                return;
            }

            for(int i = 0; i < currentImage.Height; i++)
            {
                engine.SortRow(currentImage, i);
            }

            UpdateImagePreview();
        }

        #endregion

        #region parsing settings

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(RowChanceField.Text, out rowChance)){}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(ColumnChanceField.Text, out columnChance)){}
        }

        #endregion

        #region utilities

        private void UpdateImagePreview()
        {
            pictureBox1.Image = currentImage;
        }

        private bool Chance(double targetValue)
        {
            double rngValue = RNG.NextDouble();
            if(rngValue < targetValue)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
