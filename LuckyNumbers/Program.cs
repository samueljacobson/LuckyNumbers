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
            Console.WriteLine("Welcome to Sam's Lottery!");
            Console.WriteLine("Win money by correctly guessing as many numbers as possible within a range.");
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

            //Part 2
            Random randomNumbers = new Random();
            int[] luckyNumbers = new int[6];
            int lucky;
            for (int i = 0; i < 6; i++)
            {   
                lucky = randomNumbers.Next(lowerBound, upperBound + 1);
                luckyNumbers[i] = lucky;
            }
            Console.WriteLine("Lucky Number: " + luckyNumbers[0]);
            Console.WriteLine("Lucky Number: " + luckyNumbers[1]);
            Console.WriteLine("Lucky Number: " + luckyNumbers[2]);
            Console.WriteLine("Lucky Number: " + luckyNumbers[3]);
            Console.WriteLine("Lucky Number: " + luckyNumbers[4]);
            Console.WriteLine("Lucky Number: " + luckyNumbers[5]);

            //Part 3
            Console.WriteLine();

        }
    }
}
