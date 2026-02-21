namespace _00._000CoinChange
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		void CoinChange(int target, int num10, int num5, int num1)
		{
			Console.WriteLine($"Target: {target}");
			// i: 10元數量, j: 5元數量, k: 1元數量
			for (int i = 0; i <= num10; i++)
			{
				for (int j = 0; j <= num5; j++)
				{
					for (int k = 0; k <= num1; k++)
					{
						if ((i * 10 + j * 5 + k * 1) == target)
						{
							Console.WriteLine($"10元:{i}枚, 5元:{j}枚, 1元:{k}枚");
						}
					}
				}
			}
		}
	}
}
