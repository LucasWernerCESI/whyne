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
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomersController(CustomerService service)
        {
            _service = service;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<List<Customer>> Get()
        {
            return await _service.ListCustomers();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<Customer> Get(int id)
        {
            return await _service.GetCustomer(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<Customer> Post([FromBody] Customer customer)
        {
            return await _service.CreateCustomer(customer);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public async Task<Customer> Put(int id, [FromBody] Customer customer)
        {
            return await _service.EditCustomer(customer);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteCustomer(id);
        }
    }
}
