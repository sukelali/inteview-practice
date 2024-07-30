// See https://aka.ms/new-console-template for more information
using interview_practice.topics;



while(true)
{


    Console.WriteLine("Enter Input: ");

    var str =  Console.ReadLine();

    //var reverseString = StringReverse.Reverse(str); 

    //var palindrome = StringPalindrome.IsPalindrome(str);

    var reverseSentence = SentenceReverse.Reverse(str);

    Console.WriteLine($"New String : { reverseSentence }");


}