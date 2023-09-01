﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static void Add(double x, double y)
        {
            Console.WriteLine($"The value of {x} + {y} = {x + y}.");
        }

        public static void AddAll(double[] values)
        {
            double result = 0;

            //Instead of creating a method to add all, built in function .Sum() exists. For future reference
            foreach (double value in values)
            {
                result += value;
            }
            Console.WriteLine($"The total is {result}.");
        }

    }
}