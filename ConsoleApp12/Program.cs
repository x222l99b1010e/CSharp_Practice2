using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ConsoleApp12
{
	//我要先獲取json物件
	//並將json物件反序列化
	//接著清洗資料
	//將題目指定的NA,-,"",內容清洗掉
	class MainClass
	{
		static async Task Main()
		{
			using (HttpClient client = new HttpClient())
			{
				try
				{
					//JSON來源
					string s = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/json-cleaning");
					//將字串解析為JToken
					JToken data = JToken.Parse(s);
					//執行清理動作
					CleanJson(data);
					//序列化回字串並輸出
					Console.WriteLine(data.ToString(Formatting.None));
				}
				catch (Exception ex)
				{

				}
			}
		}

		//接著建立方法 清洗json內容
		static void CleanJson(JToken token)
		{
			if (token.Type == JTokenType.Object)
			{
				JObject obj = (JObject)token;
				//找出要清洗資料
				var propertiesToClean = obj.Properties()
				.Where(p => IsEmptyValue(p.Value))
				.Select(p => p.Name)
				.ToList();

				foreach (var name in propertiesToClean)
				{
					obj.Remove(name);
				}
				// 遞迴處理剩下的內容
				foreach (var prop in obj.Properties())
				{
					CleanJson(prop.Value);
				}
			}
			else if (token.Type == JTokenType.Array)
			{
				JArray array = (JArray)token;
				//刪除
				for (int i = array.Count - 1; i >= 0; i--)
				{
					if (IsEmptyValue(array[i]))
					{
						array.RemoveAt(i);
					}
					else
					{
						CleanJson(array[i]);
					}
				}
			}
		}
		//我要先抽離並建立方法判斷是否為NA,-,或是空字串?
		static bool IsEmptyValue(JToken value)
		{
			if (value.Type == JTokenType.String)
			{
				string s = value.ToString();
				return s == "N/A" || s == "-" || s == "";
			}
			return false;
		}
	}
}
