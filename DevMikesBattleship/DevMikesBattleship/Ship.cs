using System;
using System.Collections.Generic;
using System.Text;

namespace DevMikesBattleship
{
    class Ship
    {
        public readonly string Name;
        public readonly int Width;
        public readonly int LocationX;
        public readonly int LocationY;

        public int Hits;

        public Ship(string name, int width, Panel panel)
        {
            Name = name;
            Width = width;
            LocationX = panel.X;
            LocationY = panel.Y;
        }
        public bool IsSunk()
        {
            return Hits >= Width;
        }
    }
}
