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

            int firstMax = int.MinValue;
            int secondMax = int.MinValue;

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

            long firstMax = long.MinValue;
            long secondMax = long.MinValue;
            long thirdMax = long.MinValue;

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

           
            if(thirdMax == long.MinValue)
            {
                thirdMax = firstMax;
            }


            return Convert.ToInt32(thirdMax) ;
        }


        public static int GetNThLargest(int[] numbers, int l)
        {

            // 3 2 1 5 4 => 4

            //PriorityQueue<int, int> numberPriority = new PriorityQueue<int, int>();

            var sortedQueque = new SortedSet<(int value, int index)>();


            for(int i = 0; i < numbers.Length; i++)
            {

                if(sortedQueque.Count < l)
                {
                    sortedQueque.Add((numbers[i], i));
                }
                else if (numbers[i] > sortedQueque.Min.value)
                {
                    sortedQueque.Remove(sortedQueque.Min);
                    sortedQueque.Add((numbers[i], i));

            }

            }


            return sortedQueque.Min.value;
        }


        public static string KthLargestNumber(string[] nums, int k)
        {
            var maxHeap = new SortedSet<(int value, int index)>();

            for (int i = 0; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);

                if (maxHeap.Count < k)
                {
                    maxHeap.Add((number, i));
                }
                else if (number > maxHeap.Min.value)
                {
                    maxHeap.Remove(maxHeap.Min);
                    maxHeap.Add((number, i));
                }

            }

            return maxHeap.Min.value.ToString();
        }

    }
}
