using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elum.Website.Startup))]
namespace Elum.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
