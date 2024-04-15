using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "apple", "banana", "orange", "pineapple", "grape", "watermelon", "kiwi", "strawberry" };

        Console.WriteLine("Слова длиной более 5 символов:");

        foreach (var word in FilterWordsByLength(words))
        {
            Console.WriteLine(word);
        }

        Console.ReadLine();
    }

    static IEnumerable<string> FilterWordsByLength(string[] words)
    {
        var randomWords = GenerateRandomWords(3);

        foreach (var word in words)
        {
            if (word.Length > 5)
            {
                yield return word;
            }
        }
    }

    static string[] GenerateRandomWords(int count)
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>()
        {
            { 1, "cat" },
            { 2, "dog" },
            { 3, "elephant" },
            { 4, "lion" },
            { 5, "tiger" },
            { 6, "giraffe" },
            { 7, "monkey" },
            { 8, "penguin" },
            { 9, "zebra" },
            { 10, "cheetah" }
        };

        Random random = new Random();
        List<string> randomWords = new List<string>();

        for (int i = 0; i < count; i++)
        {
            int randomKey = random.Next(1, dictionary.Count + 1);
            randomWords.Add(dictionary[randomKey]);
        }

        return randomWords.ToArray();
    }
}
