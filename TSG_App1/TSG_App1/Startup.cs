using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSG_App1.Startup))]
namespace TSG_App1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
