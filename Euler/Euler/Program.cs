﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        public static void Multiples()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("sum of all the multiples of 3 or 5 below 1000 is:");
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            Multiples();
        }
    }
}
