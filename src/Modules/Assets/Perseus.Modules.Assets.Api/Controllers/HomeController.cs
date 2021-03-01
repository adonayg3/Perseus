using Microsoft.AspNetCore.Mvc;

namespace Perseus.Modules.Assets.Api.Controllers
{
    [Route(BasePath)]
    internal class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Asset Module API";
    }
}