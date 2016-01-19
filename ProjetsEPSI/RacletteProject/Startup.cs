using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RacletteProject.Startup))]
namespace RacletteProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
