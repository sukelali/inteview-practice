namespace interview_practice.topics.Dotnet
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;
        
        public double GPA { get; set; }


        public override string ToString()
        {
            return $"Name: {Name},  GPA: {GPA}";
        }

    }
}