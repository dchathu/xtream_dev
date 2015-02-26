using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSO1.Startup))]
namespace SSO1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
