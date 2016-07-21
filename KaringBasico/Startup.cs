using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KaringBasico.Startup))]
namespace KaringBasico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
