using System;
using System.Collections.Generic;
using System.Text;

namespace DevMikesBattleship
{
    class Ship
    {
        public readonly string Name;
        public readonly int Width;
        public int Hits;

        public Ship(string name, int width)
        {
            Name = name;
            Width = width;
        }

        public Panel ShipLocation { get; set; }
        public bool IsSunk()
        {
            return Hits >= Width;
        }
    }
}
