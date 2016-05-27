using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrewAgift.Startup))]
namespace BrewAgift
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
