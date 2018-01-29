using CharlieDogs.ApplicationService.Filters;
using CharlieDogs.CrossCutting.Configuration;
using CharlieDogs.CrossCutting.Security;
using Newtonsoft.Json.Serialization;
using NLog;
using SimpleInjector.Integration.WebApi;
using System;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace CharlieDogs.ApplicationService
{
    public class Global : System.Web.HttpApplication
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        ///<Summary>
        /// Application Error
        ///</Summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            logger.Error(ex);
        }

        ///<Summary>
        /// Application Start
        ///</Summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        protected void Application_Start(object sender, EventArgs e)
        {
            // Configure Cors
            var cors = new System.Web.Http.Cors.EnableCorsAttribute(PrivateSettings.ORIGINS_CORS, PrivateSettings.HEADERS_CORS, PrivateSettings.METHODS_CORS);
            GlobalConfiguration.Configuration.EnableCors(cors);

            // Configure Formatters
            // https://stackoverflow.com/questions/25224824/how-to-change-default-web-api-2-to-json-formatter
            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());

            // Configure Camelcase Properties
            // https://stackoverflow.com/questions/22130431/web-api-serialize-properties-starting-from-lowercase-letter
            GlobalConfiguration
                .Configuration
                .Formatters
                .JsonFormatter
                .SerializerSettings
                .ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Configure Routers
            // http://www.daniellewis.me.uk/2014/02/21/asp-net-web-api-from-scratch-part-1/
            GlobalConfiguration.Configuration.Routes
                .MapHttpRoute("Default",
                "{controller}/{id}",
                new { id = RouteParameter.Optional }
                );

            // Configure Dependence Injection
            // Install: SimpleInjector.Integration.webapi
            DependenceInjection.Initialize.InitScoped();

            // This is an extension method from the integration package.
            // CrossCutting.DependenceInjetion.Initialize.Container.regiRegisterWebApiControllers(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(DependenceInjection.Initialize.Container);

            // Configure AutoMapper
            Mapping.Initialize.Init();

            // Configure Exception filter
            GlobalConfiguration.Configuration.Filters.Add(new ExceptionFilter());

            // Configure Token Authorization filter
            //GlobalConfiguration.Configuration.Filters.Add(new TokenAuthorizeAttribute());

            // Configure Audit
            Audit.Core.Configuration.DataProvider = new LogEntriesDataProvider();
        }
    }
}