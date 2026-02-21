using System.Collections.Generic;
using WA.CRM.Sys.DAOs;
using WA.CRM.Sys.DTOs;

namespace WA.CRM.Sys.Services
{
	internal class MemberService
	{
		//private readonly IMemberDao _dao;
		//// 由外部決定要給哪一種 DAO，Service 本身不負責 new
		//public MemberService(IMemberDao dao)
		//{
		//	_dao = dao;
		//}
		//public void Create(MemberDTO dto)
		//{
		//	// 這裡不需要知道 _dao 到底是 SQL 還是 Oracle，只要呼叫 Create 即可
		//	_dao.Create(dto);
		//}
		public void Create(MemberDTO dto)
		{
			//todo 驗證欄位是否合理
			//todo 判斷商業邏輯，例如帳號是否唯一

			//呼叫DAO進行存檔
			IMemberDao dao = new MemberDao();
			dao.Create(dto);
		}
		public List<MemberDTO> GetAll()
		{
			IMemberDao dao = new MemberDao();
			return dao.GetAll();
		}

		public MemberDTO GetMember(int id) {
			IMemberDao dao = new MemberDao();
			return dao.GetMember(id);
		}

		public void Update(MemberDTO dto) {
			//todo 驗證欄位是否填對
			//todo 判斷商業邏輯，例如帳號是否唯一

			//呼叫DAO進行更新
			IMemberDao dao = new MemberDao();
			dao.Update(dto);
		}
	}
}
