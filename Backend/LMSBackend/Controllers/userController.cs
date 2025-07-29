using Microsoft.AspNetCore.Mvc;
using Dto;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {

        [HttpPost("Login")]
        public Task<IActionResult> tryloginuser(LoginDto LoginDto)
        {
           
        }




    }



}
