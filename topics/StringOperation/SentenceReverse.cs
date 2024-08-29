using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics.StringOperation
{
    public static class SentenceReverse
    {
        public static string Reverse(string sentence)
        {

            // input: Welcome to Csharp corner, output: corner Csharp to Welcome

            string[] sentenceArray = sentence.Split(' ');

            StringBuilder reverseSentence = new StringBuilder();

            for (int i = 0, j = sentenceArray.Length - 1; i < sentenceArray.Length; i++, j--)
            {

                reverseSentence.Append($"{sentenceArray[j]} ");
            }

            return reverseSentence.ToString();
        }

        public static string ReverseWord(string sentence)
        {

            // input: Welcome to Csharp corner, output: corner Csharp to Welcome

            string[] sentenceArray = sentence.Split(' ');

            StringBuilder reverseSentence = new StringBuilder();

            for (int i = 0, j = sentenceArray.Length - 1; i < sentenceArray.Length; i++, j--)
            {
                var tempString = sentenceArray[i];

                var tempStringBuilder = new StringBuilder();

                for (int k = 0, l = tempString.Length - 1; k < tempString.Length; k++, l--)
                {
                    tempStringBuilder.Append(tempString[l]);
                }

                reverseSentence.Append($"{tempStringBuilder} ");
            }

            return reverseSentence.ToString();
        }


    }
}
