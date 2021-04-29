using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Bookstore.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class PurchaseController : Controller
    {   
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Purchase([FromBody] IEnumerable<Book> books)
        {
            try
            {
                return Ok();
            }   
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("{purchaseId}")]
        public IActionResult Cancel(int purchaseId)
        {
            try
            {
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{purchaseId}")]
        public IActionResult Exchange(int purchaseId, [FromBody] IEnumerable<Book> books)
        {
            try
            {
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
