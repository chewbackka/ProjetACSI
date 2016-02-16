using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetACSIRaclette.Startup))]
namespace ProjetACSIRaclette
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
