using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguridadMVC.Startup))]
namespace SeguridadMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
