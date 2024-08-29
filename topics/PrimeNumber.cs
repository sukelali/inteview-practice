namespace interview_practice.topics
{
    public static class PrimeNumber
    {

        public static async Task<string> PrimeOrNotPrime(int number)
        {

            if (number % 2 == 0)
            {
                return "Not Prime";
            }

            bool isPrime = true;


            double numberSqrt = await Task.Run(() =>
            {
                return Math.Floor(Math.Sqrt(number));
            });


            for (int i = 3; i <= numberSqrt; i = i + 2)
            {
                //Console.WriteLine($"{i} \n");

                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }


            return isPrime ? "Prime" : "Not Prime";

        }


        public static bool IsPrime(int number)
        {

            if(number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            bool isPrime = true;


            for (int i = 3; i <= Math.Floor(Math.Sqrt(number)); i = i + 2)
            {
                //Console.WriteLine($"{i} \n");

                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        public static IEnumerable<int> GetPrimeNumbers(int number)
        {
            var primeNumbers = new List<int>();

            if(number < 3)
            {
                return primeNumbers;
            }

            for (int i = 2; i <= number; i++)
            {
                if(IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;

        }


        public static bool[] PrimeNumberCountUsingSieve(int number)
        {

            if (number < 3)
                return [];

            bool[] primeNumbers = new bool[number];
            
            for(int i = 2; i < number; i++)
            {
                primeNumbers[i] = true;
            }

            for(int i = 2; i * i < number; i++)
            {

                if (primeNumbers[i] == true)
                {
                    
                   for( int j = i * i, p = i ; j < number; p++, j = i * p)
                   {
                        primeNumbers[j] = false;
                   }
                }
            }


            return primeNumbers.Where(pm => pm == true).ToArray();


        }


      
    }
}
