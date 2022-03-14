using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911066023_VanThanhKhanhDuy_BigSchool.Startup))]
namespace _1911066023_VanThanhKhanhDuy_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
