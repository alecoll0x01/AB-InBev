using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sale.GetSale
{
    /// <summary>
    /// The result of a sale retrieval operation.
    /// </summary>
    public class GetSaleResult
    {
        /// <summary>
        /// The unique identifier for the sale.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The sale number.
        /// </summary>
        public string SaleNumber { get; set; }


        /// <summary>
        /// The sale Date.
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// The unique identifier for user.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// The Customer object.
        /// </summary>
        public Customer Customer { get; set; }


        /// <summary>
        /// The unique identifier for branch.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// The Branch object.
        /// </summary>
        public Branch Branch { get; set; }

        /// <summary>
        /// The total amount of sale.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Represents if the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }
    }
}
