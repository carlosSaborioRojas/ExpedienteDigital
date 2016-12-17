using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpedienteDigital.Startup))]
namespace ExpedienteDigital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
