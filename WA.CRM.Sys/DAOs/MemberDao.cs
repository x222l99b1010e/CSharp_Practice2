using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.CRM.Sys.DTOs;

namespace WA.CRM.Sys.DAOs
{
	internal class MemberDao : IMemberDao
	{
		public void Create(MemberDTO dto)
		{
			//todo 實作存檔邏輯，例如使用ADO.NET或Entity Framework，連接到MSSQL並記錄存檔
		}

		public List<MemberDTO> GetAll()
		{
			//todo 實作讀取邏輯，例如使用ADO.NET或Entity Framework，連接到MSSQL讀取"所有"會員資料並回傳
			throw new NotImplementedException();
		}

		public MemberDTO GetMember(int id)
		{
			//todo 實作讀取邏輯，例如使用ADO.NET或Entity Framework，連接到MSSQL讀取特定會員(一筆)資料並回傳
			throw new NotImplementedException();
		}

		public void Update(MemberDTO dto)
		{
			//todo 實作更新邏輯，例如使用ADO.NET或Entity Framework，連接到MSSQL更新特定會員(一筆)資料
			throw new NotImplementedException();
		}
	}
}
