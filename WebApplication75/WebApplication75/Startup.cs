using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication75.Startup))]
namespace WebApplication75
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
