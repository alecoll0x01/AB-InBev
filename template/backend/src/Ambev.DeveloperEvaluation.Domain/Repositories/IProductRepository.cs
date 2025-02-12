using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository
    {
        /// <summary> 
        /// Retrieve a product using unique identifier
        /// </summary>
        /// <param name="id">the unique identifier of product</param>
        /// <returns>The product </returns>
        Task<Product> GetByIdAsync(int id);
    }
}
