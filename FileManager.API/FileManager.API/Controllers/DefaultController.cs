using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FileManager.API.Controllers
{
    public class DefaultController : ApiController
    {
        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <returns></returns>
        [Route("Test")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
