using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularMVC5.Startup))]
namespace AngularMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
