using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Raclette4Every1.Startup))]
namespace Raclette4Every1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
