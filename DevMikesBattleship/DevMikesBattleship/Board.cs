using System;
using System.Collections.Generic;
using System.Text;

namespace DevMikesBattleship
{
    class Board
    {
        public readonly int Width;
        public readonly int Height;
        public Board(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnBoard(Panel panel)
        {
            return panel.X >= 0 && panel.X < Width &&
                   panel.Y >= 0 && panel.Y < Height;
        }
    }
}
