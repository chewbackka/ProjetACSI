using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetACSI.Startup))]
namespace ProjetACSI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
