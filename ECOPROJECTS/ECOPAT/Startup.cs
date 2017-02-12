using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECOPAT.Startup))]
namespace ECOPAT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
