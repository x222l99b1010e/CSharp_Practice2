namespace _00._000CalculateExpression
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}


		// 簡易邏輯解法 (字串處理 + 內建計算)
		void CalculateExpression(string input)
		{
			// 1. 處理隱含乘法: 在 "數字" 與 "(" 之間插入 "*"
			// Regex 可以把 "4(" 變成 "4*("
			string processed = System.Text.RegularExpressions.Regex.Replace(input, @"(\d)(\()", "$1*$2");

			// 2. 使用 DataTable 計算
			System.Data.DataTable table = new System.Data.DataTable();
			var result = table.Compute(processed, null);

			Console.WriteLine($"{input} = {result}");
		}
	}
}
