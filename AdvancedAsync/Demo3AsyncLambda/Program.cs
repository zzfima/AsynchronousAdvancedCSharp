//https://www.youtube.com/watch?v=lh8cT6qI-nA&ab_channel=DotNext

using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Task.Run(MainAsync);
        Console.ReadLine();
    }

    static async Task MainAsync()
    {
        Console.WriteLine("MainAsync Started");

        try
        {
            Foo(() => { throw new NotImplementedException(); });
        }
        catch (Exception e)
        {
            Console.WriteLine($"MainAsync Exception happens {e.Message}");
        }

        await Task.Delay(200);
        Console.WriteLine("MainAsync Finished");
    }

    private static void Foo(Action act)
    {
        Console.WriteLine("Foo Started");
        Thread.Sleep(100);
        act();
        Console.WriteLine("Foo Finished");
    }
}