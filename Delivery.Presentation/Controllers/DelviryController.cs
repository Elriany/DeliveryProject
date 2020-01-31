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
    public class DelviryController : Controller
    {
        private readonly IDeliveryService delveryService;

        public DelviryController(IDeliveryService DelveryService)
        {
            this.delveryService = DelveryService;
        }
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            return Ok(delveryService.Get(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(delveryService.GetAll());
        }
        [HttpGet("GetAllFree")]
        public IActionResult GetAllFree()
        {
            return Ok(delveryService.GetAllDelviryFree());
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            delveryService.Delete(id);
            return Ok();

        }
        [HttpPost]
        public IActionResult Add(DeliveryDto delivery)
        {
            return Ok(delveryService.Add(delivery));
        }
        [HttpPut]
        public IActionResult Update(DeliveryDto delivery)
        {
            return Ok(delveryService.Update(delivery));
        }
    }
}