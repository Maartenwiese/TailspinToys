using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TailspinToys.Web.Startup))]
namespace TailspinToys.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
