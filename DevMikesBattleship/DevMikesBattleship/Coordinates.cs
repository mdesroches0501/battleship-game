using System;
using System.Collections.Generic;
using System.Text;

namespace DevMikesBattleship
{
    class Coordinates
    {
        public int Column { get; set; }
        public int Row { get; set;  }

        public Coordinates(int row, int column)
        {
            Column = column;
            Row = row;
        }
    }
}
