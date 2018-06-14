using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApplicationForJenkins.Startup))]
namespace TestApplicationForJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
