using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleEfProject.Startup))]
namespace ExampleEfProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
