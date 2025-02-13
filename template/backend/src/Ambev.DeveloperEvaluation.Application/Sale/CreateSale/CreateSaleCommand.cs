using Ambev.DeveloperEvaluation.Application.Sale.CreateSale;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Features.Sales.Commands
{
    /// <summary>
    /// Comando para criar uma nova venda
    /// </summary>
    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        /// <summary>
        /// The numebr of sale
        /// </summary>
        public string? SaleNumber { get; set; }

        /// <summary>
        /// The customer Unique Identifier
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// The branch Unique Identifier
        /// </summary>    
        public int BranchId { get; set; }

        /// <summary>
        /// Items of the sale
        /// </summary>
        public List<SaleItemDto>? Items { get; set; }


        /// <summary>
        /// Sale Item Data Transfer Object
        /// </summary>
        public class SaleItemDto
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
        }
    }

}