using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;
using MSHRCA.BusinessLogic.Repository;
using MSHRCA.BusinessLogic.Services.Interfaces;
using MSHRCA.BusinessLogic.UnitOfWork;

namespace MSHRCA.BusinessLogic.Services.Classes
{
	public class GroupService : IGroupService, ISelfDependency
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IRepository<Group> _groupRepository;

		public GroupService(IUnitOfWork unitOfWork, IRepository<Group> groupRepository)
		{
			_unitOfWork = unitOfWork;
			_groupRepository = groupRepository;
		}

		public IEnumerable<Group> GetAllGroups()
		{
			return _groupRepository.GetAll();
		}
	}
}
