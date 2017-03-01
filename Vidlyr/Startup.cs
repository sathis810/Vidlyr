using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlyr.Startup))]
namespace Vidlyr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
