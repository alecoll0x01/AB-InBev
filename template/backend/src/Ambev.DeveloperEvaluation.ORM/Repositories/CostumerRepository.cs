using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of CostumerRepository
        /// </summary>
        /// <param name="context"> The database context </param>
        public CustomerRepository(DefaultContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieve a costumer using unique identifier
        /// </summary>
        /// <param name="id"> The unique identifier of costumer </param>
        /// <returns> The customer in repository </returns>
        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
    }
}