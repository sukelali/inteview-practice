using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics
{
    public static class LargestInteger
    {

        public static int GetSecondLargest(int[] numbers) {

            // 3 2 1 5 4 => 4

            int firstMax = 0;
            int secondMax = 0;

            for(int i = 0; i < numbers.Length; i++)
            {


                if (numbers[i] > firstMax)
                {
                    secondMax = firstMax;

                    firstMax = numbers[i];
                } 
                else if(numbers[i] > secondMax && numbers[i] != firstMax)
                {
                    secondMax = numbers[i];
                }

              

            }


            return secondMax; 
        }


        public static int GetThirdLargest(int[] numbers)
        {

            // 3 2 1 5 4 => 4

            int firstMax = 0;
            int secondMax = 0;
            int thirdMax = 0;

            for (int i = 0; i < numbers.Length; i++)
            {


                if (numbers[i] > firstMax)
                {
                    thirdMax = secondMax;

                    secondMax = firstMax;

                    firstMax = numbers[i];
                }
                else if (numbers[i] > secondMax && numbers[i] != firstMax)
                {
                    thirdMax = secondMax;

                    secondMax = numbers[i];

                }
                else if (numbers[i] > thirdMax && numbers[i] != secondMax && numbers[i] != firstMax)
                {
                    thirdMax = numbers[i];
                }
            }


            return thirdMax;
        }
    }
}
