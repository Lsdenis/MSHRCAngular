using System;
using notimeReports.BusinessLogic.DataModel.Database;

namespace notimeReports.BusinessLogic.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		ONT_5Entities Context { get; }
		void Commit();
	}
}
