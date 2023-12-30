//from https://www.youtube.com/watch?v=RqJESGHEMDY&ab_channel=FullStackAmigo

using System.Diagnostics;

namespace AdvancedAsync
{
    internal class TaskAwaiter
    {
        public static async Task Main(string[] args)
        {
            /* EnumeratorExample shall include GetEnumerator method. No need interface
            EnumeratorExample enumeratorExample = new EnumeratorExample();
            foreach (var e in enumeratorExample) { }
            */

            /* TimeSpan.FromSeconds shall include GetAwaiter method. No need interface
            await Task.Delay(TimeSpan.FromSeconds(1));
            await TimeSpan.FromSeconds(1);
            */

            /* int shall include GetAwaiter method. No need interface
            await 5;
            */

            await Process.Start("notepad.exe");
        }
    }

    public class EnumeratorExample
    {
        public EnumerableExample GetEnumerator() => throw new NotImplementedException();
    }

    public class EnumerableExample
    {
        public int Current { get; set; }
        public bool MoveNext() => throw new NotImplementedException();
    }
}
