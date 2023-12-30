internal class TeaMaker
{
    private async static Task Main(string[] args)
    {
        var res = await MakeTeaAsync();
        Console.WriteLine(res);

        Console.ReadLine();
    }

    static async Task<string> MakeTeaAsync()
    {
        var boilingWater = BoilWaterAsync();
        $"3. take the cups out {Thread.CurrentThread.ManagedThreadId}".Dump();
        $"4. put tea in cups {Thread.CurrentThread.ManagedThreadId}".Dump();
        var water = await boilingWater;
        var tea = $"6. pour {water} in cups {Thread.CurrentThread.ManagedThreadId}";
        return tea;
    }

    static async Task<string> BoilWaterAsync()
    {
        $"1. start the kettle {Thread.CurrentThread.ManagedThreadId}".Dump();
        $"2. waiting for the kettle {Thread.CurrentThread.ManagedThreadId}".Dump();
        await Task.Delay(3000);
        $"5. kettle finished boiling {Thread.CurrentThread.ManagedThreadId}".Dump();
        return $"boiled water";
    }
}