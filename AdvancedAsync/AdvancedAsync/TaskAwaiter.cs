﻿//from https://www.youtube.com/watch?v=RqJESGHEMDY&ab_channel=FullStackAmigo

namespace AdvancedAsync
{
    internal class TaskAwaiter
    {
        public static async Task Main(string[] args)
        {
            /*
            EnumeratorExample enumeratorExample = new EnumeratorExample();
            foreach (var e in enumeratorExample) { }
            */

            await Task.Delay(TimeSpan.FromSeconds(1));
            await TimeSpan.FromSeconds(1).GetAwaiter();
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
