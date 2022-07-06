using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Whyne.BL;
using Whyne.Models.People;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Whyne.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorsController : ControllerBase
    {
        private readonly DistributorService _service;
        public DistributorsController(DistributorService service)
        {
            _service = service;
        }

        // GET: api/<DistributorsController>
        [HttpGet]
        public async Task<List<Distributor>> Get()
        {
            return await _service.ListDistributors();
        }

        // GET api/<DistributorsController>/5
        [HttpGet("{id}")]
        public async Task<Distributor> Get(int id)
        {
            return await _service.GetDistributor(id);
        }

        // POST api/<DistributorsController>
        [HttpPost]
        public async Task<Distributor> Post([FromBody] Distributor distributor)
        {
            return await _service.CreateDistributor(distributor);
        }

        // PUT api/<DistributorsController>/5
        [HttpPut("{id}")]
        public async Task<Distributor> Put(int id, [FromBody] Distributor distributor)
        {
            return await _service.EditDistributor(distributor);
        }

        // DELETE api/<DistributorsController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteDistributor(id);
        }
    }
}
