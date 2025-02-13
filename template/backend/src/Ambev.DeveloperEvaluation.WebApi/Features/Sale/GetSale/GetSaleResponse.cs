namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.GetSale
{
    /// <summary>
    /// The response of a sale retrieval operation.
    /// </summary>
    public class GetSaleResponse
    {
        /// <summary>
        /// the unique identifier for the sale.
        /// </summary>
        public Guid Id { get; set; }

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
    }
}
