using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TestWebAPI.Filter
{
    public class BasicAuthFIlter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext Context)
        {
            HttpRequestHeaders header = Context.Request.Headers;
            if (header.Authorization != null)
            {
                string Usercredential = Encoding.UTF8.GetString(Convert.FromBase64String(header.Authorization.Parameter));
                string[] UserDetail = Usercredential.Split(':');
                string userneme = UserDetail[0];
                string password = UserDetail[1];

                if (!userneme.Equals("chandru") && !password.Equals("chandru@123"))
                {
                    Context.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    return;
                }

            }
            else
            {
                Context.Response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                return;
            }

            base.OnAuthorization(Context);
        }
    }
}