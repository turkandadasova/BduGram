using BduGram.BL.Helpers;
using BduGram.Core.Entities;
using BduGram.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BduGram.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryRepository _repo) : ControllerBase
    {
        [HttpGet("Hash")]
        public async Task<IActionResult> Get(string s)
        {
            return Ok(HashHelper.HashPassword(s));
        }

        [HttpGet("IsCorrect")]
        public async Task<IActionResult> Get(string s,string pass)
        {
            return Ok(HashHelper.VerifyHashedPassword(s,pass));
        }


        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repo.GetAll().ToListAsync());
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
           // return "value";
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public async Task<IActionResult> Post(Category category)
        {
            await _repo.AddAsync(category);
            await _repo.SaveAsync();
            return Ok(category.Id);
        }

      

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
            return Ok();
        }
    }
}
