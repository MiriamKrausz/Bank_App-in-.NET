using Bank.Core.Repositories;
using Bank.Core.Services;
using Bank.Entities;


namespace Bank.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _customerRepository.GetCustomersAsync();
        }
        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            return await _customerRepository.AddCustomerAsync(customer);
        }
        public async Task<Customer> UpdateCustomerAsync(int id, Customer customer)
        {
            return await _customerRepository.UpdateCustomerAsync(id, customer);
        }
        public async Task DeleteCustomerAsync(int id)
        {
            await _customerRepository.DeleteCustomerAsync(id);
        }
    }
}
