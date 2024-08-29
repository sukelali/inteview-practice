using System.Text;

namespace interview_practice.topics.StringOperation
{
    public static class SentenceReverse
    {
        public static string Reverse(string sentence)
        {

            // input: Welcome to Csharp corner, output: corner Csharp to Welcome
            string[] sentenceArray = sentence.Split(' ');

            StringBuilder reverseSentence = new StringBuilder();

            for (int j = sentenceArray.Length - 1; j >= 0; j--)
            {
                reverseSentence.Append($"{sentenceArray[j]} ");
            }

            return reverseSentence.ToString();
        }


        public static void TakeInputAndReverseWord()
        {
            Console.WriteLine("Enter Your String: ");

            string inputString = Console.ReadLine();

            string reverseString = Reverse(inputString);

            Console.WriteLine(reverseString);
        }


    }
}
