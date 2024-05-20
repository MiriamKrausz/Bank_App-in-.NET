using AutoMapper;
using Bank.Core.DTOs;
using Bank.Core.Services;
using Bank.Entities;
using Bank.Models;
using Microsoft.AspNetCore.Mvc;


namespace Bank.Controllers
{
    [Route("bank/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _customerService.GetCustomersAsync();
            var listDto = _mapper.Map<IEnumerable<CustomerDto>>(list);
            return Ok(listDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cus = await _customerService.GetByIdAsync(id);
            if (cus is null)
            {
                return NotFound();
            }
            var customerDto = _mapper.Map<CustomerDto>(cus);
            return Ok(customerDto);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomerPostModel customer)
        {

            var cusToAdd = new Customer { PhoneNumber = customer.PhoneNumber, Name = customer.Name, Address = customer.Address, City = customer.City, AppointmentId = customer.AppointmentId };
            await _customerService.AddCustomerAsync(cusToAdd);
            return Ok(_mapper.Map<CustomerDto>(cusToAdd));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Customer customer)
        {
            return Ok(await _customerService.UpdateCustomerAsync(id, customer));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _customerService.DeleteCustomerAsync(id);
            return NoContent();
        }
    }
}
