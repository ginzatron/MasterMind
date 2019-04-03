using Mastermind.Classes;
using mastermindTest.Classes;
using System;

namespace mastermindTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            GamePlay game = new GamePlay(board.gameBoard);
        }
    }
}

