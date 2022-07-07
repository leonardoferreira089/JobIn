using JobIn.Application.InputModels;
using JobIn.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobIn.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _service.GetUser(id);

            return Ok(user);
        }

        public async Task<IActionResult> CreateUser(CreateUserInputModel inputModel)
        {
            var user = await _service.CreateUser(inputModel);

            return CreatedAtAction(nameof(GetUserById), new { user }, inputModel);
        }        
    }
}
