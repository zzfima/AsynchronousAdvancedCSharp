﻿internal class ClassDictionary
{
	private static void Main(string[] args)
	{
		Console.WriteLine();
		Dictionary<string, int> map = new Dictionary<string, int>();
		map["a"] = 1;
		map["b"] = 1;
		map["c"] = 1;
		SimpleIncrement(map, "b");
		Console.WriteLine($"{map["b"]}");
		Console.ReadLine();
	}

	//two travels do dictionary: one for read, one for write.
	//If dictionary is big and hash function is complex it can take a time
	private static void SimpleIncrement(Dictionary<string, int> map, string key)
	{
		map[key]++;
	}
}
