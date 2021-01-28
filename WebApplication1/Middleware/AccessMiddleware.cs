using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Middleware
{
    public class AccessMiddleware
    {

        private RequestDelegate nextDelegate;

        public AccessMiddleware(RequestDelegate next)
        {
            this.nextDelegate = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            var username = httpContext.Request.Query["username"].ToString();
            var rolename = httpContext.Request.Query["rolename"].ToString();
            if (username == "")
            {
                await nextDelegate.Invoke(httpContext);
                return;
            }
            Repository.StudentRepository studentRepository = new Repository.StudentRepository();
            if (studentRepository.UserInRole(username, rolename))
            {
                await nextDelegate.Invoke(httpContext);
            }
            else
            {
                httpContext.Response.StatusCode = 403;
            }
            
        }
    }


}

