using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;

namespace MSHRCA.BusinessLogic.Services.Interfaces
{
	public interface ILessonService
	{
		IEnumerable<Lesson> GetLessons();
		IEnumerable<LessonType> GetLessonTypes();
	}
}
