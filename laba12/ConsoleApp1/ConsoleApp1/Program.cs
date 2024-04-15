using System;
using System.Collections.Generic;

public abstract class Animal
{
    public string Name { get; set; }
    public abstract void DisplayAnimal();
}

public class Herbivore : Animal
{
    public override void DisplayAnimal()
    {
        Console.WriteLine("Я травоядное животное: " + Name);
    }
}

public class Carnivore : Animal
{
    public override void DisplayAnimal()
    {
        Console.WriteLine("Я плотоядное животное: " + Name);
    }
}

public class Elephant : Herbivore, IEquatable<Elephant>
{
    public int Size { get; set; }

    public Elephant(string name, int size)
    {
        Name = name;
        Size = size;
    }

    public override void DisplayAnimal()
    {
        Console.WriteLine($"Я слон. Меня зовут {Name}. Мой размер {Size}.");
    }

    public bool Equals(Elephant other)
    {
        if (other == null) return false;
        return this.Size == other.Size;
    }
}

public class Zoo
{
    private List<Herbivore> herbivores = new List<Herbivore>();
    private List<Carnivore> carnivores = new List<Carnivore>();

    public void AddAnimal(Animal animal)
    {
        if (animal is Herbivore herbivore)
        {
            herbivores.Add(herbivore);
        }
        else if (animal is Carnivore carnivore)
        {
            carnivores.Add(carnivore);
        }
    }

    public List<Herbivore> GetHerbivores()
    {
        return herbivores;
    }

    public List<Carnivore> GetCarnivores()
    {
        return carnivores;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Zoo zoo = new Zoo();
        zoo.AddAnimal(new Herbivore { Name = "Зайчик" });
        zoo.AddAnimal(new Carnivore { Name = "Лев" });
        zoo.AddAnimal(new Elephant("Слоненок", 3));

       
        foreach (var herbivore in zoo.GetHerbivores())
        {
            herbivore.DisplayAnimal();
        }

        foreach (var carnivore in zoo.GetCarnivores())
        {
            carnivore.DisplayAnimal();
        }
    }
}
