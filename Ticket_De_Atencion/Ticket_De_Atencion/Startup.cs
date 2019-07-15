using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ticket_De_Atencion.Startup))]
namespace Ticket_De_Atencion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
