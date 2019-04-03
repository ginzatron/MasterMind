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
            this.board = "1111";
            Main();
        }

        public void Main()
        {
            string plusses;
            string minuses;
            guesses = 9;
            do
            {
                Console.WriteLine($"Please enter 4 digit guess, each digit between 1-6 inclusive: ");
                this.guess = Console.ReadLine();

                plusses = "";
                minuses = "";

                if (this.board == this.guess)
                {
                    Console.WriteLine("you did it!");
                    break;
                }

                // looping throuhg guess
                for(int i = 0; i<guess.Length; i++)
                {
                    // if the index value in the guess is contained in the board
                    if (board.IndexOf(guess[i],i) > -1)
                    {
                        // number is correct and in the correct place, add a +
                        if (board.IndexOf(guess[i],i) == i)
                        {
                            plusses += "+";
                        }
                        // else if the number is correct but not in the correct location, add a -
                        else
                        {
                            minuses += "-";
                        }
                    }
                }
                Console.WriteLine(plusses+minuses);
                Console.WriteLine($"you have {guesses} guesses remaining");
                guesses--;

            } while ((guesses >= 0));
        }
    }
}
