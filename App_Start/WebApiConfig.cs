
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using WebApiDemo.repo;
using WebApiDemo.Service.Services;
using System.Web.Http.Cors;
using System.Net.Http.Headers;

namespace WebApiDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //var cors = new EnableCorsAttribute("*", "*", "*");//origins,headers,methods 
            //config.EnableCors(cors);
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType(typeof(IRepo<>), typeof(Repo<>));
            container.RegisterType<IQuoteService, QuoteService>();
            config.DependencyResolver = new UnityDependencyResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
