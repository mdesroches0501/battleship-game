using System;
using System.Collections.Generic;
using System.Text;

namespace DevMikesBattleship
{
    class Point
    {
        public Coordinates Coordinates { get; set; }

        public Point(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
        }
    }
}
