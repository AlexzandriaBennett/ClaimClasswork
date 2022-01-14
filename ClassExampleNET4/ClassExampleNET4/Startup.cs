using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassExampleNET4.Startup))]
namespace ClassExampleNET4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
