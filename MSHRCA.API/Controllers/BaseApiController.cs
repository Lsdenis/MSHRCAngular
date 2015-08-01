using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;
using Ninject.Extensions.Conventions.Syntax;

namespace MSHRCA.API.Controllers
{
	public class BaseApiController : ApiController
	{
		protected static HttpResponseMessage CreateResponse<T>(T data, HttpStatusCode code)
		{
			var response = new HttpResponseMessage(code);

			var content = JsonConvert.SerializeObject(data);

			response.Content = new StringContent(content, Encoding.UTF8, "application/json");

			return response;
		}
	}
}