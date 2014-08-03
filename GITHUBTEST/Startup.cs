using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GITHUBTEST.Startup))]
namespace GITHUBTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
