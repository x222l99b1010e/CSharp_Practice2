namespace _11CalculatingScore
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 建立學生物件，模擬多筆資料
			List<Student> students = new List<Student>
			{
				new Student("張三", 85, 90),
				new Student("李四", 90, 85), // 總分一樣 175，但數學李四較低
                new Student("王五", 92, 95),
				new Student("趙六", 90, 90)  // 總分 180
			};
			//排序學生資料
			var sortedStudents = students
				.OrderByDescending(s => s.TotalScore) // 第一順位：總分
				.ThenByDescending(s => s.MathScore)  // 第二順位：數學
				.ThenByDescending(s => s.ChineseScore) // 第三順位：國文
				.ToList();

			Console.WriteLine($"{"姓名",-5} | {"國文",-3} | {"數學",-3} | {"總分",-3} | {"平均",-5} | {"級分",-2}|");
			Console.WriteLine("------------------------------------------------------------");

			foreach (var s in sortedStudents)
			{
				// 直接調用物件內的屬性，Main 不負責計算級分邏輯
				Console.WriteLine($"{s.Name,-5} | {s.ChineseScore,5} | {s.MathScore,5} | {s.TotalScore,5} | {s.AverageScore,7:F2} | {s.GradeLevel,3} | ");
			}
		}
	}

	class Student
	{
		public string Name { get; private set; }
		public int ChineseScore { get; private set; }
		public int MathScore { get; private set; }

		// 總分與平均分數屬性，唯讀
		public int TotalScore => ChineseScore + MathScore;
		public double AverageScore => Math.Round(TotalScore / (double)2,2);
		public string GradeLevel
		{
			get
			{
				if (TotalScore >= 180) return "A";
				if (TotalScore >= 150) return "B";
				return "C";
			}
		}

		public Student(string name, int chinese, int math)
		{
			if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("姓名不可為空");
			if (chinese < 0 || chinese > 100 || math < 0 || math > 100)
				throw new ArgumentOutOfRangeException("分數必須在 0-100 之間");

			Name = name;
			ChineseScore = chinese;
			MathScore = math;
		}

		
	}
}
