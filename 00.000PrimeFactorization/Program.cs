namespace _00._000PrimeFactorization
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			Program p = new Program();
			p.PrimeFactorization(100);
		}

		void PrimeFactorization(int num)
		{
			Console.Write($"{num}=");//不換行
			var factors = new Dictionary<int, int>();
			int divisor = 2;

			while (num > 1)
			{
				if (num % divisor == 0)
				{
					if (!factors.ContainsKey(divisor)) factors[divisor] = 0;
					factors[divisor]++;
					num /= divisor;
				}
				else
				{
					divisor++;
				}
			}

			// 格式化輸出
			var parts = new List<string>();
			foreach (var item in factors)
			{
				if (item.Value > 1)
					parts.Add($"{item.Key}^{item.Value}");
				else
					parts.Add($"{item.Key}");
			}
			Console.WriteLine(string.Join("*", parts));
		}
	}
}
