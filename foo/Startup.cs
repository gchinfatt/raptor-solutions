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
//G Chin Fatt Test Comment (9/21/2015 3:14)
