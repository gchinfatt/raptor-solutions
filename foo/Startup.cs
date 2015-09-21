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

//T Justin Test Comment (9/21/15 3:05)
//T Justin Test Comment 2 (9/21/15 3:12)
