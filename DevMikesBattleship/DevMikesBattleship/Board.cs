using System;
using System.Collections.Generic;
using System.Text;

namespace DevMikesBattleship
{
    class Board
    {
        public readonly int Row;
        public readonly int Column;
        public Board(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
