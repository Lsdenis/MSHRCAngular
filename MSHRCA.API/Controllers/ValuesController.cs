using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

namespace MSHRCA.API.Controllers
{
	public class ValuesController : ApiController
	{
		[Route("api/values/helloworld")]
		public HttpResponseMessage GetHelloWorld()
		{
			var a = new HttpResponseMessage(HttpStatusCode.OK);

			var @string = JsonConvert.SerializeObject(new string[] { "hello", "world" });

			a.Content = new StringContent(@string, Encoding.UTF8, "application/json");

			return a;
		}
	}
}
