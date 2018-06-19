using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevGenius.Startup))]
namespace DevGenius
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
