namespace interview_practice.topics.Dotnet
{
    public static class LinqFilterAndSorter
    {



        public static IEnumerable<string> GetFilterStudents()
        {

            var students = new List<Student>() {
                new Student() { Id = 1, Name = "Md. Sukel Ali", GPA = 4 },
                new Student() { Id = 2, Name = "Partho Das", GPA = 3.2 },
                new Student() { Id = 3, Name = "Farhana Anwar", GPA = 3.6 },
                new Student() { Id = 4, Name = "Abu Sayed", GPA = 4.5 }
            };


            var filterStudents = students
                                        .Where(s => s.GPA > 3.5)
                                        .OrderByDescending(s => s.GPA)
                                        .Select(s => s.Name)
                                        .ToList<string>();

            return filterStudents;

        }


        public static IEnumerable<String> GetFilterStudentsByCustom()
        {
            var students = new List<Student>() {
                new Student() { Id = 1, Name = "Md. Sukel Ali", GPA = 4 },
                new Student() { Id = 2, Name = "Partho Das", GPA = 3.2 },
                new Student() { Id = 3, Name = "Farhana Anwar", GPA = 3.6 },
                new Student() { Id = 4, Name = "Abu Sayed", GPA = 4.5 }
            };

            return students.Filter(s => s.GPA > 3.5).Select(s => s.Name).ToList<string>();

        }
    }
}
