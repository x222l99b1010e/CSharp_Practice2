namespace _00._000PrimeFactorization
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			Program p = new Program();
			p.PrimeFactorization(1567);
		}

		void PrimeFactorization(int num)
		{
			if (num < 2)
			{
				Console.WriteLine($"{num} 沒有質因數分解。");
				return;
			}
			Console.Write($"{num}=");//不換行
			var factors = new Dictionary<int, int>();//建立dictionary 儲存因數
			int divisor = 2;//初始除數

			while (num >= divisor * divisor)//如果是1  要用>1 否則有無窮迴圈
			{
				if (num % divisor == 0)
				{
					if (!factors.ContainsKey(divisor)) factors[divisor] = 0;//「初始化」
					//在 C# 的 Dictionary 中，如果你直接對一個「還不存在的 Key」進行加法運算（例如 factors[2]++），程式會報錯（KeyNotFoundException）。
					//!factors.ContainsKey(divisor)：檢查字典裡是否還沒有這個除數。
					//factors[divisor] = 0：如果還沒有，就先在字典裡建立這個位置，並把次數設定為 0。
					//「如果這是我第一次遇到這個因數，先幫我留個位置，次數從 0 開始算。」
					factors[divisor]++;
					num /= divisor;
				}
				else
				{
					divisor++;
				}
			}
			//---這裡是要新增的關鍵---
			//算到平方根一定要加以下
			if (num > 1) // 檢查迴圈跑完後，是否還有剩下的質因數
			{
				// 如果字典裡還沒有這個剩下的數字（通常是最後一個大質數）
				if (!factors.ContainsKey(num))
					factors[num] = 0; // 在字典裡為這個數字開一個位置，次數先設為 0

				factors[num]++; // 把這個因數的出現次數加 1
			}

			// 格式化輸出
			var parts = new List<string>();
			foreach (var item in factors)
			{
				if (item.Value > 1)
					parts.Add($"{item.Key}^{item.Value}");//>1  次方
				else
					parts.Add($"{item.Key}");//1次方
			}
			Console.WriteLine(string.Join("*", parts));
		}
	}
}
