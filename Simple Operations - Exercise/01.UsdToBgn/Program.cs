﻿using System;

namespace _01.UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * usd;
            Console.WriteLine(bgn);
        }
    }
}