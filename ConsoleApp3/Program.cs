namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			try 
			{
				int sum = Add(3, 99);
			}
			catch (Exception ex) 
			{
				Console.WriteLine($"例外發生: {ex.Message}");
			}
			Console.WriteLine("Hello, World!");
		}
		static int Add(int n1, int n2)
		{
			if (n1 % 2 == 0)
			{
				throw new ArgumentException("相加第一個數字不能是偶數");
			}

			int sum = n1 + n2;
			if (sum > 100)
			{
				throw new ArgumentOutOfRangeException("相加的結果不能大於100");
			}
			return sum;
		}
	}
}
