namespace _11ETL_Practice2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string rawData = "ID:A123,Name:王小明,Math:85;ID:B456,Name:林小華,Math:92;ID:C789,Name:張大同,Math:null";
			
			var studentList = rawData.Split(';')
				.Select(s => s.Split(','))
				.Select(f => new {
					id = f[0].Split(':')[1],
					name = f[1].Split(':')[1],
					mathStr = f[2].Split(':')[1]
				})
				.Where(x => int.TryParse(x.mathStr, out _)) // 先過濾掉不能轉數字的
				.Select(x => new Student(x.id, x.name, int.Parse(x.mathStr)))
				.Where(s => s.Math >= 0 && s.Math <= 100) // 再次過濾合理分數
				.ToList();

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
