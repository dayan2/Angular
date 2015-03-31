using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_With_Legacy.Startup))]
namespace Angular_With_Legacy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
