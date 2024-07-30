using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics
{
    public static class PrimeNumber
    {

        public static string PrimeOrNotPrime(int number)
        {

            bool isPrime = true;

            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    isPrime =false; 
                    break;
                }
            }


            return isPrime ? "Prime" : "Not Prime";
        }
    }
}
