using e_commerce.Api.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Api.Controllers
{
    [Route("errors/{code}")]
    [ApiController]
    public class ErrorController : BaseApiController
    {
        //public IActionResult Error(int code)
        //{
        //    return new ObjectResult(new ApiResponse(code));
        //}
    }
}
