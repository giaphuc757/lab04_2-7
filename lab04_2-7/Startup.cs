using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab04_2_7.Startup))]
namespace lab04_2_7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
