using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleRepository
    {
        /// <summary>
        /// Creates a new Sale in the repository
        /// </summary>
        /// <param name="sale">The sale to create</param>
        /// <returns>The created Sale</returns>
        Task AddAsync(Sale sale);

        /// <summary>
        /// Retrieve a sale using unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of sale</param>
        /// <returns>The sale in repository</returns>
        Task<Sale> GetByIdAsync(int id);
        Task SaveChangesAsync();

    }
}
