using System;

public static class IntArrayExtensions
{
    public static int MaxElement(this int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array is null or empty");

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxNumber = numbers.MaxElement();
        Console.WriteLine("Max number: " + maxNumber);
    }
}
