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
        TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
        try
        {
            DelayAndThrowAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception happens {e.Message}");
        }

        Console.WriteLine("Finished");

        await Task.Delay(2000);
        GC.Collect();
    }

    private static void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
    {
        //
    }

    //shall be task - wrap exception
    static async Task DelayAndThrowAsync()
    {
        await Task.Delay(1000);
        throw new InvalidOperationException("fff");
    }
}