using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;

namespace MSHRCA.BusinessLogic.Services.Interfaces
{
	public interface IGroupDisciplineService
	{
		IEnumerable<GroupDiscipline> GetAllGroupDisciplines();
		void SaveOrUpdate(GroupDiscipline groupDiscipline);
		void DeleteGroupDiscipline(int id);
	}
}
