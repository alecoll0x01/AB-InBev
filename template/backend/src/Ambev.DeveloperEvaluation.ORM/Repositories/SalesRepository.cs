using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly DefaultContext _context;


        /// <summary>
        /// Initializes a new instance of SaleRepository
        /// </summary>
        /// <param name="context">The database context</param>

        public SaleRepository(DefaultContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Creates a new Sale in the database
        /// </summary>
        /// <param name="sale">The sale to create</param>
        /// <returns>The created Sale</returns>
        public async Task AddAsync(Sale sale)
        {
            await _context.Sales.AddAsync(sale);
        }


        /// <summary>
        /// Retrieve a sale using unique identifier
        /// </summary>
        /// <param name="id"> the sale unique identifier</param>
        /// <returns></returns>
        public async Task<Sale> GetByIdAsync(int id) => await _context.Sales
                .Include(s => s.Items)
                .FirstOrDefaultAsync(s => s.Id == id);


        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}