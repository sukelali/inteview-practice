using System.Text;

namespace interview_practice.topics.StringOperation
{
    public static class SubString
    {

        public static string Create(string str)
        {

            var newString = new StringBuilder();

            // abcd  a ab abc abcd b bc bcd c cd d 
            for (int i = 0; i < str.Length; i++)
            {
                // i = 1
                //newString.Append(str[i]);
                for (int j = 0; j <= i; j++)
                {
                    // j = 1

                    for (int k = j; k <= i; k++)
                    {
                        newString.Append(str[k]);
                    }

                    newString.Append(" ");

                    //newString.Append(str[j]);

                }

            }


            return newString.ToString();

        }
    }
}
