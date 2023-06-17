using ASPTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _User;

        public UserController(IUser service) 
        {
            _User = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_User.Get());

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var CTBebida = _User.Get(Id);

            if (CTBebida == null)
                return NotFound();
            return Ok(CTBebida);
        }


    }

}

