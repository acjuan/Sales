using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sales.Bakend.Startup))]
namespace Sales.Bakend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
