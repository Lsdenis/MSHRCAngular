using notimeReports.BusinessLogic.DataModel.Database;
using notimeReports.BusinessLogic.Interfaces;

namespace notimeReports.BusinessLogic.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork, IDependency
	{
		private readonly ONT_5Entities _context;

		public UnitOfWork(ONT_5Entities context)
		{
			_context = context;
		}

		public ONT_5Entities Context
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
