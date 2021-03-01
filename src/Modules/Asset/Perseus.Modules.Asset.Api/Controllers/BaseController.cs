using Microsoft.AspNetCore.Mvc;

namespace Perseus.Modules.Asset.Api.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    internal abstract class BaseController : ControllerBase
    {
        protected const string BasePath = "Asset-module";
    }
}