using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task ExecuteActionAsync(Action action, CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {
            if (!cancellationToken.IsCancellationRequested)
                action.Invoke();
        }, cancellationToken);
    }

    static async Task Main(string[] args)
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        Action action = () => Console.WriteLine("Action executed asynchronously");

        await ExecuteActionAsync(action, cancellationToken);

      
        cancellationTokenSource.Cancel();
    }
}
