using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using TokenAuthenticationInWebAPI.Models;
using Microsoft.Owin.Security.OAuth;
using System.Web.Http;

[assembly: OwinStartup(typeof(TokenAuthenticationInWebAPI.App_Start.Startup))]

namespace TokenAuthenticationInWebAPI.App_Start
{
    // In this class we will Configure the OAuth Authorization Server.
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            // Enable Cores (corss origin resource sharing) for making request using browser from different domains 
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,

                // The Path for genarating the TOKEN (http://localhost:portnumber/token)
                TokenEndpointPath = new PathString("/token"),

                // Setting the TOKEN Expired Time (24 hours / 10 hours); After expier HTTP status code 401 is returned.
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(10),

                // MyAuthorizationServerProvider class will validate the user credentials
                Provider = new MyAuthorizationServerProvider()

            };

            //TOKEN Generations. UseOAuthAuthorizationServer is an extension method.It is authentication middleware to the pipeline.
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration configuration = new HttpConfiguration();
            WebApiConfig.Register(configuration);


        }
    }
}
