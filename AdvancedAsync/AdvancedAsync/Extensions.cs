using System.Runtime.CompilerServices;

public static class Extensions
{
    public static void Dump(this string str) => Console.WriteLine(str);
    public static TaskAwaiter GetAwaiter(this TimeSpan timeSpan) => Task.Delay(timeSpan).GetAwaiter();
    public static TaskAwaiter GetAwaiter(this int seconds) => Task.Delay(TimeSpan.FromSeconds(seconds)).GetAwaiter();
}
