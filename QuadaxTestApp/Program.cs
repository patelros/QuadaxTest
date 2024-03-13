﻿using System;

namespace QuadaxTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\n Generated a random code:");
            Console.WriteLine(" - falls between 1 and 6, inclusive.");
            Console.WriteLine(" - There are only 4 digits.");
            Console.WriteLine("You have up to 10 tries to guess my secret code.");
            Console.WriteLine("After each guess, I will give you a 4-digit response:");
            Console.WriteLine(" - A '+' character means your guess was correct in that position.");
            Console.WriteLine(" - A '-' character means that digit is in the code, but not in that position.");
            Console.WriteLine(" - A ' ' means that digit is not in the code at all.");
            Console.WriteLine("\n Please enter your first guess now.");

            var game = new RandomDigit();

            do
            {
                Console.Write("\n> ");
                var guess = Console.ReadLine();

                Console.WriteLine(game.Guess(guess));

            } while (!game.IsFinished);
        }
    }
}