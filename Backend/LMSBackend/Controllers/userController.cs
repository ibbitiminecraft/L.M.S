using Microsoft.AspNetCore.Mvc;
using Dto;
using libary.classes;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {

        [HttpPost("Login")]
        public IActionResult tryloginuser(LoginDto loginDto)
        {
            if (libary.classes.User.Iscorrect(loginDto.Username, loginDto.Password))
            {
                return Ok();
            }
            else
            {
                return Unauthorized();
            }
        }




    }



}
