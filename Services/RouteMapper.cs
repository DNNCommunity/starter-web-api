using DotNetNuke.Web.Api;

namespace starter_web_api.Services
{
    public class RouterMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
            "starter-web-api",
            "default",
            "{controller}/{action}",
            new string[] { "starter_web_api.Services" });
        }
    }
}