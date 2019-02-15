using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        public static void findPrime()
        {
            int count = 1;
            int idx = 3;
            while( true)
            {
                int nums = 1;
                bool isPrime = true;
                for(int i  = 2; i  <= idx; i++)
                {
                    if(idx % i == 0)
                    {
                        nums++;
                        if (nums > 2)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    
                }
                if (isPrime)
                {
                    count++;
                    if(count == 10001)
                    {
                        Console.WriteLine("the 10 001st prime number is " + idx);
                    }
                }
                idx++;
            }
        }// Finds the 10001st prime number
        static void Main(string[] args)
        {
            findPrime();
        }
    }
}
