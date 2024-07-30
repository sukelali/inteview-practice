namespace interview_practice.topics
{
    public static class LeftCircularArray
    {

        public static int[] ShiftLeft(int[] numbers)
        {
            // [1,2,3,4] will be [2,3,4,1]

            int temp = numbers[0];

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            numbers[numbers.Length - 1] = temp;

            return numbers;
        }
    }
}
