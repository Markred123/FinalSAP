using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassroomBooking.Startup))]
namespace ClassroomBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
