using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DefaultContext _context;


        /// <summary>
        /// Initializes a new instance of ProductRepository
        /// </summary>
        /// <param name="context">The database context</param>

        public ProductRepository(DefaultContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Retrieve a Product using unique identifier
        /// </summary>
        /// <param name="id">The costumer unique identifier</param>
        /// <returns>The product in repository</returns>
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

    }
}