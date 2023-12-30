using System.Runtime.CompilerServices;

public static class Extentions
{
    public static void Dump(this string str) => Console.WriteLine(str);

    public static Task GetAwaiter(this TimeSpan timeSpan) => Task.Delay(timeSpan);
}
