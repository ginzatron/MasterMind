using mastermindTest.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind.Classes
{
    public class GamePlay
    {
        public string guess { get; set; }
        
        public int guesses { get; set; }

        public string board { get; set; }
        public GamePlay(string board)
        {
            this.board = board;
            Main();
        }

        public void Main()
        {
            string plusses;
            string minuses;
            guesses = 0;
            do
            {
                Console.WriteLine("Please enter 4 digit guess, each digit between 1-6 inclusive: ");
                this.guess = Console.ReadLine();

                plusses = "";
                minuses = "";

                if (this.board == this.guess)
                {
                    Console.WriteLine("you did it!");
                    break;
                }

                for(int i = 0; i<guess.Length; i++)
                {
                    if (board.IndexOf(guess[i]) == i)
                    {
                       plusses += "+";
                    }
                    else if (board.IndexOf(guess[i]) > 0)
                    {
                        minuses += "-";
                    }
                }
                Console.WriteLine(plusses+minuses);
                guesses++;

            } while ((guesses < 10));
        }
    }
}
