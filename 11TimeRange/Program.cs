namespace _11TimeRange
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. 現有的考試時間表
			var existingExams = new List<ExamPeriod>
			{
				new ExamPeriod("國文", new DateTime(2026, 2, 5, 9, 0, 0), new DateTime(2026, 2, 5, 10, 30, 0)),
				new ExamPeriod("英文", new DateTime(2026, 2, 5, 13, 0, 0), new DateTime(2026, 2, 5, 14, 40, 0))
			};

			// 2. 準備排入的新考試
			var newExam = new ExamPeriod("數學", new DateTime(2026, 2, 5, 10, 0, 0), new DateTime(2026, 2, 5, 11, 30, 0));

			// 3. 檢查是否有衝突
			bool hasConflict = existingExams.Any(existing => IsOverlapping(existing, newExam));

			if (hasConflict)
			{
				Console.WriteLine($"[警告]：{newExam.Subject} 與現有考試時間衝突！");
			}
			else
			{
				Console.WriteLine($"[成功]：{newExam.Subject} 安排成功。");
			}
		}

		// 核心邏輯：判斷重疊
		public static bool IsOverlapping(ExamPeriod a, ExamPeriod b)
		{
			//確保考試之間至少有 20 分鐘的休息時間
			int bufferMinutes = 20;
			// 公式：A開始 < B結束 AND B開始 < A結束
			return a.StartTime < b.EndTime.AddMinutes(bufferMinutes) &&
		   b.StartTime < a.EndTime.AddMinutes(bufferMinutes);
		}
	}
	public class ExamPeriod
	{
		public string Subject { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }

		public ExamPeriod(string subject, DateTime start, DateTime end)
		{
			Subject = subject;
			StartTime = start;
			EndTime = end;
		}
	}
}
