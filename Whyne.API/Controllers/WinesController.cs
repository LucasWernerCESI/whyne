using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Whyne.BL;
using Whyne.Models.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Whyne.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinesController : ControllerBase
    {
        private readonly WineService _service;
        public WinesController(WineService service)
        {
            _service = service;
        }

        // GET: api/<WinesController>
        [HttpGet]
        public async Task<List<Wine>> Get()
        {
            return await _service.ListWines();
        }

        // GET api/<WinesController>/5
        [HttpGet("{id}")]
        public async Task<Wine> Get(int id)
        {
            return await _service.GetWine(id);
        }

        // POST api/<WinesController>
        [HttpPost]
        public async Task<Wine> Post([FromBody] Wine wine)
        {
            return await _service.CreateWine(wine);
        }

        // PUT api/<WinesController>/5
        [HttpPut("{id}")]
        public async Task<Wine> Put(int id, [FromBody] Wine wine)
        {
            return await _service.EditWine(wine);
        }

        // DELETE api/<WinesController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteWine(id);
        }
    }
}
