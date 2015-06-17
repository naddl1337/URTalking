using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using Microsoft.Practices.Unity;
using UR_Talking.Resolver;
using UR_Talking.DAO;
using UR_Talking.DAO_Impl;
using Iveonik.Stemmers;

namespace UR_Talking.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            UnityContainer container = new UnityContainer();
            
            container.RegisterType<AnswerDAO, AnswerDAOImpl>(new HierarchicalLifetimeManager());
            container.RegisterType<IStemmer, GermanStemmer>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
        }
    }
}