using Ambev.DeveloperEvaluation.Domain.Entities;


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
        /// Deletes a sale from the repository
        /// </summary>
        /// <param name="id">the sale unique id</param>
        /// <param name="cancellationToken">the cancellation Token</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Retrieve a sale using unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of sale</param>
        /// <returns>The sale in repository</returns>
        Task<Sale> GetByIdAsync(Guid id);
        Task SaveChangesAsync();

    }
}
