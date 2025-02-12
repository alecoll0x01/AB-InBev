using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IBranchRepository
    {
        /// <summary>
        /// Retrieve a branch using unique identifier
        /// </summary>
        /// <param name="id"> the Branch unique identifier </param>
        /// <returns> the branch</returns>
        Task<Branch> GetByIdAsync(int id);
    }
}
