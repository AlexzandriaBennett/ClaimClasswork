using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NET4Import.Startup))]
namespace NET4Import
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
