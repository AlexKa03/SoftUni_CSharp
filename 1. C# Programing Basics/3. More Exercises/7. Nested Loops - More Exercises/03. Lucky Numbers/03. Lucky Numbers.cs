﻿class Program
{
    static void Main(string[] args)
    {
        int luckyNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (((i + j) == (k + l)) && (luckyNumber % (i + j) == 0))
                            {
                                Console.Write($"{i}{k}{k}{l} ");
                            }
                        }
                    }
            }
        }
    }
}