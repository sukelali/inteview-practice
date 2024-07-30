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

            // 21  , , , ,, ,, ,,,11,,13,,15,, 17,, 19,, 21

            if (number % 2 == 0)
            {
                return "Not Prime";
            }

            bool isPrime = true;

            for(int i = 3; i <= Math.Floor(Math.Sqrt(number)); i = i + 2)
            {
                //Console.WriteLine($"{i} \n");

                if (number % i == 0)
                {
                    isPrime =false;
                    break;
                }
            }


            return isPrime ? "Prime" : "Not Prime";
        }
    }
}
