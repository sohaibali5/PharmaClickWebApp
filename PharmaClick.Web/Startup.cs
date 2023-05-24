using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PharmaClick.Web.Startup))]
namespace PharmaClick.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
