namespace WA.ProjectA.SecurityInterface
{
	public interface IAuth
	{
		bool IsValid(string username, string password);
	}
}
