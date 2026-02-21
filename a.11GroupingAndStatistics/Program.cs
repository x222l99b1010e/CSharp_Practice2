namespace _11GroupingAndStatistics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. 模擬 1000 筆資料
			var random = new Random();
			string[] regions = { "台北", "台中", "高雄", "花蓮" };
			var students = Enumerable.Range(1, 1000).Select(i => new ExamData
			{
				Region = regions[random.Next(regions.Length)],
				Subject = "數學",
				Score = random.Next(0, 101) // 隨機 0~100 分
			}).ToList();

			// 2. LINQ 進階篩選與統計
			var statistics = students
				.GroupBy(s => s.Region) // 按考區分組
				.Select(g => new
				{
					RegionName = g.Key,
					AverageScore = g.Average(s => s.Score),
					// 計算不及格比例：(不及格人數 / 總人數) * 100
					FailRate = (double)g.Count(s => s.Score < 60) / g.Count() * 100
				})
				.OrderByDescending(res => res.AverageScore) // 按平均分數由高到低排列
				.ToList();

			// 3. 輸出結果
			Console.WriteLine($"{"考區",-6} | {"平均分數",-8} | {"不及格比例",-10}");
			Console.WriteLine("------------------------------------------");
			foreach (var item in statistics)
			{
				Console.WriteLine($"{item.RegionName,-6} | {item.AverageScore,10:F2} | {item.FailRate,12:F2}%");
			}
		}
	}
	public class ExamData
	{
		public string Region { get; set; }
		public string Subject { get; set; }
		public int Score { get; set; }
	}
}
