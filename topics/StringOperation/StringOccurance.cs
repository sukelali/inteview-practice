using System.Text;

namespace interview_practice.topics.StringOperation
{
    public static class StringOccurance
    {
        public static Dictionary<char, int> CountOccurance(string str)
        {
            Dictionary<char, int> occuranceDict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {

                    if (!occuranceDict.ContainsKey(str[i]))
                    {
                        occuranceDict[str[i]] = 1;
                    }
                    else
                    {
                        occuranceDict[str[i]]++;
                    }

                }
            }

            return occuranceDict;

        }


        public static void TakeInputAndCountOccurance()
        {

            Console.WriteLine("Enter Your String: ");

            string? inputString = Console.ReadLine();


            var occuranceDict = CountOccurance(inputString);

            var occuranceString = new StringBuilder();

            occuranceString.Append("\n");

            foreach (var strD in occuranceDict)
            {
                occuranceString.Append($"{strD.Key}: {strD.Value} \n");
            }

            occuranceString.ToString();

            Console.WriteLine(occuranceString);
        }

    }
}
