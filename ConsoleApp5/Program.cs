namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			int result = Calculate(OptionType.Add, 10, 5);

			string fullName = @"d:\temp\a.txt";
			CopyFile(fullName, @"d:\temp", FileOption.覆蓋);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="option">1,2,3,4分別表示加減乘除</param>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns></returns>
		static int Calculate(OptionType option, int n1, int n2){

			//if (option == OptionType.Add) return n1 + n2;
			//else if (option == OptionType.Subtract) return n1 - n2;
			//else if (option == OptionType.Multiply) return n1 * n2;
			//else if (option == OptionType.Divide)
			//{
			//	if (n2 != 0)
			//		return n1 / n2;
			//	else
			//		return 0; // 防止除以 0
			//}
			//else
			//	return 0;

			switch (option)
			{
				case OptionType.Add:
					return n1 + n2;
				case OptionType.Subtract:
					return n1 - n2;
				case OptionType.Multiply:
					return n1 * n2;
				case OptionType.Divide:
					return n2 != 0 ? n1 / n2 : 0; // 防止除以 0
				default:
					return 0;
			}
		}

		static void CopyFile(string fullName, string destPath, FileOption option)
		{ }
	}
	enum OptionType
	{
		Add,
		Subtract,
		Multiply,
		Divide,
		//取餘數,
	}

	enum FileOption
	{
		覆蓋,
		不做動作,
		串接在最後方
	}
}
