using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tempbre.Startup))]
namespace Tempbre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
