namespace inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Engineer allen = new Engineer { Name = "Allen", BaseSalary = 80000, OvertimeHours = 10 };
			//Console.WriteLine(allen.CalculateSalary());
			Sales annie = new Sales { Name = "Annie", BaseSalary = 30000, Bonus = 5000 };
			//Console.WriteLine(annie.CalculateSalary());
			Manager charlie = new Manager { Name = "Charlie", BaseSalary = 60000 };
			//Console.WriteLine(charlie.CalculateSalary());
			Employee[] employees = {
				allen,
				annie,
				charlie,
				new Engineer { Name = "Eddie", BaseSalary = 75000, },
			};

			foreach (Employee e in employees)
			{
				//int salary = e.CalculateSalary();
				//Console.WriteLine($"Name: {e.Name}, Salary: {e.CalculateSalary()}");
				Console.WriteLine(e);
			}
		}
	}

	public class Employee
	{
		public string Name { get; set; }
		public bool Gender { get; set; }
		public string BadgeNumber { get; set; }
		public int BaseSalary { get; set; }

		public virtual int CalculateSalary()
		{
			return BaseSalary;
		}

		
	}

	public class  Engineer : Employee
	{
		public int OvertimeHours { get; set; }
		public override int CalculateSalary()
		{
			return BaseSalary + OvertimeHours * 500;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Salary: {CalculateSalary()}";
		}
	}

	public class Sales : Employee
	{
		public int Bonus { get; set; }
		public override int CalculateSalary()
		{
			return BaseSalary + Bonus;
		}

	}
	public class Manager : Employee
	{

	}
}
