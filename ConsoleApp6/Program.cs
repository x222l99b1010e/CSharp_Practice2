namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			#region 取得日期的不同寫法
			DateTime dateTime = new DateTime(2024, 1, 1);
			//Console.WriteLine(dateTime);

			DateTime dt1 = DateTime.Now;
			Console.WriteLine(dt1);
			DateTime dt2 = DateTime.Today;
			Console.WriteLine(dt2);
			DateTime dt3 = new DateTime(2015,6,13);
			Console.WriteLine(dt3);
			dt3 = new DateTime(2015, 6, 13, 10, 30, 0);
			Console.WriteLine(dt3);
			dt3 = new DateTime(2015, 6, 13, 10, 30, 23, 998);//包含毫秒
			Console.WriteLine(dt3);

			DateTime dt4 = DateTime.Parse("2025/1/4");
			Console.WriteLine(dt4);
			dt4 = DateTime.Parse("2025/1/4 13:35:22");
			Console.WriteLine(dt4);
			#endregion

			#region 取得常用的屬性值
			dt1 = new DateTime(2025, 11, 5, 13, 20, 45, 998);
			int year = dt1.Year;
			Console.WriteLine(year);
			int month = dt1.Month;
			Console.WriteLine(month);
			int day = dt1.Day;
			Console.WriteLine(day);
			int hour = dt1.Hour;
			Console.WriteLine(hour);
			int minute = dt1.Minute;
			Console.WriteLine(minute);
			int second = dt1.Second;
			Console.WriteLine(second);
			int millisecond = dt1.Millisecond;
			Console.WriteLine(millisecond);
			//javascript的月份是0~11!!!!!!!!!

			bool isLeapYear = DateTime.IsLeapYear(year);//判斷是否為閏年
			Console.WriteLine(isLeapYear);
			int days = DateTime.DaysInMonth(year,month);//取得某年某月的天數,通常用來算2月有幾天
			Console.WriteLine(days);
			days = DateTime.DaysInMonth(2024, 2);
			Console.WriteLine(days);
			dt1 = DateTime.Now;
			dt2 = dt1.Date;//取得日期部分,時間部分會是0點0分0秒,去除時間的意思
			#endregion

			#region 常用方法
			Console.WriteLine("--------------------------------------");
			dt1 = DateTime.Now;
			dt2 = dt1.AddDays(1);//明天的這個時候
			Console.WriteLine(dt2);
			dt3 = dt1.AddMonths(1);//下個月的這個時候
			Console.WriteLine(dt3);
			dt4 = dt1.AddYears(1);//明年的這個時候
			Console.WriteLine(dt4);
			DateTime dt5 = dt1.AddHours(1);//一小時後
			Console.WriteLine(dt5);
			DateTime dt6 = dt1.AddMinutes(30);//30分鐘後
			Console.WriteLine(dt6);
			DateTime dt7 = dt1.AddSeconds(120);//120秒後
			Console.WriteLine(dt7);
			Console.WriteLine("--------------------------------------");
			dt1 = new DateTime(2025, 1, 31, 13, 20, 45);
			dt2 = dt1.AddMonths(1);//2025/2/28
			Console.WriteLine(dt2);
			dt1 = new DateTime(2025, 2, 1, 13, 20, 45);
			dt2 = dt1.AddMonths(1);//2025/3/1
			Console.WriteLine(dt2);
			dt4 = dt1.AddMonths(-1);//2025/1/1
			Console.WriteLine(dt4);
			Console.WriteLine("--------------------------------------");
			//如果要取得下個月的今天
			dt1 = new DateTime(2025, 12, 31, 13, 20, 45); ;
			//dt2 = new DateTime(dt1.Year, dt1.Month + 1, dt1.Day);//會出錯,因為月份超過12月
			//Console.WriteLine(dt2);
			//dt2 = new DateTime(dt1.Year, dt1.Month, dt1.Day + 1);//會出錯,因為日期超過該月的天數
			//Console.WriteLine(dt2);
			dt1 = new DateTime(2024, 2, 29, 13, 20, 45);
			//dt2 = new DateTime(dt1.Year + 1, dt1.Month, dt1.Day);//會出錯,因為2025不是閏年
			//Console.WriteLine(dt2);
			Console.WriteLine("--------------------------------------");
			dt1 = new DateTime(2025, 1, 30, 13, 20, 45);
			dt2 = dt1.AddMonths(1);
			Console.WriteLine(dt2);
			dt3 = dt1.AddDays(1);
			Console.WriteLine(dt3);
			Console.WriteLine("--------------------------------------");
			dt1 = new DateTime(2025,3,30,13,20,45);
			dt2 = dt1.AddMonths(1);
			Console.WriteLine(dt2);
			Console.WriteLine("--------------------------------------");
			dt1 = new DateTime(2024, 2, 29, 13, 20, 45);
			dt2 = dt1.AddYears(1);
			dt3 = dt1.AddMonths(1);//2024/3/29
			Console.WriteLine(dt2);
			Console.WriteLine(dt3);


			#endregion


		}
	}
}
