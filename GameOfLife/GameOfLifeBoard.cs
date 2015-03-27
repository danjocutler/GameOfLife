using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    class GameOfLifeBoard
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public GameOfLifeBoard(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

    }
}
