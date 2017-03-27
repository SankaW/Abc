using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SW01.Startup))]
namespace SW01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
