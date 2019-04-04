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
            bool won = false;

            Console.WriteLine("We are goign to play mastermind. I have generated a random 4 digit number with each digit from 1-6");
            Console.WriteLine("A + indicates a number and location correct, a - indicates a correct number but incorrect location");
            Console.WriteLine("You will have 10 chances.");

            while(true)
            {
                
                Console.WriteLine($"Please enter 4 digit guess, each digit between 1-6 inclusive: ");
                this.guess = Console.ReadLine();

                plusses = "";
                minuses = "";

                if (this.board == this.guess)
                {
                    Console.WriteLine("you did it!");
                    won = true;
                }

                // looping throuhg guess
                if (!won)
                {
                    for (int i = 0; i < guess.Length; i++)
                    {
                        // if the index value in the guess is contained in the board
                        if (board.IndexOf(guess[i], i) > -1)
                        {
                            // number is correct and in the correct place, add a +
                            if (board.IndexOf(guess[i], i) == i)
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
                    Console.WriteLine(plusses + minuses);
                    Console.WriteLine($"you have {guesses} guesses remaining");
                    guesses--;
                }
                
                // out of guesses or won the game see if user wants to play again
                if (guesses == -1 || won)
                {
                    Console.WriteLine($"the masterminded number was {this.board}");
                    Console.Write("Play Again(y/n)? ");
                    guesses = 9;
                    if (Console.ReadLine().ToLower() != "y") break;
                }
            } 
        }
    }
}
