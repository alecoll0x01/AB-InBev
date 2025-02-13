using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sale.GetSale
{
    /// <summary>
    /// Command to get a sale by their ID.
    /// </summary>
    public record GetSaleCommand : IRequest<GetSaleResult>
    {
        /// <summary>
        /// The unique identifier of the sale to retrieve.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Initilizes a new instance of GetSaleCommand
        /// </summary>
        /// <param name="id">The ID of the sale to retrieve</param>
        public GetSaleCommand(Guid id)
        {
            Id = id;
        }
    }
}
