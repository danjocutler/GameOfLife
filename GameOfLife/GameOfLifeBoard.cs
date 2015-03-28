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
        public List<List<Cell>> Rows { get; set; }

        public GameOfLifeBoard(int width, int height)
        {
            Width = width;
            Height = height;

            Rows = new List<List<Cell>>();

            GridCreation();
        }

        public void GridCreation()
        {
            for (int y = 0; y < Height; y++)
            {
                var row = new List<Cell>();
                for (int x = 0; x < Width; x++)
                {
                    row.Add(new Cell());
                }
                Rows.Add(row);
            }
        }

        public List<string> Render(GameOfLifeBoard board)
        {
            var renderRow = new List<string>();

            foreach (var row in board.Rows)
            {
                int rowLength = row.Count;
                var print = string.Join("", Enumerable.Repeat("-", rowLength));
                renderRow.Add(print);
            }

            return renderRow;
        }
    }
}
