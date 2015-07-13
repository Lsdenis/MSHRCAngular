using MSHRCA.BusinessLogic.DataModel.Database;
using MSHRCA.BusinessLogic.Interfaces;

namespace notimeReports.BusinessLogic.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork, ISelfInject
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
