// See https://aka.ms/new-console-template for more information
using interview_practice.topics;
using System.Text;



while (true)
{


    Console.WriteLine("Enter Input: ");

    var str =  Console.ReadLine();

    //var reverseString = StringReverse.Reverse(str); 

    //var palindrome = StringPalindrome.IsPalindrome(str);

    //var reverseSentence = SentenceReverse.Reverse(str);

    //var reverseSentenceWord = SentenceReverse.ReverseWord(str);

    //var occuranceString = StringOccurance.CountOccurance(str);

    //var removeDuplicateString = StringOccurance.RemoveDuplicate(str);

    //var subString = SubString.Create(str);


    //int[] numbers = str.Split(",").Select(n => Int32.Parse(n.Trim())).ToArray();

    //var newNumber = LeftCircularArray.ShiftLeft(numbers);

    //string newStr = string.Join(",", newNumber);
        

    int number = Int32.Parse(str);

    string primeOrNot = PrimeNumber.PrimeOrNotPrime(number);


   Console.WriteLine($"New String :  {primeOrNot}");

}