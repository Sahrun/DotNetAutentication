using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetAutentication.Startup))]
namespace DotNetAutentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
