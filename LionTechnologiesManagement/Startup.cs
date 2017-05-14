using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LionTechnologiesManagement.Startup))]
namespace LionTechnologiesManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
