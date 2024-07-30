using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics
{
    public static class SentenceReverse
    {
        public static string Reverse(string sentence)
        {

            // input: Welcome to Csharp corner, output: corner Csharp to Welcome

            string[] sentenceArray = sentence.Split(' ');

            StringBuilder reverseSentence = new StringBuilder();

            for(int i = 0, j = sentenceArray.Length-1;  i < sentenceArray.Length; i++, j--)
            {
                reverseSentence.Append($"{sentenceArray[j]} ");
            }

            return reverseSentence.ToString();
        }
    }
}
