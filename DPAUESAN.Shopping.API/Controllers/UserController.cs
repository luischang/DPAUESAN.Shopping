using DPAUESAN.Shopping.DOMAIN.Core.DTO;
using DPAUESAN.Shopping.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPAUESAN.Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] UserAuthenticationDTO userDTO)
        {
            var result = await _userService.Validate(userDTO.Email, userDTO.Password);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(UserAuthRequestDTO userDTO)
        {
            var result = await _userService.Register(userDTO);
            if (!result)
                return BadRequest();

            return Ok(result);
        }
    }
}
