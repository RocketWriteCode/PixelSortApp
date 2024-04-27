using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PixelSort : Form
    {
        string currentFilePath;
        Bitmap currentImage;
        double rowChance = 0.5;
        double columnChance = 0.5;

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

        private void SortAllRows(object sender, EventArgs e)
        {
            if(currentImage == null)
            {
                return;
            }

            for(int i = 0; i < currentImage.Height; i++)
            {
                //Multithread for performance at some point
                SortRow(i);
            }

            pictureBox1.Image = currentImage;
        }

        private void SortRow(int row)
        {
            List<int> PixelRow = new List<int>();

            for (int i = 0; i < currentImage.Width; i++)
            {
                PixelRow.Add(currentImage.GetPixel(i, row).ToArgb());
            }

            PixelRow.Sort();

            for (int i = 0; i < currentImage.Width; i++)
            {
                currentImage.SetPixel(i, row, Color.FromArgb(PixelRow[i]));
            }
        }

        private void SortColumn(int column)
        {
            List<int> PixelColumn = new List<int>();

            for(int i = 0; i < currentImage.Height; i++)
            {
                PixelColumn.Add(currentImage.GetPixel(column, i).ToArgb());
            }

            PixelColumn.Sort();

            for(int i = 0; i < currentImage.Height; i++)
            {
                currentImage.SetPixel(column, i, Color.FromArgb(PixelColumn[i]));
            }
        }

        private void SortRandomRowsButton_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                return;
            }

            Random RNG = new Random();
            for (int i = 0; i < currentImage.Height; i++)
            {
                double randomDouble = RNG.NextDouble();
                //Multithread for performance at some point
                if(randomDouble < rowChance)
                {
                    SortRow(i);
                }
            }

            pictureBox1.Image = currentImage;
        }

        private void SortRandomColumnsButton_Click(object sender, EventArgs e)
        {
            if(currentImage == null)
            {
                return;
            }

            Random RNG = new Random();
            for(int i = 0; i < currentImage.Width; i++)
            {
                double randomDouble = RNG.NextDouble();
                if(randomDouble < columnChance)
                {
                    SortColumn(i);
                }
            }

            pictureBox1.Image = currentImage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(RowChanceField.Text, out rowChance)){}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(ColumnChanceField.Text, out columnChance)){}
        }

        private void SortAllColumnsButton_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                return;
            }

            for (int i = 0; i < currentImage.Width; i++)
            {
                SortColumn(i);
            }

            pictureBox1.Image = currentImage;
        }
    }
}
