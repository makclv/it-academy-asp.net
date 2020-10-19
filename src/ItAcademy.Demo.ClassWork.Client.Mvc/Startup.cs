using ItAcademy.Demo.ClassWork.Infrastructure.Data.Context;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using ItAcademy.Demo.ClassWork.Client.Mvc.App_Start.Core;

[assembly: OwinStartup(typeof(ItAcademy.Demo.ClassWork.Client.Mvc.Startup))]

namespace ItAcademy.Demo.ClassWork.Client.Mvc
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(() => new CoreDbContext());
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            
           // app.CreatePerOwinContext<RoleManager<ApplicationRole>>((options, context) =>
           // new RoleManager<ApplicationRole>(
           // new RoleStore<ApplicationRole>(context.Get<CoreDbContext>())));
            
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}
