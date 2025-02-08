using DE.API.Controllers.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.API.Controllers.V1._0.Master
{
 
    public class DETestController : BaseController
    {
        [HttpGet]
        public string DETest()
        {
            return "hello from donation ethiopia";
        }
    }
}
