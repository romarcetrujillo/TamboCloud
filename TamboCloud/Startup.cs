using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TamboCloud.Startup))]
namespace TamboCloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
