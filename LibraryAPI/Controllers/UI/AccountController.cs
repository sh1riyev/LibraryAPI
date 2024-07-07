using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Service.DTOs.Account;
using Service.Helpers.Account;
using Service.Services.Interfaces;

namespace LibraryAPI.Controllers.UI
{
    [Route("api/UI/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService,
            IConfiguration configuration)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp([FromBody] RegisterDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response = await _accountService.SignUpAsync(request);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok(await _accountService.GetUserAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetByUsername([FromQuery] string username)
        {
            return Ok(await _accountService.GetByUsernameAsync(username));
        }

        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody] LoginDto request)
        {
            return Ok(await _accountService.SignInAsync(request));
        }

    }
}

