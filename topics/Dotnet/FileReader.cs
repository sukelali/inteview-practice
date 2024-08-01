namespace interview_practice.topics.Dotnet
{
    public static class FileReader
    {
        
        public static int ReadFileAndSumNumber()
        {


            var filePath = "D:\\Code\\interview-practice\\resource\\numbers.txt";
            
            int sum = 0;

            try
            {
                string[] numbers = File.ReadAllLines(filePath);

                

                foreach (var numberStr in numbers)
                {
                    Int32.TryParse(numberStr.Trim(), out int number);
                        
                    sum += number;
                }
            } 
            catch(Exception ex)
            {
               Console.WriteLine(ex.Message);
            }


            return sum;
        }
    }
}
