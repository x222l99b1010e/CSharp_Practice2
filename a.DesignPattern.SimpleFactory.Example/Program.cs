namespace a.DesignPattern.SimpleFactory.Example
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var name = "Allen Kuo";
			name = "Kuo, Allen";
			UserName result = NameFactory.GetName(name);
			Console.WriteLine($"姓:{result.LastName} 名:{result.FirstName}");
		}
	}
	public static class NameFactory
	{
		//支援Allen Kuo 以及 Kuo, Allen 兩種格式
		public static UserName GetName(string fullName)
		{
			return fullName.Contains(',')//是否含有','
				? new LastNamey在前(fullName)
				: new FirstName在前(fullName);			
		}
	}
	public class  UserName
	{
		public string LastName { get; set; }//姓
		public string FirstName { get; set; }//名
	}

	public class FirstName在前 : UserName
	{
		public FirstName在前(string fullName)//Allen Kuo
		{
			string[] items = fullName.Split(' ');
			FirstName = items[0].Trim();
			LastName = items[1].Trim();
		}
	}
	public class LastNamey在前 : UserName
	{
		public LastNamey在前(string fullName)
		{
			string[] items = fullName.Split(',');
			FirstName = items[1].Trim();
			LastName = items[0].Trim();
		}
	}
}
