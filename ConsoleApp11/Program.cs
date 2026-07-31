using System;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

// 1.我應該先發送get請求獲取json物件
// 接著解析json格式(split 拆解提取內容)
//接著判斷年齡>50? <50?

class MainClass
{
	// 非同步 async、await =>Task回傳
	static async Task Main()
	{
		HttpClient client = new HttpClient();
		try
		{
			//發送請求獲取json物件
			string s = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/age-counting");
			//解析json
			//反序列化
			var jsonObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(s);
			string dataContent = jsonObj["data"];
			//處理字串
			int jsonAge = 0;
			string[] parts = dataContent.Split(',');

			//接著遍歷所有切片獲取有age字眼的內容
			foreach (var part in parts)
			{
				if (part.Contains("age="))
				{
					//取得age右邊的年紀
					//以=切開 並取index = 1,去除空白
					string ageValueStr = part.Split('=')[1].Trim();
					if (int.TryParse(ageValueStr, out int age))
					{
						if (age >= 50)
						{
							jsonAge++;
						}
					}
				}
			}
			Console.WriteLine(s);
		}
		catch (Exception e)
		{
			Console.WriteLine("解析發生錯誤" + e.Message);
		}
	}
}