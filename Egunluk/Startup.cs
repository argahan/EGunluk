using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Egunluk.Startup))]
namespace Egunluk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
