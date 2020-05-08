using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;

namespace Nad.Trainning.Owin.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            UseCors(app);
            WebApiConfig.Configure(app);
            app.UseCors(CorsOptions.AllowAll);
        }

        private static void UseCors(IAppBuilder app)
        {
            var policy = new CorsPolicy()
            {
                AllowAnyHeader = true,
                AllowAnyMethod = true,
                AllowAnyOrigin = true,
                SupportsCredentials = true,
            };
            policy.ExposedHeaders.Add("X-Custom-Header");
            policy.ExposedHeaders.Add("Location");
            policy.ExposedHeaders.Add("Content-Disposition");
            policy.ExposedHeaders.Add("Content-Length");
            
            app.UseCors(new CorsOptions()
            {
                PolicyProvider = new CorsPolicyProvider()
                {
                    PolicyResolver = ctx => Task.FromResult(policy),
                }
            });
        }
    }
}