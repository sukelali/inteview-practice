namespace interview_practice.topics.StringOperation
{
    public static class StringPalindrome
    {
        public static string IsPalindrome(string str)
        {
            // madam == palindrome
            // book is not palindroe
            str = str.Trim().ToLower();
            var isPalindrome = true;

            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    isPalindrome = false;

                    break;
                }
            }

            return isPalindrome ? "palindrome" : "not palindrome";
        }


        public static void TakeInputAndCheckPalindrome()
        {

            Console.WriteLine("Enter Your String: ");

            string? inputString = Console.ReadLine();

            string str = IsPalindrome(inputString);

            Console.WriteLine(str);
        }
    }
}
