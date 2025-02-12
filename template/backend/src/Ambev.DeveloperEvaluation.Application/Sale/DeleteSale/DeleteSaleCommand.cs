using Ambev.DeveloperEvaluation.Application.Sale.DeleteSale;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.DeleteUser
{
    /// <summary>
    /// Command to delete a sale.
    /// </summary>
    /// 
    public class DeleteSaleCommand : IRequest<DeleteSaleResponse>
    {
        /// <summary>
        /// The unique identifier of the sale to delete
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Initializes a new instance of DeleteSaleCommand
        /// </summary>
        /// <param name="id">The ID of the sale to delete</param>
        public DeleteSaleCommand(Guid id)
        {
            Id = id;
        }
    }
}
