using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class CRUDController : Controller
    {
        private readonly IGenericRepository<Products> _genericRepository;
        public CRUDController(IGenericRepository<Products> employee)
        {
            _genericRepository = employee;
        }
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var result = _genericRepository.GetAll();
            if (result.Result != null)
            {
                return Ok(result.Result);
            }
            return NotFound();
        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _genericRepository.Get(id);
            if (result.Result != null)
            {
                return new JsonResult((Products)result.Result);
            }
            return NotFound();
        }
        [HttpPost("add")]
        public IActionResult Add(Products model)
        {
            var products = new Products
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                price = model.price,
            };
            _genericRepository.Insert(products);
            return Ok();
        }

        [HttpPost("edit")]
        public async Task<IActionResult> Update(Products model)
        {
            await _genericRepository.Update(model);
            return Ok();
        }

        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await _genericRepository.Delete(id);
            return Ok(res);
        }
    }
}
