﻿using Infrastracure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet("notfound")]
        public IActionResult GetNotFoundRequest()
        {
            var thing = _context.products.Find(50);
            if(thing == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("servererror")]
        public IActionResult GetServerErrorRequest()
        {
            var thing = _context.products.Find(50);
            var thingToReturn = thing.ToString();
            return Ok();
        }

        [HttpGet("badrequest")]
        public IActionResult GetBadRequest()
        {
            return BadRequest();
        }

        [HttpGet("badrequest/{id}")]
        public IActionResult GetBNotFoundRequest(int id)
        {
            return Ok();
        }
    }
}
