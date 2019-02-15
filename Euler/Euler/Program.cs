using System;
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

    public static int FindSmallestDiviser(int num)
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
			Multiples();
             Console.WriteLine("The number is :" + FindSmallestDiviser(100));
           
            Console.ReadLine();
        }
    }
}
