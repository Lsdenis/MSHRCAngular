using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;

namespace MSHRCA.BusinessLogic.Services.Interfaces
{
	public interface IAcademicDisciplineService
	{
		IEnumerable<AcademicDiscipline> GetAll();
		void AddOrUpdate(AcademicDiscipline academicdiscipline);
		void Delete(AcademicDiscipline academicdiscipline);
	}
}
