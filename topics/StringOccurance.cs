using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics
{
    public static class StringOccurance
    {
        public static string CountOccurance(string str)
        {
            Dictionary<char, int> stringDict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    //stringDict[str[i]] = 1;

                    if (!stringDict.ContainsKey(str[i]))
                    {
                        stringDict[str[i]] = 1;
                    } 
                    else
                    {
                        stringDict[str[i]]++;
                    }

                }
            }

            //return stringDict;

            var occuranceString = new StringBuilder();
                occuranceString.Append("\n");

            foreach ( var strD in stringDict )
            {
                occuranceString.Append($"{strD.Key}: {strD.Value} \n");
            }

            return occuranceString.ToString();

        }


        public static string RemoveDuplicate(string str)
        {
            var stringBuilder = new StringBuilder();

            for(int i = 0; i < str.Length; i++)
            {
                if (!stringBuilder.ToString().Contains(str[i]))
                {
                    stringBuilder.Append(str[i]);
                }

            }

            return stringBuilder.ToString();
        }
    }
}
