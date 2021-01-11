using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserNRolesBase.Startup))]
namespace UserNRolesBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
