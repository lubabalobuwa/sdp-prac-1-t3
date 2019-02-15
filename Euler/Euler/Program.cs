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
	

        public CheckPrime(double temp)
        {
            int rd=0;
            for(int i=1;i<-temp){
                if(temp % i==0){
                    rd++
                }
            }
            if (rd==2)
            {
                return true;
            }
            return false
        }
        
        public double LargestPrimeFactor(double Num)
        {
            List<double> primefactors = new list<double>();
            double temp=0;
            for (double i=0;i<num;i++){
                if((num%i)==0){
                    if(checkPrime(temp)){
                        primefactors.Add(temp)
                    }
                }
            }
            primefactors.sort();
            return primefactors[primefactors.Count-1];
        }
        
                
        static void Main(string[] args)
        {
			Multiples();
         Console.Writeline( LargestPrimeFactor(600851475143);  
		 
		  Console.WriteLine("The number is :" + FindSmallestDiviser(100));
           
          Console.ReadLine();
        }
    }
}
