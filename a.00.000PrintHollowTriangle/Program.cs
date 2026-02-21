namespace _00._000PrintHollowTriangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			Program p = new Program();
			p.PrintTriangleWithCoords(5);

		}
		
		void PrintTriangleWithCoords(int n)
		{
			for (int i = 0; i < n; i++)
			{
				string coordsInRow = ""; // 用來記錄這一行出現的所有座標
				for (int j = 0; j < 2 * n - 1; j++)
				{
					if (i + j == n - 1 || j - i == n - 1 || i == n - 1)
					{
						Console.Write("*");//不換行
						coordsInRow += $"({i},{j}) ";
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine($"  <-- 這一行的座標點: {coordsInRow}");//換行
			}
		}
	}
}
