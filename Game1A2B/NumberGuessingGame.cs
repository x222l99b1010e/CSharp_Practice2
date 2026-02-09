using System;
using System.Collections.Generic;
using System.Linq;

namespace Game1A2B
{
	internal class NumberGuessingGame
	{
		private string _answer;
		/// <summary>
		/// 開一個新遊戲，重設新答案
		/// </summary>
		public void NewGame()
		{
			var random = new Random();
			//取得四個不重複數字，使用HashSet確保不重複
			var hs = new HashSet<int>();
			do 
			{
				int number = random.Next(0, 10);
				hs.Add(number);
			}
			while (hs.Count < 4);
			_answer = string.Empty;
			foreach (int num in hs)//將HashSet中的數字轉成字串，組成答案
			{
				_answer += num.ToString();
			}

		}
		/// <summary>
		/// 回傳輸入值是否合理
		/// </summary>
		/// <param name="guessValue"></param>
		/// <returns></returns>
		public ValidationResult ValidateGuess(string guessValue)
		{
			// 驗證輸入是否合法
			// 輸入不能為空，必須是4位數字，且數字不能重複
			if (string.IsNullOrWhiteSpace(guessValue))
			{
				return ValidationResult.Failure("輸入不能為空");
			}
			// 輸入必須是4位數字
			if (guessValue.Length != 4)
			{
				return ValidationResult.Failure("輸入必須是4位數字");
			}
			// 輸入必須是數字
			if (!int.TryParse(guessValue, out int guessValue1))
			{
				return ValidationResult.Failure("輸入必須是數字");
			}
			// 輸入的數字不能重複
			if (guessValue.Distinct().Count() != 4)
			{
				return ValidationResult.Failure("輸入的數字不能重複");
			}

			//HashSet<char> chars = new HashSet<char>();
			//foreach (char c in guessValue)
			//{
			//	chars.Add(c);
			//}
			//if (chars.Count != 4) 
			//{
			//	return ValidationResult.Failure("輸入的數字不能重複");
			//}

			//回傳成功結果
			return ValidationResult.Success();
		}
		/// <summary>
		/// 與答案對比為幾A幾B
		/// </summary>
		/// <param name="guessValue"></param>
		public GameResult CompareGuessValue(string guessValue)
		{
			GameResult result = new GameResult { CountA = 0, CountB = 0};
			// 比對輸入與答案，回傳結果
			for (int i = 0; i < guessValue.Length; i++)
			{
				if (guessValue[i] == _answer[i])
				{
					//數字和位置對，A加1
					result.CountA++;
				}
				else
				{
					if (_answer.Contains(guessValue[i]))
						result.CountB++;
				}
			}
			return result;
		}

		public string GetAnswer()
		{
			return _answer;
		}

	}
}
