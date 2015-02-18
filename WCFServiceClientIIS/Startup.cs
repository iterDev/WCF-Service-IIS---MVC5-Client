using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCFServiceClientIIS.Startup))]
namespace WCFServiceClientIIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
