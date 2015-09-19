using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(foo.Startup))]
namespace foo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
