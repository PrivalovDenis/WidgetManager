using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WidgetManager.Startup))]
namespace WidgetManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
