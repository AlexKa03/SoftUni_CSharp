﻿using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 1;
            int number = 1;

            while (counter <= n) 
            {
                Console.WriteLine(number);
                sum += number;

                number += 2;
                counter++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
