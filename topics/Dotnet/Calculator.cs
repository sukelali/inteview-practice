namespace interview_practice.topics.Dotnet
{
    public class Calculator
    {

        

        public void Add(int a, int b)
        {

            Console.WriteLine($"Sum of {a},{b} is: {a + b}");
        }


        public void Divide(int a, int b) 
        {
            Console.WriteLine($"Dividation result of {a},{b} is {a / b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a}, {b} is {a * b}");
        }


        public double CalculateRadius(Func<double, double> op)
        {
            return op(2);
        }
    }
}
