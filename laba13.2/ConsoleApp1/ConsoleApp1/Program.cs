using System;
using System.Collections.Generic;

class Collection<T> where T : IComparable<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
        items.Sort();
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Текущий список:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

class MyClass : IComparable<MyClass>
{
    public int IdNumber { get; set; }

    public MyClass(int idNumber)
    {
        IdNumber = idNumber;
    }

    public int CompareTo(MyClass other)
    {
        return IdNumber.CompareTo(other.IdNumber);
    }

    public override string ToString()
    {
        return $"IdNumber: {IdNumber}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Collection<MyClass> collection = new Collection<MyClass>();

        
        collection.Add(new MyClass(5));
        collection.Add(new MyClass(2));
        collection.Add(new MyClass(7));

        
        collection.Add(new MyClass(4));

        Console.ReadLine();
    }
}
