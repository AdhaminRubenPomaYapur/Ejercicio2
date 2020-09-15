using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practico_Personal.Startup))]
namespace Practico_Personal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
