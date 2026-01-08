namespace _00._000IsBalanced
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		bool IsBalanced(string s)
		{
			Stack<char> stack = new Stack<char>();
			foreach (char c in s)
			{
				if (c == '(' || c == '[' || c == '{')
				{
					stack.Push(c);
				}
				else if (c == ')' || c == ']' || c == '}')
				{
					if (stack.Count == 0) return false;
					char top = stack.Pop();
					if ((c == ')' && top != '(') ||
						(c == ']' && top != '[') ||
						(c == '}' && top != '{')) return false;
				}
			}
			return stack.Count == 0;
		}
	}
}
