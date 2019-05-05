using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHUb.Startup))]
namespace GigHUb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
