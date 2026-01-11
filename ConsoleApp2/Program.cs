namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //建立一個Random 類別 新實例
            Random random = new Random();
			//產生一個0 ~ Int32.MaxValue 之間的隨機整數
			int rdNum1 = random.Next();
			//產生一個0 ~ 9 之間的隨機整數
			int rdNum2 = random.Next(10);
            //Console.WriteLine(rdNum2);
			//產生一個5 ~ 19 之間的隨機整數
			int rdNum3 = random.Next(5, 20);

            for (int i = 0; i < 9; i++)
            {
				//不要在迴圈裏面建立Random 類別 新實例
				//這樣會導致每次產生的隨機數都一樣
				//因為Random 類別是以系統時間當作亂數產生的種子
				//如果在短時間內多次建立Random 類別 新實例
				//系統時間可能是一樣的
				//所以產生的亂數也會是一樣的
				//正確的做法是只建立一個Random 類別 新實例
				//然後重複使用它
				//以下的程式碼是錯誤的示範
				//------------------------------
				//Random random1 = new Random();

				//產生一個1 ~ 6 之間的隨機整數
				int rdNum4 = random.Next(1,7);
                Console.WriteLine(rdNum4);
			}

		}
    }
}
