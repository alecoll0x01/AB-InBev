namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.CreateSale
{

    /// <summary>
    /// Represents the request for creating a sale
    /// </summary>
    public class CreateSaleRequest
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
