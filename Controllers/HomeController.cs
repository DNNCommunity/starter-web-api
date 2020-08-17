using System.Web.Http;
using System.Net;
using System.Net.Http;
using DotNetNuke.Web.Api;
using DotNetNuke.Services.Exceptions;
using starter_web_api.Models;

namespace starter_web_api.Controllers
{
    public class HomeController : DnnApiController
    {
        [DnnAuthorize()]
        [HttpGet()]
        public HttpResponseMessage DnnHello()
        {
            try
            {
                string dnnHello = "Hello from Dnn!";
                return Request.CreateResponse(HttpStatusCode.OK, dnnHello);
            }
            catch (System.Exception ex)
            {
                //Log exception and reply with Error
                Exceptions.LogException(ex);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [DnnAuthorize()]
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public HttpResponseMessage DnnGoodbye(DetailsModel data)
        {
            try
            {
                string dnnMessage = "Hello from Dnn!";
                if (data.goodbye)
                {
                    dnnMessage = "Goodbye from Dnn!";
                }
                return Request.CreateResponse(HttpStatusCode.OK, dnnMessage);
            }
            catch (System.Exception ex)
            {
                //Log exception and reply with Error
                Exceptions.LogException(ex);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}