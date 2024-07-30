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

            char[] strChar = str.ToCharArray();

            StringBuilder newString = new StringBuilder();

            for(int i = 0, j = strChar.Length - 1 ; i < strChar.Length; i++, j--)
            {

                newString.Append(strChar[j]);
            }

            return newString.ToString();    
        }

    }
}
