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
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
