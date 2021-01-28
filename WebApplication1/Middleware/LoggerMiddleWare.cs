using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using WebApplication1.Repository;


namespace WebApplication1.Middleware
{
    public class LoggerMiddleWare
    {

        private RequestDelegate nextDelegate;
        public LoggerMiddleWare(RequestDelegate next)
        {
            this.nextDelegate = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            //var controllerActionDescriptor = httpContext
            //.GetEndpoint()
            //.Metadata
            //.GetMetadata<ControllerActionDescriptor>();

            //var controllerName = controllerActionDescriptor.ControllerName;
            //var actionName = controllerActionDescriptor.ActionName;
            var controllerName = "ccc desc";
            var actionName = "aaa";
            var dateNow = DateTime.Now;
            var username = httpContext.Request.Query["username"].ToString();

            MyloggerRepository myLogger = new MyloggerRepository();


            myLogger.Addlog(username, actionName, dateNow.ToString(), controllerName);
            await nextDelegate.Invoke(httpContext);



        }



    }
}
