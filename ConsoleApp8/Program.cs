namespace ConsoleApp8
{
	/*
     * 【C# 比較介面學習筆記】
     * * 1. IComparable<T> (內在性格)
     * - 位置：實作在資料類別 (Member) 本身內部。
     * - 用途：定義「預設」排序規則。
     * - 呼叫：Array.Sort(items) -> 自動找內部的 CompareTo。
     * * 2. IComparer<T> (外部裁判)
     * - 位置：實作在獨立的類別中 (如 SortByHeight)。
     * - 用途：定義「多種、特殊」排序規則。
     * - 呼叫：Array.Sort(items, new Comparer()) -> 強制聽裁判的。
     * * 3. 優先權順序：
     * 當兩者並存時，如果有傳入「外部裁判」，則優先權最高。
     * 如果沒傳入裁判，才去找「內在性格」。
     */

	/*
	 * 【進階筆記：為什麼要把 IComparer 藏在類別裡？】
	 * * 1. 為了「好找」(Discoverability)：
	 * 寫在外面，同事要通靈才知道類別名稱；
	 * 寫在裡面透過 static 屬性曝露，同事打 Member. 就會看到選單。
	 * * 2. 為了「封裝」(Encapsulation)：
	 * 實作類別設為 private，代表「這是我家私人的裁判，外人別管怎麼做的」。
	 * * 3. 呼叫方式的改變：
	 * 外部寫法：Array.Sort(items, new SortByHeightDESC()); 
	 * 內部寫法：Array.Sort(items, Member.按身高遞減); // 讀起來更像白話文
	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			Member[] items = new Member[]
			{
				new Member { Name = "Alice", Height = 165, DateOfBirth = new DateTime(1990, 1, 1) },
				new Member { Name = "Bob", Height = 180, DateOfBirth = new DateTime(1985, 5, 15) },
				new Member { Name = "Charlie", Height = 175, DateOfBirth = new DateTime(1992, 10, 30) }
			};

			IComparer<Member> comparer = Member.按身高遞減;

			Array.Sort(items, comparer);
			foreach (var item in items)
			{
				Console.WriteLine(item);
			}

			Array.Sort(items);
			foreach (var item in items)
			{
				Console.WriteLine(item);
			}
		}
	}

	//// --- 外部裁判 1：專門處理「身高遞減」的工具人 ---
	//class SortByHeightDESC : IComparer<Member>
	//{
	//	// 實作 IComparer 介面的方法 (不需要動到 Member 類別本身)
	//	public int Compare(Member? x, Member? y)
	//	{
	//		if (x == null || y == null) return 0;
	//		// 邏輯：y 比 x (達成遞減)
	//		return y.Height.CompareTo(x.Height);
	//	}
	//}

	//// --- 外部裁判 2：專門處理「身高遞增」的工具人 ---
	//class SortByHeightASC : IComparer<Member>
	//{
	//	public int Compare(Member? x, Member? y)
	//	{
	//		return x.Height.CompareTo(y.Height);
	//	}
	//}


	class Member : IComparable<Member>
	{
		public static IComparer<Member> 按身高排序
		{
			get {
				return new SortByHeight();
			}
		}
		public static IComparer<Member> 按身高遞減 => new SortByHeightDESC();
		public string Name { get; set; }
		public int Height { get; set; }
		public DateTime DateOfBirth { get; set; }

		public int CompareTo(Member? other)
		{
			if (other == null) return 1; // null 通常排在最後面
			//為何身高能直接CompareTo？因為int實作了IComparable<int>，所以可以直接呼叫CompareTo方法。
			//return this.Height.CompareTo(other?.Height ?? 0);

			//遞減排序方法
			//return -1 * this.Height.CompareTo(other?.Height ?? 0);
			return other.Height.CompareTo(this?.Height ?? 0);

			//return this.DateOfBirth.CompareTo(other?.DateOfBirth ?? DateTime.MinValue);

			//Member x = this;
			//Member y = other;

			//if (x.Height > y.Height) return 1;
			//if (x.Height < y.Height) return -1;
			//return 0;
		}

		public override string ToString()
		{
			return $"名字: {Name,8}, 身高: {Height,4}, 生日: {DateOfBirth:yyyy/MM/dd}";
		}

		private class SortByHeight : IComparer<Member>
		{
			// 實作 IComparer 介面的方法 (不需要動到 Member 類別本身)
			public int Compare(Member? x, Member? y)
			{
				return x.Height.CompareTo(y.Height);
			}
		}
		private class SortByHeightDESC : IComparer<Member>
		{
			// 實作 IComparer 介面的方法 (不需要動到 Member 類別本身)
			public int Compare(Member? x, Member? y)
			{
				if (x == null || y == null) return 0;
				// 邏輯：y 比 x (達成遞減)
				return y.Height.CompareTo(x.Height);
			}
		}
	}
}
