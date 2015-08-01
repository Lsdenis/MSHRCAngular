using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSHRCA.Web.Startup))]
namespace MSHRCA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
