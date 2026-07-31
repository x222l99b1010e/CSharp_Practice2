namespace ConsoleApp13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = { 4, 3, 2, 7, 8, 2, 3, 1 };

			Program p = new Program();
			IList<int> missingNumbers = p.FindMissingNumber(input);

			//印出結果
			Console.WriteLine("輸入陣列: [" + string.Join(", ", input) + "]");
			Console.WriteLine("缺失數字: [" + string.Join(", ", missingNumbers) + "]");

			
		}

		public IList<int> FindMissingNumber(int[] nums) 
		{
			// 題目：給定長度為 n 的整數陣列，元素範圍 1 到 n，其中部分數字可能重複或缺失。請回傳所有缺失的數字。輸入陣列可能未排序，可能包含重複。
			// 例如，輸入 [4,3,2,7,8,2,3,1]，輸出 [5,6]，因為 5 和 6 是缺失的數字。
			// 1. 建立一個 HashSet 來存儲出現過的數字
			// 2. 遍歷輸入的數字列表，將每個數字添加到 HashSet 中
			// 3. 建立一個結果列表來存儲缺失的數字
			// 4. 從 1 到 n 遍歷，檢查每個數字是否存在於 HashSet 中，如果不存在，則將其添加到結果列表中
			// 5. 返回結果列表
			int n = nums.Length; // 假設 n 是 numbers 的長度
			HashSet<int> numSet = new HashSet<int>();
			foreach (int num in nums)
			{
				numSet.Add(num); // 將數字添加到 HashSet 中
			}
			// 建立結果列表來存儲缺失的數字
			List<int> res = new List<int>();
			// 從 1 到 n 遍歷，檢查每個數字是否存在於 HashSet 中，如果不存在，則將其添加到結果列表中
			for (int i = 1; i <= n; i++)
			{
				if (!numSet.Contains(i))
				{
					res.Add(i); // 如果 HashSet 中不包含該數字，則將其添加到結果列表中
				}
			}
			return res;
			//時間複雜度：$O(n)$遍歷一次陣列建立 HashSet 需要 $O(n)$。
			//從 1 遍歷到 $n$ 進行查找需要 $O(n)$（HashSet 查找為 $O(1)$）。
			//空間複雜度：$O(n)$最差情況下需要建立一個儲存 $n$ 個元素的 HashSet。
		}

		
	}
} 
