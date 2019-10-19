using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanzasTrabajoFinal.Startup))]
namespace FinanzasTrabajoFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
