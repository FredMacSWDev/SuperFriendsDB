using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperFriendsDB.WebMVC.Startup))]
namespace SuperFriendsDB.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
