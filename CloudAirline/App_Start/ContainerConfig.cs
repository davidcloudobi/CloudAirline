using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirLineServices;
using AirLineServices.Interface;
using AirLineServices.Services;
using AirLineServices.SqlDataServices;
using Autofac;
using Autofac.Integration.Mvc;

namespace CloudAirline
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<AirLineServices.Services.AirLineServices>().As<IAirlineServices>().InstancePerRequest();
            builder.RegisterType<UserServices>().As<IUserServices>().InstancePerRequest();
            builder.RegisterType<SqlAirlineServices>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}