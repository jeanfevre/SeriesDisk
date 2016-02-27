using System.Web.Http;
using System.Web.Http.Cors;
using serieapi.Models;

namespace serieapi.Controllers
{
	/// <summary>
	/// 
	/// </summary>
	[RoutePrefix("api")]
	[EnableCors(origins: "*", headers: "*", methods: "GET")]
	public class SeriesController : ApiController
	{
		#region
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		[Route("search/{text}")]
		[HttpGet]
		public IHttpActionResult GetSearch(string text)
		{
			return Ok(new SearchSerie(text));
		}
		#endregion
	}
}
