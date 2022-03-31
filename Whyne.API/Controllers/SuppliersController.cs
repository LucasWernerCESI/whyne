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
    public class SuppliersController : ControllerBase
    {
        private readonly SupplierService _service;
        public SuppliersController(SupplierService service)
        {
            _service = service;
        }
        // GET: api/<SuppliersController>
        [HttpGet]
        public async Task<List<Supplier>> Get()
        {
            return await _service.ListSuppliers();
        }

        // GET api/<SuppliersController>/5
        [HttpGet("{id}")]
        public async Task<Supplier> Get(int id)
        {
            return await _service.GetSupplier(id);
        }

        // POST api/<SuppliersController>
        [HttpPost]
        public async Task<Supplier> Post([FromBody] Supplier supplier)
        {
            return await _service.CreateSupplier(supplier);
        }

        // PUT api/<SuppliersController>/5
        [HttpPut("{id}")]
        public async Task<Supplier> Put(int id, [FromBody] Supplier supplier)
        {
            return await _service.EditSupplier(supplier);
        }

        // DELETE api/<SuppliersController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteSupplier(id);
        }
    }
}
