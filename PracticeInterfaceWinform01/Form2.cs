using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PracticeInterfaceWinform01
{
	public partial class Form2 : Form, IContainer
	{
		public Form2()
		{
			InitializeComponent();
		}

		public void setValue(string newValue)
		{
			textBox1.Text = newValue.ToUpper();
		}

		private void btnOpenForm3_Click(object sender, EventArgs e)
		{
			var frm = new Form3();

			frm.Owner = this;//跳出的視窗的Owner是Form2，這樣在Form3裡面就可以使用this.Owner來取得Form2的物件，進而存取Form2裡面的屬性或方法
			frm.Show();
		}
	}
}
