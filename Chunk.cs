using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelSortApp
{
    class Chunk
    {
        public int chunkWidth, chunkHeight;
        public int chunkX, chunkY;
        public List<Color> pixels;

        public Chunk(int widthIn, int heightIn, int xIn, int yIn)
        {
            chunkWidth = widthIn;
            chunkHeight = heightIn;
            chunkX = xIn;
            chunkY = yIn;
            pixels = new List<Color>();
        }
    }
}
