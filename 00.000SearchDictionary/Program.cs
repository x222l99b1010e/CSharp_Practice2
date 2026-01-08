namespace _00._000SearchDictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		void SearchDictionary()
		{
			string[] dictionary = { "unique", "antique", "query", "question", "qi", "aquarium" };
			string target = "qi";

			var result = dictionary
				.Select((word, index) => new { Word = word, Index = index }) // 保留原始索引
				.Where(x => x.Word.Contains(target))                        // 模糊查詢
				.OrderBy(x => x.Word.Length)                                // 1. 照長度排
				.ThenBy(x => x.Word)                                        // 2. 照字母順序排
				.ToList();

			foreach (var item in result)
			{
				Console.WriteLine($"Index: {item.Index}, Word: {item.Word}");
			}
		}
	}
}
