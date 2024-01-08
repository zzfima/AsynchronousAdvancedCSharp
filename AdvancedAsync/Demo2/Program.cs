//https://www.youtube.com/watch?v=lh8cT6qI-nA&ab_channel=DotNext

using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Task.Run(MainAsync);

        Console.ReadLine();
    }

    static async Task MainAsync()
    {
        Console.WriteLine("Started");

        try
        {
            DelayAndThrowAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception happens {e.Message}");
        }

        Console.WriteLine("Finished");
    }

    static async void DelayAndThrowAsync()
    {
        await Task.Delay(1000);
        throw new InvalidOperationException("fff");
    }
}