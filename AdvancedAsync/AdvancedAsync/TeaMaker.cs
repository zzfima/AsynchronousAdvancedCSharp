//from https://www.youtube.com/watch?v=il9gl8MH17s&ab_channel=RawCoding
internal class TeaMaker
{
    private async static Task MainTeaMaker(string[] args)
    {
        var mainTask = MakeTeaAsync();
        $"5. wait to main task {Thread.CurrentThread.ManagedThreadId}".Dump();
        var res = await mainTask;
        Console.WriteLine(res);

        Console.ReadLine();
    }

    static async Task<string> MakeTeaAsync()
    {
        var boilingWater = BoilWaterAsync();
        $"3. take the cups out {Thread.CurrentThread.ManagedThreadId}".Dump();
        $"4. put tea in cups {Thread.CurrentThread.ManagedThreadId}".Dump();
        var water = await boilingWater;
        var tea = $"7. pour {water} in cups {Thread.CurrentThread.ManagedThreadId}";
        return tea;
    }

    static async Task<string> BoilWaterAsync()
    {
        $"1. start the kettle {Thread.CurrentThread.ManagedThreadId}".Dump();
        $"2. waiting for the kettle {Thread.CurrentThread.ManagedThreadId}".Dump();
        await Task.Delay(3000);
        $"6. kettle finished boiling {Thread.CurrentThread.ManagedThreadId}".Dump();
        return $"boiled water";
    }
}