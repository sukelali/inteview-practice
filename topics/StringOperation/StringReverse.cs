using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics.StringOperation
{
    public static class StringReverse
    {


        public static string Reverse(string str)
        {
            if(str == null) throw new ArgumentNullException("str");


            StringBuilder newString = new StringBuilder();

            for (int j = str.Length - 1; j >= 0; j--)
            {

                newString.Append(str[j]);
            }

            return newString.ToString();
        }


        public static void TakeInputAndReverse()
        {
            Console.WriteLine("Enter Your String: ");

            string inputString = Console.ReadLine();

            string reverseString  = Reverse(inputString);
            
            Console.WriteLine(reverseString);

        }

    }
}
