﻿class Program
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

        foreach (int number in numbers)
        {
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts.Add(number, 1);
            }
        }

        foreach (var information in counts)
        {
            Console.WriteLine($"{information.Key} -> {information.Value}");
        }
    }
}