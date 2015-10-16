using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MyWaves.Web.Controllers
{
    //[Route("api/[controller]")]
    public class ValuesController : ApiController
    {
        // GET: api/values
        [HttpGet]
        public object Get()
        {
            return new { height = 5 };
        }

        //// GET api/values/5
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public object Post([FromBody]MyWaves.Models.HeightReport value)
        {
            return new { Height = value.Height };//stub we return what the user sent..
            //
            // SendGrid Emails:  Key : "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"
            // Key Name:  "MyWaves"

            //ip location : https://iplocator.melissadata.net/v2/soap/service.svc

            //SMS
            //
        }

        //// PUT api/values/5
        //[HttpPut]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete]
        //public void Delete(int id)
        //{
        //}
    }
}
