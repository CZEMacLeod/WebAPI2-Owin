using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebAPI2_Owin.Startup))]

namespace WebAPI2_Owin
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			HttpConfiguration config = new HttpConfiguration();
			WebApiConfig.Register(config);

			app.UseWebApi(config);
		}
	}
}
