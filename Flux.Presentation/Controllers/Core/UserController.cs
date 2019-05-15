using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flux.Domain.Core;
using Flux.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flux.Presentation.Controllers.Core
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/user
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            List<User> users = await _userService.GetAll();
            return users;
        }

        // Post api/user
        [HttpPost]
        public async Task<User> Post([FromBody] User user)
        {
            User userResponse = await _userService.Insert(user);
            if (userResponse != null)
            {
                return user;
            }
            return null;
        }

    }
}