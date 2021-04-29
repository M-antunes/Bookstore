using Bookstore.Models;
using Bookstore.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Bookstore.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BookController : ControllerBase
    {
        private readonly BookService bookService;
        public BookController()
        {
            bookService = new BookService();
        }
        
        [HttpGet]
        public IActionResult Get([FromQuery] string category, [FromQuery] string name) 
        {
            try
            {
                var response = bookService.Get(name, category);
                return Ok(response);
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            try
            {
                bookService.Create(book);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bookService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var response = bookService.GetById(id);
                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut]
        public IActionResult Edit([FromBody] Book book)
        {
            try
            {
                bookService.Edit(book);
                return Ok(bookService.Books);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
