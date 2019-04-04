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

        public Board board { get; set; }

        public string gameBoard { get; set; }

        public GamePlay(Board board)
        {
            this.board = board;
            Main();
        }

        public void Main()
        {
            this.gameBoard = board.generateBoard();
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

                if (this.gameBoard == this.guess)
                {
                    Console.WriteLine("you did it!");
                    won = true;
                }

                
                if (!won)
                {
                    // looping throuhg guess
                    for (int i = 0; i < guess.Length; i++)
                    {
                        // if the index value in the guess is contained in the board
                        if (gameBoard.IndexOf(guess[i]) > -1)
                        {
                            // number is correct and in the correct place, add a +
                            if (guess[i] == gameBoard[i]) 
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
                    Console.WriteLine($"the masterminded number was {this.gameBoard}");
                    Console.Write("Play Again(y/n)? ");
                    if (Console.ReadLine().ToLower() != "y") break;
                    
                    // reset defaults
                    guesses = 9;
                    won = false;
                    Console.Clear();
                    this.gameBoard = board.generateBoard();
                }
            } 
        }
    }
}
