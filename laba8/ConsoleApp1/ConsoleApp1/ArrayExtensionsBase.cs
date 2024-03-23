namespace ConsoleApp1
{
    public static class ArrayExtensionsBase
    {
        public static int Max(this int[] array)
        {
            int max = int.MinValue;
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}