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

        public List<Color> SortList(List<Color> colorIn)
        {
            List<int> tempList = new List<int>();
            foreach(Color pixel in colorIn)
            {
                tempList.Add(pixel.ToArgb());
            }
            tempList = SortList(tempList);

            List<Color> outList = new List<Color>();
            foreach(int argbValue in tempList)
            {
                outList.Add(Color.FromArgb(argbValue));
            }

            return outList;
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

        public Chunk GetChunk(Bitmap bitmapIn, int chunkHeight, int chunkWidth, int chunkX, int chunkY)
        {
            Chunk chunkOut = new Chunk(chunkWidth, chunkHeight, chunkX, chunkY);

            int chunkStartX = chunkX * chunkWidth;
            int chunkStartY = chunkY * chunkHeight;


            for(int i = 0; i < chunkHeight; i++)
            {
                for(int j = 0; j < chunkWidth; j++)
                {
                    if(chunkStartX + j < bitmapIn.Width && chunkStartY + i < bitmapIn.Height)
                    {
                        chunkOut.pixels.Add(bitmapIn.GetPixel(chunkStartX + j, chunkStartY + i));
                    }
                }
            }

            return chunkOut;
        }

        public void WriteChunk(Bitmap bitmapIn, Chunk chunkIn)
        {
            int startX = chunkIn.chunkX * chunkIn.chunkWidth;
            int startY = chunkIn.chunkY * chunkIn.chunkHeight;

            for(int i = 0; i < chunkIn.chunkHeight; i++)
            {
                for(int j = 0; j < chunkIn.chunkWidth; j++)
                {
                    if(startX + j < bitmapIn.Width && startY + i < bitmapIn.Height)
                    {
                        int pixelListIndex = (i * chunkIn.chunkHeight) + j;
                        if(pixelListIndex < chunkIn.pixels.Count)
                        {
                            bitmapIn.SetPixel(startX + j, startY + i, chunkIn.pixels[pixelListIndex]);
                        }
                    }
                }
            }
        }

        public void SortChunk(Bitmap bitmapIn, int chunkHeight, int chunkWidth, int chunkX, int chunkY)
        {
            Chunk chunk = GetChunk(bitmapIn, chunkHeight, chunkWidth, chunkX, chunkY);
            chunk.pixels = SortList(chunk.pixels);
            WriteChunk(bitmapIn, chunk);
        }
    }
}
