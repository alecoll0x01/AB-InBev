using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CostumerRepository : ICostumerRepository
    {
        private readonly DefaultContext _context;


        /// <summary>
        /// Initializes a new instance of Costumer Repository
        /// </summary>
        /// <param name="context">The database context</param>

        public CostumerRepository(DefaultContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Retrieve a costumer using unique identifier
        /// </summary>
        /// <param name="id">The costumer unique identifier</param>
        /// <returns>The costumer in repository</returns>
        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
    }
}