namespace inheritanceAbstract
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Storage fs = new FileStorage("test.txt");
			fs.Save("Hello World");
			Storage dbs = new DataBaseStorage();
			dbs.Save("Hello World");

			//Storage s = new Storage();
			//s.Save("Hello World");
		}
	}

	abstract class Storage
	{
		//抽象類別不能被實例化，必須由繼承類別實例化  (不能new 抽象類別  只能由繼承類別new出來)
		//不能用{}來實作抽象方法，必須用;來結束
		public abstract void Save(string content);
	}

	class DataBaseStorage : Storage 
	{
		//父類的抽象方法，子類別必須覆寫
		public override void Save(string content)
		{
			//將 content 存到DB
		}
	}

	class FileStorage : Storage
	{
		private readonly string fullName;
		public FileStorage(string fullName)
		{
			this.fullName = fullName;
		}
		public override void Save(string content)
		{
			//todo 將content 存到 fullName
		}
	}
}
