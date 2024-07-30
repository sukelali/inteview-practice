// See https://aka.ms/new-console-template for more information
using interview_practice.topics;



while(true)
{


    Console.WriteLine("Enter Input: ");

    var str =  Console.ReadLine();

    var reverseString = StringReverse.reverse(str); 

    Console.WriteLine($"Reverse String : { reverseString }");


}