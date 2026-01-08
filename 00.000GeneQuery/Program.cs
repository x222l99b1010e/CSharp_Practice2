namespace _00._000GeneQuery
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		void GeneQuery(string dna, string pattern)
		{
			Console.WriteLine($"Searching for {pattern} in {dna}");
			int count = 0;
			for (int i = 0; i <= dna.Length - pattern.Length; i++)
			{
				if (dna.Substring(i, pattern.Length) == pattern)
				{
					Console.WriteLine($"Found at index: {i}");
					count++;
				}
			}
			Console.WriteLine($"Total found: {count}");
		}
		// 呼叫: GeneQuery("ATGCGATCGCTA", "ATC");
	}
}
