using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS_Fundamentals_Part1.Startup))]
namespace AngularJS_Fundamentals_Part1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
