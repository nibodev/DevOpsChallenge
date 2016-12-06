using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nibo.DevOpsChallenge.Startup))]
namespace Nibo.DevOpsChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
