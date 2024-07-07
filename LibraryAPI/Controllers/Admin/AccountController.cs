using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryAPI.Controllers.Admin
{
    [Route("api/Admin/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
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
        public async Task<IActionResult> CreateRoles()
        {
            await _accountService.CreateRoleAsync();
            return Ok();
        }
    }
}

