using Microsoft.AspNetCore.Mvc;

namespace Perseus.Modules.DataProcessor.Api.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    internal abstract class BaseController : ControllerBase
    {
        protected const string BasePath = "DataProcessor-module";
    }
}