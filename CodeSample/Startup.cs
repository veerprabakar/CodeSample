using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeSample.Startup))]
namespace CodeSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
