﻿namespace IIS.MyTestApplicationEmber
{
    using System;
    using System.Reflection;
    using System.Web.Http;

    using ICSSoft.STORMNET;
    using ICSSoft.Services;
    using IIS.Caseberry.Logging.Objects;

    using Microsoft.Practices.Unity;

    using NewPlatform.Flexberry;
    using NewPlatform.Flexberry.AspNet.WebApi.Cors;
    using NewPlatform.Flexberry.ORM.ODataService;
    using NewPlatform.Flexberry.ORM.ODataService.Extensions;
    using NewPlatform.Flexberry.ORM.ODataService.Functions;
    using NewPlatform.Flexberry.ORM.ODataService.Model;
    using NewPlatform.Flexberry.Services;

    /// <summary>
    /// Configure OData Service.
    /// </summary>
    internal static class ODataConfig
    {
        /// <summary>
        /// Configure OData by DataObjects assembly.
        /// </summary>
        /// <param name="config">Http configuration object.</param>
        /// <param name="container">Unity container.</param>
        public static void Configure(HttpConfiguration config, IUnityContainer container)
        {
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            // To support CORS uncomment the line below.
            // config.EnableCors(new DynamicCorsPolicyProvider());
            // Use constructor with true first parameter for enable SupportsCredentials.

            // Use Unity as WebAPI dependency resolver
            config.DependencyResolver = new UnityDependencyResolver(container);

            // Create EDM model builder
            var assemblies = new[]
            { 
                Assembly.Load("MyTestApplicationEmber.Objects"),
                typeof(ApplicationLog).Assembly,
                typeof(UserSetting).Assembly,
                typeof(FlexberryUserSetting).Assembly,
                typeof(Lock).Assembly
            };
            var builder = new DefaultDataObjectEdmModelBuilder(assemblies);

            // Map OData Service
            var token = config.MapODataServiceDataObjectRoute(builder);

            // User functions
            token.Functions.Register(new Func<QueryParameters, string>(Test));

            // Event handlers
            token.Events.CallbackAfterCreate = CallbackAfterCreate;
        }

        private static void CallbackAfterCreate(DataObject dataObject)
        {
            // TODO: implement handler
        }

        private static string Test(QueryParameters queryParameters)
        {
            return "Hello world!";
        }
    }
}