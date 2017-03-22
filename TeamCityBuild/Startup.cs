using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityBuild.Startup))]
namespace TeamCityBuild
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
