using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;
using MSHRCA.BusinessLogic.Repository;
using MSHRCA.BusinessLogic.Services.Interfaces;

namespace MSHRCA.BusinessLogic.Services.Classes
{
	public class AcademicDisciplineService: IAcademicDisciplineService, ISelfDependency
	{
		private readonly IRepository<AcademicDiscipline> _academicDisciplineRepository;

		public AcademicDisciplineService(IRepository<AcademicDiscipline> academicDisciplineRepository)
		{
			_academicDisciplineRepository = academicDisciplineRepository;
		}

		public IEnumerable<AcademicDiscipline> GetAll()
		{
			return _academicDisciplineRepository.GetAll();
		}

		public void AddOrUpdate(AcademicDiscipline academicdiscipline)
		{
			_academicDisciplineRepository.Add(academicdiscipline);
		}

		public void Delete(AcademicDiscipline academicdiscipline)
		{
			_academicDisciplineRepository.Delete(academicdiscipline);
		}
	}
}
