using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace DockerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IConfiguration m_Config;
        public ValuesController(IConfiguration configuration)

        {
            m_Config = configuration;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var port = m_Config["Service:Port"];
            return new string[] { port };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpGet("~/api/health")]
        public ActionResult<string> CheckHealth()
        {
            return "ok";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
