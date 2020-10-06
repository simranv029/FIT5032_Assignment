using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fit5032_Assignment_Simran.Startup))]
namespace Fit5032_Assignment_Simran
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
