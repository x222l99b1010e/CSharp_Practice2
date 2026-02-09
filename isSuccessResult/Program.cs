namespace isSuccessResult
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result = new Result {
				IsSuccess = true,
			};
			var result2 = new Result
			{
				IsSuccess = false,
				ErrorMessage = "xxx"
			};
			var result3 = new Result
			{
				IsSuccess = true,
				ErrorMessage = "xxx"
			};

			var result4 = Result.Success;
			var result5 = Result.Fail("xxx");
		}
	}

	public class Result
	{
		public bool IsSuccess {  get; set; }
		public bool IsFail => !IsSuccess;
		public string ErrorMessage { get; set; }
		public static Result Success() { 		
			return new Result { IsSuccess = true }; 
		}

		public static Result Fail(string errorMessage)
		{
			return new Result { IsSuccess = false, ErrorMessage = errorMessage };
		}
	}

	//Result1 的 Success 前面沒有 static。這會導致一個很尷尬的情況：
	//你要呼叫 Success() 之前，必須先有一個 Result1 的實體。
	//用法變成： var r = new Result1().Success(); （這在邏輯上很奇怪，為了生出一個成功的結果，得先手動 new 一個）。
	public class Result1
	{
		public bool IsSuccess { get; set; }
		public bool IsFail => !IsSuccess;// 一個等號再接一個大於，讀做 'goes to'，是比較簡潔的語法
		public string ErrorMessage { get; set; }

		public Result1 Success() => new Result1
		{
			IsSuccess = true
		};

		public Result1 Fail(string errorMessage) => new Result1
		{ 
			IsSuccess = false, ErrorMessage = errorMessage };
		}
}
