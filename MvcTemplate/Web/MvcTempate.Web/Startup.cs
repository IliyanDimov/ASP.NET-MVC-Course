using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTempate.Web.Startup))]
namespace MvcTempate.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
