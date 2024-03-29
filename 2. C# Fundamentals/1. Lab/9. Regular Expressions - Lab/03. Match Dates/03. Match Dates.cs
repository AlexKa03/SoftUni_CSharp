﻿using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Updated regex pattern
        var regex = @"(?<day>\b\d{2})(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4}\b)";

        var datesStrings = Console.ReadLine();

        var dates = Regex.Matches(datesStrings, regex);

        foreach (Match date in dates)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}
