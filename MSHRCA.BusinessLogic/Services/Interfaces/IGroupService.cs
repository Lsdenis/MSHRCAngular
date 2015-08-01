using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;

namespace MSHRCA.BusinessLogic.Services.Interfaces
{
	public interface IGroupService
	{
		IEnumerable<Group> GetAllGroups();
	}
}
