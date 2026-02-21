using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA.CRM.Sys
{
	public partial class FrmMemberIndex : Form
	{
		public FrmMemberIndex()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var service = new Services.MemberService();
			List<DTOs.MemberDTO> members = service.GetAll();

			//todo : bind members to datagridview將members 繫結 (Bind) 到 datagridview 控制項裡
		}
	}
}
