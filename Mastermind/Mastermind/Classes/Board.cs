using System;
using System.Collections.Generic;
using System.Text;

namespace mastermindTest.Classes
{
    public class Board
    {
        public int[] GameBoard = new int[4];

        public Board()
        {
            Random randomNum = new Random();

            for (int i = 0; i < 4; i++)
            {
                this.GameBoard[i] = randomNum.Next(0, 7);
            }
            Console.WriteLine($"{this.GameBoard[0]}{this.GameBoard[1]}{this.GameBoard[2]}{this.GameBoard[3]}");
        }
    }
}

