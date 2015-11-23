using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBooksEmployee.Startup))]
namespace SBooksEmployee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
