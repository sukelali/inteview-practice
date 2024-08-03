// See https://aka.ms/new-console-template for more information
using interview_practice.topics;
using interview_practice.topics.Dotnet;
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


    //int number = Int32.Parse(str);

    //string primeOrNot = PrimeNumber.PrimeOrNotPrime(number);

    //int[] numbers = str.Split(",").Select(n => Int32.Parse(n.Trim())).ToArray();

    //var secondLargest = LargestInteger.GetSecondLargest(numbers);

    //var thirdLargest = LargestInteger.GetThirdLargest(numbers);

    //var nthLargest = LargestInteger.GetNThLargest(numbers, 3);


    //var filterStudentName = LinqFilterAndSorter.GetFilterStudents();

    //var names = string.Join(",", filterStudentName);

    ////int sum = FileReader.ReadFileAndSumNumber();


    //Console.WriteLine($"New String :  {sum}");

    //var singletonOne = Singleton.GetInstance();
    //var singletonTwo = Singleton.GetInstance();


    //await  FileReader.DownloadFileAsync();

    //var calculator = new Calculator();

    //CalculatorDelegate sum = delegate(int a, int b) {
    //    Console.WriteLine($"sum of {a}, {b} is: { a + b }");
    //};

    //var divide = new CalculatorDelegate(calculator.Divide);
    //var multiply = new CalculatorDelegate(calculator.Multiply);


    //sum(11, 12);
    //divide(100, 10);
    //multiply(10,12);

    CalculatorDelegateLamda sum = (a, b) => a + b;
    CalculatorDelegateLamda divide = (a, b) => a / b;
    CalculatorDelegateLamda multiply = (a, b) => a * b;

    Console.WriteLine($"Sum: {sum(11,29)}" );

    Console.WriteLine($"Divide : {divide(5, 10)}");

    Console.WriteLine($"multiply : {multiply(5, 10)}");

}


public delegate void CalculatorDelegate(int a, int b);

public delegate int CalculatorDelegateLamda(int a, int b);
