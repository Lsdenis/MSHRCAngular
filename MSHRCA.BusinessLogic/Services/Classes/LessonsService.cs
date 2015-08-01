using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;
using MSHRCA.BusinessLogic.Repository;
using MSHRCA.BusinessLogic.Services.Interfaces;

namespace MSHRCA.BusinessLogic.Services.Classes
{
	public class LessonsService : ILessonService, ISelfDependency
	{
		private readonly IRepository<Lesson> _lessonRepository;
		private readonly IRepository<LessonType> _lessonTypeRepository;

		public LessonsService(IRepository<Lesson> lessonRepository, IRepository<LessonType> lessonTypeRepository)
		{
			_lessonRepository = lessonRepository;
			_lessonTypeRepository = lessonTypeRepository;
		}

		public IEnumerable<Lesson> GetLessons()
		{
			return _lessonRepository.GetAll();
		}

		public IEnumerable<LessonType> GetLessonTypes()
		{
			return _lessonTypeRepository.GetAll();
		}
	}
}
