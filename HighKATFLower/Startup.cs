using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HighKATFLower.Startup))]
namespace HighKATFLower
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
