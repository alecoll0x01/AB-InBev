using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of BranchRepository
        /// </summary>
        /// <param name="context"> The database context </param>
        public BranchRepository(DefaultContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Retrieve a branch using unique identifier
        /// </summary>
        /// <param name="id"> the branch unique identifier</param>
        /// <returns></returns>
        public async Task<Branch> GetByIdAsync(int id)
        {
            return await _context.Branches.FindAsync(id);
        }
    }
}