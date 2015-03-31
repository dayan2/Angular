using Part6_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Part6_Angular.Controllers
{
    public class RegisterUserController : ApiController
    {
        //step1:insert the Error messages in the 'StudentVM' class
        //step2:if error occurred, to find out why it happened, i'm getting another parameter called 'request'
        //step3:checking whether the model is valid
        public HttpResponseMessage Post(HttpRequestMessage request , StudentVM student)
        {
            //checking server-side validation
            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            //when error occurred passing it to 'GetErrorMessages()' to get the message description 
            return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
        }

        private IEnumerable<string> GetErrorMessages()
        {
            //getting error message description from 'ModelState'
            return ModelState.Values.SelectMany(e=> e.Errors.Select(x=> x.ErrorMessage));//Getting each error's, error msg
        }

    }
}