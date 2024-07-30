

namespace interview_practice.topics
{
    public static class StringPalindrome
    {
        public static string IsPalindrome(string str)
        {

            str = str.Trim().ToLower();
            // madam == palindrome
            // book is not palindroe
            var isPalindrome = true;
            for(int i = 0, j = str.Length-1; i <= j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    isPalindrome = false;

                    break;
                }
            }

            return isPalindrome ? "palindrome" : "not palindrom";  
        }
    }
}
