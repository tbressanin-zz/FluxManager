using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flux.Domain.Domain;
using Flux.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flux.Presentation.Controllers.Domain
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

    }
}