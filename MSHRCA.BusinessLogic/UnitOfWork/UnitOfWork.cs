using MSHRCA.BusinessLogic.DataModel;
using MSHRCA.BusinessLogic.Services.Interfaces;

namespace MSHRCA.BusinessLogic.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork, ISelfDependency
	{
		private readonly MSHRCSchedulerContext _context;

		public UnitOfWork(MSHRCSchedulerContext context)
		{
			_context = context;
		}

		public MSHRCSchedulerContext Context
		{
			get { return _context; }
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			if (_context != null)
			{
				_context.Dispose();
			}
		}
	}
}
