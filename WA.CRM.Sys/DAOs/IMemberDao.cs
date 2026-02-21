using System.Collections.Generic;
using WA.CRM.Sys.DTOs;

namespace WA.CRM.Sys.DAOs
{
	internal interface IMemberDao
	{
		void Create(MemberDTO dto);
		List<MemberDTO> GetAll();

		MemberDTO GetMember(int id);

		void Update(MemberDTO dto);
	}
}
