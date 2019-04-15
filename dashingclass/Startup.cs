using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dashingclass.Startup))]
namespace dashingclass
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
