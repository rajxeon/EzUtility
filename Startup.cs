using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EzUtility.Startup))]
namespace EzUtility
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
