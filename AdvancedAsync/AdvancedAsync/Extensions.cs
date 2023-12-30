public static class Extensions
{
    public static void Dump(this string str) => Console.WriteLine(str);
    public static TaskAwaiter GetAwaiter(this TimeSpan timeSpan) => Task.Delay(timeSpan).GetAwaiter();
    public static TaskAwaiter GetAwaiter(this int seconds) => Task.Delay(TimeSpan.FromSeconds(seconds)).GetAwaiter();
    public static TaskAwaiter<int> GetAwaiter(this Process process)
    {
        var tcs = new TaskCompletionSource<int>();
        process.EnableRaisingEvents = true;
        process.Exited += (sender, e) => 
            tcs.TrySetResult(process.ExitCode);
        if (process.HasExited)
            tcs.TrySetResult(process.ExitCode);
        return tcs.Task.GetAwaiter();
    }
}
