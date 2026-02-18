using WA.ProjectA.SecurityInterface;

namespace WA.ProjectA.SQL
{
	public class MemberService : IAuth
	{
		public bool IsValid(string username, string password)
		{
			//連結到SQL SERVER判斷帳密正確性
			return (username == "allen");//測試用，若account是allen就回傳正確
		}
	}
}
