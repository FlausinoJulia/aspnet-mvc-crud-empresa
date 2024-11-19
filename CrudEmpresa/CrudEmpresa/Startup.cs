using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudEmpresa.Startup))]
namespace CrudEmpresa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
