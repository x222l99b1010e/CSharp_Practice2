using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; // 使用 LINQ 必須引用
using Newtonsoft.Json;

class MainClass
{
	static async Task Main()
	{
		HttpClient client = new HttpClient();
		try
		{
			// 1. 發送 GET 請求
			string s = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/age-counting");

			// 2. 解析 JSON
			var jsonObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(s);
			string dataContent = jsonObj["data"];

			// 3. 使用 LINQ 簡化判斷邏輯
			// __define-pcb__ : 使用 LINQ 一次完成 Split, 過濾與轉換
			int varPcb = dataContent.Split(',')
						  .Where(part => part.Contains("age="))           // 只取包含 age 的片段
						  .Select(part => int.Parse(part.Split('=')[1])) // 直接轉為整數
						  .Count(age => age >= 50);                       // 計算大於等於 50 的數量

			// 輸出最終結果
			Console.WriteLine(varPcb);

		}
		catch (Exception e)
		{
			Console.WriteLine("解析發生錯誤: " + e.Message);
		}
	}
}