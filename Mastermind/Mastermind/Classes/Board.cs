using System;
using System.Collections.Generic;
using System.Text;

namespace mastermindTest.Classes
{
    public class Board
    {
        public string gameBoard;

        public string generateBoard()
        {
            gameBoard = "";
            Random randomNum = new Random();

            for (int i = 0; i < 4; i++)
            {
                this.gameBoard += randomNum.Next(1, 7);
            }
            return this.gameBoard;
        }
    }
}

