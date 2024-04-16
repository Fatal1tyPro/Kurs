using System;
using System.Threading.Tasks;

class Program
{
    static async Task DelayedTaskAsync(int time)
    {
        await Task.Delay(time);
        Console.WriteLine("Hello from callback (await)");
    }

    static void Main(string[] args)
    {
        int time = 2000;

        var task = DelayedTaskAsync(time);
        task.GetAwaiter().OnCompleted(() =>
        {
            Console.WriteLine("Hello from callback (awaiter)");
        });

        Task.Delay(time).ContinueWith(_ =>
        {
            Console.WriteLine("Hello from callback (ContinueWith)");
        });

        Console.ReadLine(); 
    }
}
