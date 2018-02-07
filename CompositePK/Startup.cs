using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompositePK.Startup))]
namespace CompositePK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
