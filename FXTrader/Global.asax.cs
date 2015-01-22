﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.Mvc;
using Autofac;
using FXTrader.Modules;

namespace FXTrader
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
	
        //Autofac Configuration
          var builder = new Autofac.ContainerBuilder();
 
          builder.RegisterControllers(typeof(FXTrader.MvcApplication).Assembly).PropertiesAutowired();
 
          builder.RegisterModule(new RepositoryModule());
          builder.RegisterModule(new ServiceModule());
          builder.RegisterModule(new EFModule());
 
          var container = builder.Build();
 
          DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
