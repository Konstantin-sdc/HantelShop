using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HantelShop.Startup))]
namespace HantelShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
