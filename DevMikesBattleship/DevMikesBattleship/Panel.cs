using System;
using System.Collections.Generic;
using System.Text;

namespace DevMikesBattleship
{
    class Panel
    {
        public readonly int X;
        public readonly int Y;
        public bool Miss;

        public Panel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsOccupied(Ship ship, Panel panel)
        {
            return ship.ShipLocation == panel;
        }
    }
}
