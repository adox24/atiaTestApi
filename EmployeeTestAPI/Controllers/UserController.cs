using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeTest.Core.Entities;
using EmployeeTest.Core.Interfaces;
using EmployeeTest.Core.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeTestAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
           return _userService.GetAllUsers();
        }
        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody]UserRequest user)
        {
            _userService.AddUser(user);
          return Ok( );
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody]UserRequest user)
        {
            return Ok(_userService.UpdateUser(user, id));
        }
        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_userService.DeleteUser( id));

        }
    }
}
