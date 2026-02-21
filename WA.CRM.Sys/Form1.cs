using System;
using System.Windows.Forms;
using WA.CRM.Sys.DTOs;
using WA.CRM.Sys.Services;

namespace WA.CRM.Sys
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var service = new MemberService();
			var dto = new MemberDTO
			{
				Account = txtAccount.Text,
				Email = txtEmail.Text
			};
			service.Create(dto);
		}
	}
}
