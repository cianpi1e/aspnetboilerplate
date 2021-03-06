﻿using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Abp.WebApi.Routing
{
    public static class RouteConfig 
    {
        public static void Register(HttpConfiguration config)
        {
            //Dynamic Web APIs
            config.Routes.MapHttpRoute(
                name: "AbpDynamicWebApi",
                routeTemplate: "api/services/{serviceName}/{methodName}"
                );

            //Dynamic Web API proxies
            config.Routes.MapHttpRoute(
                name: "AbpDynamicWebApiProxy",
                routeTemplate: "api/serviceproxies/{name}.js",
                defaults: new { controller = "ServiceProxies", action = "Get" }
                );
        }
    }
}
