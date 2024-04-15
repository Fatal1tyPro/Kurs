using System;

public class Item
{
    private string Name = "unknown";

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Item item = new Item();
        Console.WriteLine("Дефолтное имя предмета: " + item.GetName());

        item.SetName("Книга");
        Console.WriteLine("Имя после установки: " + item.GetName());

        Console.ReadLine();
    }
}
