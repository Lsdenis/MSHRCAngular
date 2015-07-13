using System;
using MSHRCA.BusinessLogic.DataModel.Database;

namespace notimeReports.BusinessLogic.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		MSHRCSchedulerContext Context { get; }
		void Commit();
	}
}
