using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentisoftWeb.Startup))]
namespace CentisoftWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
