using WA.ProjectA.SecurityInterface;

namespace ConsoleApp9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string account = "allen";
			string password = "123";
			account = "simon";
			password = "123456";
			
			Login(account, password);
		}

		static void Login(string account, string password)
		{
			IAuth auth = GetAuthProvider();
			if (auth.IsValid(account, password))
			{
				Console.WriteLine("登入成功");
			}
			else
			{
				Console.WriteLine("登入失敗，帳密錯誤") ;
			}
		}

		private static IAuth GetAuthProvider()
		{
			//執行時，會在bin\Debug\net10.0底下找dll
			//BaseDirectory會回傳目前執行檔所在的資料夾路徑(是找xxxx.exe所在資料夾再找WA.ProjectA.SQL.dll的檔案)
			string dllName = Path.Combine(AppContext.BaseDirectory, "WA.ProjectA.SQL.dll");
			string className = "WA.ProjectA.SQL.MemberService";
			dllName = Path.Combine(AppContext.BaseDirectory, "FUEN43.ProjectA.Security.dll");
			className = "FUEN43.ProjectA.Security.AdvanceMemberService";

			var assembly = System.Reflection.Assembly.LoadFrom(dllName);
			object obj = assembly.CreateInstance(className);
			return (IAuth)obj;
		}
	}

	//class MemberService_Ora
	//{
	//	public bool IsValid(string account, string password)
	//	{
	//		//連結到Oracle
	//		//判斷帳密正確性，有開通且非黑名單
	//		return true;
	//	}
	//}
	//class MemberService_SQL
	//{
	//	public bool IsValid(string account, string password)
	//	{
	//		//連結到SQL SERVER
	//		//判斷帳密正確性，有開通且非黑名單
	//		return true;
	//	}
	//}


}
