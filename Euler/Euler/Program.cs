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

        public static bool CheckPrime(double temp)
        {
            int rd=0;
            for(int i=1;i <=temp;i++){
                if(temp % i==0){
                    rd++;
                }
            }
            if (rd==2)
            {
                return true;
            }
            return false;
        }
        
        public static double LargestPrimeFactor(double num)
        {
            List<double> primefactors = new List<double>();
            double temp=0;
            for (double i=0;i<num;i++)
            {
                if((num%i)==0)
                {
                    temp = i;
                    if(CheckPrime(temp))
                    {
                        primefactors.Add(temp);
                    }
                }
            }
            primefactors.Sort();
            return primefactors[primefactors.Count-1];
        }
        
                
        static void Main(string[] args)
        {
	   	  Multiples();
		  Console.WriteLine("The number is :" + FindSmallestDiviser(100));
          findPrime();
          Console.WriteLine("This might take a while \n " +"Largest Prime Factor of 600851475143 is : " +LargestPrimeFactor(600851475143));
          Console.ReadLine();
        }
		
    }
}
