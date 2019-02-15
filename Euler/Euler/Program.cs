using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program


    { public static int FindSmallestDiviser(int num)
        {
            int sumSquares = 0;
            for (int i = 1; i < num+1; i++)
            {
                sumSquares += (i * i);
            }
            int sum = 0;
            for (int xs = 1; xs < num+1; xs++)
            {
                sum += xs;
            }
            int diff = (sum * sum) - sumSquares;



            return diff;
        }
        static void Main(string[] args)
        {
             Console.WriteLine("The number is :" + FindSmallestDiviser(100));
           
            Console.ReadLine();

        }
    }
}
