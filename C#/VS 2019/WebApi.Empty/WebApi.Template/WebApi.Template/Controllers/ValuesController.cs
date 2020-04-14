using log4net;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Template.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ILog _log;
        public ValuesController(ILog log)
        {
            _log = log;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
