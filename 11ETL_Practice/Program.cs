namespace _11ETL_Practice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string rawData = "ID:A123,Name:王小明,Math:85;ID:B456,Name:林小華,Math:92;ID:C789,Name:張大同,Math:null";
			List<Student> studentList = new List<Student>();

			// 1. 先用分號拆分出每個學生的資料，結果 => 
			// ID:A123,Name:王小明,Math:85
			// ID:B456,Name:林小華,Math:92
			// ID:C789,Name:張大同,Math:null
			string[] rawStudents = rawData.Split(';');
			

			foreach (var sData in rawStudents)
			{
				// 2. 再用逗號拆分出每個欄位的資料，結果 =>
				// ID:A123
				// Name:王小明
				// Math:85
				string[] fields = sData.Split(',');

				// 用冒號拆分出欄位名稱與欄位值，並建立物件，結果 =>
				// fields[0] => ID:A123 
				// fields[1] => Name:王小明
				// fields[2] => Math:	85
				// [0][1] => A123
				// [1][1] => 王小明
				// [2][1] => 85
				string id = fields[0].Split(':')[1];
				string name = fields[1].Split(':')[1];
				string mathStr = fields[2].Split(':')[1];

				// 3: 排除 null 或分數不合理的資料 (資料清洗)
				// 使用 int.TryParse 確保安全轉換，如果是 "null" 或非數字會回傳 false
				if (int.TryParse(mathStr, out int mathScore))
				{
					if (mathScore >= 0 && mathScore <= 100)
					{
						studentList.Add(new Student(id, name, mathScore));
					}
				}

				// 4: 輸出最高分的學生
				var topStudent = studentList.OrderByDescending(s => s.Math).FirstOrDefault();

				if (topStudent != null)
				{
					Console.WriteLine($"最高分學生是：{topStudent.Name}, 分數：{topStudent.Math}");
				}
			}
		}

		class Student
		{
			public string ID { get; set; }
			public string Name { get; set; }
			public int Math { get; set; }

			public Student(string id, string name, int math)
			{
				ID = id;
				Name = name;
				Math = math;
			}
		}
	}
}
