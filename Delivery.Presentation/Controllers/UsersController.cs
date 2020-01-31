using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delivery.Core.DTO;
using Delivery.Services.Intrefaces;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            return Ok(userService.Get(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(userService.GetAll());
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            userService.Delete(id);
            return Ok();

        }
        [HttpPost]
        public IActionResult Add(UserDto user)
        {
            return Ok(userService.Add(user));
        }
        [HttpPut]
        public IActionResult Update(UserDto user)
        {
            return Ok(userService.Update(user));
        }
    }
}