namespace AK.Global.Utilities
{
#pragma warning disable 1591
	public class StringHelper
	{
		/// <summary>
		/// 擷取字串左側指定長度
		/// </summary>
		/// <param name="value">原始字串</param>
		/// <param name="length">擷取長度</param>
		/// <returns>擷取後的子字串；若輸入為空則回傳空字串。</returns>
		public static string Truncate(string value, int length)
		{
			if (string.IsNullOrWhiteSpace(value)) return string.Empty;
			if (length <= 0) return string.Empty;
			if (value.Length <= length) return value;

			return value.Substring(0, length);
		}
	}
#pragma warning restore 1591
}
