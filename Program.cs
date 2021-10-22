using System;

namespace RandomNumGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 20);
            int guessNumber;

            Console.WriteLine("GUESS THE NUMBER between 1 and 20!");
            Console.WriteLine("I am thinking of a number!");

            for (int guess = 0; guess < 3; guess++)
            {
                Console.Write("Take a guess: ");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == randomNumber)
                {
                    Console.WriteLine($"YOU GOT IT! The correct number is {randomNumber}!");
                    break;
                }
                else if (guessNumber < randomNumber)
                {
                    if (guess == 2)
                    {
                        Console.WriteLine($"Game Over!\nSorry. The number I was thinking was {randomNumber}.");
                    }
                    else
                    {
                        Console.WriteLine("Mmm... Not quite! Try a bigger number.");
                    }
                }
                else
                {
                    if (guess == 2)
                    {
                        Console.WriteLine($"Game Over!\nSorry. The number I was thinking was {randomNumber}.");
                    }
                    else
                    {
                        Console.WriteLine("Nope... Try a smaller number.");
                    }
                }
            }
        }
    }
}
