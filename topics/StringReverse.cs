using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics
{
    public static class StringReverse
    {


        public static string reverse(string str) {


            StringBuilder newString = new StringBuilder();

            for(int i = 0, j = str.Length - 1 ; i < str.Length; i++, j--)
            {

                newString.Append(str[j]);
            }

            return newString.ToString();    
        }

    }
}
