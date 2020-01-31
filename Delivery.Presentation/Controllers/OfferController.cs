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
    public class OfferController : Controller
    {
        private readonly IOfferService offerService;

        public OfferController(IOfferService offerService)
        {
            this.offerService = offerService;
        }
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            return Ok(offerService.Get(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(offerService.GetAll());
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            offerService.Delete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(OffersDto offer)
        {
            return Ok(offerService.Add(offer));
        }
        [HttpPut]
        public IActionResult Put(OffersDto offer)
        {
            return Ok(offerService.Update(offer));
        }
    }
}