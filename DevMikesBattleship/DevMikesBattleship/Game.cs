using System;

namespace DevMikesBattleship
{
    class Game
    {
        static void Main(string[] args)
        {
            Board board = new Board(5, 5);

            Panel panel1 = new Panel(4, 2);
            bool isOnBoard = board.OnBoard(panel1);
            Console.WriteLine(isOnBoard);

            Panel panel2 = new Panel(1, 4);
            isOnBoard = board.OnBoard(panel2);
            Console.WriteLine(isOnBoard);

            Ship ship = new Ship("Single", 1);
            bool IsPanelOccupied = panel1.IsOccupied(ship, panel1);
            Console.WriteLine(IsPanelOccupied);

            ship.ShipLocation = panel1;
            IsPanelOccupied = panel1.IsOccupied(ship, panel1);
            Console.WriteLine(IsPanelOccupied);
        }
    }
}
