using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;

namespace MSHRCA.BusinessLogic.Services.Interfaces
{
	public interface ITeacherService
	{
		IEnumerable<Teacher> GetAllTeachers();
		void SaveOrUpdateGDTeacher(GDTeacher teacher);
		void SaveOrUpdateGDTeacher(List<GDTeacher> teachers, List<int> existedTeachers);
	}
}
