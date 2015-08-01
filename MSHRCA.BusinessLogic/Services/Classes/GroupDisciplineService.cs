using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MSHRCA.BusinessLogic.DataModel;
using MSHRCA.BusinessLogic.Repository;
using MSHRCA.BusinessLogic.Services.Interfaces;
using MSHRCA.BusinessLogic.UnitOfWork;

namespace MSHRCA.BusinessLogic.Services.Classes
{
	public class GroupDisciplineService : IGroupDisciplineService, ISelfDependency
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IRepository<GroupDiscipline> _groupDisciplineRepository;
		private readonly IRepository<GDTeacher> _gdTeachersRepository;
		private readonly IRepository<GDCabinet> _gdCabinetsRepository;

		public GroupDisciplineService(IUnitOfWork unitOfWork, IRepository<GroupDiscipline> groupDisciplineRepository,
			IRepository<GDTeacher> gdTeachersRepository, IRepository<GDCabinet> gdCabinetsRepository)
		{
			_unitOfWork = unitOfWork;
			_groupDisciplineRepository = groupDisciplineRepository;
			_gdTeachersRepository = gdTeachersRepository;
			_gdCabinetsRepository = gdCabinetsRepository;
		}

		public IEnumerable<GroupDiscipline> GetAllGroupDisciplines()
		{
			return _groupDisciplineRepository.GetAll();
		}

		public void SaveOrUpdate(GroupDiscipline groupDiscipline)
		{
			if (groupDiscipline.Id == 0)
			{
				_groupDisciplineRepository.Add(groupDiscipline);
			}
			else
			{
				var discipline = _groupDisciplineRepository.Get(gd => gd.Id == groupDiscipline.Id);
				_unitOfWork.Context.Entry(discipline).CurrentValues.SetValues(groupDiscipline);
				_unitOfWork.Context.Entry(discipline).State = EntityState.Modified;
			}
		}

		public void DeleteGroupDiscipline(int id)
		{
			var teachers = _gdTeachersRepository.GetAll(teacher => teacher.GroupDisciplineId == id);
			foreach (var teacher in teachers)
			{
				_gdTeachersRepository.Delete(teacher);
			}

			var gdCabinets = _gdCabinetsRepository.GetAll(cabinet => cabinet.GDId == id);
			foreach (var gdCabinet in gdCabinets)
			{
				_gdCabinetsRepository.Delete(gdCabinet);
			}
			
			var groupDiscipline = _groupDisciplineRepository.GetAll(discipline => discipline.Id == id).Single();
			_groupDisciplineRepository.Delete(groupDiscipline);
		}
	}
}
