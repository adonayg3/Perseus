using Microsoft.AspNetCore.Mvc;

namespace Perseus.Modules.DataProcessor.Api.Controllers
{
    [Route(BasePath)]
    internal class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Data Processor Api";
    }
}