using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelSortApp
{
    class PixelEngine
    {
        public List<int> SortList(List<int> argbIn)
        {
            argbIn.Sort();
            return argbIn;
        }

        public List<int> GetRow(Bitmap bitmapIn, int targetRow)
        {
            List<int> argbOut = new List<int>();

            for(int i = 0; i < bitmapIn.Width; i++)
            {
                Color pixelColor = bitmapIn.GetPixel(i, targetRow);
                argbOut.Add(pixelColor.ToArgb());
            }

            return argbOut;
        }

        public List<int> GetColumn(Bitmap bitmapIn, int targetColumn)
        {
            List<int> argbOut = new List<int>();

            for(int i = 0; i < bitmapIn.Height; i++)
            {
                Color pixelColor = bitmapIn.GetPixel(targetColumn, i);
                argbOut.Add(pixelColor.ToArgb());
            }

            return argbOut;
        }

        public void WriteRow(Bitmap bitmapIn, int targetRow, List<int> argbIn)
        {
            for(int i = 0; i < bitmapIn.Width; i++)
            {
                Color pixelColor = Color.FromArgb(argbIn[i]);
                bitmapIn.SetPixel(i, targetRow, pixelColor);
            }
        }

        public void WriteColumn(Bitmap bitmapIn, int targetColumn, List<int> argbIn)
        {
            for(int i = 0; i < bitmapIn.Height; i++)
            {
                Color pixelColor = Color.FromArgb(argbIn[i]);
                bitmapIn.SetPixel(targetColumn, i, pixelColor);
            }
        }

        public void SortColumn(Bitmap bitmapIn, int targetColumn)
        {
            List<int> argb = GetColumn(bitmapIn, targetColumn);
            argb = SortList(argb);
            WriteColumn(bitmapIn, targetColumn, argb);
        }

        public void SortRow(Bitmap bitmapIn, int targetRow)
        {
            List<int> argb = GetRow(bitmapIn, targetRow);
            argb = SortList(argb);
            WriteRow(bitmapIn, targetRow, argb);
        }
    }
}
