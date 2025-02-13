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
        public async Task<Sale> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) => await _context.Sales
                .Include(s => s.Items)
                .FirstOrDefaultAsync(s => s.Id == id);


        /// <summary>
        /// Deletes a user from the database
        /// </summary>
        /// <param name="id">The unique identifier of the user to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the user was deleted, false if not found</returns>
        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var sale = await GetByIdAsync(id);
            if (sale == null)
                return false;

            _context.Sales.Remove(sale);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}