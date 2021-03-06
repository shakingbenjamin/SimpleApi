﻿namespace SimpleApi
{
    using System;
    using System.Configuration;
    using System.Web;
    using Funq;
    using ServiceStack;
    using ServiceStack.Data;
    using ServiceStack.OrmLite;
    using SimpleApi.Interfaces;
    using SimpleApi.Services;

    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }

    // so servicestack can find the web services
    public class AppHost : AppHostBase
    {
        // naming the application and where to find el services
        public AppHost() : base("Simple Api", typeof(ISimpleApiClient).Assembly) { }

        public override void Configure(Container container)
        {
            // where to register the dependencies the services have, for example
            container.Register<IDbConnectionFactory>(
                new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["simpleapidb"].ConnectionString, SqlServerDialect.Provider, true));
        }
    }
}