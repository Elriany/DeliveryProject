using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delivery.Core.DTO;
using Delivery.Services.Intrefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            return Ok(_customerService.Get(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_customerService.GetAll());
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _customerService.Delete(id);
            return Ok();
            
        }
        [HttpPost]
        public IActionResult Add(CustomerDto customer)
        {
            return Ok(_customerService.Add(customer));
        }
        [HttpPut]
        public IActionResult Update(CustomerDto customer)
        {
            return Ok(_customerService.Update(customer));
        }
    }
}