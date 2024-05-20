using Bank.Core.Repositories;
using Bank.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _context.CustomerList.ToListAsync();
        }
        public async Task<Customer> GetByIdAsync(int id)

        {
            return _context.CustomerList.Find(id);
        }
        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            _context.CustomerList.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task<Customer> UpdateCustomerAsync(int id, Customer customer)
        {
            var updatedCustomer = _context.CustomerList.Find(id);
            updatedCustomer = customer;
            await _context.SaveChangesAsync();
            return updatedCustomer;
        }
        public async Task DeleteCustomerAsync(int id)
        {
            _context.CustomerList.Remove(_context.CustomerList.Find(id));
            await _context.SaveChangesAsync();
        }
    }
}
