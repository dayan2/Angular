using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_Fundamental_Part2.Startup))]
namespace Angular_Fundamental_Part2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
