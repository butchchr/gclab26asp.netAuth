using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gclab26Auth.Startup))]
namespace gclab26Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
