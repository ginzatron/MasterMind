using mastermindTest.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind.Classes
{
    public class GamePlay
    {
        public Board Board { get; }
        public GamePlay(Board board)
        {
            this.Board = board;
        }
    }
}
