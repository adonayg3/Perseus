using Microsoft.AspNetCore.Mvc;

namespace Perseus.Modules.Assets.Api.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    internal abstract class BaseController : ControllerBase
    {
        protected const string BasePath = "Assets-module";
    }
}