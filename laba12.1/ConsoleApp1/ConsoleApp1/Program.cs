using System;
using System.Collections.Generic;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int NumOffspring { get; set; }

    public abstract void DisplayAnimal();
}

public class Carnivore : Animal
{
    public override void DisplayAnimal()
    {
        Console.WriteLine($"Carnivore: {Name}, Age: {Age}, Offspring: {NumOffspring}");
    }
}

public class Herbivore : Animal
{
    public override void DisplayAnimal()
    {
        Console.WriteLine($"Herbivore: {Name}, Age: {Age}, Offspring: {NumOffspring}");
    }
}

public class Cat : Carnivore
{
    public string Sound { get; set; }
    public string Color { get; set; }
}

public class Bear : Carnivore
{
    public string Sound { get; set; }
    public string Color { get; set; }
}

public class Elephant : Herbivore, IEquatable<Elephant>
{
    public string Sound { get; set; }
    public string Color { get; set; }
    public int Size { get; set; }

    public bool Equals(Elephant other)
    {
        return this.Size == other.Size;
    }
}

public class Zoo
{
    private List<Carnivore> carnivores = new List<Carnivore>();
    private List<Herbivore> herbivores = new List<Herbivore>();

    public void AddAnimal(Animal animal)
    {
        if (animal is Carnivore carnivore)
        {
            carnivores.Add(carnivore);
        }
        else if (animal is Herbivore herbivore)
        {
            herbivores.Add(herbivore);
        }
    }
}
