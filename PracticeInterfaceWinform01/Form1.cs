namespace PracticeInterfaceWinform01
{
	public partial class Form1 : Form, IContainer
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void setValue(string newValue)
		{
			label1.Text = newValue.ToLower();
		}

		private void btnOpenForm2_Click(object sender, EventArgs e)
		{
			var frm = new Form2();
			frm.Show();
		}

		private void btnOpenForm3_Click(object sender, EventArgs e)
		{
			var frm = new Form3();

			frm.Owner = this;//跳出的視窗的Owner是Form1，這樣在Form3裡面就可以使用this.Owner來取得Form1的物件，進而存取Form1裡面的屬性或方法
			frm.Show();
		}
	}
}
