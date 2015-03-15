using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_Route_SimpleExample.Startup))]
namespace Angular_Route_SimpleExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
