using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MightyMaverick.web.Startup))]
namespace MightyMaverick.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
