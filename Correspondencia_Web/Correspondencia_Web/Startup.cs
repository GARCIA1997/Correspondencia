using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Correspondencia_Web.Startup))]
namespace Correspondencia_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
