using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(facture.Startup))]
namespace facture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
