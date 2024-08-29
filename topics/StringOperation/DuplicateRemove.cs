using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics.StringOperation
{
    public static class DuplicateRemove
    {
        public static string RemoveDuplicate(string str)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (!stringBuilder.ToString().Contains(str[i]))
                {
                    stringBuilder.Append(str[i]);
                }

            }

            return stringBuilder.ToString();
        }


        public static void TakeInputAndRemoveDuplicate()
        {
            Console.WriteLine("Enter Your String: ");

            string inputString = Console.ReadLine();

            string uniqueString = RemoveDuplicate(inputString);

            Console.WriteLine(uniqueString);
        }
    }
}
