using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			string email = textBox2.Text;
			string phone = textBox3.Text;

			string message = $@"Name: {name}
Email: {email}
Phone: {phone}";
			MessageBox.Show(message);
		}
	}
}
