using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Part 1 - ask for user input
                Console.WriteLine("Welcome to Sam's Lottery!");
                Console.WriteLine("Win money by correctly guessing as many numbers as possible within a range.");
                Console.WriteLine("If you correctly guess all 6 numbers, the jackpot is $100,000.");
                Console.WriteLine("Please enter the lower bound of the range.");
                int lowerBound = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the upper bound of the range.");
                int upperBound = int.Parse(Console.ReadLine());

                int[] guessNumbers = new int[6];
                int guess;
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Guess a number.");
                    guess = int.Parse(Console.ReadLine());
                    {
                        while (guess < lowerBound || guess > upperBound)
                        {
                            Console.WriteLine("That number is out of range. Please enter another.");
                            guess = int.Parse(Console.ReadLine());
                        }
                    }
                    guessNumbers[i] = guess;
                }

                //Part 2 - generate random numbers
                Random randomNumbers = new Random();
                int[] luckyNumbers = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    luckyNumbers[i] = randomNumbers.Next(lowerBound, upperBound + 1);
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }

                //Part 3 - compare user input to random numbers and determine corresponding payout
                int correctGuesses = 0;                 //this method does not seem to calculating the correct number of matches
                foreach (int guesses in guessNumbers)
                {
                    if (guesses == luckyNumbers[0])
                    {
                        correctGuesses += 1;
                    }
                    if (guesses == luckyNumbers[1])
                    {
                        correctGuesses += 1;
                    }
                    if (guesses == luckyNumbers[2])
                    {
                        correctGuesses += 1;
                    }
                    if (guesses == luckyNumbers[3])
                    {
                        correctGuesses += 1;
                    }
                    if (guesses == luckyNumbers[4])
                    {
                        correctGuesses += 1;
                    }
                    if (guesses == luckyNumbers[5])
                    {
                        correctGuesses += 1;
                    }
                }

                //for (int i = 0; i < 6; i++)           //additional attempt, also not correctly calculating
                //{
                //    if (guessNumbers[0] == luckyNumbers[i])
                //    {
                //        correctGuesses += 1;   
                //    }
                //    if (guessNumbers[1] == luckyNumbers[i])
                //    {
                //        correctGuesses += 1;
                //    }
                //    if (guessNumbers[2] == luckyNumbers[i])
                //    {
                //        correctGuesses += 1;
                //    }
                //    if (guessNumbers[3] == luckyNumbers[i])
                //    {
                //        correctGuesses += 1;
                //    }
                //    if (guessNumbers[4] == luckyNumbers[i])
                //    {
                //        correctGuesses += 1;
                //    }
                //    if (guessNumbers[5] == luckyNumbers[i])
                //    {
                //        correctGuesses += 1;
                //    }
                //}
                Console.WriteLine("\nYou guessed " + correctGuesses + " correctly!");

                string payout;
                if (correctGuesses == 1)
                {
                    payout = "$10.00";
                    Console.WriteLine("Congratulations! You won " + payout + "!");
                }
                else if (correctGuesses == 2)
                {
                    payout = "$50.00";
                    Console.WriteLine("Congratulations! You won " + payout + "!");
                }
                else if (correctGuesses == 3)
                {
                    payout = "$100.00";
                    Console.WriteLine("Congratulations! You won " + payout + "!");
                }
                else if (correctGuesses == 4)
                {
                    payout = "$1000.00";
                    Console.WriteLine("Congratulations! You won " + payout + "!");
                }
                else if (correctGuesses == 5)
                {
                    payout = "$10,000.00";
                    Console.WriteLine("Congratulations! You won " + payout + "!");
                }
                else if (correctGuesses == 6)
                {
                    payout = "$100,000.00";
                    Console.WriteLine("Congratulations! You won " + payout + "!");
                }
                else
                {
                    Console.WriteLine("Sorry, you didn't win anything.");
                }

                //Part 4 - entire program contained within a while loop
                Console.WriteLine("\nWould you like to play again? YES/NO");
                string playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "NO")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}