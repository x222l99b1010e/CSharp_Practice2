namespace ConsoleApp7
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Console.WriteLine("Hello, World!");
			#region 日期只能相減,無法做+ * / 等運算
			DateOnly dt100 = new DateOnly(2025, 1, 31);
			DateTime dt1 = new DateTime(2025, 6, 20,8,00,00);
			DateTime dt2 = new DateTime(2025, 6, 21,10,00,00);
			TimeSpan ts1 = dt2 - dt1;
			Console.WriteLine(ts1.Days);
			Console.WriteLine(ts1.TotalDays);
			Console.WriteLine(ts1.Hours);
			Console.WriteLine(ts1.TotalHours);

			#endregion

		}
	}
}
