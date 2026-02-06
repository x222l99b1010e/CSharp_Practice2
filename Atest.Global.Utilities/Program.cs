//原本檔名是Atest.AK.Global.Utilities

//這樣很容易噴錯，前面要加入global::

//這樣才會往外尋找AK.Global.Utilities的命名空間

//否則只會停止在這個類別裡面
namespace Atest.Global.Utilities
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "ABCDEFG";
			// 使用「完整限定名稱 (Fully Qualified Name)」呼叫外部類別庫。
			// 注意：若目前命名空間 (Atest.Global.Utilities) 與目標路徑 (AK.Global.Utilities) 
			// 在層級上有重疊或混淆，編譯器會優先由內向外尋找（導致找不到目標）。
			// 在路徑前加上 global:: 可強制編譯器從「根命名空間」開始查找，避免命名空間遮蔽。
			string result = AK.Global.Utilities.StringHelper.Truncate(value, 3);
			Console.WriteLine(result);
		}
	}
}
