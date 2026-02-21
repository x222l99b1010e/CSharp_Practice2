namespace a.OOP.RefactorCode
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
	public static class DateTimeExtensions
	{
		public static bool IsWorkingDay(this DateTime date)
		{
			//int weekday = int.Parse(date.DayOfWeek.ToString("d"));
			//int weekday = (int)date.DayOfWeek;
			//return weekday >= 1 && weekday <= 5;
			return ((int)date.DayOfWeek).IsBetween(1,5);
		}
		public static bool IsBetween(this DateTime date, DateTime start, DateTime end)//判斷時間是否在9:00~13:30
		{
			return (date >= start && date <= end);
		}
		public static bool IsBetween(this int value, int start, int end)//判斷星期幾是否在1~5
		{
			return (value >= start && value <= end);
		}
	}
	public class Utility
	{
		/// <summary>
		/// 判斷是否為台灣股票交易時間，平日上午9點到下午1點半
		/// </summary>
		/// <param name="today"></param>
		/// <returns></returns>
		public bool IsTaiwanStockTradingHours(DateTime today)
			=>	today.IsWorkingDay() &&
				today.IsBetween(today.Date.AddHours(9), today.Date.AddHours(13.5));
		//{
		//	//if (today.IsWorkingDay() == false) return false;
		//	//DateTime start = new DateTime(today.Year, today.Month, today.Day, 9, 0, 0, 0);
		//	//DateTime start = today.Date.AddHours(9);
		//	//DateTime end = new DateTime(today.Year, today.Month, today.Day, 13, 30, 0, 0);
		//	//DateTime end = today.Date.AddHours(13.5);
		//	return today.IsWorkingDay() && 
		//		today.IsBetween(today.Date.AddHours(9), today.Date.AddHours(13.5));
		//}
	}
}
