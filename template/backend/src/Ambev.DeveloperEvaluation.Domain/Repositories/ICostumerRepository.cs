using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ICustomerRepository
    {
        /// <summary> 
        /// Retrieve a costumer using unique identifier
        /// </summary>
        /// <param name="id">the unique identifier of Costumer</param>
        /// <returns>the costumer</returns>
        Task<Customer> GetByIdAsync(int id);
    }
}
