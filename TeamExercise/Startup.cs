using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamExercise.Startup))]
namespace TeamExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
