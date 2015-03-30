using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Part6_Angular.Startup))]
namespace Part6_Angular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
