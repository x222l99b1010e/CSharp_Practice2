namespace interfacePractice
{
	internal class Member : IMember
	{
		public string name;//field
		public Member()
		{
			
		}
		// method 可多載
		public int Add(int a, int b)
		{
			return a + b;
		}
		public int Add(int a)
		{
			return a;
		}

		private int _height;//field
		public int Height//property
		{
			get { return _height; }
			set { _height = value; }
		}

		public int Weight { get; set; } // auto-implemented property
	}
}
