using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MSHRCA.BusinessLogic.Services.Interfaces;

namespace MSHRCA.API.Controllers
{
	public class GroupDisciplinesController : BaseApiController
	{
		private readonly IGroupDisciplineService _groupDisciplineService;

		public GroupDisciplinesController(IGroupDisciplineService groupDisciplineService)
		{
			_groupDisciplineService = groupDisciplineService;
		}

		[Route("api/groupdisciplines/getall")]
		public HttpResponseMessage GetGroupDisciplines()
		{
			var groupDisciplines = _groupDisciplineService.GetAllGroupDisciplines();
			var response = CreateResponse(groupDisciplines, HttpStatusCode.OK);
			return response;
		}
	}
}