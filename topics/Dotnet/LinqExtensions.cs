namespace interview_practice.topics.Dotnet
{
    public static class LinqExtensions
    {


        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {

            foreach(var item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }


        }


        public static string GetNameString<T>(this T sourceObject)
        {
            
            if(sourceObject == null)
                return string.Empty;


            var nameProperty = typeof(T).GetProperty("Name");


            if(nameProperty == null)
            {
                return string.Empty;
            }

            return nameProperty.GetValue(sourceObject).ToString();


        }

    }
}
