namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");	
			try
			{
				DoB();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("----- Inner Exception -----");
				Console.WriteLine(ex.InnerException?.Message);
			}
		}

		static void DoB()
		{
			int value = -5;
			try 
			{
				DoA(value);
			}
			catch (Exception ex)
			{
				throw new Exception("DoA 發生錯誤", ex);
			}
		}

		static void DoA(int num)
		{
			if (num < 0)
			{
				throw new Exception("num 不能是負數");
			}
		}
	}
}
