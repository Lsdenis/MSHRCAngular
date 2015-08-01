using System;
using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;
using MSHRCA.BusinessLogic.DTO;

namespace MSHRCA.BusinessLogic.Services.Interfaces
{
	public interface IGDCabinetService
	{
		IEnumerable<GeneralTableRowValue> GetGeneralTableRowValues(DateTime date);
		IEnumerable<GDCabinet> GetAllGDCabinets();
		Dictionary<Lesson, List<Cabinet>> GetCabinetLessons(DateTime date);
	}
}
