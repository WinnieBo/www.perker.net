using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.Perker.Net.Startup))]
namespace MVC.Perker.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
