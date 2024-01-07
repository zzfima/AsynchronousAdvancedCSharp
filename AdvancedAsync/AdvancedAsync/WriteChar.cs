//from https://www.youtube.com/watch?v=eip2Xjrzp9g&ab_channel=ITVDN

namespace AdvancedAsync
{
	internal class WriteChar
	{
		private static async Task Main(string[] args)
		{
			$"1. main started ThreadID: {Thread.CurrentThread.ManagedThreadId}".Dump();
			await WriteSymbolAsync('#');
			WriteSymbol('*');
			$"6. main finished ThreadID: {Thread.CurrentThread.ManagedThreadId}".Dump();

			Console.ReadLine();
		}

		static async Task WriteSymbolAsync(char symbol)
		{
			$"2. WriteCharAsync started ThreadID: {Thread.CurrentThread.ManagedThreadId}".Dump();
			await Task.Run(() => WriteSymbol(symbol));
			$"5. WriteCharAsync finished ThreadID: {Thread.CurrentThread.ManagedThreadId}".Dump();
		}

		static void WriteSymbol(char symbol)
		{
			$"3. WriteChar started in ThreadID: {Thread.CurrentThread.ManagedThreadId} TaskID: {Task.CurrentId}".Dump();
			Thread.Sleep(500);
			for (int i = 0; i < 80; i++)
			{
				Console.Write(symbol);
				Thread.Sleep(100);
			}
			Console.WriteLine(symbol);

			$"4. WriteChar finished in ThreadID: {Thread.CurrentThread.ManagedThreadId}".Dump();
		}
	}
}
