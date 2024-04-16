using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class PizzaPlace
{
    private SemaphoreSlim semaphore;

    public PizzaPlace(int numberOfEmployees)
    {
        semaphore = new SemaphoreSlim(numberOfEmployees);
    }

    public async Task MakePizzaAsync()
    {
        await semaphore.WaitAsync();

        try
        {
            
            await Task.Delay(2000);
            Console.WriteLine("Pizza is ready!");
        }
        finally
        {
            semaphore.Release();
        }
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        var pizzaPlace = new PizzaPlace(3); 

        List<Task> tasks = new List<Task>();

       
        for (int i = 0; i < 5; i++)
        {
            tasks.Add(pizzaPlace.MakePizzaAsync());
        }

        await Task.WhenAll(tasks);

        Console.WriteLine("All pizzas are ready!");

        Console.ReadLine(); 
    }
}
