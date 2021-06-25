using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THLTWLAB3.Startup))]
namespace THLTWLAB3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
