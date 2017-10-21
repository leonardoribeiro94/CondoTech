using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace Condominio.Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Off;//alterar para off para funcionamento do ajax
            routes.EnableFriendlyUrls(settings);
        }
    }
}
