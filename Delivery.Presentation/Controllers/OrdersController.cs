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
    public class OrdersController : Controller
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            return Ok(orderService.Get(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(orderService.GetAll()); 
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            orderService.Delete(id);
            return Ok();

        }
        [HttpPost]
        public IActionResult Add(OrderDto customer)
        {
            return Ok(orderService.Add(customer));
        }
        [HttpPut]
        public IActionResult Update(OrderDto customer)
        {
            return Ok(orderService.Update(customer));
        }
    }
}