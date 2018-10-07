using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhotonTSapi.Models;
using PhotonTSapi.DAL;
using System.Web.Http.Filters;
using System.Web.Http.Cors;

namespace PhotonTSapi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class userController : ApiController
    {
        public void Get() { }

        public user Post(UserDetail userDetails)
        {
            //var allUrlKeyValues = ControllerContext.Request.GetQueryNameValuePairs();
            //string username = allUrlKeyValues.SingleOrDefault(x => x.Key == "username").Value;

             PhotonTSDAL pDAL = new PhotonTSDAL();
            //List<user> userCol = pDAL.users.ToList<user>();
            user authUser = (from x in pDAL.users
                             where x.username.ToLower() == userDetails.username.ToLower()
                             select x
                            ).FirstOrDefault();
            return authUser;
        }
    }   

    public class AllowCrossSite: ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if(actionExecutedContext.Response != null)
            {
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin","*");
            }
            base.OnActionExecuted(actionExecutedContext);
        }
    }

    public class UserDetail
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
