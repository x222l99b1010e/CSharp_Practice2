using WA.ProjectA.SecurityInterface;

namespace FUEN43.ProjectA.Security
{
	public class AdvanceMemberService : IAuth
	{
		public bool IsValid(string username, string password)
		{
			return username == "simon" && password == "123456";
		}
	}
}
