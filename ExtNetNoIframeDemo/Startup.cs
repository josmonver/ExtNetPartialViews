using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExtNetNoIframeDemo.Startup))]
namespace ExtNetNoIframeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
