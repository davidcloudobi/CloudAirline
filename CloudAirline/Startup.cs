using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudAirline.Startup))]
namespace CloudAirline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
