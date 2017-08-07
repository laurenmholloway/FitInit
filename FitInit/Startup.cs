using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitInit.Startup))]
namespace FitInit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
