namespace interfacePractice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}

	public interface IMember
	{
		// interface 不能宣告 field
		//public string Name;

		// interface 只能宣告 method, property, event, indexer
		// 不能宣告建構函數, 不能宣告 static method, 不能宣告 instance method

		//method可以多載
		//不必寫public 不能寫 private, interface裡面的方法預設就是public
		//public int Add(int a, int b) { } 
		// interface裡面的方法不能有實作
		// 不能有大括號，只能接分號，類似抽象方法的宣告方式
		int Add(int a, int b);
		int Add(int a);

		int Height { get; set; }
	}
}
