using a.OOP.RefactorCode;
using NUnit.Framework.Legacy;

namespace a.OOP.Refactor.TestProject1
{
	public class UtilityTests
	{
		//[SetUp]
		//public void Setup()
		//{
		//}

		[Test]
		public void IsTaiwanStockTradingHours_假日_ReturnFalse()
		{
			var sut = new Utility();//system under test,測試的對象
			var date = new DateTime(2025, 7, 5); // 2025/7/5 是星期六

			bool actual = sut.IsTaiwanStockTradingHours(date);//叫用方法

			// Assert (斷言) - 使用 NUnit 4 語法
			Assert.That(actual, Is.False);
		}
		[TestCase("2025/7/4 8:59:59")]
		[TestCase("2025/7/4 13:30:01")]
		public void IsTaiwanStockTradingHours_平日非營業時間_ReturnFalse(DateTime date)
		{
			var sut = new Utility();//system under test,測試的對象
			//var date = new DateTime(2025, 7, 5); // 2025/7/5 是星期六

			bool actual = sut.IsTaiwanStockTradingHours(date);//叫用方法

			// Assert (斷言) - 使用 NUnit 4 語法
			Assert.That(actual, Is.False);
		}
		[TestCase("2025/7/4 09:00:00")]
		[TestCase("2025/7/4 13:30:00")]
		[TestCase("2025/7/7 09:00:00")]
		[TestCase("2025/7/7 13:30:00")]
		[TestCase("2025/7/8 09:00:00")]
		[TestCase("2025/7/8 13:30:00")]
		[TestCase("2025/7/9 09:00:00")]
		[TestCase("2025/7/9 13:30:00")]
		[TestCase("2025/7/10 09:00:00")]
		[TestCase("2025/7/10 13:30:00")]
		public void IsTaiwanStockTradingHours_平日營業時間_ReturnFalse(DateTime date)
		{
			var sut = new Utility();//system under test,測試的對象
			//var date = new DateTime(2025, 7, 5); // 2025/7/5 是星期六

			bool actual = sut.IsTaiwanStockTradingHours(date);//叫用方法

			// Assert (斷言) - 使用 NUnit 4 語法
			Assert.That(actual, Is.True);
		}
	}
}
