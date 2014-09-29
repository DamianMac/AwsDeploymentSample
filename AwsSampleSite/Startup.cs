using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AwsSampleSite.Startup))]
namespace AwsSampleSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
