using System;
using MSHRCA.BusinessLogic.DataModel;

namespace MSHRCA.BusinessLogic.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		MSHRCSchedulerContext Context { get; }
		void Commit();
	}
}
