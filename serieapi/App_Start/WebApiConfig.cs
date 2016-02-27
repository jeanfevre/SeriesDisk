using System.Web.Http;
using System.Web.Http.Cors;

namespace serieapi
{
	/// <summary>
	/// 
	/// </summary>
	public static class WebApiConfig
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="config"></param>
		public static void Register(HttpConfiguration config)
		{
			var cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(cors);
			// Configuration et services API Web

			// Itinéraires de l'API Web
			config.MapHttpAttributeRoutes();
		}
	}
}
