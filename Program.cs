﻿using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer between 2 and 10: ");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 1)
            {

                for (int i = 0; i < n - 1; i++)

                    Console.WriteLine("You entered an odd number");

            }

            else
            {

                for (int i = 0; i < n + 1; i++)

                    Console.WriteLine("You entered an even number");

            }

        }

    }
}


