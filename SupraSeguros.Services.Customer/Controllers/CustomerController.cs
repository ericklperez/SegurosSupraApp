using Microsoft.AspNetCore.Mvc;
using SupraSeguros.Persistence.Repositories.Contracts;

namespace SupraSeguros.Services.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepositoryAsync<Entities.Customer> _customerService;

        public CustomerController(IRepositoryAsync<Entities.Customer> customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id}", Name = "GetBasketLine")]
        public async Task<ActionResult<Entities.Customer>> GetByIdAsync(Guid id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Entities.Customer>>> ListAllAsync()
        {
            var customers = await _customerService.ListAllAsync();
            return Ok(customers);
        }

        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddAsync([FromBody] Entities.Customer customer)
        {
            var createdCustomer = await _customerService.AddAsync(customer);
            return CreatedAtAction("GetById", new { id = createdCustomer.ClienteId }, createdCustomer);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(Guid id, [FromBody] Entities.Customer customer)
        {
            if (id != customer.ClienteId)
            {
                return BadRequest();
            }
            await _customerService.UpdateAsync(customer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            await _customerService.DeleteAsync(customer);
            return NoContent();
        }

        [HttpGet("paged")]
        public async Task<ActionResult<IReadOnlyList<Entities.Customer>>> GetPagedResponseAsync(int page, int size)
        {
            var pagedCustomers = await _customerService.GetPagedReponseAsync(page, size);
            return Ok(pagedCustomers);
        }
    }
}
